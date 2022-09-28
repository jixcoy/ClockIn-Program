
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
            this.manageEmployeesDTbl = new System.Windows.Forms.DataGridView();
            this.NName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManageEmployeesTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageEmployeesDTbl)).BeginInit();
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
            // manageEmployeesDTbl
            // 
            this.manageEmployeesDTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageEmployeesDTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NName,
            this.Rating,
            this.Pay});
            this.manageEmployeesDTbl.Location = new System.Drawing.Point(169, 152);
            this.manageEmployeesDTbl.Name = "manageEmployeesDTbl";
            this.manageEmployeesDTbl.RowHeadersWidth = 51;
            this.manageEmployeesDTbl.RowTemplate.Height = 24;
            this.manageEmployeesDTbl.Size = new System.Drawing.Size(428, 236);
            this.manageEmployeesDTbl.TabIndex = 1;
            // 
            // NName
            // 
            this.NName.HeaderText = "Name";
            this.NName.MinimumWidth = 6;
            this.NName.Name = "NName";
            this.NName.Width = 125;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            this.Rating.Width = 125;
            // 
            // Pay
            // 
            this.Pay.HeaderText = "Pay";
            this.Pay.MinimumWidth = 6;
            this.Pay.Name = "Pay";
            this.Pay.Width = 125;
            // 
            // BossManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.manageEmployeesDTbl);
            this.Controls.Add(this.ManageEmployeesTitle);
            this.Name = "BossManageEmployees";
            this.Size = new System.Drawing.Size(916, 567);
            this.Load += new System.EventHandler(this.BossManageEmployees_Load);
            this.ManageEmployeesTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manageEmployeesDTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ManageEmployeesTitle;
        private System.Windows.Forms.Label ManageEmployeesLbl;
        private System.Windows.Forms.DataGridView manageEmployeesDTbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn NName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pay;
    }
}
