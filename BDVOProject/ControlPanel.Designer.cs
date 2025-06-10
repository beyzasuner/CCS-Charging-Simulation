namespace BDVOProject
{
    partial class ControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.startCarBtn = new System.Windows.Forms.Button();
            this.startStationBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CCS = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.CPFaulty = new System.Windows.Forms.CheckBox();
            this.PPFaulty = new System.Windows.Forms.CheckBox();
            this.PEFaulty = new System.Windows.Forms.CheckBox();
            this.NFaulty = new System.Windows.Forms.CheckBox();
            this.L1Faulty = new System.Windows.Forms.CheckBox();
            this.L2Faulty = new System.Windows.Forms.CheckBox();
            this.L3Faulty = new System.Windows.Forms.CheckBox();
            this.DCPlusFaulty = new System.Windows.Forms.CheckBox();
            this.DCMinusFaulty = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ccsCostBox = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.type2CostBox = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.adressBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.yCorBox = new System.Windows.Forms.TextBox();
            this.xCorBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stationCodeBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.batteryLevel = new System.Windows.Forms.NumericUpDown();
            this.clearBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccsCostBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type2CostBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteryLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // startCarBtn
            // 
            this.startCarBtn.Location = new System.Drawing.Point(6, 255);
            this.startCarBtn.Name = "startCarBtn";
            this.startCarBtn.Size = new System.Drawing.Size(153, 47);
            this.startCarBtn.TabIndex = 0;
            this.startCarBtn.Text = "Start Car Interface";
            this.startCarBtn.UseVisualStyleBackColor = true;
            this.startCarBtn.Click += new System.EventHandler(this.startCarBtn_Click);
            // 
            // startStationBtn
            // 
            this.startStationBtn.Location = new System.Drawing.Point(224, 212);
            this.startStationBtn.Name = "startStationBtn";
            this.startStationBtn.Size = new System.Drawing.Size(153, 47);
            this.startStationBtn.TabIndex = 1;
            this.startStationBtn.Text = "Start Charging Station Interface";
            this.startStationBtn.UseVisualStyleBackColor = true;
            this.startStationBtn.Click += new System.EventHandler(this.startStationBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Car Properties";
            // 
            // CCS
            // 
            this.CCS.AutoSize = true;
            this.CCS.Location = new System.Drawing.Point(6, 55);
            this.CCS.Name = "CCS";
            this.CCS.Size = new System.Drawing.Size(103, 20);
            this.CCS.TabIndex = 3;
            this.CCS.Text = "CCS Charge";
            this.CCS.UseVisualStyleBackColor = true;
            this.CCS.CheckedChanged += new System.EventHandler(this.CCS_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(6, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(176, 20);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Type2 Charging (default)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // CPFaulty
            // 
            this.CPFaulty.AutoSize = true;
            this.CPFaulty.Location = new System.Drawing.Point(6, 21);
            this.CPFaulty.Name = "CPFaulty";
            this.CPFaulty.Size = new System.Drawing.Size(100, 20);
            this.CPFaulty.TabIndex = 6;
            this.CPFaulty.Text = "Control Pilot";
            this.CPFaulty.UseVisualStyleBackColor = true;
            // 
            // PPFaulty
            // 
            this.PPFaulty.AutoSize = true;
            this.PPFaulty.Location = new System.Drawing.Point(6, 47);
            this.PPFaulty.Name = "PPFaulty";
            this.PPFaulty.Size = new System.Drawing.Size(112, 20);
            this.PPFaulty.TabIndex = 7;
            this.PPFaulty.Text = "Proximity Pilot";
            this.PPFaulty.UseVisualStyleBackColor = true;
            // 
            // PEFaulty
            // 
            this.PEFaulty.AutoSize = true;
            this.PEFaulty.Location = new System.Drawing.Point(6, 73);
            this.PEFaulty.Name = "PEFaulty";
            this.PEFaulty.Size = new System.Drawing.Size(123, 20);
            this.PEFaulty.TabIndex = 8;
            this.PEFaulty.Text = "Protective Earth";
            this.PEFaulty.UseVisualStyleBackColor = true;
            // 
            // NFaulty
            // 
            this.NFaulty.AutoSize = true;
            this.NFaulty.Location = new System.Drawing.Point(6, 99);
            this.NFaulty.Name = "NFaulty";
            this.NFaulty.Size = new System.Drawing.Size(94, 20);
            this.NFaulty.TabIndex = 9;
            this.NFaulty.Text = "Neutral Pin";
            this.NFaulty.UseVisualStyleBackColor = true;
            // 
            // L1Faulty
            // 
            this.L1Faulty.AutoSize = true;
            this.L1Faulty.Location = new System.Drawing.Point(6, 125);
            this.L1Faulty.Name = "L1Faulty";
            this.L1Faulty.Size = new System.Drawing.Size(65, 20);
            this.L1Faulty.TabIndex = 10;
            this.L1Faulty.Text = "L1 Pin";
            this.L1Faulty.UseVisualStyleBackColor = true;
            // 
            // L2Faulty
            // 
            this.L2Faulty.AutoSize = true;
            this.L2Faulty.Location = new System.Drawing.Point(6, 151);
            this.L2Faulty.Name = "L2Faulty";
            this.L2Faulty.Size = new System.Drawing.Size(65, 20);
            this.L2Faulty.TabIndex = 11;
            this.L2Faulty.Text = "L2 Pin";
            this.L2Faulty.UseVisualStyleBackColor = true;
            // 
            // L3Faulty
            // 
            this.L3Faulty.AutoSize = true;
            this.L3Faulty.Location = new System.Drawing.Point(6, 177);
            this.L3Faulty.Name = "L3Faulty";
            this.L3Faulty.Size = new System.Drawing.Size(65, 20);
            this.L3Faulty.TabIndex = 12;
            this.L3Faulty.Text = "L3 Pin";
            this.L3Faulty.UseVisualStyleBackColor = true;
            // 
            // DCPlusFaulty
            // 
            this.DCPlusFaulty.AutoSize = true;
            this.DCPlusFaulty.Enabled = false;
            this.DCPlusFaulty.Location = new System.Drawing.Point(6, 203);
            this.DCPlusFaulty.Name = "DCPlusFaulty";
            this.DCPlusFaulty.Size = new System.Drawing.Size(55, 20);
            this.DCPlusFaulty.TabIndex = 13;
            this.DCPlusFaulty.Text = "DC+";
            this.DCPlusFaulty.UseVisualStyleBackColor = true;
            // 
            // DCMinusFaulty
            // 
            this.DCMinusFaulty.AutoSize = true;
            this.DCMinusFaulty.Enabled = false;
            this.DCMinusFaulty.Location = new System.Drawing.Point(6, 229);
            this.DCMinusFaulty.Name = "DCMinusFaulty";
            this.DCMinusFaulty.Size = new System.Drawing.Size(52, 20);
            this.DCMinusFaulty.TabIndex = 14;
            this.DCMinusFaulty.Text = "DC-";
            this.DCMinusFaulty.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DCMinusFaulty);
            this.groupBox1.Controls.Add(this.DCPlusFaulty);
            this.groupBox1.Controls.Add(this.CPFaulty);
            this.groupBox1.Controls.Add(this.L3Faulty);
            this.groupBox1.Controls.Add(this.PPFaulty);
            this.groupBox1.Controls.Add(this.L2Faulty);
            this.groupBox1.Controls.Add(this.PEFaulty);
            this.groupBox1.Controls.Add(this.startCarBtn);
            this.groupBox1.Controls.Add(this.L1Faulty);
            this.groupBox1.Controls.Add(this.NFaulty);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 312);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Faulty Pins:";
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(219, 55);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(398, 411);
            this.LogBox.TabIndex = 16;
            this.LogBox.TextChanged += new System.EventHandler(this.LogBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Event Logs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(708, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Charging Station Properties";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ccsCostBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.type2CostBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.adressBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.startStationBtn);
            this.groupBox2.Controls.Add(this.yCorBox);
            this.groupBox2.Controls.Add(this.xCorBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.stationCodeBox);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(623, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 265);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // ccsCostBox
            // 
            this.ccsCostBox.DecimalPlaces = 2;
            this.ccsCostBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ccsCostBox.Location = new System.Drawing.Point(110, 191);
            this.ccsCostBox.Name = "ccsCostBox";
            this.ccsCostBox.Size = new System.Drawing.Size(101, 22);
            this.ccsCostBox.TabIndex = 13;
            this.ccsCostBox.Value = new decimal(new int[] {
            750,
            0,
            0,
            131072});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "CCS    ₺/kWh:";
            // 
            // type2CostBox
            // 
            this.type2CostBox.DecimalPlaces = 2;
            this.type2CostBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.type2CostBox.Location = new System.Drawing.Point(110, 158);
            this.type2CostBox.Name = "type2CostBox";
            this.type2CostBox.Size = new System.Drawing.Size(101, 22);
            this.type2CostBox.TabIndex = 11;
            this.type2CostBox.Value = new decimal(new int[] {
            599,
            0,
            0,
            131072});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Type2 ₺/kWh:";
            // 
            // adressBox
            // 
            this.adressBox.Location = new System.Drawing.Point(110, 84);
            this.adressBox.Multiline = true;
            this.adressBox.Name = "adressBox";
            this.adressBox.Size = new System.Drawing.Size(261, 61);
            this.adressBox.TabIndex = 8;
            this.adressBox.Text = "Eskibağlar Mah. Prof. Dr. Yılmaz Büyükerşen Blv. No:21, Tepebaşı , 26170 Eskişehi" +
    "r / Türkiye";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "X:";
            // 
            // yCorBox
            // 
            this.yCorBox.Location = new System.Drawing.Point(256, 52);
            this.yCorBox.Name = "yCorBox";
            this.yCorBox.Size = new System.Drawing.Size(115, 22);
            this.yCorBox.TabIndex = 4;
            this.yCorBox.Text = "30° 30\' 39.3948\" E";
            // 
            // xCorBox
            // 
            this.xCorBox.Location = new System.Drawing.Point(110, 52);
            this.xCorBox.Name = "xCorBox";
            this.xCorBox.Size = new System.Drawing.Size(115, 22);
            this.xCorBox.TabIndex = 3;
            this.xCorBox.Text = "39° 46\' 59.1348\" N";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Station Code:";
            // 
            // stationCodeBox
            // 
            this.stationCodeBox.Location = new System.Drawing.Point(110, 21);
            this.stationCodeBox.Name = "stationCodeBox";
            this.stationCodeBox.Size = new System.Drawing.Size(261, 22);
            this.stationCodeBox.TabIndex = 0;
            this.stationCodeBox.Text = "TR-ESK-001";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.batteryLevel);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.CCS);
            this.groupBox3.Location = new System.Drawing.Point(12, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 115);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(108, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "/60 kW";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(3, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Battery Capacity: 60 kW";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Battery:";
            // 
            // batteryLevel
            // 
            this.batteryLevel.Location = new System.Drawing.Point(61, 78);
            this.batteryLevel.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.batteryLevel.Name = "batteryLevel";
            this.batteryLevel.Size = new System.Drawing.Size(46, 22);
            this.batteryLevel.TabIndex = 5;
            this.batteryLevel.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(542, 29);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 21;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 478);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ControlPanel";
            this.Text = "Control Panel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccsCostBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type2CostBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteryLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startStationBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox CPFaulty;
        private System.Windows.Forms.CheckBox PPFaulty;
        private System.Windows.Forms.CheckBox PEFaulty;
        private System.Windows.Forms.CheckBox NFaulty;
        private System.Windows.Forms.CheckBox L1Faulty;
        private System.Windows.Forms.CheckBox L2Faulty;
        private System.Windows.Forms.CheckBox L3Faulty;
        private System.Windows.Forms.CheckBox DCPlusFaulty;
        private System.Windows.Forms.CheckBox DCMinusFaulty;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox LogBox;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox CCS;
        public System.Windows.Forms.Button startCarBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox yCorBox;
        public System.Windows.Forms.TextBox xCorBox;
        public System.Windows.Forms.TextBox stationCodeBox;
        public System.Windows.Forms.TextBox adressBox;
        public System.Windows.Forms.NumericUpDown type2CostBox;
        public System.Windows.Forms.NumericUpDown ccsCostBox;
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.NumericUpDown batteryLevel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button clearBtn;
    }
}

