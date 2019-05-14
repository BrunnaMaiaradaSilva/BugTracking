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

        //create user
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
                    MessageBox.Show("Success to Entry Bug Solutions");
                    dgvbugsolutions.DataSource = bsc.GetAllBugSolutions();
                    HelperClass.makeFieldsBlank(grpContainer);
                    picbugsolutions.Image = null;
                }
                else
                {
                    MessageBox.Show("Couldn't success to Entry Bug Solutions"); //display error message as data cannot be stored
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

        private void dgvbugsolutions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BugSolutionId = Convert.ToInt32(dgvbugsolutions.SelectedRows[0].Cells["bugsolutionid"].Value.ToString());
                txtbugsolvedby.Text = dgvbugsolutions.SelectedRows[0].Cells["bugsolvedby"].Value.ToString();
                dtpdate.Text = dgvbugsolutions.SelectedRows[0].Cells["date"].Value.ToString();
                cmbproject.Text = dgvbugsolutions.SelectedRows[0].Cells["project"].Value.ToString();
                txtbugdetails.Text = dgvbugsolutions.SelectedRows[0].Cells["bugdetails"].Value.ToString();
                txtsolutiondetails.Text = dgvbugsolutions.SelectedRows[0].Cells["solutiondetails"].Value.ToString();
                txtcode.Text = dgvbugsolutions.SelectedRows[0].Cells["code"].Value.ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dgvbugsolutions.SelectedRows[0].Cells["profilePicture"].Value);
                picbugsolutions.Image = Image.FromStream(memoryStream);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bugsolution_Load(object sender, EventArgs e)
        {
            dgvbugsolutions.DataSource = bsc.GetAllBugSolutions();
            cmbproject.DataSource = pc.GetAllProjects();
            cmbproject.DisplayMember = "ProjectName";
            cmbproject.ValueMember = "ProjectName";
            cmbproject.SelectedIndex = -1;
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            try
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

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
