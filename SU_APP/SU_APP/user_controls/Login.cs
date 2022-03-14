//using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SU_APP.NewFolder
{
    public partial class Login : UserControl
    {

        public string getUser
        {
            get { return txtPwd.Text; }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;


          ///CoNN_Qerry conlogin = new CoNN_Qerry();

           // conlogin.OpenConection();

            try
            {
                //conlogin.DataReader("Select password from logntable where Username='" + txtUsername.Text + "' ");

            }
            catch(Exception ex)
            {
                MessageBox.Show("no connected");
            }

         

           
          


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            chpwd chpass = new chpwd();
            chpass.ShowDialog();

            ///this.SendToBack();
            this.Visible = false;
        }
    }
}
