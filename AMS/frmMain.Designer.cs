namespace AMS
{
    partial class frmMain
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAccountSetting = new System.Windows.Forms.Button();
            this.btnEmployeesList = new System.Windows.Forms.Button();
            this.btnAttendanceList = new System.Windows.Forms.Button();
            this.btnTakeAttendance = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Crimson;
            this.panelMenu.Controls.Add(this.btnAccountSetting);
            this.panelMenu.Controls.Add(this.btnEmployeesList);
            this.panelMenu.Controls.Add(this.btnAttendanceList);
            this.panelMenu.Controls.Add(this.btnTakeAttendance);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 614);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAccountSetting
            // 
            this.btnAccountSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccountSetting.FlatAppearance.BorderSize = 0;
            this.btnAccountSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAccountSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccountSetting.Image = global::AMS.Properties.Resources.settings;
            this.btnAccountSetting.Location = new System.Drawing.Point(0, 317);
            this.btnAccountSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccountSetting.Name = "btnAccountSetting";
            this.btnAccountSetting.Size = new System.Drawing.Size(240, 76);
            this.btnAccountSetting.TabIndex = 4;
            this.btnAccountSetting.Text = "  Account Setting";
            this.btnAccountSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccountSetting.UseVisualStyleBackColor = true;
            this.btnAccountSetting.Click += new System.EventHandler(this.btnAccountSetting_Click);
            // 
            // btnEmployeesList
            // 
            this.btnEmployeesList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeesList.FlatAppearance.BorderSize = 0;
            this.btnEmployeesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEmployeesList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployeesList.Image = global::AMS.Properties.Resources.employees_List;
            this.btnEmployeesList.Location = new System.Drawing.Point(0, 241);
            this.btnEmployeesList.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployeesList.Name = "btnEmployeesList";
            this.btnEmployeesList.Size = new System.Drawing.Size(240, 76);
            this.btnEmployeesList.TabIndex = 3;
            this.btnEmployeesList.Text = "  Employees List";
            this.btnEmployeesList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeesList.UseVisualStyleBackColor = true;
            this.btnEmployeesList.Click += new System.EventHandler(this.btnEmployeesList_Click);
            // 
            // btnAttendanceList
            // 
            this.btnAttendanceList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendanceList.FlatAppearance.BorderSize = 0;
            this.btnAttendanceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendanceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAttendanceList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAttendanceList.Image = global::AMS.Properties.Resources.attandance_List;
            this.btnAttendanceList.Location = new System.Drawing.Point(0, 165);
            this.btnAttendanceList.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttendanceList.Name = "btnAttendanceList";
            this.btnAttendanceList.Size = new System.Drawing.Size(240, 76);
            this.btnAttendanceList.TabIndex = 2;
            this.btnAttendanceList.Text = "    Attandance List";
            this.btnAttendanceList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendanceList.UseVisualStyleBackColor = true;
            this.btnAttendanceList.Click += new System.EventHandler(this.btnAttendanceList_Click);
            // 
            // btnTakeAttendance
            // 
            this.btnTakeAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTakeAttendance.FlatAppearance.BorderSize = 0;
            this.btnTakeAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnTakeAttendance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTakeAttendance.Image = global::AMS.Properties.Resources.take_attendance;
            this.btnTakeAttendance.Location = new System.Drawing.Point(0, 89);
            this.btnTakeAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.btnTakeAttendance.Name = "btnTakeAttendance";
            this.btnTakeAttendance.Size = new System.Drawing.Size(240, 76);
            this.btnTakeAttendance.TabIndex = 0;
            this.btnTakeAttendance.Text = "   Take Attendance";
            this.btnTakeAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTakeAttendance.UseVisualStyleBackColor = true;
            this.btnTakeAttendance.Click += new System.EventHandler(this.btnTakeAttendance_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 89);
            this.panel1.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(928, 614);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAccountSetting;
        private System.Windows.Forms.Button btnEmployeesList;
        private System.Windows.Forms.Button btnAttendanceList;
        private System.Windows.Forms.Button btnTakeAttendance;
    }
}

