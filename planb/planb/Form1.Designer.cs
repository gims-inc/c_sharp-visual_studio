namespace SSC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.notLabel = new System.Windows.Forms.Label();
            this.airtLabel = new System.Windows.Forms.Label();
            this.locLabel = new System.Windows.Forms.Label();
            this.regLabel = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            this.opLabel = new System.Windows.Forms.Label();
            this.sigLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numCombo = new System.Windows.Forms.ComboBox();
            this.incoming = new System.Windows.Forms.ComboBox();
            this.sr = new System.Windows.Forms.ComboBox();
            this.dat11 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.serialLabel = new System.Windows.Forms.Label();
            this.hardLabel = new System.Windows.Forms.Label();
            this.reportBox = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.airtBox = new System.Windows.Forms.Label();
            this.locBox = new System.Windows.Forms.Label();
            this.regBox = new System.Windows.Forms.Label();
            this.numBox = new System.Windows.Forms.Label();
            this.opBox = new System.Windows.Forms.Label();
            this.sigBox = new System.Windows.Forms.Label();
            this.serialBox = new System.Windows.Forms.Label();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.nummBox = new System.Windows.Forms.TextBox();
            this.usb = new System.Windows.Forms.CheckBox();
            this.swtch = new System.Windows.Forms.CheckBox();
            this.solar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(365, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUNami SSC Application";
            // 
            // notLabel
            // 
            this.notLabel.AutoSize = true;
            this.notLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notLabel.ForeColor = System.Drawing.Color.Red;
            this.notLabel.Location = new System.Drawing.Point(528, 152);
            this.notLabel.Name = "notLabel";
            this.notLabel.Size = new System.Drawing.Size(51, 20);
            this.notLabel.TabIndex = 1;
            this.notLabel.Text = "label2";
            // 
            // airtLabel
            // 
            this.airtLabel.AutoSize = true;
            this.airtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airtLabel.Location = new System.Drawing.Point(26, 337);
            this.airtLabel.Name = "airtLabel";
            this.airtLabel.Size = new System.Drawing.Size(208, 20);
            this.airtLabel.TabIndex = 2;
            this.airtLabel.Text = "Querying for Airtime balance";
            // 
            // locLabel
            // 
            this.locLabel.AutoSize = true;
            this.locLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locLabel.Location = new System.Drawing.Point(28, 381);
            this.locLabel.Name = "locLabel";
            this.locLabel.Size = new System.Drawing.Size(220, 20);
            this.locLabel.TabIndex = 3;
            this.locLabel.Text = "Checking if SIM card is locked";
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLabel.Location = new System.Drawing.Point(28, 426);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(210, 20);
            this.regLabel.TabIndex = 4;
            this.regLabel.Text = "Checking for version number";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLabel.Location = new System.Drawing.Point(28, 464);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(197, 20);
            this.numLabel.TabIndex = 5;
            this.numLabel.Text = "Checking for manufacturer";
            // 
            // opLabel
            // 
            this.opLabel.AutoSize = true;
            this.opLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opLabel.Location = new System.Drawing.Point(28, 504);
            this.opLabel.Name = "opLabel";
            this.opLabel.Size = new System.Drawing.Size(211, 20);
            this.opLabel.TabIndex = 6;
            this.opLabel.Text = "Checking for service provider";
            // 
            // sigLabel
            // 
            this.sigLabel.AutoSize = true;
            this.sigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigLabel.Location = new System.Drawing.Point(28, 545);
            this.sigLabel.Name = "sigLabel";
            this.sigLabel.Size = new System.Drawing.Size(206, 20);
            this.sigLabel.TabIndex = 7;
            this.sigLabel.Text = "Checking for signal strength";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.Red;
            this.startLabel.Location = new System.Drawing.Point(397, 261);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(192, 20);
            this.startLabel.TabIndex = 8;
            this.startLabel.Text = "SSC Pinging in progress...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(366, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(319, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Connect the SSC to the computer and select COM port.";
            // 
            // numCombo
            // 
            this.numCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCombo.ForeColor = System.Drawing.Color.Red;
            this.numCombo.FormattingEnabled = true;
            this.numCombo.Location = new System.Drawing.Point(561, 112);
            this.numCombo.Name = "numCombo";
            this.numCombo.Size = new System.Drawing.Size(62, 28);
            this.numCombo.TabIndex = 10;
            // 
            // incoming
            // 
            this.incoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incoming.FormattingEnabled = true;
            this.incoming.Location = new System.Drawing.Point(933, 112);
            this.incoming.Name = "incoming";
            this.incoming.Size = new System.Drawing.Size(95, 28);
            this.incoming.TabIndex = 11;
            // 
            // sr
            // 
            this.sr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sr.ForeColor = System.Drawing.Color.Red;
            this.sr.FormattingEnabled = true;
            this.sr.Items.AddRange(new object[] {
            "SPS-",
            "NHBD-",
            "NSNFHBD-",
            "NHBD2-",
            "NHBD-2PS-",
            "NHBD-2PS-UG-",
            "Other"});
            this.sr.Location = new System.Drawing.Point(1124, 172);
            this.sr.Name = "sr";
            this.sr.Size = new System.Drawing.Size(116, 28);
            this.sr.TabIndex = 12;
            this.sr.SelectedIndexChanged += new System.EventHandler(this.nummBox_SelectedIndexChanged);
            // 
            // dat11
            // 
            this.dat11.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dat11.CustomFormat = "MM/dd/yyyy";
            this.dat11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dat11.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dat11.Location = new System.Drawing.Point(1124, 110);
            this.dat11.Name = "dat11";
            this.dat11.Size = new System.Drawing.Size(116, 26);
            this.dat11.TabIndex = 13;
            this.dat11.ValueChanged += new System.EventHandler(this.dat11_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(32, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 150);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(539, 184);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 28);
            this.btnTest.TabIndex = 15;
            this.btnTest.Text = "Start";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialLabel.Location = new System.Drawing.Point(26, 583);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(197, 20);
            this.serialLabel.TabIndex = 16;
            this.serialLabel.Text = "Querying for Serial number";
            // 
            // hardLabel
            // 
            this.hardLabel.AutoSize = true;
            this.hardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardLabel.ForeColor = System.Drawing.Color.Red;
            this.hardLabel.Location = new System.Drawing.Point(28, 621);
            this.hardLabel.Name = "hardLabel";
            this.hardLabel.Size = new System.Drawing.Size(356, 20);
            this.hardLabel.TabIndex = 17;
            this.hardLabel.Text = "Performing other hardware tests... Please hold on";
            // 
            // reportBox
            // 
            this.reportBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBox.Location = new System.Drawing.Point(830, 495);
            this.reportBox.Multiline = true;
            this.reportBox.Name = "reportBox";
            this.reportBox.Size = new System.Drawing.Size(380, 108);
            this.reportBox.TabIndex = 18;
            this.reportBox.Text = "Comment and Submit...\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.reportBox.TextChanged += new System.EventHandler(this.reportBox_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(30, 657);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(83, 32);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(401, 657);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(129, 32);
            this.btnReport.TabIndex = 20;
            this.btnReport.Text = "View Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1141, 657);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 32);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(365, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Enter your Phone number";
            // 
            // airtBox
            // 
            this.airtBox.AutoSize = true;
            this.airtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.airtBox.Location = new System.Drawing.Point(509, 337);
            this.airtBox.Name = "airtBox";
            this.airtBox.Size = new System.Drawing.Size(33, 20);
            this.airtBox.TabIndex = 24;
            this.airtBox.Text = "null";
            // 
            // locBox
            // 
            this.locBox.AutoSize = true;
            this.locBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.locBox.Location = new System.Drawing.Point(509, 381);
            this.locBox.Name = "locBox";
            this.locBox.Size = new System.Drawing.Size(33, 20);
            this.locBox.TabIndex = 25;
            this.locBox.Text = "null";
            // 
            // regBox
            // 
            this.regBox.AutoSize = true;
            this.regBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.regBox.Location = new System.Drawing.Point(507, 426);
            this.regBox.Name = "regBox";
            this.regBox.Size = new System.Drawing.Size(33, 20);
            this.regBox.TabIndex = 26;
            this.regBox.Text = "null";
            // 
            // numBox
            // 
            this.numBox.AutoSize = true;
            this.numBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.numBox.Location = new System.Drawing.Point(507, 464);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(33, 20);
            this.numBox.TabIndex = 27;
            this.numBox.Text = "null";
            // 
            // opBox
            // 
            this.opBox.AutoSize = true;
            this.opBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.opBox.Location = new System.Drawing.Point(509, 504);
            this.opBox.Name = "opBox";
            this.opBox.Size = new System.Drawing.Size(33, 20);
            this.opBox.TabIndex = 28;
            this.opBox.Text = "null";
            // 
            // sigBox
            // 
            this.sigBox.AutoSize = true;
            this.sigBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.sigBox.Location = new System.Drawing.Point(509, 545);
            this.sigBox.Name = "sigBox";
            this.sigBox.Size = new System.Drawing.Size(33, 20);
            this.sigBox.TabIndex = 29;
            this.sigBox.Text = "null";
            // 
            // serialBox
            // 
            this.serialBox.AutoSize = true;
            this.serialBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.serialBox.Location = new System.Drawing.Point(507, 583);
            this.serialBox.Name = "serialBox";
            this.serialBox.Size = new System.Drawing.Size(33, 20);
            this.serialBox.TabIndex = 30;
            this.serialBox.Text = "null";
            // 
            // statusCombo
            // 
            this.statusCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.Items.AddRange(new object[] {
            "First time",
            "From field",
            "Subsequent",
            "Other tests"});
            this.statusCombo.Location = new System.Drawing.Point(933, 172);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(121, 28);
            this.statusCombo.TabIndex = 31;
            // 
            // nummBox
            // 
            this.nummBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nummBox.ForeColor = System.Drawing.Color.Red;
            this.nummBox.Location = new System.Drawing.Point(629, 114);
            this.nummBox.Name = "nummBox";
            this.nummBox.Size = new System.Drawing.Size(100, 26);
            this.nummBox.TabIndex = 32;
            // 
            // usb
            // 
            this.usb.AutoSize = true;
            this.usb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usb.Location = new System.Drawing.Point(830, 338);
            this.usb.Name = "usb";
            this.usb.Size = new System.Drawing.Size(172, 24);
            this.usb.TabIndex = 33;
            this.usb.Text = "USB Port is working.";
            this.usb.UseVisualStyleBackColor = true;
            // 
            // swtch
            // 
            this.swtch.AutoSize = true;
            this.swtch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtch.Location = new System.Drawing.Point(830, 391);
            this.swtch.Name = "swtch";
            this.swtch.Size = new System.Drawing.Size(237, 24);
            this.swtch.TabIndex = 34;
            this.swtch.Text = "Controller can switch ON/OFF";
            this.swtch.UseVisualStyleBackColor = true;
            // 
            // solar
            // 
            this.solar.AutoSize = true;
            this.solar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solar.Location = new System.Drawing.Point(830, 447);
            this.solar.Name = "solar";
            this.solar.Size = new System.Drawing.Size(189, 24);
            this.solar.TabIndex = 35;
            this.solar.Text = "Solar Panel is charging";
            this.solar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1252, 749);
            this.Controls.Add(this.solar);
            this.Controls.Add(this.swtch);
            this.Controls.Add(this.usb);
            this.Controls.Add(this.nummBox);
            this.Controls.Add(this.statusCombo);
            this.Controls.Add(this.serialBox);
            this.Controls.Add(this.sigBox);
            this.Controls.Add(this.opBox);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.regBox);
            this.Controls.Add(this.locBox);
            this.Controls.Add(this.airtBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.reportBox);
            this.Controls.Add(this.hardLabel);
            this.Controls.Add(this.serialLabel);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dat11);
            this.Controls.Add(this.sr);
            this.Controls.Add(this.incoming);
            this.Controls.Add(this.numCombo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.sigLabel);
            this.Controls.Add(this.opLabel);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.locLabel);
            this.Controls.Add(this.airtLabel);
            this.Controls.Add(this.notLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSC TestApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label notLabel;
        private System.Windows.Forms.Label airtLabel;
        private System.Windows.Forms.Label locLabel;
        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label opLabel;
        private System.Windows.Forms.Label sigLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox numCombo;
        private System.Windows.Forms.ComboBox incoming;
        private System.Windows.Forms.ComboBox sr;
        private System.Windows.Forms.DateTimePicker dat11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label serialLabel;
        private System.Windows.Forms.Label hardLabel;
        private System.Windows.Forms.TextBox reportBox;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label airtBox;
        private System.Windows.Forms.Label locBox;
        private System.Windows.Forms.Label regBox;
        private System.Windows.Forms.Label numBox;
        private System.Windows.Forms.Label opBox;
        private System.Windows.Forms.Label sigBox;
        private System.Windows.Forms.Label serialBox;
        private System.Windows.Forms.ComboBox statusCombo;
        private System.Windows.Forms.TextBox nummBox;
        private System.Windows.Forms.CheckBox usb;
        private System.Windows.Forms.CheckBox swtch;
        private System.Windows.Forms.CheckBox solar;
    }
}

