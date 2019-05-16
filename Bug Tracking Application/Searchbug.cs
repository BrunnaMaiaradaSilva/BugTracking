﻿using System;
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
    public partial class Searchbug : Form
    {
        public Searchbug()
        {
            InitializeComponent();
        }
        BugSolutionClass bsc = new BugSolutionClass();
        ProjectClass pc = new ProjectClass();

        private void Searchbug_Load(object sender, EventArgs e)
        {
            try
            {

                dgvsearchbug.DataSource = BugSolutionClass.getAllBugSolutions();
                lblTotalProjects.Text = ProjectClass.countNumberOfProjects().ToString();
                lblTotalMembers.Text = memberClass.totalMember().ToString();
                lblTotalRegBug.Text = bugEntry.getAllBugs().Rows.Count.ToString();
                lblTotalSolvedBug.Text = bugSolutionClass.getAllBugSolutions().Rows.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
