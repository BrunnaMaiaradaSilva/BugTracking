namespace Bug_Tracking_Application
{
    partial class bugsolution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bugsolution));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpContainer = new System.Windows.Forms.GroupBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.txtbugsolvedby = new System.Windows.Forms.TextBox();
            this.dgvbugsolutions = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picbugsolutions = new System.Windows.Forms.PictureBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbugdetails = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.cmbproject = new System.Windows.Forms.ComboBox();
            this.txtsolutiondetails = new System.Windows.Forms.TextBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbugsolutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbugsolutions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.grpContainer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 517);
            this.panel1.TabIndex = 2;
            // 
            // grpContainer
            // 
            this.grpContainer.BackColor = System.Drawing.Color.Transparent;
            this.grpContainer.Controls.Add(this.btnbrowse);
            this.grpContainer.Controls.Add(this.txtbugsolvedby);
            this.grpContainer.Controls.Add(this.dgvbugsolutions);
            this.grpContainer.Controls.Add(this.Id);
            this.grpContainer.Controls.Add(this.label9);
            this.grpContainer.Controls.Add(this.label7);
            this.grpContainer.Controls.Add(this.picbugsolutions);
            this.grpContainer.Controls.Add(this.dtpdate);
            this.grpContainer.Controls.Add(this.label8);
            this.grpContainer.Controls.Add(this.txtbugdetails);
            this.grpContainer.Controls.Add(this.label2);
            this.grpContainer.Controls.Add(this.btnupdate);
            this.grpContainer.Controls.Add(this.btnexit);
            this.grpContainer.Controls.Add(this.btnadd);
            this.grpContainer.Controls.Add(this.btndelete);
            this.grpContainer.Controls.Add(this.cmbproject);
            this.grpContainer.Controls.Add(this.txtsolutiondetails);
            this.grpContainer.Controls.Add(this.txtcode);
            this.grpContainer.Controls.Add(this.label6);
            this.grpContainer.Controls.Add(this.label5);
            this.grpContainer.Controls.Add(this.label4);
            this.grpContainer.Controls.Add(this.label3);
            this.grpContainer.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContainer.ForeColor = System.Drawing.Color.White;
            this.grpContainer.Location = new System.Drawing.Point(2, 63);
            this.grpContainer.Margin = new System.Windows.Forms.Padding(2);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Padding = new System.Windows.Forms.Padding(2);
            this.grpContainer.Size = new System.Drawing.Size(1194, 440);
            this.grpContainer.TabIndex = 37;
            this.grpContainer.TabStop = false;
            this.grpContainer.Text = "Enter the following Information";
            // 
            // btnbrowse
            // 
            this.btnbrowse.BackColor = System.Drawing.Color.Black;
            this.btnbrowse.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.ForeColor = System.Drawing.Color.White;
            this.btnbrowse.Location = new System.Drawing.Point(408, 376);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(149, 36);
            this.btnbrowse.TabIndex = 58;
            this.btnbrowse.Text = "Browse Image";
            this.btnbrowse.UseVisualStyleBackColor = false;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // txtbugsolvedby
            // 
            this.txtbugsolvedby.Location = new System.Drawing.Point(157, 56);
            this.txtbugsolvedby.Name = "txtbugsolvedby";
            this.txtbugsolvedby.Size = new System.Drawing.Size(188, 26);
            this.txtbugsolvedby.TabIndex = 57;
            // 
            // dgvbugsolutions
            // 
            this.dgvbugsolutions.AllowUserToAddRows = false;
            this.dgvbugsolutions.AllowUserToDeleteRows = false;
            this.dgvbugsolutions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbugsolutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbugsolutions.Location = new System.Drawing.Point(605, 25);
            this.dgvbugsolutions.MultiSelect = false;
            this.dgvbugsolutions.Name = "dgvbugsolutions";
            this.dgvbugsolutions.ReadOnly = true;
            this.dgvbugsolutions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbugsolutions.Size = new System.Drawing.Size(579, 200);
            this.dgvbugsolutions.TabIndex = 56;
            this.dgvbugsolutions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbugsolutions_CellContentClick);
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(157, 25);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(188, 26);
            this.Id.TabIndex = 55;
            this.Id.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(24, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 19);
            this.label9.TabIndex = 54;
            this.label9.Text = "Bug Solution Id";
            this.label9.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(365, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 53;
            this.label7.Text = "Solution";
            // 
            // picbugsolutions
            // 
            this.picbugsolutions.BackColor = System.Drawing.Color.DarkGray;
            this.picbugsolutions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbugsolutions.Location = new System.Drawing.Point(369, 218);
            this.picbugsolutions.Name = "picbugsolutions";
            this.picbugsolutions.Size = new System.Drawing.Size(220, 152);
            this.picbugsolutions.TabIndex = 50;
            this.picbugsolutions.TabStop = false;
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(157, 88);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(188, 26);
            this.dtpdate.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(365, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 45;
            this.label8.Text = "Code";
            // 
            // txtbugdetails
            // 
            this.txtbugdetails.Location = new System.Drawing.Point(157, 172);
            this.txtbugdetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtbugdetails.Multiline = true;
            this.txtbugdetails.Name = "txtbugdetails";
            this.txtbugdetails.Size = new System.Drawing.Size(188, 94);
            this.txtbugdetails.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Solution Details";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Black;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(758, 306);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(107, 52);
            this.btnupdate.TabIndex = 41;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Black;
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(1075, 306);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(107, 52);
            this.btnexit.TabIndex = 41;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Black;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(603, 306);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(107, 52);
            this.btnadd.TabIndex = 42;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Black;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(912, 306);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(107, 52);
            this.btndelete.TabIndex = 40;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // cmbproject
            // 
            this.cmbproject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbproject.FormattingEnabled = true;
            this.cmbproject.Location = new System.Drawing.Point(157, 129);
            this.cmbproject.Margin = new System.Windows.Forms.Padding(2);
            this.cmbproject.Name = "cmbproject";
            this.cmbproject.Size = new System.Drawing.Size(188, 27);
            this.cmbproject.TabIndex = 7;
            // 
            // txtsolutiondetails
            // 
            this.txtsolutiondetails.Location = new System.Drawing.Point(157, 282);
            this.txtsolutiondetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtsolutiondetails.Multiline = true;
            this.txtsolutiondetails.Name = "txtsolutiondetails";
            this.txtsolutiondetails.Size = new System.Drawing.Size(188, 120);
            this.txtsolutiondetails.TabIndex = 5;
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(368, 45);
            this.txtcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(220, 130);
            this.txtcode.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Bug Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Project";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bug Solved By";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(439, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 43);
            this.label1.TabIndex = 39;
            this.label1.Text = "Bug Solution";
            // 
            // bugsolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 499);
            this.Controls.Add(this.panel1);
            this.Name = "bugsolution";
            this.Text = "bugsolution";
            this.Load += new System.EventHandler(this.bugsolution_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpContainer.ResumeLayout(false);
            this.grpContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbugsolutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbugsolutions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpContainer;
        private System.Windows.Forms.PictureBox picbugsolutions;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbugdetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ComboBox cmbproject;
        private System.Windows.Forms.TextBox txtsolutiondetails;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvbugsolutions;
        private System.Windows.Forms.TextBox txtbugsolvedby;
        private System.Windows.Forms.Button btnbrowse;
    }
}