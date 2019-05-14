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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void manageMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managemember mm = new managemember();
            mm.MdiParent = this;
            mm.Dock = DockStyle.None;
            mm.Show();
        }

        private void manageProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageproject mp = new manageproject();
            mp.MdiParent = this;
            mp.Dock = DockStyle.None;
            mp.Show();
        }

        private void bugEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bugentry be = new bugentry();
            be.MdiParent = this;
            be.Dock = DockStyle.None;
            be.Show();
        }

        private void bugSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bugsolution bs = new bugsolution();
            bs.MdiParent = this;
            bs.Dock = DockStyle.None;
            bs.Show();
        }


        private void searchByMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bugbymember bbm = new bugbymember();
            bbm.MdiParent = this;
            bbm.Dock = DockStyle.None;
            bbm.Show();
        }

        private void searchByProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bugbyproduct bbp = new bugbyproduct();
            bbp.MdiParent = this;
            bbp.Dock = DockStyle.None;
            bbp.Show();
        }

        private void searchByBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searchbug sb = new Searchbug();
            sb.MdiParent = this;
            sb.Dock = DockStyle.None;
            sb.Show();
        }

        private void bugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bugentry be = new bugentry();
            be.MdiParent = this;
            be.Dock = DockStyle.None;
            be.Show();
        }

        private void solutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bugsolution bs = new bugsolution();
            bs.MdiParent = this;
            bs.Dock = DockStyle.None;
            bs.Show();
        }
    }
}
