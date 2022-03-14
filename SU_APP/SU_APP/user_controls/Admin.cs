using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SU_APP.user_controls
{
    public partial class Admin : UserControl
    {
        
       // MySqlDataAdapter adapt;

        //DataTable dt;
        public Admin()
        {
            InitializeComponent();

           // CoNN_Qerry conlog = new CoNN_Qerry();

            //conlog.OpenConection();


            try
            {

                // dataGridViewLog.DataSource = conlog.ShowDataInGridView("Select logs from logtable ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            //conlog.CloseConnection();


        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSL_TextChanged(object sender, EventArgs e)
        {
           /* DataView dv = new DataView(dt);

            dv.RowFilter = string.Format("logs LIKE'%{0}%'", textBoxSL.Text);

            dataGridViewLog.DataSource = dv; */
        }

        private void dataGridViewLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }
    }
}
