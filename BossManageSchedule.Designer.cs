
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.manageScheduleDTBL = new System.Windows.Forms.DataGridView();
            this.editRoleTB = new ClockIn.CustomTB();
            this.editShiftTB = new ClockIn.CustomTB();
            this.editNameTB = new ClockIn.CustomTB();
            this.EditButton = new ClockIn.CustomButton();
            this.CancelButton = new ClockIn.CustomButton();
            this.EnterButton = new ClockIn.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageScheduleDTBL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TitleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.manageScheduleDTBL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.manageScheduleDTBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.manageScheduleDTBL.DefaultCellStyle = dataGridViewCellStyle12;
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
            // editRoleTB
            // 
            this.editRoleTB.Location = new System.Drawing.Point(600, 464);
            this.editRoleTB.Margin = new System.Windows.Forms.Padding(5);
            this.editRoleTB.Name = "editRoleTB";
            this.editRoleTB.Size = new System.Drawing.Size(287, 31);
            this.editRoleTB.TabIndex = 6;
            this.editRoleTB.Texts = "Role";
            this.editRoleTB.Enter += new System.EventHandler(this.editRoleTB_Enter);
            this.editRoleTB.Leave += new System.EventHandler(this.editRoleTB_Leave);
            // 
            // editShiftTB
            // 
            this.editShiftTB.Location = new System.Drawing.Point(305, 464);
            this.editShiftTB.Margin = new System.Windows.Forms.Padding(5);
            this.editShiftTB.Name = "editShiftTB";
            this.editShiftTB.Size = new System.Drawing.Size(287, 31);
            this.editShiftTB.TabIndex = 5;
            this.editShiftTB.Texts = "Shift";
            this.editShiftTB.Enter += new System.EventHandler(this.editShiftTB_Enter);
            this.editShiftTB.Leave += new System.EventHandler(this.editShiftTB_Leave);
            // 
            // editNameTB
            // 
            this.editNameTB.Location = new System.Drawing.Point(11, 464);
            this.editNameTB.Margin = new System.Windows.Forms.Padding(5);
            this.editNameTB.Name = "editNameTB";
            this.editNameTB.Size = new System.Drawing.Size(287, 31);
            this.editNameTB.TabIndex = 4;
            this.editNameTB.Texts = "Full Name";
            this.editNameTB.Enter += new System.EventHandler(this.editNameTB_Enter);
            this.editNameTB.Leave += new System.EventHandler(this.editNameTB_Leave);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.EditButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.EditButton.BorderColor = System.Drawing.Color.Black;
            this.EditButton.BorderRadius = 15;
            this.EditButton.BorderSize = 1;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(366, 403);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 40);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit Employee";
            this.EditButton.TextColor = System.Drawing.Color.White;
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Maroon;
            this.CancelButton.BackgroundColor = System.Drawing.Color.Maroon;
            this.CancelButton.BorderColor = System.Drawing.Color.Black;
            this.CancelButton.BorderRadius = 15;
            this.CancelButton.BorderSize = 1;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(296, 503);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 40);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextColor = System.Drawing.Color.White;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.Green;
            this.EnterButton.BackgroundColor = System.Drawing.Color.Green;
            this.EnterButton.BorderColor = System.Drawing.Color.Black;
            this.EnterButton.BorderRadius = 15;
            this.EnterButton.BorderSize = 1;
            this.EnterButton.FlatAppearance.BorderSize = 0;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.ForeColor = System.Drawing.Color.White;
            this.EnterButton.Location = new System.Drawing.Point(452, 503);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(150, 40);
            this.EnterButton.TabIndex = 11;
            this.EnterButton.Text = "Enter";
            this.EnterButton.TextColor = System.Drawing.Color.White;
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // BossManageSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.editRoleTB);
            this.Controls.Add(this.editShiftTB);
            this.Controls.Add(this.editNameTB);
            this.Controls.Add(this.manageScheduleDTBL);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BossManageSchedule";
            this.Size = new System.Drawing.Size(908, 567);
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
        private CustomTB editNameTB;
        private CustomTB editShiftTB;
        private CustomTB editRoleTB;
        private CustomButton EditButton;
        private CustomButton CancelButton;
        private CustomButton EnterButton;
    }
}
