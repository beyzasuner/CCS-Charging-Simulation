namespace BDVOProject
{
    partial class ElectricVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElectricVehicle));
            this.batteryBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectType2Btn = new System.Windows.Forms.Button();
            this.connectCCSBtn = new System.Windows.Forms.Button();
            this.pinsGroupBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dcPinsGroupBox = new System.Windows.Forms.GroupBox();
            this.disconnectType2Btn = new System.Windows.Forms.Button();
            this.disconnectCCSBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.stopCarBtn = new System.Windows.Forms.Button();
            this.startCarBtn = new System.Windows.Forms.Button();
            this.immobilizedImage = new System.Windows.Forms.PictureBox();
            this.DCMinusUsedImage = new System.Windows.Forms.PictureBox();
            this.DCPlusFaultyImage = new System.Windows.Forms.PictureBox();
            this.DCMinusFaultyImage = new System.Windows.Forms.PictureBox();
            this.DCPlusUsedImage = new System.Windows.Forms.PictureBox();
            this.L3UsedImage = new System.Windows.Forms.PictureBox();
            this.L3FaultyImage = new System.Windows.Forms.PictureBox();
            this.L2UsedImage = new System.Windows.Forms.PictureBox();
            this.L2FaultyImage = new System.Windows.Forms.PictureBox();
            this.L1UsedImage = new System.Windows.Forms.PictureBox();
            this.L1FaultyImage = new System.Windows.Forms.PictureBox();
            this.NUsedImage = new System.Windows.Forms.PictureBox();
            this.NFaultyImage = new System.Windows.Forms.PictureBox();
            this.PEUsedImage = new System.Windows.Forms.PictureBox();
            this.PEFaultyImage = new System.Windows.Forms.PictureBox();
            this.PPUsedImage = new System.Windows.Forms.PictureBox();
            this.PPFaultyImage = new System.Windows.Forms.PictureBox();
            this.CPUsedImage = new System.Windows.Forms.PictureBox();
            this.CPFaultyImage = new System.Windows.Forms.PictureBox();
            this.ChargerImage = new System.Windows.Forms.PictureBox();
            this.pinsGroupBox.SuspendLayout();
            this.dcPinsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.immobilizedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCMinusUsedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCPlusFaultyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCMinusFaultyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCPlusUsedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3UsedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3FaultyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2UsedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2FaultyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1UsedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1FaultyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUsedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NFaultyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEUsedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEFaultyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPUsedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPFaultyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUsedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPFaultyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChargerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // batteryBar
            // 
            this.batteryBar.Location = new System.Drawing.Point(12, 442);
            this.batteryBar.Maximum = 60;
            this.batteryBar.Name = "batteryBar";
            this.batteryBar.Size = new System.Drawing.Size(800, 34);
            this.batteryBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Battery Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Socket";
            // 
            // connectType2Btn
            // 
            this.connectType2Btn.Enabled = false;
            this.connectType2Btn.Location = new System.Drawing.Point(559, 306);
            this.connectType2Btn.Name = "connectType2Btn";
            this.connectType2Btn.Size = new System.Drawing.Size(125, 62);
            this.connectType2Btn.TabIndex = 4;
            this.connectType2Btn.Text = "Connect to Type2";
            this.connectType2Btn.UseVisualStyleBackColor = true;
            this.connectType2Btn.Click += new System.EventHandler(this.connectType2Btn_Click);
            // 
            // connectCCSBtn
            // 
            this.connectCCSBtn.Enabled = false;
            this.connectCCSBtn.Location = new System.Drawing.Point(687, 306);
            this.connectCCSBtn.Name = "connectCCSBtn";
            this.connectCCSBtn.Size = new System.Drawing.Size(125, 62);
            this.connectCCSBtn.TabIndex = 5;
            this.connectCCSBtn.Text = "Connect to CCS (Fast Charging)";
            this.connectCCSBtn.UseVisualStyleBackColor = true;
            this.connectCCSBtn.Click += new System.EventHandler(this.connectCCSBtn_Click);
            // 
            // pinsGroupBox
            // 
            this.pinsGroupBox.Controls.Add(this.L3UsedImage);
            this.pinsGroupBox.Controls.Add(this.L3FaultyImage);
            this.pinsGroupBox.Controls.Add(this.L2UsedImage);
            this.pinsGroupBox.Controls.Add(this.L2FaultyImage);
            this.pinsGroupBox.Controls.Add(this.L1UsedImage);
            this.pinsGroupBox.Controls.Add(this.L1FaultyImage);
            this.pinsGroupBox.Controls.Add(this.NUsedImage);
            this.pinsGroupBox.Controls.Add(this.NFaultyImage);
            this.pinsGroupBox.Controls.Add(this.PEUsedImage);
            this.pinsGroupBox.Controls.Add(this.PEFaultyImage);
            this.pinsGroupBox.Controls.Add(this.PPUsedImage);
            this.pinsGroupBox.Controls.Add(this.PPFaultyImage);
            this.pinsGroupBox.Controls.Add(this.CPUsedImage);
            this.pinsGroupBox.Controls.Add(this.CPFaultyImage);
            this.pinsGroupBox.Controls.Add(this.label11);
            this.pinsGroupBox.Controls.Add(this.label10);
            this.pinsGroupBox.Controls.Add(this.label9);
            this.pinsGroupBox.Controls.Add(this.label8);
            this.pinsGroupBox.Controls.Add(this.label7);
            this.pinsGroupBox.Controls.Add(this.label6);
            this.pinsGroupBox.Controls.Add(this.label5);
            this.pinsGroupBox.Controls.Add(this.label4);
            this.pinsGroupBox.Controls.Add(this.label3);
            this.pinsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.pinsGroupBox.Name = "pinsGroupBox";
            this.pinsGroupBox.Size = new System.Drawing.Size(283, 270);
            this.pinsGroupBox.TabIndex = 6;
            this.pinsGroupBox.TabStop = false;
            this.pinsGroupBox.Text = "Pins";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "L3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "PE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "L2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "L1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "N";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "PP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "CP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Used";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Faulty";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "DC+";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "DC-";
            // 
            // dcPinsGroupBox
            // 
            this.dcPinsGroupBox.Controls.Add(this.label12);
            this.dcPinsGroupBox.Controls.Add(this.DCMinusUsedImage);
            this.dcPinsGroupBox.Controls.Add(this.label13);
            this.dcPinsGroupBox.Controls.Add(this.DCPlusFaultyImage);
            this.dcPinsGroupBox.Controls.Add(this.DCMinusFaultyImage);
            this.dcPinsGroupBox.Controls.Add(this.DCPlusUsedImage);
            this.dcPinsGroupBox.Location = new System.Drawing.Point(12, 288);
            this.dcPinsGroupBox.Name = "dcPinsGroupBox";
            this.dcPinsGroupBox.Size = new System.Drawing.Size(283, 92);
            this.dcPinsGroupBox.TabIndex = 13;
            this.dcPinsGroupBox.TabStop = false;
            this.dcPinsGroupBox.Text = "DC Pins";
            // 
            // disconnectType2Btn
            // 
            this.disconnectType2Btn.Enabled = false;
            this.disconnectType2Btn.Location = new System.Drawing.Point(559, 374);
            this.disconnectType2Btn.Name = "disconnectType2Btn";
            this.disconnectType2Btn.Size = new System.Drawing.Size(125, 62);
            this.disconnectType2Btn.TabIndex = 14;
            this.disconnectType2Btn.Text = "Remove Type2";
            this.disconnectType2Btn.UseVisualStyleBackColor = true;
            this.disconnectType2Btn.Click += new System.EventHandler(this.disconnectType2Btn_Click);
            // 
            // disconnectCCSBtn
            // 
            this.disconnectCCSBtn.Enabled = false;
            this.disconnectCCSBtn.Location = new System.Drawing.Point(687, 374);
            this.disconnectCCSBtn.Name = "disconnectCCSBtn";
            this.disconnectCCSBtn.Size = new System.Drawing.Size(125, 62);
            this.disconnectCCSBtn.TabIndex = 15;
            this.disconnectCCSBtn.Text = "Remove CCS";
            this.disconnectCCSBtn.UseVisualStyleBackColor = true;
            this.disconnectCCSBtn.Click += new System.EventHandler(this.disconnectCCSBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(312, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "Immobilized";
            // 
            // stopCarBtn
            // 
            this.stopCarBtn.Location = new System.Drawing.Point(424, 16);
            this.stopCarBtn.Name = "stopCarBtn";
            this.stopCarBtn.Size = new System.Drawing.Size(75, 25);
            this.stopCarBtn.TabIndex = 17;
            this.stopCarBtn.Text = "Stop Car";
            this.stopCarBtn.UseVisualStyleBackColor = true;
            this.stopCarBtn.Click += new System.EventHandler(this.stopCarBtn_Click);
            // 
            // startCarBtn
            // 
            this.startCarBtn.Enabled = false;
            this.startCarBtn.Location = new System.Drawing.Point(424, 43);
            this.startCarBtn.Name = "startCarBtn";
            this.startCarBtn.Size = new System.Drawing.Size(75, 25);
            this.startCarBtn.TabIndex = 18;
            this.startCarBtn.Text = "Start Car";
            this.startCarBtn.UseVisualStyleBackColor = true;
            this.startCarBtn.Click += new System.EventHandler(this.startCarBtn_Click);
            // 
            // immobilizedImage
            // 
            this.immobilizedImage.Image = global::BDVOProject.Properties.Resources.busy;
            this.immobilizedImage.Location = new System.Drawing.Point(397, 31);
            this.immobilizedImage.Name = "immobilizedImage";
            this.immobilizedImage.Size = new System.Drawing.Size(20, 20);
            this.immobilizedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.immobilizedImage.TabIndex = 13;
            this.immobilizedImage.TabStop = false;
            // 
            // DCMinusUsedImage
            // 
            this.DCMinusUsedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DCMinusUsedImage.Location = new System.Drawing.Point(196, 55);
            this.DCMinusUsedImage.Name = "DCMinusUsedImage";
            this.DCMinusUsedImage.Size = new System.Drawing.Size(20, 20);
            this.DCMinusUsedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DCMinusUsedImage.TabIndex = 12;
            this.DCMinusUsedImage.TabStop = false;
            // 
            // DCPlusFaultyImage
            // 
            this.DCPlusFaultyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DCPlusFaultyImage.Location = new System.Drawing.Point(105, 23);
            this.DCPlusFaultyImage.Name = "DCPlusFaultyImage";
            this.DCPlusFaultyImage.Size = new System.Drawing.Size(20, 20);
            this.DCPlusFaultyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DCPlusFaultyImage.TabIndex = 11;
            this.DCPlusFaultyImage.TabStop = false;
            // 
            // DCMinusFaultyImage
            // 
            this.DCMinusFaultyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DCMinusFaultyImage.Location = new System.Drawing.Point(105, 55);
            this.DCMinusFaultyImage.Name = "DCMinusFaultyImage";
            this.DCMinusFaultyImage.Size = new System.Drawing.Size(20, 20);
            this.DCMinusFaultyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DCMinusFaultyImage.TabIndex = 11;
            this.DCMinusFaultyImage.TabStop = false;
            // 
            // DCPlusUsedImage
            // 
            this.DCPlusUsedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DCPlusUsedImage.Location = new System.Drawing.Point(196, 23);
            this.DCPlusUsedImage.Name = "DCPlusUsedImage";
            this.DCPlusUsedImage.Size = new System.Drawing.Size(20, 20);
            this.DCPlusUsedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DCPlusUsedImage.TabIndex = 12;
            this.DCPlusUsedImage.TabStop = false;
            // 
            // L3UsedImage
            // 
            this.L3UsedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L3UsedImage.Location = new System.Drawing.Point(196, 235);
            this.L3UsedImage.Name = "L3UsedImage";
            this.L3UsedImage.Size = new System.Drawing.Size(20, 20);
            this.L3UsedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.L3UsedImage.TabIndex = 12;
            this.L3UsedImage.TabStop = false;
            // 
            // L3FaultyImage
            // 
            this.L3FaultyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L3FaultyImage.Location = new System.Drawing.Point(105, 235);
            this.L3FaultyImage.Name = "L3FaultyImage";
            this.L3FaultyImage.Size = new System.Drawing.Size(20, 20);
            this.L3FaultyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.L3FaultyImage.TabIndex = 11;
            this.L3FaultyImage.TabStop = false;
            // 
            // L2UsedImage
            // 
            this.L2UsedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L2UsedImage.Location = new System.Drawing.Point(196, 203);
            this.L2UsedImage.Name = "L2UsedImage";
            this.L2UsedImage.Size = new System.Drawing.Size(20, 20);
            this.L2UsedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.L2UsedImage.TabIndex = 12;
            this.L2UsedImage.TabStop = false;
            // 
            // L2FaultyImage
            // 
            this.L2FaultyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L2FaultyImage.Location = new System.Drawing.Point(105, 203);
            this.L2FaultyImage.Name = "L2FaultyImage";
            this.L2FaultyImage.Size = new System.Drawing.Size(20, 20);
            this.L2FaultyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.L2FaultyImage.TabIndex = 11;
            this.L2FaultyImage.TabStop = false;
            // 
            // L1UsedImage
            // 
            this.L1UsedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L1UsedImage.Location = new System.Drawing.Point(196, 171);
            this.L1UsedImage.Name = "L1UsedImage";
            this.L1UsedImage.Size = new System.Drawing.Size(20, 20);
            this.L1UsedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.L1UsedImage.TabIndex = 12;
            this.L1UsedImage.TabStop = false;
            // 
            // L1FaultyImage
            // 
            this.L1FaultyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L1FaultyImage.Location = new System.Drawing.Point(105, 171);
            this.L1FaultyImage.Name = "L1FaultyImage";
            this.L1FaultyImage.Size = new System.Drawing.Size(20, 20);
            this.L1FaultyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.L1FaultyImage.TabIndex = 11;
            this.L1FaultyImage.TabStop = false;
            // 
            // NUsedImage
            // 
            this.NUsedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUsedImage.Location = new System.Drawing.Point(196, 139);
            this.NUsedImage.Name = "NUsedImage";
            this.NUsedImage.Size = new System.Drawing.Size(20, 20);
            this.NUsedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NUsedImage.TabIndex = 12;
            this.NUsedImage.TabStop = false;
            // 
            // NFaultyImage
            // 
            this.NFaultyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NFaultyImage.Location = new System.Drawing.Point(105, 139);
            this.NFaultyImage.Name = "NFaultyImage";
            this.NFaultyImage.Size = new System.Drawing.Size(20, 20);
            this.NFaultyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NFaultyImage.TabIndex = 11;
            this.NFaultyImage.TabStop = false;
            // 
            // PEUsedImage
            // 
            this.PEUsedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PEUsedImage.Location = new System.Drawing.Point(196, 107);
            this.PEUsedImage.Name = "PEUsedImage";
            this.PEUsedImage.Size = new System.Drawing.Size(20, 20);
            this.PEUsedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PEUsedImage.TabIndex = 12;
            this.PEUsedImage.TabStop = false;
            // 
            // PEFaultyImage
            // 
            this.PEFaultyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PEFaultyImage.Location = new System.Drawing.Point(105, 107);
            this.PEFaultyImage.Name = "PEFaultyImage";
            this.PEFaultyImage.Size = new System.Drawing.Size(20, 20);
            this.PEFaultyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PEFaultyImage.TabIndex = 11;
            this.PEFaultyImage.TabStop = false;
            // 
            // PPUsedImage
            // 
            this.PPUsedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PPUsedImage.Location = new System.Drawing.Point(196, 75);
            this.PPUsedImage.Name = "PPUsedImage";
            this.PPUsedImage.Size = new System.Drawing.Size(20, 20);
            this.PPUsedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PPUsedImage.TabIndex = 12;
            this.PPUsedImage.TabStop = false;
            // 
            // PPFaultyImage
            // 
            this.PPFaultyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PPFaultyImage.Location = new System.Drawing.Point(105, 75);
            this.PPFaultyImage.Name = "PPFaultyImage";
            this.PPFaultyImage.Size = new System.Drawing.Size(20, 20);
            this.PPFaultyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PPFaultyImage.TabIndex = 11;
            this.PPFaultyImage.TabStop = false;
            // 
            // CPUsedImage
            // 
            this.CPUsedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUsedImage.Location = new System.Drawing.Point(196, 45);
            this.CPUsedImage.Name = "CPUsedImage";
            this.CPUsedImage.Size = new System.Drawing.Size(20, 20);
            this.CPUsedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CPUsedImage.TabIndex = 12;
            this.CPUsedImage.TabStop = false;
            // 
            // CPFaultyImage
            // 
            this.CPFaultyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPFaultyImage.Location = new System.Drawing.Point(105, 45);
            this.CPFaultyImage.Name = "CPFaultyImage";
            this.CPFaultyImage.Size = new System.Drawing.Size(20, 20);
            this.CPFaultyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CPFaultyImage.TabIndex = 11;
            this.CPFaultyImage.TabStop = false;
            // 
            // ChargerImage
            // 
            this.ChargerImage.Location = new System.Drawing.Point(559, 31);
            this.ChargerImage.Name = "ChargerImage";
            this.ChargerImage.Size = new System.Drawing.Size(253, 269);
            this.ChargerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChargerImage.TabIndex = 2;
            this.ChargerImage.TabStop = false;
            // 
            // ElectricVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 483);
            this.Controls.Add(this.startCarBtn);
            this.Controls.Add(this.stopCarBtn);
            this.Controls.Add(this.immobilizedImage);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.disconnectCCSBtn);
            this.Controls.Add(this.disconnectType2Btn);
            this.Controls.Add(this.dcPinsGroupBox);
            this.Controls.Add(this.pinsGroupBox);
            this.Controls.Add(this.connectCCSBtn);
            this.Controls.Add(this.connectType2Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChargerImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.batteryBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ElectricVehicle";
            this.Text = "Electric Vehicle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ElectricVehicle_FormClosing);
            this.pinsGroupBox.ResumeLayout(false);
            this.pinsGroupBox.PerformLayout();
            this.dcPinsGroupBox.ResumeLayout(false);
            this.dcPinsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.immobilizedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCMinusUsedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCPlusFaultyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCMinusFaultyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCPlusUsedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3UsedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3FaultyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2UsedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2FaultyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1UsedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1FaultyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUsedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NFaultyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEUsedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEFaultyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPUsedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPFaultyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUsedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPFaultyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChargerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ChargerImage;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button connectType2Btn;
        public System.Windows.Forms.Button connectCCSBtn;
        private System.Windows.Forms.GroupBox pinsGroupBox;
        private System.Windows.Forms.PictureBox L3UsedImage;
        private System.Windows.Forms.PictureBox L3FaultyImage;
        private System.Windows.Forms.PictureBox L2UsedImage;
        private System.Windows.Forms.PictureBox L2FaultyImage;
        private System.Windows.Forms.PictureBox L1UsedImage;
        private System.Windows.Forms.PictureBox L1FaultyImage;
        private System.Windows.Forms.PictureBox NUsedImage;
        private System.Windows.Forms.PictureBox NFaultyImage;
        private System.Windows.Forms.PictureBox PEUsedImage;
        private System.Windows.Forms.PictureBox PEFaultyImage;
        private System.Windows.Forms.PictureBox PPUsedImage;
        private System.Windows.Forms.PictureBox PPFaultyImage;
        private System.Windows.Forms.PictureBox CPUsedImage;
        private System.Windows.Forms.PictureBox CPFaultyImage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox DCPlusFaultyImage;
        private System.Windows.Forms.PictureBox DCPlusUsedImage;
        private System.Windows.Forms.PictureBox DCMinusFaultyImage;
        private System.Windows.Forms.PictureBox DCMinusUsedImage;
        private System.Windows.Forms.GroupBox dcPinsGroupBox;
        public System.Windows.Forms.Button disconnectType2Btn;
        public System.Windows.Forms.Button disconnectCCSBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox immobilizedImage;
        private System.Windows.Forms.Button stopCarBtn;
        private System.Windows.Forms.Button startCarBtn;
        public System.Windows.Forms.ProgressBar batteryBar;
    }
}