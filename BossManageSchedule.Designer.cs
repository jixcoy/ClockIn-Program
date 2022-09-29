
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 100);
            this.panel1.TabIndex = 0;
            // 
            // TitleLbl
            // 
            this.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.White;
            this.TitleLbl.Location = new System.Drawing.Point(0, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(908, 100);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Manage Schedule";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.manageScheduleDTBL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.manageScheduleDTBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.manageScheduleDTBL.DefaultCellStyle = dataGridViewCellStyle2;
            this.manageScheduleDTBL.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageScheduleDTBL.Location = new System.Drawing.Point(0, 100);
            this.manageScheduleDTBL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageScheduleDTBL.Name = "manageScheduleDTBL";
            this.manageScheduleDTBL.RowHeadersVisible = false;
            this.manageScheduleDTBL.RowHeadersWidth = 51;
            this.manageScheduleDTBL.RowTemplate.Height = 24;
            this.manageScheduleDTBL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.manageScheduleDTBL.Size = new System.Drawing.Size(908, 281);
            this.manageScheduleDTBL.TabIndex = 2;
            // 
            // editEmployeeBtn
            // 
            this.editEmployeeBtn.Location = new System.Drawing.Point(384, 409);
            this.editEmployeeBtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.editEmployeeBtn.Name = "editEmployeeBtn";
            this.editEmployeeBtn.Size = new System.Drawing.Size(128, 33);
            this.editEmployeeBtn.TabIndex = 3;
            this.editEmployeeBtn.Text = "Edit Employee";
            this.editEmployeeBtn.UseVisualStyleBackColor = true;
            this.editEmployeeBtn.Click += new System.EventHandler(this.editEmployeeBtn_Click);
            // 
            // editCancelBtn
            // 
            this.editCancelBtn.Location = new System.Drawing.Point(305, 502);
            this.editCancelBtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.editCancelBtn.Name = "editCancelBtn";
            this.editCancelBtn.Size = new System.Drawing.Size(128, 30);
            this.editCancelBtn.TabIndex = 7;
            this.editCancelBtn.Text = "Cancel";
            this.editCancelBtn.UseVisualStyleBackColor = true;
            this.editCancelBtn.Click += new System.EventHandler(this.editCancelBtn_Click);
            // 
            // editEnter
            // 
            this.editEnter.Location = new System.Drawing.Point(464, 502);
            this.editEnter.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.editEnter.Name = "editEnter";
            this.editEnter.Size = new System.Drawing.Size(128, 30);
            this.editEnter.TabIndex = 8;
            this.editEnter.Text = "Enter";
            this.editEnter.UseVisualStyleBackColor = true;
            this.editEnter.Click += new System.EventHandler(this.editEnter_Click);
            // 
            // editRoleTB
            // 
            this.editRoleTB.Location = new System.Drawing.Point(600, 464);
            this.editRoleTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editRoleTB.Name = "editRoleTB";
            this.editRoleTB.Size = new System.Drawing.Size(287, 31);
            this.editRoleTB.TabIndex = 6;
            this.editRoleTB.Texts = "Text";
            // 
            // editShiftTB
            // 
            this.editShiftTB.Location = new System.Drawing.Point(305, 464);
            this.editShiftTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editShiftTB.Name = "editShiftTB";
            this.editShiftTB.Size = new System.Drawing.Size(287, 31);
            this.editShiftTB.TabIndex = 5;
            this.editShiftTB.Texts = "Text";
            // 
            // editNameTB
            // 
            this.editNameTB.Location = new System.Drawing.Point(10, 464);
            this.editNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editNameTB.Name = "editNameTB";
            this.editNameTB.Size = new System.Drawing.Size(287, 31);
            this.editNameTB.TabIndex = 4;
            this.editNameTB.Texts = "Text";
            // 
            // BossManageSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.Name = "BossManageSchedule";
            this.Size = new System.Drawing.Size(908, 567);
            this.Load += new System.EventHandler(this.BossManageSchedule_Load);
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
