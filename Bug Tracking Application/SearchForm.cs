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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            bugbymember frm = new bugbymember();
            frm.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bugbyproject frm = new bugbyproject();
            frm.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Searchbug frm = new Searchbug();
            frm.ShowDialog();
        }
    }
}
