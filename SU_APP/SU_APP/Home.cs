using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SU_APP.NewFolder;

namespace SU_APP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            //panells for active buttons
            panelAb1.Visible = false;
            panelAb2.Visible = false;
            panelAb3.Visible = false;
            panelAb4.Visible = false;
            panelAb5.Visible = false;


            //controlls
            userControl21.Visible = false; //test 
            userControl11.Visible=false;//home
            trackController1.Visible = false; //track controllers

            login1.Visible = false;//login form

            track1.Visible = false;//track
            admin1.Visible = false;// admin
            dispatch1.Visible = false;//Dispatch


        }




     
       

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (log_in == true)
            {


                panelAb1.Visible = true;

                panelAb2.Visible = false;
                panelAb3.Visible = false;
                panelAb4.Visible = false;
                panelAb5.Visible = false;

                userControl11.Visible = true;


                //hide other controls
                userControl21.Visible = false;
                trackController1.Visible = false;
                admin1.Visible = false;
                dispatch1.Visible = false;
            }
            else
                MessageBox.Show("Kindly log in!");

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (log_in == true)
            {

                panelAb2.Visible = true;

            panelAb1.Visible = false;
            panelAb3.Visible = false;
            panelAb4.Visible = false;
            panelAb5.Visible = false;

             userControl21.Visible = true;

                //close other controls
            userControl11.Visible = false;
                trackController1.Visible = false;
                // track1.Visible = false;
                admin1.Visible = false;
                dispatch1.Visible = false;
            }
            else
                MessageBox.Show("Kindly log in!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (log_in == true)
            {
                panelAb3.Visible = true;

            panelAb1.Visible = false;
            panelAb2.Visible = false;
            panelAb4.Visible = false;
            panelAb5.Visible = false;

                trackController1.Visible = true;

                //close other controls
                userControl21.Visible = false; ;
                userControl11.Visible = false;
                admin1.Visible = false;
                dispatch1.Visible = false;
            }
            else
                MessageBox.Show("Kindly log in!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (log_in == true)
            {
                panelAb4.Visible = true;

            panelAb1.Visible = false;
            panelAb3.Visible = false;
            panelAb2.Visible = false;
            panelAb5.Visible = false;


                //close other controls
                userControl21.Visible = false; 
                userControl11.Visible = false;
                //track1.Visible = false;
                trackController1.Visible = false;
                admin1.Visible = false;


                dispatch1.Visible = true;
            }
            else
                MessageBox.Show("Kindly log in!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (log_in == true)
            {
                panelAb5.Visible = true;

            panelAb1.Visible = false;
            panelAb3.Visible = false;
            panelAb4.Visible = false;
            panelAb2.Visible = false;

                //close other controls
                userControl21.Visible = false;
                userControl11.Visible = false;
                //track1.Visible = false;
                trackController1.Visible = false;
                admin1.Visible = false;
                dispatch1.Visible = false;
            }
            else
                MessageBox.Show("Kindly log in!");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login1.Visible = true;
            login1.BringToFront();
        }
        public bool log_in = false;
        private void login1_Load(object sender, EventArgs e)
        {
           
            log_in = true;
            //this.Close();
            linkLabelLogin.Text = "username";
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (log_in == true)
            {
                //
                panelAb1.Visible = false;
                panelAb2.Visible = false;
                panelAb3.Visible = false;
                panelAb4.Visible = false;
                panelAb5.Visible = false;

                admin1.Visible = true;

                //close other controls
                userControl21.Visible = false;
                userControl11.Visible = false;
                // track1.Visible = false;
                trackController1.Visible = false;
                dispatch1.Visible = false;
            }
            else
                MessageBox.Show("Kindly log in!");
        
        }
    }
}
