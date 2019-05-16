namespace Bug_Tracking_Application
{
    partial class manageproject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageproject));
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvprojects = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.grpContainer = new System.Windows.Forms.GroupBox();
            this.dtpfinishingdate = new System.Windows.Forms.DateTimePicker();
            this.dtpstartingdate = new System.Windows.Forms.DateTimePicker();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtprojectname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprojects)).BeginInit();
            this.grpContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Black;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(467, 83);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(81, 36);
            this.btnupdate.TabIndex = 41;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Black;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(467, 43);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(81, 36);
            this.btnadd.TabIndex = 42;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvprojects
            // 
            this.dgvprojects.AllowUserToAddRows = false;
            this.dgvprojects.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LawnGreen;
            this.dgvprojects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvprojects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvprojects.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvprojects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprojects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvprojects.Location = new System.Drawing.Point(0, 0);
            this.dgvprojects.Margin = new System.Windows.Forms.Padding(2);
            this.dgvprojects.Name = "dgvprojects";
            this.dgvprojects.ReadOnly = true;
            this.dgvprojects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprojects.Size = new System.Drawing.Size(583, 152);
            this.dgvprojects.TabIndex = 38;
            this.dgvprojects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprojects_CellContentClick);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Black;
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(467, 163);
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
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(467, 124);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(81, 36);
            this.btndelete.TabIndex = 40;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // grpContainer
            // 
            this.grpContainer.BackColor = System.Drawing.Color.Transparent;
            this.grpContainer.Controls.Add(this.dtpfinishingdate);
            this.grpContainer.Controls.Add(this.dtpstartingdate);
            this.grpContainer.Controls.Add(this.txtdescription);
            this.grpContainer.Controls.Add(this.btnupdate);
            this.grpContainer.Controls.Add(this.btnexit);
            this.grpContainer.Controls.Add(this.btnadd);
            this.grpContainer.Controls.Add(this.btndelete);
            this.grpContainer.Controls.Add(this.txtprojectname);
            this.grpContainer.Controls.Add(this.label6);
            this.grpContainer.Controls.Add(this.label5);
            this.grpContainer.Controls.Add(this.label4);
            this.grpContainer.Controls.Add(this.label3);
            this.grpContainer.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContainer.ForeColor = System.Drawing.Color.White;
            this.grpContainer.Location = new System.Drawing.Point(9, 80);
            this.grpContainer.Margin = new System.Windows.Forms.Padding(2);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Padding = new System.Windows.Forms.Padding(2);
            this.grpContainer.Size = new System.Drawing.Size(584, 232);
            this.grpContainer.TabIndex = 37;
            this.grpContainer.TabStop = false;
            this.grpContainer.Text = "Enter the following Information";
            // 
            // dtpfinishingdate
            // 
            this.dtpfinishingdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfinishingdate.Location = new System.Drawing.Point(164, 93);
            this.dtpfinishingdate.Name = "dtpfinishingdate";
            this.dtpfinishingdate.Size = new System.Drawing.Size(216, 26);
            this.dtpfinishingdate.TabIndex = 45;
            // 
            // dtpstartingdate
            // 
            this.dtpstartingdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpstartingdate.Location = new System.Drawing.Point(164, 66);
            this.dtpstartingdate.Name = "dtpstartingdate";
            this.dtpstartingdate.Size = new System.Drawing.Size(216, 26);
            this.dtpstartingdate.TabIndex = 44;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(164, 123);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(216, 95);
            this.txtdescription.TabIndex = 43;
            // 
            // txtprojectname
            // 
            this.txtprojectname.Location = new System.Drawing.Point(164, 37);
            this.txtprojectname.Margin = new System.Windows.Forms.Padding(2);
            this.txtprojectname.Name = "txtprojectname";
            this.txtprojectname.Size = new System.Drawing.Size(216, 26);
            this.txtprojectname.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Finishing Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Starting Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Project Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 43);
            this.label1.TabIndex = 39;
            this.label1.Text = "Manage Project";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grpContainer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 468);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvprojects);
            this.panel2.Location = new System.Drawing.Point(10, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 152);
            this.panel2.TabIndex = 40;
            // 
            // manageproject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 464);
            this.Controls.Add(this.panel1);
            this.Name = "manageproject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Project";
            this.Load += new System.EventHandler(this.manageproject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprojects)).EndInit();
            this.grpContainer.ResumeLayout(false);
            this.grpContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvprojects;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.GroupBox grpContainer;
        private System.Windows.Forms.TextBox txtprojectname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.DateTimePicker dtpfinishingdate;
        private System.Windows.Forms.DateTimePicker dtpstartingdate;
        private System.Windows.Forms.Panel panel2;
    }
}