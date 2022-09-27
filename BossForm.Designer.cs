
namespace ClockIn
{
    partial class BossForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.workerLeftPanel = new System.Windows.Forms.Panel();
            this.ManageScheduleBtn = new FontAwesome.Sharp.IconButton();
            this.clockInLabel = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.ManageEmployeesBtn = new FontAwesome.Sharp.IconButton();
            this.emailIconBtn = new FontAwesome.Sharp.IconButton();
            this.profileIconButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.workerLeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.workerLeftPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 567);
            this.panel1.TabIndex = 0;
            // 
            // workerLeftPanel
            // 
            this.workerLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.workerLeftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workerLeftPanel.Controls.Add(this.ManageScheduleBtn);
            this.workerLeftPanel.Controls.Add(this.clockInLabel);
            this.workerLeftPanel.Controls.Add(this.logOutBtn);
            this.workerLeftPanel.Controls.Add(this.ManageEmployeesBtn);
            this.workerLeftPanel.Controls.Add(this.emailIconBtn);
            this.workerLeftPanel.Controls.Add(this.profileIconButton);
            this.workerLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.workerLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.workerLeftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.workerLeftPanel.Name = "workerLeftPanel";
            this.workerLeftPanel.Size = new System.Drawing.Size(263, 567);
            this.workerLeftPanel.TabIndex = 1;
            // 
            // ManageScheduleBtn
            // 
            this.ManageScheduleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.ManageScheduleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageScheduleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageScheduleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageScheduleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageScheduleBtn.ForeColor = System.Drawing.Color.White;
            this.ManageScheduleBtn.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.ManageScheduleBtn.IconColor = System.Drawing.Color.White;
            this.ManageScheduleBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ManageScheduleBtn.IconSize = 30;
            this.ManageScheduleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ManageScheduleBtn.Location = new System.Drawing.Point(0, 471);
            this.ManageScheduleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ManageScheduleBtn.Name = "ManageScheduleBtn";
            this.ManageScheduleBtn.Size = new System.Drawing.Size(261, 95);
            this.ManageScheduleBtn.TabIndex = 6;
            this.ManageScheduleBtn.Text = "Manage Schedule";
            this.ManageScheduleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageScheduleBtn.UseVisualStyleBackColor = false;
            this.ManageScheduleBtn.Click += new System.EventHandler(this.ManageScheduleBtn_Click);
            // 
            // clockInLabel
            // 
            this.clockInLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.clockInLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clockInLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.clockInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockInLabel.ForeColor = System.Drawing.Color.White;
            this.clockInLabel.Location = new System.Drawing.Point(0, 380);
            this.clockInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clockInLabel.Name = "clockInLabel";
            this.clockInLabel.Size = new System.Drawing.Size(261, 91);
            this.clockInLabel.TabIndex = 1;
            this.clockInLabel.Text = "Clock In";
            this.clockInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(0, 285);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(261, 95);
            this.logOutBtn.TabIndex = 5;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // ManageEmployeesBtn
            // 
            this.ManageEmployeesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.ManageEmployeesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageEmployeesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageEmployeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageEmployeesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageEmployeesBtn.ForeColor = System.Drawing.Color.White;
            this.ManageEmployeesBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.ManageEmployeesBtn.IconColor = System.Drawing.Color.White;
            this.ManageEmployeesBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ManageEmployeesBtn.IconSize = 30;
            this.ManageEmployeesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ManageEmployeesBtn.Location = new System.Drawing.Point(0, 190);
            this.ManageEmployeesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ManageEmployeesBtn.Name = "ManageEmployeesBtn";
            this.ManageEmployeesBtn.Size = new System.Drawing.Size(261, 95);
            this.ManageEmployeesBtn.TabIndex = 4;
            this.ManageEmployeesBtn.Text = "Manage Employees";
            this.ManageEmployeesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageEmployeesBtn.UseVisualStyleBackColor = false;
            this.ManageEmployeesBtn.Click += new System.EventHandler(this.hoursIconBtn_Click);
            // 
            // emailIconBtn
            // 
            this.emailIconBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.emailIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailIconBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.emailIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailIconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailIconBtn.ForeColor = System.Drawing.Color.White;
            this.emailIconBtn.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.emailIconBtn.IconColor = System.Drawing.Color.White;
            this.emailIconBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.emailIconBtn.IconSize = 30;
            this.emailIconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emailIconBtn.Location = new System.Drawing.Point(0, 95);
            this.emailIconBtn.Margin = new System.Windows.Forms.Padding(4);
            this.emailIconBtn.Name = "emailIconBtn";
            this.emailIconBtn.Size = new System.Drawing.Size(261, 95);
            this.emailIconBtn.TabIndex = 3;
            this.emailIconBtn.Text = "Email";
            this.emailIconBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.emailIconBtn.UseVisualStyleBackColor = false;
            this.emailIconBtn.Click += new System.EventHandler(this.emailIconBtn_Click);
            // 
            // profileIconButton
            // 
            this.profileIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.profileIconButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileIconButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileIconButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileIconButton.ForeColor = System.Drawing.Color.White;
            this.profileIconButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.profileIconButton.IconColor = System.Drawing.Color.White;
            this.profileIconButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.profileIconButton.IconSize = 30;
            this.profileIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.profileIconButton.Location = new System.Drawing.Point(0, 0);
            this.profileIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.profileIconButton.Name = "profileIconButton";
            this.profileIconButton.Size = new System.Drawing.Size(261, 95);
            this.profileIconButton.TabIndex = 2;
            this.profileIconButton.Text = "Profile";
            this.profileIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.profileIconButton.UseVisualStyleBackColor = false;
            this.profileIconButton.Click += new System.EventHandler(this.profileIconButton_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(263, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 567);
            this.panel2.TabIndex = 2;
            // 
            // BossForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 567);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BossForm";
            this.Text = "BossForm";
            this.panel1.ResumeLayout(false);
            this.workerLeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel workerLeftPanel;
        private System.Windows.Forms.Label clockInLabel;
        private System.Windows.Forms.Button logOutBtn;
        private FontAwesome.Sharp.IconButton ManageEmployeesBtn;
        private FontAwesome.Sharp.IconButton emailIconBtn;
        private FontAwesome.Sharp.IconButton profileIconButton;
        private FontAwesome.Sharp.IconButton ManageScheduleBtn;
        private System.Windows.Forms.Panel panel2;
    }
}