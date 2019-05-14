using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Windows.Forms;

namespace Bug_Tracking_Application
{
    public partial class bugbymember : Form
    {
        public bugbymember()
        {
            InitializeComponent();
        }
        MemberClass mc = new MemberClass();
        BusinessLogicClass blc = new BusinessLogicClass();

        private void Bugbymember_Load(object sender, EventArgs e)
        {
            try
            {
                cmbMemberName.DataSource = mc.GetAllUsers();
                cmbMemberName.DisplayMember = "MemberName";
                cmbMemberName.ValueMember = "MemberId";
                cmbMemberName.SelectedIndex = -1;
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
                dgvReport.DataSource = rc.GetBugByMember(Convert.ToInt32(cmbMemberName.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
