using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbtry2
{
    public partial class CRUD : Form
    {
        List<Person> person = new List<Person>();

        public CRUD()
        {
            InitializeComponent();

            confirmpwdTxt.Hide();
            cpwdLbl.Hide();
            lblCount.Hide();

            UpdateListBox();

           // btnShowall.Hide();
            ShowItems();

        }
        private void UpdateListBox()
        {
            listBox1.DataSource = person;
            listBox1.DisplayMember = "nammeNmail";
        }

        private void one_Load(object sender, EventArgs e)
        {

        }
        public  bool CheckPwd()
        {
            var olppwd = pwdTxt.Text.ToString();
            var newpwd = confirmpwdTxt.Text.ToString();
            // (olppwd==newpwd ) 
                return (olppwd == newpwd);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            
            person =db.GetPeople(searchTxt.Text);

            UpdateListBox();

            countItems();
        }
       

        private void btnAddnew_Click(object sender, EventArgs e)//4 save button
        {
            DataAccess db = new DataAccess();

            if (!CheckPwd())
                 
                        MessageBox.Show("The passwords do not match!");
            else

                db.insertPerson(/*idTxt.Text,*/ usernameTxt.Text, fnameTxt.Text, lnameTxt.Text, emailTxt.Text, pwdTxt.Text);//db insert order

            

            clear();
           

        }
        public void clear()
        {
            idTxt.Text = "";
            usernameTxt.Text = "";
            fnameTxt.Text = "";
            lnameTxt.Text = "";
            emailTxt.Text = "";
            pwdTxt.Text = "";
            confirmpwdTxt.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)//4 add new button
        {
            confirmpwdTxt.Show();
            cpwdLbl.Show();

            clear();

            listBox1.DataSource = person;
            listBox1.DisplayMember = "allDetails";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Person personSelected = (Person)listBox1.SelectedItem;

            DataAccess db = new DataAccess();


            DialogResult dialogResult = MessageBox.Show($"CAUTION!\nThis action cannot be UNDONE!\nDelete: {personSelected.lName}?", "Carefull Now!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                person = db.DeletePerson(personSelected.email);

                person = db.GetALLPeople();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            

            listBox1.DataSource = person;
            listBox1.DisplayMember = "allDetails";
        }

        private void btnShowall_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            person = db.GetALLPeople();

            listBox1.DataSource = person;
            listBox1.DisplayMember = "allDetails";

            clear();
            countItems();
        }
        public void ShowItems()
        {
            DataAccess db = new DataAccess();

            person = db.GetALLPeople();

            listBox1.DataSource = person;
            listBox1.DisplayMember = "allDetails";

            countItems();

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            person = db.EditPerson(idTxt.Text, usernameTxt.Text, fnameTxt.Text, lnameTxt.Text, emailTxt.Text, pwdTxt.Text);

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            Person personSelected = (Person)listBox1.SelectedItem;

            // MessageBox.Show($"{personSelected.lName}");  //debug

            idTxt.Text =personSelected.id;
            usernameTxt.Text =personSelected.username;
            fnameTxt.Text = personSelected.fName;
            lnameTxt.Text = personSelected.lName;
            emailTxt.Text =personSelected.email;
            pwdTxt.Text = personSelected.password;


        }

        public void countItems()
        {
            lblCount.Text = $"{listBox1.Items.Count.ToString()} RECORDS";
            lblCount.Show();
        }

        private void btnTxtFile_Click(object sender, EventArgs e)
        {
            string flstring = @"C:\Users\SUNami\Downloads\CRUDtxt.txt";// change

            using (System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(flstring))
            {
                foreach (var item in listBox1.Items)
                {
                    SaveFile.WriteLine(item);
                }
            }

            MessageBox.Show("CRUDtxt saved to Dowwnloads folder");

        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
