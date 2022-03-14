using System;
//using ADODB;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.SqlClient;

namespace SSC
{
    public partial class Form1 : Form
    {
        public string _nem;
        string mobNumber; SerialPort outgo = new SerialPort(); SerialPort income = new SerialPort(); String report, vers, manu, mei, opp, locc; float airrt; int sig;
        int loc; string stat; string srl1, srl2, srl;
        public Form1()
        {
            InitializeComponent();
            incoming.Text = "Incoming COM";
            //btn_disconnect.Enabled = false;
            // btn_connect.ForeColor = Color.Green;
            string[] port2 = SerialPort.GetPortNames();
            for (int i = 0; i < port2.Length; i++)
                incoming.Items.Add(port2[i]);
            outgo.Close();
            notLabel.Visible = false;
            locLabel.Visible = false; locBox.Visible = false;
            numLabel.Visible = false; numBox.Visible = false;
            regLabel.Visible = false; regBox.Visible = false;
            opLabel.Visible = false; opBox.Visible = false;
            sigLabel.Visible = false; sigBox.Visible = false;
            serialLabel.Visible = false; serialBox.Visible = false;
            airtLabel.Visible = false; airtBox.Visible = false;
            hardLabel.Visible = false; btnSubmit.Visible = false;
            btnReport.Visible = false;
            statusCombo.Text = "Type of test";
            // btnTest.Visible = false;
            startLabel.Visible = false; reportBox.Visible = false;
            reportBox.ForeColor = Color.Gray;
            reportBox.Click += reportBox_Click;
            sr.Text = "Version";
            numCombo.Text = "+254"; nummBox.Text = "790032188"; incoming.Text = "COM22";
          //  dat11.Format = DateTimePickerFormat.Custom;
            //dat11.CustomFormat = "MM/dd/yyyy";
            solar.Visible = false;
            swtch.Visible = false;
            usb.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string trak;
        private void btnStart_Click(object sender, EventArgs e)
        {

                mobNumber = numCombo.Text.ToString() + nummBox.Text.ToString(); int len = mobNumber.Length;
             
                if (len < 13 || len > 13)
                {
                    notLabel.Visible = true;
                    notLabel.Text = "Invalid number!"; return;
                }
                else
                {
                    notLabel.Visible = false;
                }
                //Cursor.Current = Cursors.WaitCursor;

            if(statusCombo.Text=="Type of test")
            {
                MessageBox.Show("Type of test can not be left blank!"); return;
            }
                try
                {
                    income = new SerialPort();

                    income.PortName = incoming.Text.ToString();

                    income.BaudRate = 9600;
                    if (income.IsOpen)
                    {
                        income.Close();
                    }

                    if (!income.IsOpen)
                    {
                        income.Open();// outgo.WriteLine("");
                    }
                    btnTest.Enabled = false;
                    btnSubmit.Enabled = true;
                    btnSubmit.ForeColor = Color.Maroon;
                }
                catch (Exception ex)
                {
                    ForeColor = Color.Blue;
                    MessageBox.Show("COM Port does not exist! \n\n\n\nPlease select the right COM Port."); return;
                }
                finally
                {

                }

                //  btnTest.Visible = true;
                Task.Delay(2000).Wait();
                // notLabel.Visible = true;
                startLabel.Visible = true;
                Task.Delay(500).Wait();
                airtLabel.Visible = true;
                // airtBox.Visible = true;
                income.WriteLine("AIRT");
                Task.Delay(7000).Wait();
                income.ReadTimeout = 1000;
                try
                {
                    string tm = income.ReadLine();//MessageBox.Show("length:"+tm.Length);
                    if (tm.Length < 10)
                    {
                        
                        airtBox.Text= tm;
                    }
                    else
                    {
                        MessageBox.Show("There was an error while checking airtime. Please reload and test again."); return;
                    }
                     
                    // airtBox.Text = income.ReadLine();

                    // MessageBox.Show("Timed Out. Press Okay to exit app.");

                    // Application.Exit();
                    // this.Close();
                }
            catch(Exception ex)
                {
                    MessageBox.Show("App could not find airtime balance!");
                }
                
                airtBox.Visible = true;

                Task.Delay(1000).Wait();

                locLabel.Visible = true;
                income.WriteLine("LOC");
                Task.Delay(3000).Wait();
         
               try
                {
               locBox.Text= income.ReadLine();
                
                   }
            catch(Exception ex)
                {
                    MessageBox.Show("App could not find SIM status!");
                }
                locBox.Visible = true;
                regLabel.Visible = true;
                income.WriteLine("VERSION");
                Task.Delay(5000).Wait();
           
               try
                {
                    vers = income.ReadLine();
                while(vers==null)
                {
                    vers = income.ReadLine();
                }
                
                    }
            catch(Exception ex)
                {
                    MessageBox.Show("App could not find version number!");
                }
                regBox.Text = vers;
                regBox.Visible = true;
                Task.Delay(500).Wait();
                numLabel.Visible = true;
                income.WriteLine("MANU");
                Task.Delay(6000).Wait();
                 try
                {
                    manu = income.ReadLine();
                
                   }
            catch(Exception ex)
                {
                    MessageBox.Show("App could not find manufacturer!");
                }
                //manu = income.ReadLine();
                // manu = income.ReadLine();

                numBox.Text = manu;
                numBox.Visible = true;
                Task.Delay(500).Wait();
                opLabel.Visible = true;
                income.WriteLine("OP");
                Task.Delay(5000).Wait();
           try
                {
                    opBox.Text = income.ReadLine();
                    if (opBox == null)
                    {
                        opBox.Text = income.ReadLine();
                    }
                
                   }
            catch(Exception ex)
                {
                    MessageBox.Show("App could not find SIM operator!");
                }
                //opBox.Text = income.ReadLine();

                opBox.Visible = true;
                Task.Delay(500).Wait();
                sigLabel.Visible = true;
                income.WriteLine("SIG");
                Task.Delay(5000).Wait();
               try
                {
                    sigBox.Text = income.ReadLine();
                 }
            catch(Exception ex)
                {
                    MessageBox.Show("App could not find Signal strength!");
                }
                //sigBox.Text = income.ReadLine();
                sigBox.Visible = true;
                Task.Delay(500).Wait();
                serialLabel.Visible = true;
                income.WriteLine("SERIAL");
                Task.Delay(4000).Wait();
              try
                {
                    serialBox.Text = income.ReadLine();

                    if (serialBox == null)
                    {
                        serialBox.Text = income.ReadLine();
                    }
                    serialBox.Text = income.ReadLine();

                }
              catch (Exception ex)
              {
                  MessageBox.Show("App could not find Serial number!");
              }
                serialBox.Visible = true;
                Task.Delay(500).Wait();

                try
                {
                    sig = int.Parse(sigBox.Text);
                    // int airrt;
                    // bool res    = int.TryParse(airtBox.Text,out airrt);
                    airrt = float.Parse(airtBox.Text);
                    mei = serialBox.Text.ToString();
                    opp = opBox.Text.ToString();
                    locc = locBox.Text.ToString();
                    stat = statusCombo.Text.ToString();
                    hardLabel.Visible = true;
                    //Other tests for database entry
                    income.WriteLine("HARDWARE");
                    Task.Delay(3000).Wait();
                    srl1 = mei.Substring(mei.Length-7);
                    srl2 = sr.Text + srl1;
                    trak = "Testing";
                //while(label2.Text!="Okay")
                //{
                //    label2.Text = income.ReadLine();
                //}
                
                }
                catch (Exception ex)
                {
                    // ForeColor = Color.Green;
                    MessageBox.Show("Please reload for testing. All parameters must be captured."); income.Close(); return;// this.Close();
                }
                if (sig > 64 && sig < 83 && airrt > 7)
                {
                    // ForeColor = Color.Green;
                    MessageBox.Show("Please label as B" + sig + ". The controller has the required airtime and signal strength. \n\nKindly proceed to hardware tests. ");
                }
                if (sig > 82 && airrt > 7)
                {
                    // ForeColor = Color.Green;
                    MessageBox.Show("Please label as A" + sig + ". The controller has the required airtime and signal strength. \n\nKindly proceed to hardware tests. ");
                }
                if (sig > 82 && airrt < 7)
                {
                    //  ForeColor = Color.Maroon;
                    MessageBox.Show("Please label as A" + sig + ". The controller does not have the required airtime. \n\nKindly proceed to hardware tests and withhold it afterwards. ");
                }

                if (sig >= 64 && sig < 83 && airrt < 7)
                {
                    // ForeColor = Color.Maroon;
                    MessageBox.Show("Please label as B" + sig + ". The controller does not have the required airtime. \n\nKindly proceed to hardware tests and withhold it afterwards. ");
                }
                if (sig < 64)
                {
                    // ForeColor = Color.Red;
                    MessageBox.Show("With " + sig + "%. The controller does not qualify for installation. \n\nKindly return to production department for further repair/correction.");
                }

                solar.Visible = true;
                swtch.Visible = true;
                usb.Visible = true;
                reportBox.Visible = true;
                btnSubmit.Visible = true;




                income.Close();
            }
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            if (usb.Checked == false)
            {
                MessageBox.Show("Please test if the USB Port is charging before proceeding."); return;
            }
            if (swtch.Checked == false)
            {
                MessageBox.Show("Please test if the controller can switch ON/OFF before proceeding."); return;
            }
            if (solar.Checked == false)
            {
                MessageBox.Show("Please test if the solar is charging before proceeding."); return;
            }
            if(firstTime==true ||reportBox.Text=="")
            {
                MessageBox.Show("Are you not confident of the test? Please comment and Submit."); return;
            }
            report = reportBox.Text.ToString();
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=192.168.8.80,1234;User ID=sa;Password=sunami;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                con.Open();

                SqlCommand put = new SqlCommand(string.Format("INSERT INTO dataTable(IMEI,Cversion,type,signal,airtime,Gversion,manufacturer,operator,created,track,comment) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", mei, srl2, stat, sig, airrt, vers, manu, opp, dat11.Value, trak, report), con);
                put.ExecuteNonQuery();

                MessageBox.Show("Saved successifully!");
                string eventlog = _nem + " tested a new controller serial number " + srl2 + " on " + DateTime.Now;
                SqlCommand pt = new SqlCommand(string.Format("INSERT INTO logTable(logs) VALUES('{0}')", eventlog), con);
                pt.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception exp)
            {
                MessageBox.Show(exp + "Error");
            }
            finally
            {

            }
            this.Close();
        }
        bool firstTime = true;
        private void reportBox_Click(object sender, EventArgs e)
        {
            if (firstTime)
            {
                firstTime = false;
                reportBox.Clear(); reportBox.Text = "";
                reportBox.ForeColor = Color.Black;
            }
        }
       // string signal;
        private void btnClose_Click(object sender, EventArgs e)
        {
            //string strConnect = @"Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\Users\user\Desktop\QC FILES\SSC\SSC\TestApp.accdb";

            //DataTable dt = new DataTable();
            //using (OleDbConnection con = new OleDbConnection(strConnect))
            //{
            //    OleDbCommand cmd = new OleDbCommand("SELECT * FROM dataTable", con);
            //    con.Open();
            //    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //    da.Fill(dt);
            //}

            //SqlConnection conn = new SqlConnection(@"Data Source=192.168.8.80,1234;User ID=sa;Password=sunami;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


            //conn.Open();
            //using (SqlBulkCopy bulk = new SqlBulkCopy(conn))
            //{
            //    bulk.DestinationTableName = "dataTable";
            //    bulk.WriteToServer(dt);
            //}
            //MessageBox.Show("Copied");









            income.Close(); this.Close();


        }

        private void nummBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static string getHomePath()
        {
            // Not in .NET 2.0
            // System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (System.Environment.OSVersion.Platform == System.PlatformID.Unix)
                return System.Environment.GetEnvironmentVariable("HOME");

            return System.Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
        }

        private void dat11_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
