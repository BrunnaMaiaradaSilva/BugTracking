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

namespace Bug_Tracking_Application
{
    public partial class manageproject : Form
    {
        public manageproject()
        {
            InitializeComponent();
        }
        //acccessing data from various classes
        BusinessLogicClass blc = new BusinessLogicClass();
        ProjectClass pc = new ProjectClass();
        HelperClass hc = new HelperClass();
        public int ProjectId;

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (txtprojectname.Text == "")
            {
                MessageBox.Show("Provide Projectname: Full information required");
            }
            if (dtpstartingdate.Text == "")
            {
                MessageBox.Show("Provide Starting Date: Full information required");
            }
            if (dtpfinishingdate.Text == "")
            {
                MessageBox.Show("Provide Finishing Date: Full information required");
            }
            if (txtdescription.Text == "")
            {
                MessageBox.Show("Provide Description: Full information required");
            }
            else if (DublicateProject() == true)
            {
                MessageBox.Show("Project with same name already exists");
                txtprojectname.Clear();
                txtprojectname.Focus();
            }
            { CreateProject(); }
        }

        private void CreateProject()
        {
            try
            {
                bool res = blc.ProjectTable(0,
                   txtprojectname.Text,
                  Convert.ToDateTime(dtpstartingdate.Text),
                  Convert.ToDateTime(dtpfinishingdate.Text),
                   txtdescription.Text,
                       1);
                if (res == true)
                {
                    MessageBox.Show("Success to Create Project");
                    dgvprojects.DataSource = pc.GetAllProjects();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
                else
                {
                    MessageBox.Show("Couldn't Create selected Project");
                    dgvprojects.DataSource = pc.GetAllProjects();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool DublicateProject()
        {
            int x = 0;
            try
            {

                for (int i = 0; i < dgvprojects.Rows.Count; i++)
                {
                    if (txtprojectname.Text == dgvprojects.Rows[i].Cells["projectname"].Value.ToString())
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

        private void dgvprojects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                 ProjectId = Convert.ToInt32(dgvprojects.SelectedRows[0].Cells["ProjectId"].Value.ToString());
                  txtprojectname.Text = dgvprojects.SelectedRows[0].Cells["projectname"].Value.ToString();
                  dtpstartingdate.Text = dgvprojects.SelectedRows[0].Cells["startingdate"].Value.ToString();
                  dtpfinishingdate.Text = dgvprojects.SelectedRows[0].Cells["finishingdate"].Value.ToString();
                  txtdescription.Text = dgvprojects.SelectedRows[0].Cells["description"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void manageproject_Load(object sender, EventArgs e)
        {
            dgvprojects.DataSource = pc.GetAllProjects();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = blc.ProjectTable(ProjectId,
                   txtprojectname.Text,
                  Convert.ToDateTime(dtpstartingdate.Text),
                  Convert.ToDateTime(dtpfinishingdate.Text),
                   txtdescription.Text,
                       2);
                if (res == true)
                {
                    MessageBox.Show("Success to Update Project");
                    dgvprojects.DataSource = pc.GetAllProjects();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
                else
                {
                    MessageBox.Show("Couldn't Update selected Project");
                    dgvprojects.DataSource = pc.GetAllProjects();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = blc.ProjectTable(ProjectId,
                   txtprojectname.Text,
                  Convert.ToDateTime(dtpstartingdate.Text),
                  Convert.ToDateTime(dtpfinishingdate.Text),
                   txtdescription.Text,
                       3);
                if (res == true)
                {
                    MessageBox.Show("Success to Delete Project");
                    dgvprojects.DataSource = pc.GetAllProjects();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
                else
                {
                    MessageBox.Show("Couldn't Delete selected Project");
                    dgvprojects.DataSource = pc.GetAllProjects();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
