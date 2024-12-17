namespace AMS.Employees
{
    partial class frmAddEditEmployee
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
            this.components = new System.ComponentModel.Container();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tcEmployee = new System.Windows.Forms.TabControl();
            this.tpPerson = new System.Windows.Forms.TabPage();
            this.ctrlPersonFilterCard1 = new AMS.People.Controls.ctrlPersonFilterCard();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpEmployee = new System.Windows.Forms.TabPage();
            this.cbEmployeesList = new System.Windows.Forms.CheckBox();
            this.cbAttendanceList = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.tbEmployeeID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcEmployee.SuspendLayout();
            this.tpPerson.SuspendLayout();
            this.tpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(301, 39);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(224, 37);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "Add Employee";
            // 
            // tcEmployee
            // 
            this.tcEmployee.Controls.Add(this.tpPerson);
            this.tcEmployee.Controls.Add(this.tpEmployee);
            this.tcEmployee.Location = new System.Drawing.Point(18, 136);
            this.tcEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcEmployee.Name = "tcEmployee";
            this.tcEmployee.SelectedIndex = 0;
            this.tcEmployee.Size = new System.Drawing.Size(840, 509);
            this.tcEmployee.TabIndex = 14;
            // 
            // tpPerson
            // 
            this.tpPerson.Controls.Add(this.ctrlPersonFilterCard1);
            this.tpPerson.Controls.Add(this.btnNext);
            this.tpPerson.Location = new System.Drawing.Point(4, 29);
            this.tpPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpPerson.Name = "tpPerson";
            this.tpPerson.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpPerson.Size = new System.Drawing.Size(832, 476);
            this.tpPerson.TabIndex = 0;
            this.tpPerson.Text = "Person";
            this.tpPerson.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonFilterCard1
            // 
            this.ctrlPersonFilterCard1.FilterEnabled = true;
            this.ctrlPersonFilterCard1.Location = new System.Drawing.Point(16, 7);
            this.ctrlPersonFilterCard1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlPersonFilterCard1.Name = "ctrlPersonFilterCard1";
            this.ctrlPersonFilterCard1.Size = new System.Drawing.Size(793, 384);
            this.ctrlPersonFilterCard1.TabIndex = 39;
            this.ctrlPersonFilterCard1.OnPersonSelected += new System.Action<int>(this.ctrlPersonFilterCard1_OnPersonSelected);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNext.Image = global::AMS.Properties.Resources.Next_32;
            this.btnNext.Location = new System.Drawing.Point(646, 400);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 61);
            this.btnNext.TabIndex = 38;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpEmployee
            // 
            this.tpEmployee.Controls.Add(this.cbEmployeesList);
            this.tpEmployee.Controls.Add(this.cbAttendanceList);
            this.tpEmployee.Controls.Add(this.pictureBox2);
            this.tpEmployee.Controls.Add(this.label2);
            this.tpEmployee.Controls.Add(this.tbPassword);
            this.tpEmployee.Controls.Add(this.label1);
            this.tpEmployee.Controls.Add(this.pictureBox1);
            this.tpEmployee.Controls.Add(this.cbDepartment);
            this.tpEmployee.Controls.Add(this.tbEmployeeID);
            this.tpEmployee.Controls.Add(this.label6);
            this.tpEmployee.Controls.Add(this.label8);
            this.tpEmployee.Controls.Add(this.pictureBox3);
            this.tpEmployee.Controls.Add(this.pictureBox4);
            this.tpEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tpEmployee.Location = new System.Drawing.Point(4, 29);
            this.tpEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpEmployee.Name = "tpEmployee";
            this.tpEmployee.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpEmployee.Size = new System.Drawing.Size(832, 476);
            this.tpEmployee.TabIndex = 1;
            this.tpEmployee.Text = "Employee";
            this.tpEmployee.UseVisualStyleBackColor = true;
            // 
            // cbEmployeesList
            // 
            this.cbEmployeesList.AutoSize = true;
            this.cbEmployeesList.Location = new System.Drawing.Point(351, 292);
            this.cbEmployeesList.Name = "cbEmployeesList";
            this.cbEmployeesList.Size = new System.Drawing.Size(135, 24);
            this.cbEmployeesList.TabIndex = 51;
            this.cbEmployeesList.Text = "Employees List";
            this.cbEmployeesList.UseVisualStyleBackColor = true;
            // 
            // cbAttendanceList
            // 
            this.cbAttendanceList.AutoSize = true;
            this.cbAttendanceList.Location = new System.Drawing.Point(205, 292);
            this.cbAttendanceList.Name = "cbAttendanceList";
            this.cbAttendanceList.Size = new System.Drawing.Size(140, 24);
            this.cbAttendanceList.TabIndex = 50;
            this.cbAttendanceList.Text = "Attendance List";
            this.cbAttendanceList.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AMS.Properties.Resources.PersonDetails_32;
            this.pictureBox2.Location = new System.Drawing.Point(150, 288);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(9, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Permissions : ";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(190, 226);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(337, 26);
            this.tbPassword.TabIndex = 47;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(9, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Password : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AMS.Properties.Resources.Person_32;
            this.pictureBox1.Location = new System.Drawing.Point(150, 223);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(190, 147);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(337, 28);
            this.cbDepartment.TabIndex = 44;
            // 
            // tbEmployeeID
            // 
            this.tbEmployeeID.Location = new System.Drawing.Point(190, 66);
            this.tbEmployeeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmployeeID.Name = "tbEmployeeID";
            this.tbEmployeeID.Size = new System.Drawing.Size(337, 26);
            this.tbEmployeeID.TabIndex = 41;
            this.tbEmployeeID.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(8, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "Department : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(9, 67);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Employee ID : ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AMS.Properties.Resources.List_32;
            this.pictureBox3.Location = new System.Drawing.Point(150, 145);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AMS.Properties.Resources.Person_32;
            this.pictureBox4.Location = new System.Drawing.Point(150, 63);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Image = global::AMS.Properties.Resources.Close_32;
            this.btnCancel.Location = new System.Drawing.Point(546, 655);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 61);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = global::AMS.Properties.Resources.Save_32;
            this.btnSave.Location = new System.Drawing.Point(704, 655);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 61);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 721);
            this.Controls.Add(this.tcEmployee);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddEditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditEmployee";
            this.Load += new System.EventHandler(this.frmAddEditEmployee_Load);
            this.tcEmployee.ResumeLayout(false);
            this.tpPerson.ResumeLayout(false);
            this.tpEmployee.ResumeLayout(false);
            this.tpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TabControl tcEmployee;
        private System.Windows.Forms.TabPage tpPerson;
        private System.Windows.Forms.TabPage tpEmployee;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tbEmployeeID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private People.Controls.ctrlPersonFilterCard ctrlPersonFilterCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbEmployeesList;
        private System.Windows.Forms.CheckBox cbAttendanceList;
    }
}