using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bug_Tracking_Application
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void BtnMembers_Click(object sender, EventArgs e)
        {
            managemember frm = new managemember();
            frm.ShowDialog();
        }

        private void BtnProjects_Click(object sender, EventArgs e)
        {
            manageproject frm = new manageproject();
            frm.ShowDialog();
        }

        private void BtnBug_Click(object sender, EventArgs e)
        {
            bugentry frm = new bugentry();
            frm.ShowDialog();
        }

        private void BtnSolutions_Click(object sender, EventArgs e)
        {
            bugsolution frm = new bugsolution();
            frm.ShowDialog();
        }
    }
}
