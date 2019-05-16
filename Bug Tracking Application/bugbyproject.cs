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

namespace Bug_Tracking_Application
{
    public partial class bugbyproject : Form
    {
        public bugbyproject()
        {
            InitializeComponent();
        }
        ProjectClass pc = new ProjectClass();
        ReportClass rc = new ReportClass();
        BusinessLogicClass blc = new BusinessLogicClass();

        private void Bugbyproduct_Load(object sender, EventArgs e)
        {
            try
            {
                cmbprojectname.DataSource = pc.GetAllProjects();
                cmbprojectname.DisplayMember = "ProjectName";
                cmbprojectname.ValueMember = "ProjectId";
                cmbprojectname.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvReportproject.DataSource = rc.GetBugByProject(Convert.ToInt32(cmbprojectname.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
