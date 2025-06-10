namespace BDVOProject
{
    partial class ChargingStation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChargingStation));
            this.stationBox = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.startChargingBtn = new System.Windows.Forms.Button();
            this.stopChargingBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CCSImage = new System.Windows.Forms.PictureBox();
            this.type2Image = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CCSImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type2Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // stationBox
            // 
            this.stationBox.BackColor = System.Drawing.Color.PowderBlue;
            this.stationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stationBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stationBox.Location = new System.Drawing.Point(12, 37);
            this.stationBox.Multiline = true;
            this.stationBox.Name = "stationBox";
            this.stationBox.ReadOnly = true;
            this.stationBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stationBox.Size = new System.Drawing.Size(436, 349);
            this.stationBox.TabIndex = 0;
            this.stationBox.Text = "Welcome to Electric Vehicle Supply Exuipment\r\n";
            this.stationBox.TextChanged += new System.EventHandler(this.stationBox_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(190, 25);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "EV Charging Station";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CCS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.type2Image);
            this.groupBox1.Location = new System.Drawing.Point(12, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CCSImage);
            this.groupBox2.Location = new System.Drawing.Point(337, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 57);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // startChargingBtn
            // 
            this.startChargingBtn.Enabled = false;
            this.startChargingBtn.Location = new System.Drawing.Point(111, 455);
            this.startChargingBtn.Name = "startChargingBtn";
            this.startChargingBtn.Size = new System.Drawing.Size(112, 50);
            this.startChargingBtn.TabIndex = 8;
            this.startChargingBtn.Text = "Start Charging";
            this.startChargingBtn.UseVisualStyleBackColor = true;
            this.startChargingBtn.Click += new System.EventHandler(this.startChargingBtn_Click);
            // 
            // stopChargingBtn
            // 
            this.stopChargingBtn.Enabled = false;
            this.stopChargingBtn.Location = new System.Drawing.Point(229, 455);
            this.stopChargingBtn.Name = "stopChargingBtn";
            this.stopChargingBtn.Size = new System.Drawing.Size(112, 50);
            this.stopChargingBtn.TabIndex = 9;
            this.stopChargingBtn.Text = "Stop Charging";
            this.stopChargingBtn.UseVisualStyleBackColor = true;
            this.stopChargingBtn.Click += new System.EventHandler(this.stopChargingBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CCSImage
            // 
            this.CCSImage.Image = global::BDVOProject.Properties.Resources.available;
            this.CCSImage.Location = new System.Drawing.Point(68, 18);
            this.CCSImage.Name = "CCSImage";
            this.CCSImage.Size = new System.Drawing.Size(27, 27);
            this.CCSImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CCSImage.TabIndex = 5;
            this.CCSImage.TabStop = false;
            // 
            // type2Image
            // 
            this.type2Image.Image = global::BDVOProject.Properties.Resources.available;
            this.type2Image.Location = new System.Drawing.Point(86, 18);
            this.type2Image.Name = "type2Image";
            this.type2Image.Size = new System.Drawing.Size(27, 27);
            this.type2Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.type2Image.TabIndex = 3;
            this.type2Image.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BDVOProject.Properties.Resources.connector1;
            this.pictureBox1.Location = new System.Drawing.Point(148, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BDVOProject.Properties.Resources.connector2;
            this.pictureBox2.Location = new System.Drawing.Point(277, 399);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // ChargingStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 517);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stopChargingBtn);
            this.Controls.Add(this.startChargingBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.stationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChargingStation";
            this.Text = "Charging Station";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChargingStation_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CCSImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type2Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.PictureBox type2Image;
        public System.Windows.Forms.PictureBox CCSImage;
        public System.Windows.Forms.TextBox stationBox;
        public System.Windows.Forms.Button startChargingBtn;
        public System.Windows.Forms.Button stopChargingBtn;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}