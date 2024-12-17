namespace AMS.Attendance
{
    partial class frmTakeAttendance
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbAttendTitle = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbAttendanceID = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAbsent = new System.Windows.Forms.RadioButton();
            this.rbInCollage = new System.Windows.Forms.RadioButton();
            this.rbAttend = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Image = global::AMS.Properties.Resources.Close_32;
            this.btnCancel.Location = new System.Drawing.Point(358, 364);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 50);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = global::AMS.Properties.Resources.Save_32;
            this.btnSave.Location = new System.Drawing.Point(493, 364);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 50);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbTime.Location = new System.Drawing.Point(240, 245);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(52, 26);
            this.lbTime.TabIndex = 54;
            this.lbTime.Text = "N/A";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AMS.Properties.Resources.Notes_32;
            this.pictureBox6.Location = new System.Drawing.Point(202, 242);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 53;
            this.pictureBox6.TabStop = false;
            // 
            // lbAttendTitle
            // 
            this.lbAttendTitle.AutoSize = true;
            this.lbAttendTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbAttendTitle.Location = new System.Drawing.Point(35, 245);
            this.lbAttendTitle.Name = "lbAttendTitle";
            this.lbAttendTitle.Size = new System.Drawing.Size(161, 26);
            this.lbAttendTitle.TabIndex = 52;
            this.lbAttendTitle.Text = "Attend Time : ";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbDate.Location = new System.Drawing.Point(240, 191);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(52, 26);
            this.lbDate.TabIndex = 51;
            this.lbDate.Text = "N/A";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::AMS.Properties.Resources.Calendar_32;
            this.pictureBox7.Location = new System.Drawing.Point(202, 188);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 50;
            this.pictureBox7.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(113, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 26);
            this.label10.TabIndex = 49;
            this.label10.Text = "Date : ";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbFullName.Location = new System.Drawing.Point(240, 137);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(52, 26);
            this.lbFullName.TabIndex = 48;
            this.lbFullName.Text = "N/A";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::AMS.Properties.Resources.Person_32;
            this.pictureBox8.Location = new System.Drawing.Point(202, 134);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox8.TabIndex = 47;
            this.pictureBox8.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(54, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 26);
            this.label12.TabIndex = 46;
            this.label12.Text = "Full Name : ";
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbEmployeeID.Location = new System.Drawing.Point(240, 83);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(52, 26);
            this.lbEmployeeID.TabIndex = 45;
            this.lbEmployeeID.Text = "N/A";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::AMS.Properties.Resources.Number_32;
            this.pictureBox9.Location = new System.Drawing.Point(202, 80);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox9.TabIndex = 44;
            this.pictureBox9.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(26, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 26);
            this.label14.TabIndex = 43;
            this.label14.Text = "Employee ID : ";
            // 
            // lbAttendanceID
            // 
            this.lbAttendanceID.AutoSize = true;
            this.lbAttendanceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbAttendanceID.Location = new System.Drawing.Point(240, 29);
            this.lbAttendanceID.Name = "lbAttendanceID";
            this.lbAttendanceID.Size = new System.Drawing.Size(52, 26);
            this.lbAttendanceID.TabIndex = 42;
            this.lbAttendanceID.Text = "N/A";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::AMS.Properties.Resources.Number_32;
            this.pictureBox10.Location = new System.Drawing.Point(202, 26);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox10.TabIndex = 41;
            this.pictureBox10.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(12, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(184, 26);
            this.label16.TabIndex = 40;
            this.label16.Text = "Attendance ID : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(102, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 55;
            this.label1.Text = "Status :";
            // 
            // rbAbsent
            // 
            this.rbAbsent.AutoSize = true;
            this.rbAbsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAbsent.Location = new System.Drawing.Point(339, 293);
            this.rbAbsent.Name = "rbAbsent";
            this.rbAbsent.Size = new System.Drawing.Size(93, 28);
            this.rbAbsent.TabIndex = 64;
            this.rbAbsent.TabStop = true;
            this.rbAbsent.Text = "Absent";
            this.rbAbsent.UseVisualStyleBackColor = true;
            this.rbAbsent.CheckedChanged += new System.EventHandler(this.rbAbsent_CheckedChanged);
            // 
            // rbInCollage
            // 
            this.rbInCollage.AutoSize = true;
            this.rbInCollage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInCollage.Location = new System.Drawing.Point(438, 293);
            this.rbInCollage.Name = "rbInCollage";
            this.rbInCollage.Size = new System.Drawing.Size(122, 28);
            this.rbInCollage.TabIndex = 65;
            this.rbInCollage.TabStop = true;
            this.rbInCollage.Text = "In Collage";
            this.rbInCollage.UseVisualStyleBackColor = true;
            this.rbInCollage.CheckedChanged += new System.EventHandler(this.rbInCollage_CheckedChanged);
            // 
            // rbAttend
            // 
            this.rbAttend.AutoSize = true;
            this.rbAttend.Checked = true;
            this.rbAttend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAttend.Location = new System.Drawing.Point(245, 293);
            this.rbAttend.Name = "rbAttend";
            this.rbAttend.Size = new System.Drawing.Size(88, 28);
            this.rbAttend.TabIndex = 63;
            this.rbAttend.TabStop = true;
            this.rbAttend.Text = "Attend";
            this.rbAttend.UseVisualStyleBackColor = true;
            this.rbAttend.CheckedChanged += new System.EventHandler(this.rbAttend_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AMS.Properties.Resources.PassedTests_32;
            this.pictureBox1.Location = new System.Drawing.Point(202, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // frmTakeAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbAbsent);
            this.Controls.Add(this.rbInCollage);
            this.Controls.Add(this.rbAttend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lbAttendTitle);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbEmployeeID);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbAttendanceID);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTakeAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take Attendance";
            this.Load += new System.EventHandler(this.frmTakeAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbAttendTitle;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbEmployeeID;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbAttendanceID;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAbsent;
        private System.Windows.Forms.RadioButton rbInCollage;
        private System.Windows.Forms.RadioButton rbAttend;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}