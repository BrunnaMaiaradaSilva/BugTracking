namespace Bug_Tracking_Application
{
    partial class managemember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managemember));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvmembers = new System.Windows.Forms.DataGridView();
            this.grpContainer = new System.Windows.Forms.GroupBox();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.picmembers = new System.Windows.Forms.PictureBox();
            this.dtpjoiningdate = new System.Windows.Forms.DateTimePicker();
            this.dtpbirthdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtmembername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmembers)).BeginInit();
            this.grpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picmembers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.dgvmembers);
            this.panel1.Controls.Add(this.grpContainer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 545);
            this.panel1.TabIndex = 1;
            // 
            // dgvmembers
            // 
            this.dgvmembers.AllowUserToAddRows = false;
            this.dgvmembers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LawnGreen;
            this.dgvmembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvmembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmembers.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvmembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvmembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmembers.Location = new System.Drawing.Point(2, 375);
            this.dgvmembers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvmembers.MultiSelect = false;
            this.dgvmembers.Name = "dgvmembers";
            this.dgvmembers.ReadOnly = true;
            this.dgvmembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmembers.Size = new System.Drawing.Size(636, 124);
            this.dgvmembers.TabIndex = 0;
            this.dgvmembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmembers_CellContentClick);
            // 
            // grpContainer
            // 
            this.grpContainer.BackColor = System.Drawing.Color.Transparent;
            this.grpContainer.Controls.Add(this.cmbrole);
            this.grpContainer.Controls.Add(this.label11);
            this.grpContainer.Controls.Add(this.txtpassword);
            this.grpContainer.Controls.Add(this.label10);
            this.grpContainer.Controls.Add(this.txtusername);
            this.grpContainer.Controls.Add(this.label9);
            this.grpContainer.Controls.Add(this.btnbrowse);
            this.grpContainer.Controls.Add(this.picmembers);
            this.grpContainer.Controls.Add(this.dtpjoiningdate);
            this.grpContainer.Controls.Add(this.dtpbirthdate);
            this.grpContainer.Controls.Add(this.label7);
            this.grpContainer.Controls.Add(this.label8);
            this.grpContainer.Controls.Add(this.txtcontact);
            this.grpContainer.Controls.Add(this.label2);
            this.grpContainer.Controls.Add(this.btnupdate);
            this.grpContainer.Controls.Add(this.btnexit);
            this.grpContainer.Controls.Add(this.AddButton);
            this.grpContainer.Controls.Add(this.btndelete);
            this.grpContainer.Controls.Add(this.cmbgender);
            this.grpContainer.Controls.Add(this.txtemail);
            this.grpContainer.Controls.Add(this.txtaddress);
            this.grpContainer.Controls.Add(this.txtmembername);
            this.grpContainer.Controls.Add(this.label6);
            this.grpContainer.Controls.Add(this.label5);
            this.grpContainer.Controls.Add(this.label4);
            this.grpContainer.Controls.Add(this.label3);
            this.grpContainer.ForeColor = System.Drawing.Color.White;
            this.grpContainer.Location = new System.Drawing.Point(2, 63);
            this.grpContainer.Margin = new System.Windows.Forms.Padding(2);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Padding = new System.Windows.Forms.Padding(2);
            this.grpContainer.Size = new System.Drawing.Size(636, 313);
            this.grpContainer.TabIndex = 37;
            this.grpContainer.TabStop = false;
            this.grpContainer.Text = "Enter the following Information";
            // 
            // cmbrole
            // 
            this.cmbrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmbrole.Location = new System.Drawing.Point(114, 116);
            this.cmbrole.Margin = new System.Windows.Forms.Padding(2);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(131, 21);
            this.cmbrole.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 119);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Role";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(114, 85);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(131, 20);
            this.txtpassword.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(114, 24);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(131, 20);
            this.txtusername.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "User Name";
            // 
            // btnbrowse
            // 
            this.btnbrowse.BackColor = System.Drawing.Color.DimGray;
            this.btnbrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbrowse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.Location = new System.Drawing.Point(345, 253);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(109, 31);
            this.btnbrowse.TabIndex = 51;
            this.btnbrowse.Text = "Insert Image";
            this.btnbrowse.UseVisualStyleBackColor = false;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // picmembers
            // 
            this.picmembers.BackColor = System.Drawing.Color.White;
            this.picmembers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picmembers.BackgroundImage")));
            this.picmembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picmembers.Location = new System.Drawing.Point(299, 67);
            this.picmembers.Name = "picmembers";
            this.picmembers.Size = new System.Drawing.Size(189, 149);
            this.picmembers.TabIndex = 50;
            this.picmembers.TabStop = false;
            // 
            // dtpjoiningdate
            // 
            this.dtpjoiningdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpjoiningdate.Location = new System.Drawing.Point(114, 287);
            this.dtpjoiningdate.Name = "dtpjoiningdate";
            this.dtpjoiningdate.Size = new System.Drawing.Size(131, 20);
            this.dtpjoiningdate.TabIndex = 49;
            // 
            // dtpbirthdate
            // 
            this.dtpbirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpbirthdate.Location = new System.Drawing.Point(114, 257);
            this.dtpbirthdate.Name = "dtpbirthdate";
            this.dtpbirthdate.Size = new System.Drawing.Size(131, 20);
            this.dtpbirthdate.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Joining Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 263);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Birth Date";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(114, 227);
            this.txtcontact.Margin = new System.Windows.Forms.Padding(2);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(131, 20);
            this.txtcontact.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Contact";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Black;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(533, 85);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(81, 36);
            this.btnupdate.TabIndex = 41;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Black;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(533, 171);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(81, 36);
            this.btnexit.TabIndex = 41;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Black;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(533, 40);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(81, 36);
            this.AddButton.TabIndex = 42;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Black;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(533, 129);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(81, 36);
            this.btndelete.TabIndex = 40;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // cmbgender
            // 
            this.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmbgender.Location = new System.Drawing.Point(114, 200);
            this.cmbgender.Margin = new System.Windows.Forms.Padding(2);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(131, 21);
            this.cmbgender.TabIndex = 7;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(114, 171);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(131, 20);
            this.txtemail.TabIndex = 6;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(114, 145);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(131, 20);
            this.txtaddress.TabIndex = 5;
            // 
            // txtmembername
            // 
            this.txtmembername.Location = new System.Drawing.Point(114, 54);
            this.txtmembername.Margin = new System.Windows.Forms.Padding(2);
            this.txtmembername.Name = "txtmembername";
            this.txtmembername.Size = new System.Drawing.Size(131, 20);
            this.txtmembername.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 43);
            this.label1.TabIndex = 39;
            this.label1.Text = "Manage Members";
            // 
            // managemember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 476);
            this.Controls.Add(this.panel1);
            this.Name = "managemember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Member";
            this.Load += new System.EventHandler(this.managemember_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmembers)).EndInit();
            this.grpContainer.ResumeLayout(false);
            this.grpContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picmembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView dgvmembers;
        private System.Windows.Forms.GroupBox grpContainer;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtmembername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpjoiningdate;
        private System.Windows.Forms.DateTimePicker dtpbirthdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picmembers;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbrole;
    }
}