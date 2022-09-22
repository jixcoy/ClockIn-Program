
namespace ClockIn
{
    partial class WorkerForm
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
            this.workerLeftPanel = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.emailIconBtn = new FontAwesome.Sharp.IconButton();
            this.hoursIconBtn = new FontAwesome.Sharp.IconButton();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.clockInLabel = new System.Windows.Forms.Label();
            this.workerLeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // workerLeftPanel
            // 
            this.workerLeftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workerLeftPanel.Controls.Add(this.clockInLabel);
            this.workerLeftPanel.Controls.Add(this.logOutBtn);
            this.workerLeftPanel.Controls.Add(this.hoursIconBtn);
            this.workerLeftPanel.Controls.Add(this.emailIconBtn);
            this.workerLeftPanel.Controls.Add(this.iconButton1);
            this.workerLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.workerLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.workerLeftPanel.Name = "workerLeftPanel";
            this.workerLeftPanel.Size = new System.Drawing.Size(200, 461);
            this.workerLeftPanel.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(198, 75);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Profile";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // emailIconBtn
            // 
            this.emailIconBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emailIconBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.emailIconBtn.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.emailIconBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailIconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.emailIconBtn.IconSize = 25;
            this.emailIconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emailIconBtn.Location = new System.Drawing.Point(0, 75);
            this.emailIconBtn.Name = "emailIconBtn";
            this.emailIconBtn.Size = new System.Drawing.Size(198, 75);
            this.emailIconBtn.TabIndex = 3;
            this.emailIconBtn.Text = "Email";
            this.emailIconBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.emailIconBtn.UseVisualStyleBackColor = false;
            // 
            // hoursIconBtn
            // 
            this.hoursIconBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hoursIconBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.hoursIconBtn.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.hoursIconBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hoursIconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.hoursIconBtn.IconSize = 25;
            this.hoursIconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hoursIconBtn.Location = new System.Drawing.Point(0, 150);
            this.hoursIconBtn.Name = "hoursIconBtn";
            this.hoursIconBtn.Size = new System.Drawing.Size(198, 75);
            this.hoursIconBtn.TabIndex = 4;
            this.hoursIconBtn.Text = "Hours and Schedule";
            this.hoursIconBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.hoursIconBtn.UseVisualStyleBackColor = false;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logOutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logOutBtn.Location = new System.Drawing.Point(0, 225);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(198, 75);
            this.logOutBtn.TabIndex = 5;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // clockInLabel
            // 
            this.clockInLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clockInLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clockInLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.clockInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockInLabel.Location = new System.Drawing.Point(0, 300);
            this.clockInLabel.Name = "clockInLabel";
            this.clockInLabel.Size = new System.Drawing.Size(198, 75);
            this.clockInLabel.TabIndex = 1;
            this.clockInLabel.Text = "Clock In";
            this.clockInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.workerLeftPanel);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.workerLeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel workerLeftPanel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Button logOutBtn;
        private FontAwesome.Sharp.IconButton hoursIconBtn;
        private FontAwesome.Sharp.IconButton emailIconBtn;
        private System.Windows.Forms.Label clockInLabel;
    }
}