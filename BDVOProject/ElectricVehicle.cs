using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDVOProject
{
    public partial class ElectricVehicle : Form
    {
        ControlPanel controlForm;
        TextBox LogBox;
        EV vehicle; //create EV
        EVSE Evse;
        public ChargingStation chargingForm;
        List<bool> faultyPins;
        public bool CCSConnection;

        public ElectricVehicle(ControlPanel controlForm,ref EV _vehicle , bool hasCCS,
                               List<bool> faultyPins, ref ChargingStation _chargingForm,ref EVSE _evse)
        {
            InitializeComponent();
            LogBox = controlForm.LogBox;
            this.controlForm = controlForm;
            vehicle = _vehicle;
            chargingForm = _chargingForm;
            this.faultyPins = faultyPins;
            CCSConnection = hasCCS;

            if (hasCCS)
            {
                ChargerImage.Image = BDVOProject.Properties.Resources.ccs;
                connectType2Btn.Enabled = false;
            }
            else
            {
                ChargerImage.Image = BDVOProject.Properties.Resources.type2;
                dcPinsGroupBox.Enabled = false;
                connectCCSBtn.Enabled = false;
            }

            vehicle = new EV(hasCCS); //initalize EV
            LogBox.Text += "Created new vehicle.";
            if (hasCCS) { LogBox.Text += "It has a CCS support.\r\n"; }
            else { LogBox.Text += "No CCS support.\r\n"; }

            //set faulty of pins
            vehicle.Inlet.CP.Faulty = faultyPins[0];
            vehicle.Inlet.PP.Faulty = faultyPins[1];
            vehicle.Inlet.PE.Faulty = faultyPins[2];
            vehicle.Inlet.N.Faulty = faultyPins[3];
            vehicle.Inlet.L1.Faulty = faultyPins[4];
            vehicle.Inlet.L2.Faulty = faultyPins[5];
            vehicle.Inlet.L3.Faulty = faultyPins[6];
            if (faultyPins.Count > 7)
            {
                vehicle.Inlet.DCPlus.Faulty = faultyPins[7];
                vehicle.Inlet.DCMinus.Faulty = faultyPins[8];
            }

            int FaultyPinCount = 0;
            foreach (bool value in faultyPins)
            {
                if (value == true)
                {
                    FaultyPinCount++;
                }
            }

            if (FaultyPinCount > 0)
            {
                LogBox.Text += FaultyPinCount + " Faulty pins detected.\r\n";
            }

            batteryBar.Value = Convert.ToInt32(controlForm.batteryLevel.Value);

            Evse = _evse;

            //set faulty pins
            Image img = BDVOProject.Properties.Resources.busy;
            if (vehicle.Inlet.CP.Faulty) { CPFaultyImage.Image = img; }
            if (vehicle.Inlet.PP.Faulty) { PPFaultyImage.Image = img; }
            if (vehicle.Inlet.PE.Faulty) { PEFaultyImage.Image = img; }
            if (vehicle.Inlet.N.Faulty)  { NFaultyImage.Image = img; }
            if (vehicle.Inlet.L1.Faulty) { L1FaultyImage.Image = img; }
            if (vehicle.Inlet.L2.Faulty) { L2FaultyImage.Image = img; }
            if (vehicle.Inlet.L3.Faulty) { L3FaultyImage.Image = img; }
            if (vehicle.Inlet.DCPlus != null && vehicle.Inlet.DCPlus.Faulty)
            { 
                DCPlusFaultyImage.Image = img; 
            }
            if (vehicle.Inlet.DCMinus != null && vehicle.Inlet.DCMinus.Faulty) 
            { 
                DCMinusFaultyImage.Image = img;
            }

            //if ccs, set unused pins
            if (hasCCS)
            {
                NUsedImage.Image = img;
                L1UsedImage.Image = img;
                L2UsedImage.Image = img;
                L3UsedImage.Image = img;
            }

            else
            {
                DCPlusUsedImage.Image = img;
                DCMinusUsedImage.Image = img;
            }

            vehicle.IsRunning = true;
        }


        private void ElectricVehicle_FormClosing(object sender, FormClosingEventArgs e)
        {
            //enable Control Panel's Car Creation interface while closing
            controlForm.groupBox1.Enabled = true;
            controlForm.groupBox3.Enabled = true;
            if (chargingForm != null) chargingForm.Close();
        }

        private void connectType2Btn_Click(object sender, EventArgs e)
        {
            connectType2Btn.Enabled = false;
            chargingForm.type2Image.Image = BDVOProject.Properties.Resources.busy;

            //Set used pins' images:
            Image img = BDVOProject.Properties.Resources.available;
            CPUsedImage.Image = img;
            PPUsedImage.Image = img;
            PEUsedImage.Image = img;
            NUsedImage.Image = img;
            L1UsedImage.Image= img;
            L2UsedImage.Image= img;
            L3UsedImage.Image= img;

            disconnectType2Btn.Enabled = true;

            //STATE B: Vehicle detected
            chargingForm.stationBox.Text += "EV connected to Type2\r\n";

            foreach (bool value in faultyPins)
            {
                if (value == true) //if there is a faulty pin
                {
                    //STATE F: ERROR
                    chargingForm.Evse.type2Connector.CP.Voltage = -12;
                    chargingForm.stationBox.Text += "Error during communication. Please remove the plug.\r\n";
                    LogBox.Text += "CP is set to -12V State E (Error)\r\n";
                    LogBox.Text += "Pulse Width Modulation (PWM) - %100 duty cycle\r\n";
                    return;
                }
            }

            if (vehicle.IsRunning)
            {
                LogBox.Text += "Vehicle is not immobilized.\r\n";
                chargingForm.stationBox.Text += "Vehicle is not immobilized. Charging can't start.\r\n";
                return;
            }

            chargingForm.Evse.type2Connector.CP.Voltage = 9;
            LogBox.Text += "CP is set to 9V State B (Vehicle detected)\r\n";
            LogBox.Text += "Pulse Width Modulation (PWM) - %5 duty cycle\r\n";


            //if not faulty, prepare for charging
            LogBox.Text += "Exchange of parameters started\r\n";
            chargingForm.stationBox.Text += "Acquiring car info.\r\n";
            LogBox.Text += "CP is set to 6V State C (Ready or Charge)\r\n";
            LogBox.Text += "Supply started checking system isolation.\r\n";
            LogBox.Text += "EV sent Pre-Charge request with requested current and voltage.\r\n";
            if (!CCSConnection)
            {
                chargingForm.stationBox.Text += "Charging can start with 6 kW/h.\r\n";
            }
            else
            {
                chargingForm.stationBox.Text += "Charging can start with 120 kW/h.\r\n";
            }
            
            chargingForm.startChargingBtn.Enabled = true;
            chargingForm.stopChargingBtn.Enabled = false;
        }

        private void disconnectType2Btn_Click(object sender, EventArgs e)
        {
            if (chargingForm.Evse != null && chargingForm.Evse.type2Connector.Locked)
            {
                MessageBox.Show("Plug is locked. Please stop charging process.");
                return;
            }

            connectType2Btn.Enabled = true;

            CPUsedImage.Image = null;
            PPUsedImage.Image = null;
            PEUsedImage.Image = null;
            NUsedImage.Image =  null;
            L1UsedImage.Image = null;
            L2UsedImage.Image = null;
            L3UsedImage.Image = null;

            disconnectType2Btn.Enabled = false;

            //State A: Standby
            chargingForm.stationBox.Text += "Disconnected EV\r\n";
            chargingForm.Evse.type2Connector.CP.Voltage = 12;
            LogBox.Text += "CP is set to 12V State A (Standby)\r\n";
            LogBox.Text += "Pulse Width Modulation (PWM) Ended\r\n";
            chargingForm.type2Image.Image = BDVOProject.Properties.Resources.available;

            chargingForm.startChargingBtn.Enabled = false;
            chargingForm.stopChargingBtn.Enabled = false;
        }

        private void stopCarBtn_Click(object sender, EventArgs e)
        {
            vehicle.IsRunning = false;
            immobilizedImage.Image = BDVOProject.Properties.Resources.available;
            LogBox.Text += "Vehicle is immobilized\r\n";
            startCarBtn.Enabled = true;
            stopCarBtn.Enabled = false;
        }

        private void startCarBtn_Click(object sender, EventArgs e)
        {
            if (chargingForm.timer1.Enabled)
            {
                MessageBox.Show("Can't start car during charging.");
                return;
            }

            vehicle.IsRunning = true;
            immobilizedImage.Image = BDVOProject.Properties.Resources.busy;
            LogBox.Text += "Vehicle is not immobilized\r\n";
            startCarBtn.Enabled = false;
            stopCarBtn.Enabled = true;
        }

        private void connectCCSBtn_Click(object sender, EventArgs e)
        {
            connectCCSBtn.Enabled = false;
            chargingForm.CCSImage.Image = BDVOProject.Properties.Resources.busy;

            //set used pin's images:
            Image img = BDVOProject.Properties.Resources.available;
            CPUsedImage.Image = img;
            PPUsedImage.Image = img;
            PEUsedImage.Image = img;
            DCPlusUsedImage.Image = img;
            DCMinusUsedImage.Image = img;

            disconnectCCSBtn.Enabled = true;

            //State B: Vehicle Detected
            chargingForm.stationBox.Text += "EV Connected to Combo2\r\n";

            for (int i = 0; i < 9; i++)
            {
                if (i > 2 && i < 7) continue;
                if (faultyPins[i] == true)
                {
                    //STATE F: ERROR
                    chargingForm.Evse.comboConnector.CP.Voltage = -12;
                    chargingForm.stationBox.Text += "Error during communication. Please remove the plug.\r\n";
                    LogBox.Text += "CP is set to -12V State E (Error)\r\n";
                    LogBox.Text += "Pulse Width Modulation (PWM) - %100 duty cycle\r\n";
                    return;
                }
            }

            if (vehicle.IsRunning)
            {
                LogBox.Text += "Vehicle is not immobilized.\r\n";
                chargingForm.stationBox.Text += "Vehicle is not immobilized. Charging can't start.\r\n";
                return;
            }

            chargingForm.Evse.comboConnector.CP.Voltage = 9;
            LogBox.Text += "CP is set to 9V State B (Vehicle detected)\r\n";
            LogBox.Text += "Pulse Width Modulation (PWM) - %5 duty cycle\r\n";

            //if not faulty, prepare for charging
            LogBox.Text += "Exchange of parameters started\r\n";
            chargingForm.stationBox.Text += "Acquiring car info.\r\n";
            LogBox.Text += "CP is set to 6V State C (Ready or Charge)\r\n";
            LogBox.Text += "Supply started checking system isolation.\r\n";
            LogBox.Text += "EV sent Pre-Charge request with requested current and voltage.\r\n";
            if (!CCSConnection)
            {
                chargingForm.stationBox.Text += "Charging can start with 6 kW/h.\r\n";
            }
            else
            {
                chargingForm.stationBox.Text += "Charging can start with 120 kW/h.\r\n";
            }

            chargingForm.startChargingBtn.Enabled = true;
            chargingForm.stopChargingBtn.Enabled = false;

        }

        private void disconnectCCSBtn_Click(object sender, EventArgs e)
        {
            if (chargingForm.Evse != null && chargingForm.Evse.comboConnector.Locked)
            {
                MessageBox.Show("Plug is locked. Please stop charging process.");
                return;
            }

            connectCCSBtn.Enabled = true;

            CPUsedImage.Image = null;
            PPUsedImage.Image = null;
            PEUsedImage.Image = null;
            DCPlusUsedImage.Image = null;
            DCMinusUsedImage.Image = null;

            disconnectCCSBtn.Enabled = false;

            //STATE A: Standby
            chargingForm.stationBox.Text += "Disconnected EV\r\n";
            chargingForm.Evse.comboConnector.CP.Voltage = 12;
            LogBox.Text += "CP is set to 12V State A (Standby)\r\n";
            LogBox.Text += "Pulse Width Modulation (PWM) ended\r\n";
            chargingForm.CCSImage.Image = BDVOProject.Properties.Resources.available;

            chargingForm.startChargingBtn.Enabled = false;
            chargingForm.stopChargingBtn.Enabled = false;
        }
    }
}
