namespace Bug_Tracking_Application
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.manageMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bugEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bugDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.solutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bugSolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bugSolutionDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchByMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchByProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchByBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// manageMemberToolStripMenuItem
			// 
			this.manageMemberToolStripMenuItem.Name = "manageMemberToolStripMenuItem";
			this.manageMemberToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
			this.manageMemberToolStripMenuItem.Text = "Manage Member";
			this.manageMemberToolStripMenuItem.Click += new System.EventHandler(this.manageMemberToolStripMenuItem_Click);
			// 
			// manageProjectToolStripMenuItem
			// 
			this.manageProjectToolStripMenuItem.Name = "manageProjectToolStripMenuItem";
			this.manageProjectToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
			this.manageProjectToolStripMenuItem.Text = "Manage Project";
			this.manageProjectToolStripMenuItem.Click += new System.EventHandler(this.manageProjectToolStripMenuItem_Click);
			// 
			// bugToolStripMenuItem
			// 
			this.bugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bugEntryToolStripMenuItem,
            this.bugDataToolStripMenuItem});
			this.bugToolStripMenuItem.Name = "bugToolStripMenuItem";
			this.bugToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.bugToolStripMenuItem.Text = "Bug";
			this.bugToolStripMenuItem.Click += new System.EventHandler(this.bugToolStripMenuItem_Click);
			// 
			// bugEntryToolStripMenuItem
			// 
			this.bugEntryToolStripMenuItem.Name = "bugEntryToolStripMenuItem";
			this.bugEntryToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.bugEntryToolStripMenuItem.Text = "Bug entry";
			this.bugEntryToolStripMenuItem.Click += new System.EventHandler(this.bugEntryToolStripMenuItem_Click);
			// 
			// bugDataToolStripMenuItem
			// 
			this.bugDataToolStripMenuItem.Name = "bugDataToolStripMenuItem";
			this.bugDataToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.bugDataToolStripMenuItem.Text = "Bug Data";
			// 
			// solutionToolStripMenuItem
			// 
			this.solutionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bugSolutionToolStripMenuItem,
            this.bugSolutionDataToolStripMenuItem});
			this.solutionToolStripMenuItem.Name = "solutionToolStripMenuItem";
			this.solutionToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.solutionToolStripMenuItem.Text = "Solution ";
			this.solutionToolStripMenuItem.Click += new System.EventHandler(this.solutionToolStripMenuItem_Click);
			// 
			// bugSolutionToolStripMenuItem
			// 
			this.bugSolutionToolStripMenuItem.Name = "bugSolutionToolStripMenuItem";
			this.bugSolutionToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.bugSolutionToolStripMenuItem.Text = "Bug Solution";
			this.bugSolutionToolStripMenuItem.Click += new System.EventHandler(this.bugSolutionToolStripMenuItem_Click);
			// 
			// bugSolutionDataToolStripMenuItem
			// 
			this.bugSolutionDataToolStripMenuItem.Name = "bugSolutionDataToolStripMenuItem";
			this.bugSolutionDataToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.bugSolutionDataToolStripMenuItem.Text = "Bug Solution Data";
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByMemberToolStripMenuItem,
            this.searchByProjectToolStripMenuItem,
            this.searchByBugToolStripMenuItem});
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.searchToolStripMenuItem.Text = "Search";
			// 
			// searchByMemberToolStripMenuItem
			// 
			this.searchByMemberToolStripMenuItem.Name = "searchByMemberToolStripMenuItem";
			this.searchByMemberToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.searchByMemberToolStripMenuItem.Text = "Search by Member";
			this.searchByMemberToolStripMenuItem.Click += new System.EventHandler(this.searchByMemberToolStripMenuItem_Click);
			// 
			// searchByProjectToolStripMenuItem
			// 
			this.searchByProjectToolStripMenuItem.Name = "searchByProjectToolStripMenuItem";
			this.searchByProjectToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.searchByProjectToolStripMenuItem.Text = "Search by Project";
			this.searchByProjectToolStripMenuItem.Click += new System.EventHandler(this.searchByProjectToolStripMenuItem_Click);
			// 
			// searchByBugToolStripMenuItem
			// 
			this.searchByBugToolStripMenuItem.Name = "searchByBugToolStripMenuItem";
			this.searchByBugToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.searchByBugToolStripMenuItem.Text = "Search by Bug";
			this.searchByBugToolStripMenuItem.Click += new System.EventHandler(this.searchByBugToolStripMenuItem_Click);
			// 
			// logOutToolStripMenuItem
			// 
			this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
			this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.logOutToolStripMenuItem.Text = "Log Out";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageMemberToolStripMenuItem,
            this.manageProjectToolStripMenuItem,
            this.bugToolStripMenuItem,
            this.solutionToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.logOutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(984, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 532);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.Text = "Main";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.ToolStripMenuItem manageMemberToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageProjectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bugToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bugEntryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bugDataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem solutionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bugSolutionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bugSolutionDataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchByMemberToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchByProjectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchByBugToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}