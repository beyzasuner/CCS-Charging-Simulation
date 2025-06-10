using System;
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
    public partial class ChargingStation : Form
    {
        ControlPanel controlForm;
        TextBox LogBox;
        EV Vehicle;
        public EVSE Evse;
        ElectricVehicle vehicleForm;
        public double price = 0;
        
        public ChargingStation(ControlPanel controlForm,ref TextBox logBox,
                               ref EV vehicle, ref ElectricVehicle _vehicleForm,ref EVSE _evse)
        {
            InitializeComponent();

            //initialize EVSE:
            double type2Cost = Convert.ToDouble(controlForm.type2CostBox.Value);
            double ccsCost = Convert.ToDouble(controlForm.ccsCostBox.Value);
            _evse = new EVSE(controlForm.stationCodeBox.Text, controlForm.xCorBox.Text,
                controlForm.yCorBox.Text, controlForm.adressBox.Text, type2Cost, ccsCost);

            //set other properties:
            labelTitle.Text += " (" + controlForm.stationCodeBox.Text + ")";
            this.controlForm = controlForm;
            LogBox = logBox;
            Vehicle = vehicle;
            vehicleForm = _vehicleForm;
            stationBox.Text += "\r\nType 2: " + type2Cost + " ₺/kWh | CCS: " + ccsCost + " ₺/kWh\r\n";

            //allow vehicle to connect:
            if (controlForm.CCS.Checked) { vehicleForm.connectCCSBtn.Enabled = true; }
            else { vehicleForm.connectType2Btn.Enabled = true; }
            Evse = new EVSE(controlForm.stationCodeBox.Text, controlForm.xCorBox.Text,
                controlForm.yCorBox.Text, controlForm.adressBox.Text, type2Cost, ccsCost);

            logBox.Text += "Created charging station with code " + controlForm.stationCodeBox.Text + "\r\n";
            
            //STATE A: STANDBY MODE
            Evse.comboConnector.CP.Voltage = 12;
            Evse.type2Connector.CP.Voltage = 12;
            logBox.Text += "Both chargers' Control Pilot is set from 0V to 12V\r\n" +
                "Chargers switched from State E (Shut off) to A: Standby\r\n";

            stationBox.Text += "Type2 = 6 kW/h       | CCS = 120 kW/h\r\n";

            vehicleForm.chargingForm = this;
        }

        private void ChargingStation_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlForm.groupBox2.Enabled = true;
        }

        private void stationBox_TextChanged(object sender, EventArgs e)
        {
            stationBox.SelectionStart = stationBox.Text.Length;
            stationBox.ScrollToCaret();
        }

        private void startChargingBtn_Click(object sender, EventArgs e)
        {
            if (!vehicleForm.CCSConnection)
            {
                Evse.type2Connector.Locked = true;
                LogBox.Text += "Type2 connector locked.\r\n";
                startChargingBtn.Enabled = false;
                stopChargingBtn.Enabled = true;
                stationBox.Text += "Charging started.\r\n";
            }
            else
            {
                Evse.comboConnector.Locked = true;
                LogBox.Text += "Combo2 connector locked.\r\n";
                startChargingBtn.Enabled = false;
                stopChargingBtn.Enabled = true;
                stationBox.Text += "Charging started.\r\n";
            }
            timer1.Enabled = true;
        }

        private void stopChargingBtn_Click(object sender, EventArgs e)
        {
            if (!vehicleForm.CCSConnection)
            {
                Evse.type2Connector.Locked = false;
                LogBox.Text += "Type2 connector unlocked\r\n";
                startChargingBtn.Enabled = true;
                stopChargingBtn.Enabled = false;
                stationBox.Text += "Charging Stopped\r\n";

            }
            else
            {
                Evse.comboConnector.Locked = false;
                LogBox.Text += "Combo2 connector unlocked\r\n";
                startChargingBtn.Enabled = true;
                stopChargingBtn.Enabled = false;
            }
            timer1.Enabled = false;
            price = vehicleForm.batteryBar.Value - (double)controlForm.batteryLevel.Value;
            if (vehicleForm.CCSConnection) price *= (double)controlForm.ccsCostBox.Value;
            else price *= (double)controlForm.type2CostBox.Value;
            stationBox.Text += "Payment: " + price + "₺\r\n";
            price = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!vehicleForm.CCSConnection)
            {
                if (vehicleForm.batteryBar.Value < 60)
                {
                    vehicleForm.batteryBar.Value += 1;
                    price += Convert.ToDouble(controlForm.type2CostBox.Value);
                }    
            }
            else 
            {
                if (vehicleForm.batteryBar.Value < 40)
                {
                    vehicleForm.batteryBar.Value += 20;
                }
                else if (vehicleForm.batteryBar.Value < 60)
                {                     
                    vehicleForm.batteryBar.Value = 60;
                }
            }

            if (vehicleForm.batteryBar.Value == 60)
            {
                timer1.Enabled = false;
                stopChargingBtn_Click(sender, e);
            }
        }
    }
}
