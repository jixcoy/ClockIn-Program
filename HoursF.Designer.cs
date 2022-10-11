
namespace ClockIn
{
    partial class HoursF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HoursDtb = new System.Windows.Forms.DataGridView();
            this.addHoursBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.enterBtn = new System.Windows.Forms.Button();
            this.shiftTB = new ClockIn.CustomTB();
            this.dateTB = new ClockIn.CustomTB();
            this.hoursTB = new ClockIn.CustomTB();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursDtb)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(681, 100);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Hours";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 100);
            this.panel1.TabIndex = 1;
            // 
            // HoursDtb
            // 
            this.HoursDtb.AllowUserToAddRows = false;
            this.HoursDtb.AllowUserToDeleteRows = false;
            this.HoursDtb.AllowUserToResizeColumns = false;
            this.HoursDtb.AllowUserToResizeRows = false;
            this.HoursDtb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HoursDtb.BackgroundColor = System.Drawing.Color.White;
            this.HoursDtb.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HoursDtb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.HoursDtb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HoursDtb.DefaultCellStyle = dataGridViewCellStyle6;
            this.HoursDtb.Dock = System.Windows.Forms.DockStyle.Top;
            this.HoursDtb.Location = new System.Drawing.Point(0, 100);
            this.HoursDtb.Margin = new System.Windows.Forms.Padding(2);
            this.HoursDtb.Name = "HoursDtb";
            this.HoursDtb.RowHeadersVisible = false;
            this.HoursDtb.RowHeadersWidth = 51;
            this.HoursDtb.RowTemplate.Height = 24;
            this.HoursDtb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HoursDtb.Size = new System.Drawing.Size(681, 228);
            this.HoursDtb.TabIndex = 3;
            // 
            // addHoursBtn
            // 
            this.addHoursBtn.Location = new System.Drawing.Point(301, 347);
            this.addHoursBtn.Name = "addHoursBtn";
            this.addHoursBtn.Size = new System.Drawing.Size(75, 23);
            this.addHoursBtn.TabIndex = 4;
            this.addHoursBtn.Text = "Add Hours";
            this.addHoursBtn.UseVisualStyleBackColor = true;
            this.addHoursBtn.Click += new System.EventHandler(this.addHoursBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(234, 416);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Close";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(343, 416);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(100, 23);
            this.enterBtn.TabIndex = 9;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // shiftTB
            // 
            this.shiftTB.Location = new System.Drawing.Point(449, 385);
            this.shiftTB.Name = "shiftTB";
            this.shiftTB.Size = new System.Drawing.Size(209, 25);
            this.shiftTB.TabIndex = 7;
            this.shiftTB.Texts = "Text";
            this.shiftTB.Visible = false;
            // 
            // dateTB
            // 
            this.dateTB.Location = new System.Drawing.Point(234, 385);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(209, 25);
            this.dateTB.TabIndex = 6;
            this.dateTB.Texts = "Text";
            this.dateTB.Visible = false;
            // 
            // hoursTB
            // 
            this.hoursTB.Location = new System.Drawing.Point(19, 385);
            this.hoursTB.Name = "hoursTB";
            this.hoursTB.Size = new System.Drawing.Size(209, 25);
            this.hoursTB.TabIndex = 5;
            this.hoursTB.Texts = "Text";
            this.hoursTB.Visible = false;
            // 
            // HoursF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.shiftTB);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.hoursTB);
            this.Controls.Add(this.addHoursBtn);
            this.Controls.Add(this.HoursDtb);
            this.Controls.Add(this.panel1);
            this.Name = "HoursF";
            this.Size = new System.Drawing.Size(681, 461);
            this.Load += new System.EventHandler(this.HoursF_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HoursDtb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView HoursDtb;
        private System.Windows.Forms.Button addHoursBtn;
        private CustomTB hoursTB;
        private CustomTB dateTB;
        private CustomTB shiftTB;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button enterBtn;
    }
}
