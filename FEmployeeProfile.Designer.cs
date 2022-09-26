
namespace ClockIn
{
    partial class FEmployeeProfile
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
            this.UserIconLabel = new FontAwesome.Sharp.IconPictureBox();
            this.HoursTable = new System.Windows.Forms.TableLayoutPanel();
            this.DateValue = new System.Windows.Forms.Label();
            this.HoursValue = new System.Windows.Forms.Label();
            this.HoursHead = new System.Windows.Forms.Label();
            this.DateHead = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconLabel)).BeginInit();
            this.HoursTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserIconLabel
            // 
            this.UserIconLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.UserIconLabel.IconChar = FontAwesome.Sharp.IconChar.User;
            this.UserIconLabel.IconColor = System.Drawing.Color.White;
            this.UserIconLabel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.UserIconLabel.IconSize = 74;
            this.UserIconLabel.Location = new System.Drawing.Point(79, 56);
            this.UserIconLabel.Name = "UserIconLabel";
            this.UserIconLabel.Size = new System.Drawing.Size(74, 76);
            this.UserIconLabel.TabIndex = 0;
            this.UserIconLabel.TabStop = false;
            // 
            // HoursTable
            // 
            this.HoursTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.HoursTable.ColumnCount = 2;
            this.HoursTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HoursTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HoursTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.HoursTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.HoursTable.Controls.Add(this.DateValue, 1, 1);
            this.HoursTable.Controls.Add(this.HoursValue, 0, 1);
            this.HoursTable.Controls.Add(this.HoursHead, 0, 0);
            this.HoursTable.Controls.Add(this.DateHead, 1, 0);
            this.HoursTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursTable.ForeColor = System.Drawing.Color.Black;
            this.HoursTable.Location = new System.Drawing.Point(79, 172);
            this.HoursTable.Name = "HoursTable";
            this.HoursTable.RowCount = 2;
            this.HoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HoursTable.Size = new System.Drawing.Size(525, 164);
            this.HoursTable.TabIndex = 2;
            this.HoursTable.Paint += new System.Windows.Forms.PaintEventHandler(this.HoursTable_Paint);
            // 
            // DateValue
            // 
            this.DateValue.AutoSize = true;
            this.DateValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateValue.Location = new System.Drawing.Point(265, 83);
            this.DateValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateValue.Name = "DateValue";
            this.DateValue.Size = new System.Drawing.Size(256, 79);
            this.DateValue.TabIndex = 7;
            this.DateValue.Text = "label10";
            this.DateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoursValue
            // 
            this.HoursValue.AutoSize = true;
            this.HoursValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoursValue.Location = new System.Drawing.Point(4, 83);
            this.HoursValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HoursValue.Name = "HoursValue";
            this.HoursValue.Size = new System.Drawing.Size(255, 79);
            this.HoursValue.TabIndex = 6;
            this.HoursValue.Text = "label9";
            this.HoursValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoursHead
            // 
            this.HoursHead.AutoSize = true;
            this.HoursHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoursHead.Location = new System.Drawing.Point(4, 2);
            this.HoursHead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HoursHead.Name = "HoursHead";
            this.HoursHead.Size = new System.Drawing.Size(255, 79);
            this.HoursHead.TabIndex = 0;
            this.HoursHead.Text = "Hours";
            this.HoursHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateHead
            // 
            this.DateHead.AutoSize = true;
            this.DateHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateHead.Location = new System.Drawing.Point(265, 2);
            this.DateHead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateHead.Name = "DateHead";
            this.DateHead.Size = new System.Drawing.Size(256, 79);
            this.DateHead.TabIndex = 1;
            this.DateHead.Text = "Date";
            this.DateHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(159, 67);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(105, 25);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "UserName";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.Location = new System.Drawing.Point(159, 107);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(51, 25);
            this.RoleLabel.TabIndex = 3;
            this.RoleLabel.Text = "Role";
            // 
            // FEmployeeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.HoursTable);
            this.Controls.Add(this.UserIconLabel);
            this.Name = "FEmployeeProfile";
            this.Size = new System.Drawing.Size(681, 461);
            this.Load += new System.EventHandler(this.FEmployeeProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserIconLabel)).EndInit();
            this.HoursTable.ResumeLayout(false);
            this.HoursTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox UserIconLabel;
        private System.Windows.Forms.TableLayoutPanel HoursTable;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label HoursHead;
        private System.Windows.Forms.Label DateHead;
        private System.Windows.Forms.Label DateValue;
        private System.Windows.Forms.Label HoursValue;
    }
}
