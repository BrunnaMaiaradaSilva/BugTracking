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

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        //create user
        private void CreateBugs() 
        {
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
                    MessageBox.Show("Success to Entry Bugs");
                    dgvbugs.DataSource = bec.GetAllBugs();
                    HelperClass.makeFieldsBlank(grpContainer);
                    picbugs.Image = null;
                }
                else
                {
                    MessageBox.Show("Couldn't success to Entry Bugs"); //display error message as data cannot be stored
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


        private void dgvbugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BugId = Convert.ToInt32(dgvbugs.SelectedRows[0].Cells["bugid"].Value.ToString());
                dtpdate.Text = dgvbugs.SelectedRows[0].Cells["date"].Value.ToString();
                txtclasslibrary.Text = dgvbugs.SelectedRows[0].Cells["classlibrary"].Value.ToString();
                txtblock.Text = dgvbugs.SelectedRows[0].Cells["block"].Value.ToString();
                txtidentifiedby.Text = dgvbugs.SelectedRows[0].Cells["identifiedby"].Value.ToString();
                txtclass.Text = dgvbugs.SelectedRows[0].Cells["class"].Value.ToString();
                txtlinenumber.Text = dgvbugs.SelectedRows[0].Cells["linenumber"].Value.ToString();
                cmbproject.Text = dgvbugs.SelectedRows[0].Cells["project"].Value.ToString();
                txtmethod.Text = dgvbugs.SelectedRows[0].Cells["method"].Value.ToString();
                txtbugdetails.Text = dgvbugs.SelectedRows[0].Cells["bugdetails"].Value.ToString();
                txtcode.Text = dgvbugs.SelectedRows[0].Cells["code"].Value.ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dgvbugs.SelectedRows[0].Cells["profilePicture"].Value);
                picbugs.Image = Image.FromStream(memoryStream);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bugentry_Load(object sender, EventArgs e)
        {
            dgvbugs.DataSource = bec.GetAllBugs();

            cmbproject.DataSource = pc.GetAllProjects();
            cmbproject.DisplayMember = "ProjectName";
            cmbproject.ValueMember = "ProjectName";
            cmbproject.SelectedIndex = -1;
        }

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
    }
}
