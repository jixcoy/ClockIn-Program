
namespace ClockIn
{
    partial class BossManageSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.manageScheduleDTBL = new System.Windows.Forms.DataGridView();
            this.editEmployeeBtn = new System.Windows.Forms.Button();
            this.editCancelBtn = new System.Windows.Forms.Button();
            this.editEnter = new System.Windows.Forms.Button();
            this.editRoleTB = new ClockIn.CustomTB();
            this.editShiftTB = new ClockIn.CustomTB();
            this.editNameTB = new ClockIn.CustomTB();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageScheduleDTBL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TitleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 81);
            this.panel1.TabIndex = 0;
            // 
            // TitleLbl
            // 
            this.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.White;
            this.TitleLbl.Location = new System.Drawing.Point(0, 0);
            this.TitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(681, 81);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Manage Schedule";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLbl.VisibleChanged += new System.EventHandler(this.BossManageSchedule_Load);
            this.TitleLbl.Enter += new System.EventHandler(this.BossManageSchedule_Load);
            // 
            // manageScheduleDTBL
            // 
            this.manageScheduleDTBL.AllowUserToAddRows = false;
            this.manageScheduleDTBL.AllowUserToDeleteRows = false;
            this.manageScheduleDTBL.AllowUserToResizeColumns = false;
            this.manageScheduleDTBL.AllowUserToResizeRows = false;
            this.manageScheduleDTBL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.manageScheduleDTBL.BackgroundColor = System.Drawing.Color.White;
            this.manageScheduleDTBL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.manageScheduleDTBL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.manageScheduleDTBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.manageScheduleDTBL.DefaultCellStyle = dataGridViewCellStyle16;
            this.manageScheduleDTBL.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageScheduleDTBL.Location = new System.Drawing.Point(0, 81);
            this.manageScheduleDTBL.Margin = new System.Windows.Forms.Padding(2);
            this.manageScheduleDTBL.Name = "manageScheduleDTBL";
            this.manageScheduleDTBL.RowHeadersVisible = false;
            this.manageScheduleDTBL.RowHeadersWidth = 51;
            this.manageScheduleDTBL.RowTemplate.Height = 24;
            this.manageScheduleDTBL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.manageScheduleDTBL.Size = new System.Drawing.Size(681, 228);
            this.manageScheduleDTBL.TabIndex = 2;
            // 
            // editEmployeeBtn
            // 
            this.editEmployeeBtn.Location = new System.Drawing.Point(288, 332);
            this.editEmployeeBtn.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.editEmployeeBtn.Name = "editEmployeeBtn";
            this.editEmployeeBtn.Size = new System.Drawing.Size(96, 27);
            this.editEmployeeBtn.TabIndex = 3;
            this.editEmployeeBtn.Text = "Edit Employee";
            this.editEmployeeBtn.UseVisualStyleBackColor = true;
            this.editEmployeeBtn.Click += new System.EventHandler(this.editEmployeeBtn_Click);
            // 
            // editCancelBtn
            // 
            this.editCancelBtn.Location = new System.Drawing.Point(229, 408);
            this.editCancelBtn.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.editCancelBtn.Name = "editCancelBtn";
            this.editCancelBtn.Size = new System.Drawing.Size(96, 24);
            this.editCancelBtn.TabIndex = 7;
            this.editCancelBtn.Text = "Cancel";
            this.editCancelBtn.UseVisualStyleBackColor = true;
            this.editCancelBtn.Visible = false;
            this.editCancelBtn.Click += new System.EventHandler(this.editCancelBtn_Click);
            // 
            // editEnter
            // 
            this.editEnter.Location = new System.Drawing.Point(348, 408);
            this.editEnter.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.editEnter.Name = "editEnter";
            this.editEnter.Size = new System.Drawing.Size(96, 24);
            this.editEnter.TabIndex = 8;
            this.editEnter.Text = "Enter";
            this.editEnter.UseVisualStyleBackColor = true;
            this.editEnter.Visible = false;
            this.editEnter.Click += new System.EventHandler(this.editEnter_Click);
            // 
            // editRoleTB
            // 
            this.editRoleTB.Location = new System.Drawing.Point(450, 377);
            this.editRoleTB.Name = "editRoleTB";
            this.editRoleTB.Size = new System.Drawing.Size(215, 25);
            this.editRoleTB.TabIndex = 6;
            this.editRoleTB.Texts = "Text";
            // 
            // editShiftTB
            // 
            this.editShiftTB.Location = new System.Drawing.Point(229, 377);
            this.editShiftTB.Name = "editShiftTB";
            this.editShiftTB.Size = new System.Drawing.Size(215, 25);
            this.editShiftTB.TabIndex = 5;
            this.editShiftTB.Texts = "Text";
            // 
            // editNameTB
            // 
            this.editNameTB.Location = new System.Drawing.Point(8, 377);
            this.editNameTB.Name = "editNameTB";
            this.editNameTB.Size = new System.Drawing.Size(215, 25);
            this.editNameTB.TabIndex = 4;
            this.editNameTB.Texts = "Text";
            // 
            // BossManageSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.editEnter);
            this.Controls.Add(this.editCancelBtn);
            this.Controls.Add(this.editRoleTB);
            this.Controls.Add(this.editShiftTB);
            this.Controls.Add(this.editNameTB);
            this.Controls.Add(this.editEmployeeBtn);
            this.Controls.Add(this.manageScheduleDTBL);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BossManageSchedule";
            this.Size = new System.Drawing.Size(681, 461);
            this.Load += new System.EventHandler(this.BossManageSchedule_Load);
            this.VisibleChanged += new System.EventHandler(this.refresh);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manageScheduleDTBL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.DataGridView manageScheduleDTBL;
        private System.Windows.Forms.Button editEmployeeBtn;
        private CustomTB editNameTB;
        private CustomTB editShiftTB;
        private CustomTB editRoleTB;
        private System.Windows.Forms.Button editCancelBtn;
        private System.Windows.Forms.Button editEnter;
    }
}
