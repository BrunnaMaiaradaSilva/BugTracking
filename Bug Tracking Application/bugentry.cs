using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using BusinessLogicLayer;
using DataAccessLayer;
using System.IO;

namespace Bug_Tracking_Application
{
    public partial class bugentry : Form
    {
        public bugentry()
        {
            InitializeComponent();
        }
        //acccessing data from various classes
        BusinessLogicClass blc = new BusinessLogicClass();
        HelperClass hc = new HelperClass();
        ProjectClass pc = new ProjectClass();
        BugEntryClass bec = new BugEntryClass();
        public int BugId;


        //close the form
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //adding the data to display on datagridview and store to database
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (dtpdate.Text == "")
            {
                MessageBox.Show("Provide Date: Full information required");
            }
            if (txtclasslibrary.Text == "")
            {
                MessageBox.Show("Provide Class Library: Full information required");
            }
            if (txtblock.Text == "")
            {
                MessageBox.Show("Provide Block: Full information required");
            }
            if (txtidentifiedby.Text == "")
            {
                MessageBox.Show("Provide Identified by: Full information required");
            }
            if (txtclass.Text == "")
            {
                MessageBox.Show("Provide Class: Full information required");
            }
            if (txtlinenumber.Text == "")
            {
                MessageBox.Show("Provide Line Number: Full information required");
            }
            if (cmbproject.SelectedIndex == -1)
            {
                MessageBox.Show("Provide Project: Full information required");
            }
            if (txtmethod.Text == "")
            {
                MessageBox.Show("Provide Method: Full information required");
            }
            if (txtbugdetails.Text == "")
            {
                MessageBox.Show("Provide Bug Details: Full information required");
            }
            if (txtcode.Text == "")
            {
                MessageBox.Show("Provide Code: Full information required");
            }
            if (btnbrowse.Text == "")
            {
                MessageBox.Show("Provide Image: Full information required");
            }
            
            { CreateBugs(); }
        }

        //create bugs to fill the empty space 
        private void CreateBugs() 
        {
            //try catch exception
            try
            {
                bool res = blc.BugTable(0,
                  Convert.ToDateTime(dtpdate.Text),
                   txtclasslibrary.Text,
                   txtblock.Text,
                   txtidentifiedby.Text,
                   txtclass.Text,
                   txtlinenumber.Text,
                   cmbproject.Text,
                   txtmethod.Text,
                txtbugdetails.Text,
                txtcode.Text,
                   HelperClass.imageConverter(picbugs),
                       1);
                if (res == true)
                {
                    //display message of successfully added
                    MessageBox.Show("Added to Entry Bugs");
                    dgvbugs.DataSource = bec.GetAllBugs();
                    HelperClass.makeFieldsBlank(grpContainer);
                    picbugs.Image = null;
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't Add data to Entry Bugs"); 
                    dgvbugs.DataSource = bec.GetAllBugs();
                    HelperClass.makeFieldsBlank(grpContainer);
                    picbugs.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //retrive all data from datagridview to the details entry section on a single click
        private void dgvbugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BugId = Convert.ToInt32(dgvbugs.SelectedRows[0].Cells["BugId"].Value.ToString());
                dtpdate.Text = dgvbugs.SelectedRows[0].Cells["Date"].Value.ToString();
                txtclasslibrary.Text = dgvbugs.SelectedRows[0].Cells["ClassLibrary"].Value.ToString();
                txtblock.Text = dgvbugs.SelectedRows[0].Cells["Block"].Value.ToString();
                txtidentifiedby.Text = dgvbugs.SelectedRows[0].Cells["IdentifiedBy"].Value.ToString();
                txtclass.Text = dgvbugs.SelectedRows[0].Cells["Class"].Value.ToString();
                txtlinenumber.Text = dgvbugs.SelectedRows[0].Cells["LineNumber"].Value.ToString();
                cmbproject.Text = dgvbugs.SelectedRows[0].Cells["Project"].Value.ToString();
                txtmethod.Text = dgvbugs.SelectedRows[0].Cells["Method"].Value.ToString();
                txtbugdetails.Text = dgvbugs.SelectedRows[0].Cells["BugDetails"].Value.ToString();
                txtcode.Text = dgvbugs.SelectedRows[0].Cells["Code"].Value.ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dgvbugs.SelectedRows[0].Cells["Snap"].Value);
                picbugs.Image = Image.FromStream(memoryStream);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //retrieve the data on DataGridView 
        private void bugentry_Load(object sender, EventArgs e)
        {
            dgvbugs.DataSource = bec.GetAllBugs();

            cmbproject.DataSource = pc.GetAllProjects();
            cmbproject.DisplayMember = "ProjectName";
            cmbproject.ValueMember = "ProjectName";
            cmbproject.SelectedIndex = -1;
        }

        //Browse image in button click
        private void btnbrowse_Click_1(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        picbugs.Image = Image.FromFile(ofd.FileName);

                    }
                    else
                    {
                        MessageBox.Show("Please select a Bug picture");
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

        // update the data entered into the database
        private void Btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = blc.BugTable(BugId,
                  Convert.ToDateTime(dtpdate.Text),
                   txtclasslibrary.Text,
                   txtblock.Text,
                   txtidentifiedby.Text,
                   txtclass.Text,
                   txtlinenumber.Text,
                   cmbproject.Text,
                   txtmethod.Text,
                txtbugdetails.Text,
                txtcode.Text,
                   HelperClass.imageConverter(picbugs),
                       2);
                if (res == true)
                {
                    //display message of successfully updated
                    MessageBox.Show("Success to Update Bugs");
                    dgvbugs.DataSource = bec.GetAllBugs();
                    HelperClass.makeFieldsBlank(grpContainer);
                    picbugs.Image = null;
                }
                else
                {
                    //display error message as data cannot be updated
                    MessageBox.Show("Couldn't success to Update Bugs"); 
                    dgvbugs.DataSource = bec.GetAllBugs();
                    HelperClass.makeFieldsBlank(grpContainer);
                    picbugs.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // delete the data entered into the database
        private void Btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = blc.BugTable(BugId,
                  Convert.ToDateTime(dtpdate.Text),
                   txtclasslibrary.Text,
                   txtblock.Text,
                   txtidentifiedby.Text,
                   txtclass.Text,
                   txtlinenumber.Text,
                   cmbproject.Text,
                   txtmethod.Text,
                txtbugdetails.Text,
                txtcode.Text,
                   HelperClass.imageConverter(picbugs),
                       3);
                if (res == true)
                {
                    //display message of successfully deleted
                    MessageBox.Show("Success to Delete Bugs");
                    dgvbugs.DataSource = bec.GetAllBugs();
                    HelperClass.makeFieldsBlank(grpContainer);
                    picbugs.Image = null;
                }
                else
                {
                    //display error message as data cannot be deleted
                    MessageBox.Show("Couldn't success to Delete Bugs"); 
                    dgvbugs.DataSource = bec.GetAllBugs();
                    HelperClass.makeFieldsBlank(grpContainer);
                    picbugs.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
