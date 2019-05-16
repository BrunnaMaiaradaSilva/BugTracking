using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLogicLayer;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
using System.IO;

namespace Bug_Tracking_Application
{
    public partial class managemember : Form
    {
        public managemember()
        {
            InitializeComponent();
            txtcontact.MaxLength = 10;
        }
        //acccessing data from various classes
        BusinessLogicClass blc = new BusinessLogicClass();
        MemberClass mc = new MemberClass();
        HelperClass hc = new HelperClass();
        public int MemberId;



		//close the window 
		private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        //retrieve the data on DataGridView 
        private void managemember_Load(object sender, EventArgs e)
        {
            dgvmembers.DataSource = mc.GetAllUsers();
        }

        //adding the data to display on datagridview and store to database
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("Provide Username: Full information required");
            }
            if (txtmembername.Text == "")
            {
                MessageBox.Show("Provide Member Name: Full information required");
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("Provide Password: Full information required");
            }
            if (cmbrole.SelectedIndex == -1)
            {
                MessageBox.Show("Provide Role: Full information required");
            }
            if (txtaddress.Text == "")
            {
                MessageBox.Show("Provide Address: Full information required");
            }
            if (txtemail.Text == "")
            {
                MessageBox.Show("Provide Email: Full information required");
            }
            if (cmbgender.SelectedIndex == -1)
            {
                MessageBox.Show("Provide Gender: Full information required");
            }
            if (txtcontact.Text == "")
            {
                MessageBox.Show("Provide Contact: Full information required");
            }
            if (dtpbirthdate.Text == "")
            {
                MessageBox.Show("Provide Birth Date: Full information required");
            }
            if (dtpjoiningdate.Text == "")
            {
                MessageBox.Show("Provide Join Date: Full information required");
            }
            if (btnbrowse.Text == "")
            {
                MessageBox.Show("Provide Image: Full information required");
            }
            else if (DublicateUser() == true)
            {
                MessageBox.Show("Member with same name already exists");
                txtusername.Clear();
                txtusername.Focus();
            }
            { CreateUser(); }
        }

        //create user
        private void CreateUser()
        {
			//try catch exception
            try
            {
                bool res = blc.MemberTable(0,
                   txtusername.Text,
                   txtmembername.Text,
                   txtpassword.Text,
                   cmbrole.Text,
                   txtaddress.Text,
                   txtemail.Text,
                   cmbgender.Text,
                  Convert.ToInt32 (txtcontact.Text),
                  Convert.ToDateTime (dtpbirthdate.Text),
                   Convert.ToDateTime(dtpjoiningdate.Text),
                   HelperClass.imageConverter(picmembers),
                       1);
                if (res == true)
                {
					//display message of adding memeber in database
                    MessageBox.Show("Success to Add member");
                    dgvmembers.DataSource = mc.GetAllUsers();
                    HelperClass.makeFieldsBlank(grpContainer);
                    picmembers.Image = null;
                }
                else
                {
					//display error message as data cannot be stored
					MessageBox.Show("Couldn't Add selected member"); 
                    dgvmembers.DataSource = mc.GetAllUsers();
                    HelperClass.makeFieldsBlank(grpContainer);
                    picmembers.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


		//helps in data store as if users have same information
		public bool DublicateUser() 
            {
            int x = 0;
            try
            {
               
                for (int i = 0;i<dgvmembers.Rows.Count;i++)
                {
                    if (txtusername.Text == dgvmembers.Rows[i].Cells["UserName"].Value.ToString())
                        x = 1;
                }
                 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            if (x == 1)
                return true;
            else
                return false;
        }

        //Browse image in button click
        private void btnbrowse_Click(object sender, EventArgs e)
            {
                try
                {
                    try
                    {
                        OpenFileDialog ofd = new OpenFileDialog();
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            picmembers.Image = Image.FromFile(ofd.FileName);

                        }
                        else
                        {
                            MessageBox.Show("Please select a profile picture");
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }


             //retrive all data from datagridview to the details entry section on a single click
            private void dgvmembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    MemberId = Convert.ToInt32(dgvmembers.SelectedRows[0].Cells["MemberId"].Value.ToString());
                    txtusername.Text = dgvmembers.SelectedRows[0].Cells["UserName"].Value.ToString();
                    txtmembername.Text = dgvmembers.SelectedRows[0].Cells["Name"].Value.ToString();
                    txtpassword.Text = dgvmembers.SelectedRows[0].Cells["Password"].Value.ToString();
                    cmbrole.Text = dgvmembers.SelectedRows[0].Cells["Role"].Value.ToString();
                    txtaddress.Text = dgvmembers.SelectedRows[0].Cells["Address"].Value.ToString();
                    txtemail.Text = dgvmembers.SelectedRows[0].Cells["Email"].Value.ToString();
                    cmbgender.Text = dgvmembers.SelectedRows[0].Cells["Gender"].Value.ToString();
                    txtcontact.Text = dgvmembers.SelectedRows[0].Cells["Contact"].Value.ToString();
                    dtpbirthdate.Text = dgvmembers.SelectedRows[0].Cells["DOB"].Value.ToString();
                    dtpjoiningdate.Text = dgvmembers.SelectedRows[0].Cells["DOJ"].Value.ToString();
                    MemoryStream memoryStream = new MemoryStream((byte[])dgvmembers.SelectedRows[0].Cells["Image"].Value);
                    picmembers.Image = Image.FromStream(memoryStream);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }


        //update the date entered into the database
        private void btnupdate_Click(object sender, EventArgs e)
            {
                try
                {
                    bool res = blc.MemberTable(MemberId,
                       txtusername.Text,
                       txtmembername.Text,
                       txtpassword.Text,
                       cmbrole.Text,
                       txtaddress.Text,
                       txtemail.Text,
                       cmbgender.Text,
                      Convert.ToInt32(txtcontact.Text),
                      Convert.ToDateTime(dtpbirthdate.Text),
                       Convert.ToDateTime(dtpjoiningdate.Text),
                       HelperClass.imageConverter(picmembers),
                           2);
                    if (res == true)
                    {
                        MessageBox.Show("Success to Update Member");
                        dgvmembers.DataSource = mc.GetAllUsers();
                        HelperClass.makeFieldsBlank(grpContainer);
                        picmembers.Image = null;
                    }
                    else
                    {
					//display error message as data cannot be updated
					MessageBox.Show("Couldn't Update selected member"); 
                        dgvmembers.DataSource = mc.GetAllUsers();
                        HelperClass.makeFieldsBlank(grpContainer);
                        picmembers.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        // delete the data entered into the database
            private void btndelete_Click(object sender, EventArgs e)
            {

                try
                {
                    bool res = blc.MemberTable(MemberId,
                       txtusername.Text,
                       txtmembername.Text,
                       txtpassword.Text,
                       cmbrole.Text,
                       txtaddress.Text,
                       txtemail.Text,
                       cmbgender.Text,
                      Convert.ToInt32(txtcontact.Text),
                      Convert.ToDateTime(dtpbirthdate.Text),
                       Convert.ToDateTime(dtpjoiningdate.Text),
                       HelperClass.imageConverter(picmembers),
                           3);
                    if (res == true)
                    {
                    //display message of successfully deleted
                    MessageBox.Show("Success to Delete Member");
                        dgvmembers.DataSource = mc.GetAllUsers();
                        HelperClass.makeFieldsBlank(grpContainer);
                        picmembers.Image = null;
                    }
                    else
                    {
                    //display error message as data cannot be deleted
                    MessageBox.Show("Couldn't delete selected memeber"); 
                        dgvmembers.DataSource = mc.GetAllUsers();
                        HelperClass.makeFieldsBlank(grpContainer);
                        picmembers.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        private void Txtemail_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(txtemail.Text.Trim());
            if (!isValid==false)
            {
                MessageBox.Show("Invalid Email.");
            }

        }

        private void Txtcontact_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

    }

