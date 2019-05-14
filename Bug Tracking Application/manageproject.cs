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

        //adding the data to display on datagridview and store to database
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
            //try catch exception
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
                    //display message as added project
                    MessageBox.Show("Add to Create Project");
                    dgvprojects.DataSource = pc.GetAllProjects();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
                else
                {
                    //display error message as data cannot be added
                    MessageBox.Show("Couldn't Add selected Project");
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
                    if (txtprojectname.Text == dgvprojects.Rows[i].Cells["ProjectName"].Value.ToString())
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


        //retrive all data from datagridview to the details entry section on a single click
        private void dgvprojects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                 ProjectId = Convert.ToInt32(dgvprojects.SelectedRows[0].Cells["ProjectId"].Value.ToString());
                  txtprojectname.Text = dgvprojects.SelectedRows[0].Cells["ProjectName"].Value.ToString();
                  dtpstartingdate.Text = dgvprojects.SelectedRows[0].Cells["StartingDate"].Value.ToString();
                  dtpfinishingdate.Text = dgvprojects.SelectedRows[0].Cells["FinishingDate"].Value.ToString();
                  txtdescription.Text = dgvprojects.SelectedRows[0].Cells["Description"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //retrieve the data on DataGridView 
        private void manageproject_Load(object sender, EventArgs e)
        {
            dgvprojects.DataSource = pc.GetAllProjects();
        }


        //update the date entered into the database
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
                    //display message as updated project
                    MessageBox.Show("Success to Update Project");
                    dgvprojects.DataSource = pc.GetAllProjects();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
                else
                {
                    //display error message as data cannot be updated
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


        // delete the data entered into the database
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
                    //display message as deleted project
                    MessageBox.Show("Success to Delete Project");
                    dgvprojects.DataSource = pc.GetAllProjects();
                    HelperClass.makeFieldsBlank(grpContainer);
                }
                else
                {
                    //display error message as data cannot be deleted
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
