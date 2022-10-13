
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
            this.shiftTB = new ClockIn.CustomTB();
            this.dateTB = new ClockIn.CustomTB();
            this.hoursTB = new ClockIn.CustomTB();
            this.AddButton = new ClockIn.CustomButton();
            this.CancelButton = new ClockIn.CustomButton();
            this.EnterButton = new ClockIn.CustomButton();
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
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(908, 123);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Hours";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 123);
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
            this.HoursDtb.Location = new System.Drawing.Point(0, 123);
            this.HoursDtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HoursDtb.Name = "HoursDtb";
            this.HoursDtb.RowHeadersVisible = false;
            this.HoursDtb.RowHeadersWidth = 51;
            this.HoursDtb.RowTemplate.Height = 24;
            this.HoursDtb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HoursDtb.Size = new System.Drawing.Size(908, 281);
            this.HoursDtb.TabIndex = 3;
            // 
            // shiftTB
            // 
            this.shiftTB.Location = new System.Drawing.Point(599, 474);
            this.shiftTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.shiftTB.Name = "shiftTB";
            this.shiftTB.Size = new System.Drawing.Size(279, 31);
            this.shiftTB.TabIndex = 7;
            this.shiftTB.Texts = "Text";
            this.shiftTB.Visible = false;
            // 
            // dateTB
            // 
            this.dateTB.Location = new System.Drawing.Point(312, 474);
            this.dateTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(279, 31);
            this.dateTB.TabIndex = 6;
            this.dateTB.Texts = "Text";
            this.dateTB.Visible = false;
            // 
            // hoursTB
            // 
            this.hoursTB.Location = new System.Drawing.Point(25, 474);
            this.hoursTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.hoursTB.Name = "hoursTB";
            this.hoursTB.Size = new System.Drawing.Size(279, 31);
            this.hoursTB.TabIndex = 5;
            this.hoursTB.Texts = "Text";
            this.hoursTB.Visible = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.AddButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.AddButton.BorderColor = System.Drawing.Color.Black;
            this.AddButton.BorderRadius = 15;
            this.AddButton.BorderSize = 1;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(368, 411);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 40);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add Hours";
            this.AddButton.TextColor = System.Drawing.Color.White;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
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
            this.CancelButton.Location = new System.Drawing.Point(283, 506);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 40);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextColor = System.Drawing.Color.White;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Visible = false;
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
            this.EnterButton.Location = new System.Drawing.Point(465, 506);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(150, 40);
            this.EnterButton.TabIndex = 12;
            this.EnterButton.Text = "Enter";
            this.EnterButton.TextColor = System.Drawing.Color.White;
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Visible = false;
            // 
            // HoursF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.shiftTB);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.hoursTB);
            this.Controls.Add(this.HoursDtb);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HoursF";
            this.Size = new System.Drawing.Size(908, 567);
            this.Load += new System.EventHandler(this.HoursF_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HoursDtb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView HoursDtb;
        private CustomTB hoursTB;
        private CustomTB dateTB;
        private CustomTB shiftTB;
        private CustomButton AddButton;
        private CustomButton CancelButton;
        private CustomButton EnterButton;
    }
}
