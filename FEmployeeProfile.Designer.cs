
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserIconLabel = new FontAwesome.Sharp.IconPictureBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.profileHoursDtb = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileHoursDtb)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserIconLabel
            // 
            this.UserIconLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.UserIconLabel.IconChar = FontAwesome.Sharp.IconChar.User;
            this.UserIconLabel.IconColor = System.Drawing.Color.White;
            this.UserIconLabel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.UserIconLabel.IconSize = 74;
            this.UserIconLabel.Location = new System.Drawing.Point(79, 67);
            this.UserIconLabel.Name = "UserIconLabel";
            this.UserIconLabel.Size = new System.Drawing.Size(74, 76);
            this.UserIconLabel.TabIndex = 0;
            this.UserIconLabel.TabStop = false;
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
            // profileHoursDtb
            // 
            this.profileHoursDtb.AllowUserToAddRows = false;
            this.profileHoursDtb.AllowUserToDeleteRows = false;
            this.profileHoursDtb.AllowUserToResizeColumns = false;
            this.profileHoursDtb.AllowUserToResizeRows = false;
            this.profileHoursDtb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.profileHoursDtb.BackgroundColor = System.Drawing.Color.White;
            this.profileHoursDtb.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.profileHoursDtb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.profileHoursDtb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.profileHoursDtb.DefaultCellStyle = dataGridViewCellStyle4;
            this.profileHoursDtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileHoursDtb.Location = new System.Drawing.Point(0, 0);
            this.profileHoursDtb.Margin = new System.Windows.Forms.Padding(2);
            this.profileHoursDtb.Name = "profileHoursDtb";
            this.profileHoursDtb.ReadOnly = true;
            this.profileHoursDtb.RowHeadersVisible = false;
            this.profileHoursDtb.RowHeadersWidth = 51;
            this.profileHoursDtb.RowTemplate.Height = 24;
            this.profileHoursDtb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.profileHoursDtb.Size = new System.Drawing.Size(687, 234);
            this.profileHoursDtb.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.profileHoursDtb);
            this.panel1.Location = new System.Drawing.Point(1, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 234);
            this.panel1.TabIndex = 5;
            // 
            // FEmployeeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserIconLabel);
            this.Name = "FEmployeeProfile";
            this.Size = new System.Drawing.Size(688, 461);
            this.Load += new System.EventHandler(this.FEmployeeProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserIconLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileHoursDtb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox UserIconLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.DataGridView profileHoursDtb;
        private System.Windows.Forms.Panel panel1;
    }
}
