
namespace ClockIn
{
    partial class BossManageEmployees
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
            this.ManageEmployeesTitle = new System.Windows.Forms.Panel();
            this.ManageEmployeesLbl = new System.Windows.Forms.Label();
            this.ManageEmployeesTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManageEmployeesTitle
            // 
            this.ManageEmployeesTitle.Controls.Add(this.ManageEmployeesLbl);
            this.ManageEmployeesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageEmployeesTitle.Location = new System.Drawing.Point(0, 0);
            this.ManageEmployeesTitle.Name = "ManageEmployeesTitle";
            this.ManageEmployeesTitle.Size = new System.Drawing.Size(916, 100);
            this.ManageEmployeesTitle.TabIndex = 0;
            // 
            // ManageEmployeesLbl
            // 
            this.ManageEmployeesLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageEmployeesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageEmployeesLbl.Location = new System.Drawing.Point(0, 0);
            this.ManageEmployeesLbl.Name = "ManageEmployeesLbl";
            this.ManageEmployeesLbl.Size = new System.Drawing.Size(916, 100);
            this.ManageEmployeesLbl.TabIndex = 0;
            this.ManageEmployeesLbl.Text = "Manage Employees";
            this.ManageEmployeesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BossManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.ManageEmployeesTitle);
            this.Name = "BossManageEmployees";
            this.Size = new System.Drawing.Size(916, 567);
            this.ManageEmployeesTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ManageEmployeesTitle;
        private System.Windows.Forms.Label ManageEmployeesLbl;
    }
}
