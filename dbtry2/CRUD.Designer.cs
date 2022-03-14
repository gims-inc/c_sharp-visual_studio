
namespace dbtry2
{
    partial class CRUD
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fnameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lnameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pwdTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.cpwdLbl = new System.Windows.Forms.Label();
            this.confirmpwdTxt = new System.Windows.Forms.TextBox();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnShowall = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnTxtFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(278, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 20);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search?";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(278, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(485, 277);
            this.listBox1.TabIndex = 1;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(99, 73);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(163, 20);
            this.idTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(99, 99);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(163, 20);
            this.usernameTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name:";
            // 
            // fnameTxt
            // 
            this.fnameTxt.Location = new System.Drawing.Point(99, 125);
            this.fnameTxt.Name = "fnameTxt";
            this.fnameTxt.Size = new System.Drawing.Size(163, 20);
            this.fnameTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // lnameTxt
            // 
            this.lnameTxt.Location = new System.Drawing.Point(99, 151);
            this.lnameTxt.Name = "lnameTxt";
            this.lnameTxt.Size = new System.Drawing.Size(163, 20);
            this.lnameTxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(99, 177);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(163, 20);
            this.emailTxt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email:";
            // 
            // pwdTxt
            // 
            this.pwdTxt.Location = new System.Drawing.Point(99, 203);
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.PasswordChar = '*';
            this.pwdTxt.Size = new System.Drawing.Size(163, 20);
            this.pwdTxt.TabIndex = 2;
            this.pwdTxt.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Password:";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(99, 13);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(163, 20);
            this.searchTxt.TabIndex = 2;
            this.searchTxt.Text = "Enter last name\r\n";
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // cpwdLbl
            // 
            this.cpwdLbl.AutoSize = true;
            this.cpwdLbl.Location = new System.Drawing.Point(19, 232);
            this.cpwdLbl.Name = "cpwdLbl";
            this.cpwdLbl.Size = new System.Drawing.Size(69, 13);
            this.cpwdLbl.TabIndex = 3;
            this.cpwdLbl.Text = "Confirm Pwd:";
            // 
            // confirmpwdTxt
            // 
            this.confirmpwdTxt.Location = new System.Drawing.Point(99, 232);
            this.confirmpwdTxt.Name = "confirmpwdTxt";
            this.confirmpwdTxt.PasswordChar = '*';
            this.confirmpwdTxt.Size = new System.Drawing.Size(163, 20);
            this.confirmpwdTxt.TabIndex = 2;
            this.confirmpwdTxt.UseSystemPasswordChar = true;
            // 
            // btnAddnew
            // 
            this.btnAddnew.Location = new System.Drawing.Point(99, 300);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(75, 20);
            this.btnAddnew.TabIndex = 0;
            this.btnAddnew.Text = "Save";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(187, 274);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 20);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(75, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 20);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Add New/Edit";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(278, 373);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(98, 20);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Export To Exel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(187, 300);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 20);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Delete!";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnShowall
            // 
            this.btnShowall.Location = new System.Drawing.Point(412, 13);
            this.btnShowall.Name = "btnShowall";
            this.btnShowall.Size = new System.Drawing.Size(95, 19);
            this.btnShowall.TabIndex = 4;
            this.btnShowall.Text = "refresh";
            this.btnShowall.UseVisualStyleBackColor = true;
            this.btnShowall.Click += new System.EventHandler(this.btnShowall_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(670, 52);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 13);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "Count";
            // 
            // btnTxtFile
            // 
            this.btnTxtFile.Location = new System.Drawing.Point(393, 373);
            this.btnTxtFile.Name = "btnTxtFile";
            this.btnTxtFile.Size = new System.Drawing.Size(144, 20);
            this.btnTxtFile.TabIndex = 0;
            this.btnTxtFile.Text = "Export To Text File";
            this.btnTxtFile.UseVisualStyleBackColor = true;
            this.btnTxtFile.Click += new System.EventHandler(this.btnTxtFile_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnShowall);
            this.Controls.Add(this.cpwdLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmpwdTxt);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.pwdTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.lnameTxt);
            this.Controls.Add(this.fnameTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnTxtFile);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.btnSearch);
            this.Name = "CRUD";
            this.Text = "C# CRUD";
            this.Load += new System.EventHandler(this.one_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fnameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lnameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pwdTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label cpwdLbl;
        private System.Windows.Forms.TextBox confirmpwdTxt;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnShowall;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnTxtFile;
    }
}

