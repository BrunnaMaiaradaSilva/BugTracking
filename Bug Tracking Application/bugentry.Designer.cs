namespace Bug_Tracking_Application
{
    partial class bugentry
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bugentry));
			this.btnupdate = new System.Windows.Forms.Button();
			this.btnadd = new System.Windows.Forms.Button();
			this.btnexit = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.grpContainer = new System.Windows.Forms.GroupBox();
			this.dgvbugs = new System.Windows.Forms.DataGridView();
			this.btnbrowse = new System.Windows.Forms.Button();
			this.picbugs = new System.Windows.Forms.PictureBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtcode = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.dtpdate = new System.Windows.Forms.DateTimePicker();
			this.cmbproject = new System.Windows.Forms.ComboBox();
			this.txtmethod = new System.Windows.Forms.TextBox();
			this.txtbugdetails = new System.Windows.Forms.TextBox();
			this.txtlinenumber = new System.Windows.Forms.TextBox();
			this.txtclass = new System.Windows.Forms.TextBox();
			this.txtidentifiedby = new System.Windows.Forms.TextBox();
			this.txtblock = new System.Windows.Forms.TextBox();
			this.txtclasslibrary = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.grpContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvbugs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picbugs)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnupdate
			// 
			this.btnupdate.BackColor = System.Drawing.Color.Black;
			this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnupdate.ForeColor = System.Drawing.Color.White;
			this.btnupdate.Location = new System.Drawing.Point(824, 277);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(81, 36);
			this.btnupdate.TabIndex = 41;
			this.btnupdate.Text = "Update";
			this.btnupdate.UseVisualStyleBackColor = false;
			// 
			// btnadd
			// 
			this.btnadd.BackColor = System.Drawing.Color.Black;
			this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnadd.ForeColor = System.Drawing.Color.White;
			this.btnadd.Location = new System.Drawing.Point(699, 277);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(81, 36);
			this.btnadd.TabIndex = 42;
			this.btnadd.Text = "Add";
			this.btnadd.UseVisualStyleBackColor = false;
			this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
			// 
			// btnexit
			// 
			this.btnexit.BackColor = System.Drawing.Color.Black;
			this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnexit.ForeColor = System.Drawing.Color.White;
			this.btnexit.Location = new System.Drawing.Point(1076, 277);
			this.btnexit.Name = "btnexit";
			this.btnexit.Size = new System.Drawing.Size(81, 36);
			this.btnexit.TabIndex = 41;
			this.btnexit.Text = "Exit";
			this.btnexit.UseVisualStyleBackColor = false;
			this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
			// 
			// btndelete
			// 
			this.btndelete.BackColor = System.Drawing.Color.Black;
			this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndelete.ForeColor = System.Drawing.Color.White;
			this.btndelete.Location = new System.Drawing.Point(946, 277);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(81, 36);
			this.btndelete.TabIndex = 40;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = false;
			// 
			// grpContainer
			// 
			this.grpContainer.BackColor = System.Drawing.Color.Transparent;
			this.grpContainer.Controls.Add(this.dgvbugs);
			this.grpContainer.Controls.Add(this.btnupdate);
			this.grpContainer.Controls.Add(this.btnbrowse);
			this.grpContainer.Controls.Add(this.picbugs);
			this.grpContainer.Controls.Add(this.btnexit);
			this.grpContainer.Controls.Add(this.label12);
			this.grpContainer.Controls.Add(this.txtcode);
			this.grpContainer.Controls.Add(this.btnadd);
			this.grpContainer.Controls.Add(this.btndelete);
			this.grpContainer.Controls.Add(this.label11);
			this.grpContainer.Controls.Add(this.dtpdate);
			this.grpContainer.Controls.Add(this.cmbproject);
			this.grpContainer.Controls.Add(this.txtmethod);
			this.grpContainer.Controls.Add(this.txtbugdetails);
			this.grpContainer.Controls.Add(this.txtlinenumber);
			this.grpContainer.Controls.Add(this.txtclass);
			this.grpContainer.Controls.Add(this.txtidentifiedby);
			this.grpContainer.Controls.Add(this.txtblock);
			this.grpContainer.Controls.Add(this.txtclasslibrary);
			this.grpContainer.Controls.Add(this.label10);
			this.grpContainer.Controls.Add(this.label6);
			this.grpContainer.Controls.Add(this.label5);
			this.grpContainer.Controls.Add(this.label9);
			this.grpContainer.Controls.Add(this.label7);
			this.grpContainer.Controls.Add(this.label8);
			this.grpContainer.Controls.Add(this.label4);
			this.grpContainer.Controls.Add(this.label2);
			this.grpContainer.Controls.Add(this.label3);
			this.grpContainer.ForeColor = System.Drawing.Color.White;
			this.grpContainer.Location = new System.Drawing.Point(2, 63);
			this.grpContainer.Margin = new System.Windows.Forms.Padding(2);
			this.grpContainer.Name = "grpContainer";
			this.grpContainer.Padding = new System.Windows.Forms.Padding(2);
			this.grpContainer.Size = new System.Drawing.Size(1239, 388);
			this.grpContainer.TabIndex = 37;
			this.grpContainer.TabStop = false;
			this.grpContainer.Text = "Enter the following Information";
			// 
			// dgvbugs
			// 
			this.dgvbugs.AllowUserToAddRows = false;
			this.dgvbugs.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.LawnGreen;
			this.dgvbugs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvbugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvbugs.BackgroundColor = System.Drawing.Color.DimGray;
			this.dgvbugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvbugs.Location = new System.Drawing.Point(575, 17);
			this.dgvbugs.Margin = new System.Windows.Forms.Padding(2);
			this.dgvbugs.MultiSelect = false;
			this.dgvbugs.Name = "dgvbugs";
			this.dgvbugs.ReadOnly = true;
			this.dgvbugs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvbugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvbugs.Size = new System.Drawing.Size(647, 217);
			this.dgvbugs.TabIndex = 48;
			this.dgvbugs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbugs_CellContentClick);
			// 
			// btnbrowse
			// 
			this.btnbrowse.BackColor = System.Drawing.Color.Black;
			this.btnbrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnbrowse.ForeColor = System.Drawing.Color.White;
			this.btnbrowse.Location = new System.Drawing.Point(345, 319);
			this.btnbrowse.Name = "btnbrowse";
			this.btnbrowse.Size = new System.Drawing.Size(170, 36);
			this.btnbrowse.TabIndex = 43;
			this.btnbrowse.Text = "Browse Image";
			this.btnbrowse.UseVisualStyleBackColor = false;
			this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click_1);
			// 
			// picbugs
			// 
			this.picbugs.BackColor = System.Drawing.Color.DimGray;
			this.picbugs.Location = new System.Drawing.Point(331, 171);
			this.picbugs.Name = "picbugs";
			this.picbugs.Size = new System.Drawing.Size(218, 142);
			this.picbugs.TabIndex = 47;
			this.picbugs.TabStop = false;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(328, 148);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(141, 17);
			this.label12.TabIndex = 46;
			this.label12.Text = "Snap of error message";
			// 
			// txtcode
			// 
			this.txtcode.Location = new System.Drawing.Point(331, 53);
			this.txtcode.Multiline = true;
			this.txtcode.Name = "txtcode";
			this.txtcode.Size = new System.Drawing.Size(218, 92);
			this.txtcode.TabIndex = 45;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(328, 28);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(39, 17);
			this.label11.TabIndex = 44;
			this.label11.Text = "Code";
			// 
			// dtpdate
			// 
			this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpdate.Location = new System.Drawing.Point(128, 24);
			this.dtpdate.Name = "dtpdate";
			this.dtpdate.Size = new System.Drawing.Size(145, 20);
			this.dtpdate.TabIndex = 43;
			// 
			// cmbproject
			// 
			this.cmbproject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbproject.FormattingEnabled = true;
			this.cmbproject.Location = new System.Drawing.Point(128, 98);
			this.cmbproject.Name = "cmbproject";
			this.cmbproject.Size = new System.Drawing.Size(145, 21);
			this.cmbproject.TabIndex = 42;
			// 
			// txtmethod
			// 
			this.txtmethod.Location = new System.Drawing.Point(128, 270);
			this.txtmethod.Name = "txtmethod";
			this.txtmethod.Size = new System.Drawing.Size(145, 20);
			this.txtmethod.TabIndex = 41;
			// 
			// txtbugdetails
			// 
			this.txtbugdetails.Location = new System.Drawing.Point(128, 303);
			this.txtbugdetails.Multiline = true;
			this.txtbugdetails.Name = "txtbugdetails";
			this.txtbugdetails.Size = new System.Drawing.Size(145, 61);
			this.txtbugdetails.TabIndex = 40;
			// 
			// txtlinenumber
			// 
			this.txtlinenumber.Location = new System.Drawing.Point(128, 202);
			this.txtlinenumber.Name = "txtlinenumber";
			this.txtlinenumber.Size = new System.Drawing.Size(145, 20);
			this.txtlinenumber.TabIndex = 39;
			// 
			// txtclass
			// 
			this.txtclass.Location = new System.Drawing.Point(128, 168);
			this.txtclass.Name = "txtclass";
			this.txtclass.Size = new System.Drawing.Size(145, 20);
			this.txtclass.TabIndex = 38;
			// 
			// txtidentifiedby
			// 
			this.txtidentifiedby.Location = new System.Drawing.Point(128, 64);
			this.txtidentifiedby.Name = "txtidentifiedby";
			this.txtidentifiedby.Size = new System.Drawing.Size(145, 20);
			this.txtidentifiedby.TabIndex = 37;
			// 
			// txtblock
			// 
			this.txtblock.Location = new System.Drawing.Point(128, 232);
			this.txtblock.Name = "txtblock";
			this.txtblock.Size = new System.Drawing.Size(145, 20);
			this.txtblock.TabIndex = 36;
			// 
			// txtclasslibrary
			// 
			this.txtclasslibrary.Location = new System.Drawing.Point(128, 130);
			this.txtclasslibrary.Name = "txtclasslibrary";
			this.txtclasslibrary.Size = new System.Drawing.Size(145, 20);
			this.txtclasslibrary.TabIndex = 35;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(17, 304);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(88, 19);
			this.label10.TabIndex = 34;
			this.label10.Text = "Bug Details";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(17, 269);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 19);
			this.label6.TabIndex = 33;
			this.label6.Text = "Method";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(17, 100);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 19);
			this.label5.TabIndex = 32;
			this.label5.Text = "Project";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(18, 205);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(86, 17);
			this.label9.TabIndex = 31;
			this.label9.Text = "Line Number";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(18, 130);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 17);
			this.label7.TabIndex = 28;
			this.label7.Text = "Class Library";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(18, 171);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 17);
			this.label8.TabIndex = 27;
			this.label8.Text = "Class";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(18, 27);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 17);
			this.label4.TabIndex = 25;
			this.label4.Text = "Date";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 67);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 17);
			this.label2.TabIndex = 22;
			this.label2.Text = "Identified By:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(18, 233);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 17);
			this.label3.TabIndex = 23;
			this.label3.Text = "Block";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(391, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(241, 43);
			this.label1.TabIndex = 39;
			this.label1.Text = "Manage Bugs";
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.grpContainer);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1265, 583);
			this.panel1.TabIndex = 1;
			// 
			// bugentry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1265, 554);
			this.Controls.Add(this.panel1);
			this.Name = "bugentry";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bug Entry";
			this.Load += new System.EventHandler(this.bugentry_Load);
			this.grpContainer.ResumeLayout(false);
			this.grpContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvbugs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picbugs)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.GroupBox grpContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.PictureBox picbugs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.ComboBox cmbproject;
        private System.Windows.Forms.TextBox txtmethod;
        private System.Windows.Forms.TextBox txtbugdetails;
        private System.Windows.Forms.TextBox txtlinenumber;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.TextBox txtidentifiedby;
        private System.Windows.Forms.TextBox txtblock;
        private System.Windows.Forms.TextBox txtclasslibrary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvbugs;
    }
}