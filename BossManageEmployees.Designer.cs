
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ManageEmployeesTitle = new System.Windows.Forms.Panel();
            this.ManageEmployeesLbl = new System.Windows.Forms.Label();
            this.manageEmployeesDTbl = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nameCustomTb = new ClockIn.CustomTB();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.shiftCustomTB = new ClockIn.CustomTB();
            this.payCustomTb = new ClockIn.CustomTB();
            this.idCustomTb = new ClockIn.CustomTB();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.enterBtn = new System.Windows.Forms.Button();
            this.ManageEmployeesTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageEmployeesDTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageEmployeesTitle
            // 
            this.ManageEmployeesTitle.Controls.Add(this.ManageEmployeesLbl);
            this.ManageEmployeesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageEmployeesTitle.Location = new System.Drawing.Point(0, 0);
            this.ManageEmployeesTitle.Margin = new System.Windows.Forms.Padding(2);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.manageEmployeesDTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.manageEmployeesDTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.manageEmployeesDTbl.DefaultCellStyle = dataGridViewCellStyle2;
            this.manageEmployeesDTbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageEmployeesDTbl.Location = new System.Drawing.Point(0, 81);
            this.manageEmployeesDTbl.Margin = new System.Windows.Forms.Padding(2);
            this.manageEmployeesDTbl.Name = "manageEmployeesDTbl";
            this.manageEmployeesDTbl.RowHeadersVisible = false;
            this.manageEmployeesDTbl.RowHeadersWidth = 51;
            this.manageEmployeesDTbl.RowTemplate.Height = 24;
            this.manageEmployeesDTbl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.manageEmployeesDTbl.Size = new System.Drawing.Size(687, 228);
            this.manageEmployeesDTbl.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nameCustomTb
            // 
            this.nameCustomTb.Location = new System.Drawing.Point(14, 367);
            this.nameCustomTb.Name = "nameCustomTb";
            this.nameCustomTb.Size = new System.Drawing.Size(171, 25);
            this.nameCustomTb.TabIndex = 3;
            this.nameCustomTb.Texts = "";
            this.nameCustomTb.Visible = false;
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.Location = new System.Drawing.Point(14, 326);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(115, 23);
            this.addEmpBtn.TabIndex = 4;
            this.addEmpBtn.Text = "Add Employee";
            this.addEmpBtn.UseVisualStyleBackColor = true;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmpBtn_Click);
            // 
            // shiftCustomTB
            // 
            this.shiftCustomTB.Location = new System.Drawing.Point(204, 398);
            this.shiftCustomTB.Name = "shiftCustomTB";
            this.shiftCustomTB.Size = new System.Drawing.Size(171, 25);
            this.shiftCustomTB.TabIndex = 5;
            this.shiftCustomTB.Texts = "";
            this.shiftCustomTB.Visible = false;
            // 
            // payCustomTb
            // 
            this.payCustomTb.Location = new System.Drawing.Point(204, 367);
            this.payCustomTb.Name = "payCustomTb";
            this.payCustomTb.Size = new System.Drawing.Size(171, 25);
            this.payCustomTb.TabIndex = 6;
            this.payCustomTb.Texts = "";
            this.payCustomTb.Visible = false;
            // 
            // idCustomTb
            // 
            this.idCustomTb.Location = new System.Drawing.Point(14, 398);
            this.idCustomTb.Name = "idCustomTb";
            this.idCustomTb.Size = new System.Drawing.Size(171, 25);
            this.idCustomTb.TabIndex = 7;
            this.idCustomTb.Texts = "";
            this.idCustomTb.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(218, 326);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(137, 326);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(75, 23);
            this.enterBtn.TabIndex = 9;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Visible = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // BossManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.idCustomTb);
            this.Controls.Add(this.payCustomTb);
            this.Controls.Add(this.shiftCustomTB);
            this.Controls.Add(this.addEmpBtn);
            this.Controls.Add(this.nameCustomTb);
            this.Controls.Add(this.manageEmployeesDTbl);
            this.Controls.Add(this.ManageEmployeesTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private CustomTB nameCustomTb;
        private System.Windows.Forms.Button addEmpBtn;
        private CustomTB shiftCustomTB;
        private CustomTB payCustomTb;
        private CustomTB idCustomTb;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button enterBtn;
    }
}
