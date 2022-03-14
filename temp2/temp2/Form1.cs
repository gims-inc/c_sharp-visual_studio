using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temp2
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();

            selectBtnPanel.Visible = false;
            //ccontrol1.Visible = false;
            panelBtn1.Visible = false;
            panelBtn2.Visible = false;
            panelBtn5.Visible = false;

            //panelDesktop.Visible = false;
            cont5.Visible = false;
        }


        login loadn = new login();
       


        public bool btnPush = false;
       
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        control5 cont5 = new control5();
        private void button5_Click(object sender, EventArgs e)
        {
            btnPush = true;
            if (btnPush==true)
            { 
                
            }

            panelBtn5.Visible = true;

            panelBtn1.Visible = false;
            panelBtn2.Visible = false;
            selectBtnPanel.Visible = false;

            //control5 cont5 = new control5();

            cont5.Visible = true;
            

           
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            btnPush = true;


            panelBtn1.Visible = true;
            selectBtnPanel.Visible = false;
            panelBtn2.Visible = false;
            panelBtn5.Visible = false;

            control1 cont1 = new control1();
            cont1.Show();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnPush = true;

            panelBtn2.Visible = true;
            panelBtn1.Visible = false;
            selectBtnPanel.Visible = false;
            panelBtn5.Visible = false;


            control2 cont2 = new control2();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnPush = true;
            selectBtnPanel.Visible = true;
            panelBtn1.Visible = false;
            panelBtn2.Visible = false;
            panelBtn5.Visible = false;
            control3 cont3 = new control3();
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

    
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
                loadn.ShowDialog();
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            


        }

        private void control11_Load(object sender, EventArgs e)
        {

        }
    }
}
