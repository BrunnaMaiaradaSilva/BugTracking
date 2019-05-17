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

namespace Bug_Tracking_Application
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }
        MemberClass mc = new MemberClass();


        private void btnlogin_Click(object sender, EventArgs e)
        {
            //Main lf = new Main();
            //lf.Show();
            try
            {
                String Role = mc.Login(txtusername.Text, txtpassword.Text);
                if (Role == "Admin")
                {
                    Dashboard frm = new Dashboard();
                    frm.Show();
                }
                else if (Role == "User")
                {
                    Dashboard frm = new Dashboard();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid user name or password");
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtusername.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid user name or password");
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();
                txtusername.BackColor = Color.Red;
                txtpassword.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txtusername_MouseClick(object sender, MouseEventArgs e)
        {
            txtusername.BackColor = Color.White;
        }

        private void Txtpassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtpassword.BackColor = Color.White;
        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }
    }
}
