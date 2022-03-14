
namespace SU_APP
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.dispatch1 = new SU_APP.user_controls.Dispatch();
            this.trackController1 = new SU_APP.user_controls.TrackController();
            this.track1 = new SU_APP.user_controls.Track();
            this.admin1 = new SU_APP.user_controls.Admin();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.login1 = new SU_APP.NewFolder.Login();
            this.userControl11 = new SU_APP.NewFolder.UserControl1();
            this.userControl21 = new SU_APP.NewFolder.UserControl2();
            this.panelAb1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelAb4 = new System.Windows.Forms.Panel();
            this.panelAb3 = new System.Windows.Forms.Panel();
            this.panelAb5 = new System.Windows.Forms.Panel();
            this.panelAb2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 6);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.linkLabelLogin);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 52);
            this.panel2.TabIndex = 1;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Salmon;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(906, 34);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(26, 15);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Exit";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.ActiveLinkColor = System.Drawing.Color.Salmon;
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.LinkColor = System.Drawing.Color.Red;
            this.linkLabelLogin.Location = new System.Drawing.Point(842, 34);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(37, 15);
            this.linkLabelLogin.TabIndex = 1;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Login";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(568, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 52);
            this.button5.TabIndex = 0;
            this.button5.Text = "Get Data";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(426, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 52);
            this.button4.TabIndex = 0;
            this.button4.Text = "Dispatch";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(284, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 52);
            this.button3.TabIndex = 0;
            this.button3.Text = "Track Controller";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(142, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 52);
            this.button2.TabIndex = 0;
            this.button2.Text = "TESTS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 574);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(944, 6);
            this.panel4.TabIndex = 1;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.btnAdmin);
            this.panelDesktop.Controls.Add(this.userControl21);
            this.panelDesktop.Controls.Add(this.dispatch1);
            this.panelDesktop.Controls.Add(this.trackController1);
            this.panelDesktop.Controls.Add(this.track1);
            this.panelDesktop.Controls.Add(this.admin1);
            this.panelDesktop.Controls.Add(this.userControl11);
            this.panelDesktop.Controls.Add(this.login1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 58);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(944, 516);
            this.panelDesktop.TabIndex = 2;
            // 
            // dispatch1
            // 
            this.dispatch1.Location = new System.Drawing.Point(17, 29);
            this.dispatch1.Name = "dispatch1";
            this.dispatch1.Size = new System.Drawing.Size(889, 421);
            this.dispatch1.TabIndex = 7;
            // 
            // trackController1
            // 
            this.trackController1.Location = new System.Drawing.Point(8, 35);
            this.trackController1.Name = "trackController1";
            this.trackController1.Size = new System.Drawing.Size(924, 428);
            this.trackController1.TabIndex = 6;
            // 
            // track1
            // 
            this.track1.Location = new System.Drawing.Point(12, 35);
            this.track1.Name = "track1";
            this.track1.Size = new System.Drawing.Size(907, 389);
            this.track1.TabIndex = 5;
            // 
            // admin1
            // 
            this.admin1.BackColor = System.Drawing.Color.White;
            this.admin1.Location = new System.Drawing.Point(12, 29);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(907, 395);
            this.admin1.TabIndex = 4;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackgroundImage = global::SU_APP.Properties.Resources.add_512x512_475004;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Location = new System.Drawing.Point(17, 469);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(50, 41);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(555, 29);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(359, 146);
            this.login1.TabIndex = 2;
            this.login1.Load += new System.EventHandler(this.login1_Load);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.LightSalmon;
            this.userControl11.Location = new System.Drawing.Point(12, 29);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(902, 395);
            this.userControl11.TabIndex = 0;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl21.Location = new System.Drawing.Point(17, 29);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(902, 463);
            this.userControl21.TabIndex = 1;
            // 
            // panelAb1
            // 
            this.panelAb1.BackColor = System.Drawing.Color.Red;
            this.panelAb1.Location = new System.Drawing.Point(0, 0);
            this.panelAb1.Name = "panelAb1";
            this.panelAb1.Size = new System.Drawing.Size(143, 6);
            this.panelAb1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.panelAb4);
            this.panel3.Controls.Add(this.panelAb3);
            this.panel3.Controls.Add(this.panelAb5);
            this.panel3.Controls.Add(this.panelAb2);
            this.panel3.Controls.Add(this.panelAb1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 10);
            this.panel3.TabIndex = 2;
            // 
            // panelAb4
            // 
            this.panelAb4.BackColor = System.Drawing.Color.Red;
            this.panelAb4.Location = new System.Drawing.Point(426, 0);
            this.panelAb4.Name = "panelAb4";
            this.panelAb4.Size = new System.Drawing.Size(142, 6);
            this.panelAb4.TabIndex = 0;
            // 
            // panelAb3
            // 
            this.panelAb3.BackColor = System.Drawing.Color.Red;
            this.panelAb3.Location = new System.Drawing.Point(284, 0);
            this.panelAb3.Name = "panelAb3";
            this.panelAb3.Size = new System.Drawing.Size(143, 6);
            this.panelAb3.TabIndex = 0;
            // 
            // panelAb5
            // 
            this.panelAb5.BackColor = System.Drawing.Color.Red;
            this.panelAb5.Location = new System.Drawing.Point(568, 0);
            this.panelAb5.Name = "panelAb5";
            this.panelAb5.Size = new System.Drawing.Size(142, 6);
            this.panelAb5.TabIndex = 0;
            // 
            // panelAb2
            // 
            this.panelAb2.BackColor = System.Drawing.Color.Red;
            this.panelAb2.Location = new System.Drawing.Point(142, 0);
            this.panelAb2.Name = "panelAb2";
            this.panelAb2.Size = new System.Drawing.Size(142, 6);
            this.panelAb2.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 580);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelAb1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelAb5;
        private System.Windows.Forms.Panel panelAb4;
        private System.Windows.Forms.Panel panelAb3;
        private System.Windows.Forms.Panel panelAb2;
        private NewFolder.UserControl1 userControl11;
        private NewFolder.UserControl2 userControl21;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private NewFolder.Login login1;
        private System.Windows.Forms.Button btnAdmin;
        private user_controls.Admin admin1;
        private user_controls.Track track1;
        private user_controls.TrackController trackController1;
        private user_controls.Dispatch dispatch1;
    }
}

