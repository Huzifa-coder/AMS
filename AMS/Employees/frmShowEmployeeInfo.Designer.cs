namespace AMS.Employees
{
    partial class frmShowEmployeeInfo
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
            this.ctrlEmployeesInfoCard1 = new AMS.Employees.ctrlEmployeesInfoCard();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Image = global::AMS.Properties.Resources.Close_32;
            this.btnCancel.Location = new System.Drawing.Point(442, 450);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 48);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ctrlEmployeesInfoCard1
            // 
            this.ctrlEmployeesInfoCard1.Location = new System.Drawing.Point(4, 12);
            this.ctrlEmployeesInfoCard1.Name = "ctrlEmployeesInfoCard1";
            this.ctrlEmployeesInfoCard1.Size = new System.Drawing.Size(579, 430);
            this.ctrlEmployeesInfoCard1.TabIndex = 40;
            // 
            // frmShowEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 510);
            this.Controls.Add(this.ctrlEmployeesInfoCard1);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmShowEmployeeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowEmployeeInfo";
            this.Load += new System.EventHandler(this.frmShowEmployeeInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private ctrlEmployeesInfoCard ctrlEmployeesInfoCard1;
    }
}