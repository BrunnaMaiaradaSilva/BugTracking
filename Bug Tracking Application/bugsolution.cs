using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;
using System.IO;

namespace Bug_Tracking_Application
{
    public partial class bugsolution : Form
    {
        public bugsolution()
        {
            InitializeComponent();
        }
        //acccessing data from various classes
        BusinessLogicClass blc = new BusinessLogicClass();
        HelperClass hc = new HelperClass();
        ProjectClass pc = new ProjectClass();
        BugEntryClass bec = new BugEntryClass();
        BugSolutionClass bsc = new BugSolutionClass();
        public int BugSolutionId;


        //adding the data to display on datagridview and store to database
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtbugsolvedby.Text == "")
            {
                MessageBox.Show("Provide Bug Solved By: Full information required");
            }
            if (dtpdate.Text == "")
            {
                MessageBox.Show("Provide Date: Full information required");
            }
            if (cmbproject.Text == "")
            {
                MessageBox.Show("Provide Project: Full information required");
            }
            if (txtbugdetails.Text == "")
            {
                MessageBox.Show("Provide Bug Details by: Full information required");
            }
            if (txtsolutiondetails.Text == "")
            {
                MessageBox.Show("Provide Solution Details: Full information required");
            }
            if (txtcode.Text == "")
            {
                MessageBox.Show("Provide Code: Full information required");
            }
            if (btnbrowse.Text == "")
            {
                MessageBox.Show("Provide Image: Full information required");
            }

            { CreateBugSolution(); }
        }

        //create bug solution
        private void CreateBugSolution()
        {
            try
            {
                bool res = blc.BugSolutionTable(0,
                   txtbugsolvedby.Text,
                  Convert.ToDateTime(dtpdate.Text),
                  cmbproject.Text,
                   txtbugdetails.Text,
                   txtsolutiondetails.Text,
                   txtcode.Text,
                   HelperClass.imageConverter(picbugsolutions),
                       1);
                if (res == true)
                {
                    //display message of entred bug solution data
                    MessageBox.Show("Success to Entry Bug Solutions");
                    dgvbugsolutions.DataSource = bsc.GetAllBugSolutions();
                    HelperClass.makeFieldsBlank(grpContainer);
                    picbugsolutions.Image = null;
                }
                else
                {
                    //display error message as data cannot be stored
                    MessageBox.Show("Couldn't success to Entry Bug Solutions"); 
                    dgvbugsolutions.DataSource = bsc.GetAllBugSolutions();
                    HelperClass.makeFieldsBlank(grpContainer);
                    picbugsolutions.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //retrive all data from datagridview to the details entry section on a single click
        private void dgvbugsolutions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BugSolutionId = Convert.ToInt32(dgvbugsolutions.SelectedRows[0].Cells["BugSolutionId"].Value.ToString());
                txtbugsolvedby.Text = dgvbugsolutions.SelectedRows[0].Cells["BugSolvedBy"].Value.ToString();
                dtpdate.Text = dgvbugsolutions.SelectedRows[0].Cells["Date"].Value.ToString();
                cmbproject.Text = dgvbugsolutions.SelectedRows[0].Cells["Project"].Value.ToString();
                txtbugdetails.Text = dgvbugsolutions.SelectedRows[0].Cells["BugDetails"].Value.ToString();
                txtsolutiondetails.Text = dgvbugsolutions.SelectedRows[0].Cells["SolutionDetails"].Value.ToString();
                txtcode.Text = dgvbugsolutions.SelectedRows[0].Cells["Code"].Value.ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dgvbugsolutions.SelectedRows[0].Cells["Snap"].Value);
                picbugsolutions.Image = Image.FromStream(memoryStream);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //retrieve the data on DataGridView 
        private void bugsolution_Load(object sender, EventArgs e)
        {
            dgvbugsolutions.DataSource = bsc.GetAllBugSolutions();
            cmbproject.DataSource = pc.GetAllProjects();
            cmbproject.DisplayMember = "ProjectName";
            cmbproject.ValueMember = "ProjectName";
            cmbproject.SelectedIndex = -1;
        }

        //Browse image in button click
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            try
            //try catch exception
            {
                try
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        picbugsolutions.Image = Image.FromFile(ofd.FileName);

                    }
                    else
                    {
                        MessageBox.Show("Please select a Solution picture");
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


        //close the form
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // update the data entered into the database
        private void Btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = blc.BugSolutionTable(BugSolutionId,
                   txtbugsolvedby.Text,
                  Convert.ToDateTime(dtpdate.Text),
                  cmbproject.Text,
                   txtbugdetails.Text,
                   txtsolutiondetails.Text,
                   txtcode.Text,
                   HelperClass.imageConverter(picbugsolutions),
                       2);
                if (res == true)
                {
                    //display message of updating the bug solution data
                    MessageBox.Show("Success to Update Bug Solutions");
                    dgvbugsolutions.DataSource = bsc.GetAllBugSolutions();
                    HelperClass.makeFieldsBlank(grpContainer);
                    picbugsolutions.Image = null;
                }
                else
                {
                    //display error message as data cannot be updated
                    MessageBox.Show("Couldn't success to Update Bug Solutions");
                    dgvbugsolutions.DataSource = bsc.GetAllBugSolutions();
                    HelperClass.makeFieldsBlank(grpContainer);
                    picbugsolutions.Image = null;
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
                bool res = blc.BugSolutionTable(BugSolutionId,
                   txtbugsolvedby.Text,
                  Convert.ToDateTime(dtpdate.Text),
                  cmbproject.Text,
                   txtbugdetails.Text,
                   txtsolutiondetails.Text,
                   txtcode.Text,
                   HelperClass.imageConverter(picbugsolutions),
                       3);
                if (res == true)
                {
                    //display message of deleting the bug solution data
                    MessageBox.Show("Success to Delete Bug Solutions");
                    dgvbugsolutions.DataSource = bsc.GetAllBugSolutions();
                    HelperClass.makeFieldsBlank(grpContainer);
                    picbugsolutions.Image = null;
                }
                else
                {
                    //display error message as data cannot be deleted
                    MessageBox.Show("Couldn't success to Delete Bug Solutions");
                    dgvbugsolutions.DataSource = bsc.GetAllBugSolutions();
                    HelperClass.makeFieldsBlank(grpContainer);
                    picbugsolutions.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
