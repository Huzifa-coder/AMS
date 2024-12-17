namespace AMS.Employees
{
    partial class ctrlEmployeesInfoCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlPersonInfoCard1 = new AMS.People.Controls.ctrlPersonInfoCard();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEmployeesList = new System.Windows.Forms.CheckBox();
            this.cbAttendanceList = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lnlEditEmployeeInfo = new System.Windows.Forms.LinkLabel();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlPersonInfoCard1
            // 
            this.ctrlPersonInfoCard1.AutoSize = true;
            this.ctrlPersonInfoCard1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlPersonInfoCard1.Location = new System.Drawing.Point(2, 2);
            this.ctrlPersonInfoCard1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlPersonInfoCard1.Name = "ctrlPersonInfoCard1";
            this.ctrlPersonInfoCard1.Size = new System.Drawing.Size(562, 175);
            this.ctrlPersonInfoCard1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEmployeesList);
            this.groupBox1.Controls.Add(this.cbAttendanceList);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lnlEditEmployeeInfo);
            this.groupBox1.Controls.Add(this.lbDepartment);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbEmployeeID);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(2, 181);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(562, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Info";
            // 
            // cbEmployeesList
            // 
            this.cbEmployeesList.AutoCheck = false;
            this.cbEmployeesList.AutoSize = true;
            this.cbEmployeesList.Enabled = false;
            this.cbEmployeesList.Location = new System.Drawing.Point(338, 154);
            this.cbEmployeesList.Name = "cbEmployeesList";
            this.cbEmployeesList.Size = new System.Drawing.Size(135, 24);
            this.cbEmployeesList.TabIndex = 53;
            this.cbEmployeesList.Text = "Employees List";
            this.cbEmployeesList.UseVisualStyleBackColor = true;
            // 
            // cbAttendanceList
            // 
            this.cbAttendanceList.AutoCheck = false;
            this.cbAttendanceList.AutoSize = true;
            this.cbAttendanceList.Enabled = false;
            this.cbAttendanceList.Location = new System.Drawing.Point(192, 154);
            this.cbAttendanceList.Name = "cbAttendanceList";
            this.cbAttendanceList.Size = new System.Drawing.Size(140, 24);
            this.cbAttendanceList.TabIndex = 52;
            this.cbAttendanceList.Text = "Attendance List";
            this.cbAttendanceList.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AMS.Properties.Resources.ApplicationTitle;
            this.pictureBox3.Location = new System.Drawing.Point(147, 150);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(5, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Permissions : ";
            // 
            // lnlEditEmployeeInfo
            // 
            this.lnlEditEmployeeInfo.AutoSize = true;
            this.lnlEditEmployeeInfo.Location = new System.Drawing.Point(414, 207);
            this.lnlEditEmployeeInfo.Name = "lnlEditEmployeeInfo";
            this.lnlEditEmployeeInfo.Size = new System.Drawing.Size(143, 20);
            this.lnlEditEmployeeInfo.TabIndex = 49;
            this.lnlEditEmployeeInfo.TabStop = true;
            this.lnlEditEmployeeInfo.Text = "Edit Employee Info";
            this.lnlEditEmployeeInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlEditEmployeeInfo_LinkClicked);
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbDepartment.Location = new System.Drawing.Point(188, 98);
            this.lbDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(42, 24);
            this.lbDepartment.TabIndex = 48;
            this.lbDepartment.Text = "N/A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AMS.Properties.Resources.Applications_64;
            this.pictureBox1.Location = new System.Drawing.Point(147, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(5, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "Department : ";
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbEmployeeID.Location = new System.Drawing.Point(188, 41);
            this.lbEmployeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(42, 24);
            this.lbEmployeeID.TabIndex = 45;
            this.lbEmployeeID.Text = "N/A";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AMS.Properties.Resources.Person_32;
            this.pictureBox2.Location = new System.Drawing.Point(147, 37);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(5, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Employee ID : ";
            // 
            // ctrlEmployeesInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlPersonInfoCard1);
            this.Name = "ctrlEmployeesInfoCard";
            this.Size = new System.Drawing.Size(574, 436);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private People.Controls.ctrlPersonInfoCard ctrlPersonInfoCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnlEditEmployeeInfo;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbEmployeeID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbAttendanceList;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbEmployeesList;
    }
}
