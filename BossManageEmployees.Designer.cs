
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ManageEmployeesTitle = new System.Windows.Forms.Panel();
            this.ManageEmployeesLbl = new System.Windows.Forms.Label();
            this.manageEmployeesDTbl = new System.Windows.Forms.DataGridView();
            this.ManageEmployeesTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageEmployeesDTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageEmployeesTitle
            // 
            this.ManageEmployeesTitle.Controls.Add(this.ManageEmployeesLbl);
            this.ManageEmployeesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageEmployeesTitle.Location = new System.Drawing.Point(0, 0);
            this.ManageEmployeesTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManageEmployeesTitle.Name = "ManageEmployeesTitle";
            this.ManageEmployeesTitle.Size = new System.Drawing.Size(687, 81);
            this.ManageEmployeesTitle.TabIndex = 0;
            // 
            // ManageEmployeesLbl
            // 
            this.ManageEmployeesLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageEmployeesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageEmployeesLbl.ForeColor = System.Drawing.Color.White;
            this.ManageEmployeesLbl.Location = new System.Drawing.Point(0, 0);
            this.ManageEmployeesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManageEmployeesLbl.Name = "ManageEmployeesLbl";
            this.ManageEmployeesLbl.Size = new System.Drawing.Size(687, 81);
            this.ManageEmployeesLbl.TabIndex = 0;
            this.ManageEmployeesLbl.Text = "Manage Employees";
            this.ManageEmployeesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manageEmployeesDTbl
            // 
            this.manageEmployeesDTbl.AllowUserToAddRows = false;
            this.manageEmployeesDTbl.AllowUserToDeleteRows = false;
            this.manageEmployeesDTbl.AllowUserToResizeColumns = false;
            this.manageEmployeesDTbl.AllowUserToResizeRows = false;
            this.manageEmployeesDTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.manageEmployeesDTbl.BackgroundColor = System.Drawing.Color.White;
            this.manageEmployeesDTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.manageEmployeesDTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.manageEmployeesDTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.manageEmployeesDTbl.DefaultCellStyle = dataGridViewCellStyle4;
            this.manageEmployeesDTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageEmployeesDTbl.Location = new System.Drawing.Point(0, 81);
            this.manageEmployeesDTbl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageEmployeesDTbl.Name = "manageEmployeesDTbl";
            this.manageEmployeesDTbl.RowHeadersVisible = false;
            this.manageEmployeesDTbl.RowHeadersWidth = 51;
            this.manageEmployeesDTbl.RowTemplate.Height = 24;
            this.manageEmployeesDTbl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.manageEmployeesDTbl.Size = new System.Drawing.Size(687, 380);
            this.manageEmployeesDTbl.TabIndex = 1;
            this.manageEmployeesDTbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.manageEmployeesDTbl_CellContentClick);
            // 
            // BossManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.manageEmployeesDTbl);
            this.Controls.Add(this.ManageEmployeesTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BossManageEmployees";
            this.Size = new System.Drawing.Size(687, 461);
            this.Load += new System.EventHandler(this.BossManageEmployees_Load);
            this.ManageEmployeesTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manageEmployeesDTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ManageEmployeesTitle;
        private System.Windows.Forms.Label ManageEmployeesLbl;
        private System.Windows.Forms.DataGridView manageEmployeesDTbl;
    }
}
