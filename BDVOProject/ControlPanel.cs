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
    public partial class ControlPanel : Form
    {
        EV vehicle;
        public EVSE Evse;
        ElectricVehicle vehicleForm;
        ChargingStation chargingForm;

        public ControlPanel()
        {
            InitializeComponent();
        }

        private void CCS_CheckedChanged(object sender, EventArgs e)
        {
            if (CCS.Checked)
            {
                DCPlusFaulty.Enabled = true;
                DCMinusFaulty.Enabled = true;
            }
            else
            {
                DCPlusFaulty.Enabled = false;
                DCMinusFaulty.Enabled = false;
                DCPlusFaulty.Checked = false;
                DCMinusFaulty.Checked = false;
            }
        }

        private void startCarBtn_Click(object sender, EventArgs e)
        {
            //get faulty pins:
            List<bool> faultyPins = new List<bool> {CPFaulty.Checked,PPFaulty.Checked,PEFaulty.Checked,
                                            NFaulty.Checked, L1Faulty.Checked, L2Faulty.Checked,
                                            L3Faulty.Checked};

            if (CCS.Checked)
            {
                faultyPins.Add(DCPlusFaulty.Checked);
                faultyPins.Add(DCMinusFaulty.Checked);
            }

            //disable components:
            groupBox3.Enabled = false;
            groupBox1.Enabled = false;

            //set vehicle properties
            vehicle = new EV(CCS.Checked);

            //enable station properties
            groupBox2.Enabled = true;

            //create form
            vehicleForm = new ElectricVehicle(this,ref vehicle, CCS.Checked,
                                              faultyPins, ref chargingForm, ref Evse);
            vehicleForm.Show();
        }

        private void startStationBtn_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;

            chargingForm = new ChargingStation(this, ref LogBox,ref vehicle, ref vehicleForm, ref Evse);
            chargingForm.Show();
        }

        private void LogBox_TextChanged(object sender, EventArgs e)
        {
            LogBox.SelectionStart = LogBox.Text.Length;
            LogBox.ScrollToCaret();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            LogBox.Text = "";
        }
    }
}
