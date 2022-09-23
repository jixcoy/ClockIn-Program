
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerForm));
            this.workerLeftPanel = new System.Windows.Forms.Panel();
            this.clockInLabel = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.hoursIconBtn = new FontAwesome.Sharp.IconButton();
            this.emailIconBtn = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.fEmployeeProfile1 = new ClockIn.FEmployeeProfile();
            this.hoursF1 = new ClockIn.HoursF();
            this.emailF1 = new ClockIn.EmailF();
            this.workerLeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // workerLeftPanel
            // 
            this.workerLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.workerLeftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workerLeftPanel.Controls.Add(this.clockInLabel);
            this.workerLeftPanel.Controls.Add(this.logOutBtn);
            this.workerLeftPanel.Controls.Add(this.hoursIconBtn);
            this.workerLeftPanel.Controls.Add(this.emailIconBtn);
            this.workerLeftPanel.Controls.Add(this.iconButton1);
            this.workerLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.workerLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.workerLeftPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.workerLeftPanel.Name = "workerLeftPanel";
            this.workerLeftPanel.Size = new System.Drawing.Size(264, 567);
            this.workerLeftPanel.TabIndex = 0;
            // 
            // clockInLabel
            // 
            this.clockInLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.clockInLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clockInLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.clockInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(223)))), ((int)(((byte)(172)))));
            this.clockInLabel.Location = new System.Drawing.Point(0, 456);
            this.clockInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clockInLabel.Name = "clockInLabel";
            this.clockInLabel.Size = new System.Drawing.Size(262, 114);
            this.clockInLabel.TabIndex = 1;
            this.clockInLabel.Text = "Clock In";
            this.clockInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(22)))), ((int)(((byte)(47)))));
            this.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(223)))), ((int)(((byte)(172)))));
            this.logOutBtn.Location = new System.Drawing.Point(0, 342);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(262, 114);
            this.logOutBtn.TabIndex = 5;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // hoursIconBtn
            // 
            this.hoursIconBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(22)))), ((int)(((byte)(47)))));
            this.hoursIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hoursIconBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.hoursIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoursIconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursIconBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(223)))), ((int)(((byte)(172)))));
            this.hoursIconBtn.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.hoursIconBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(223)))), ((int)(((byte)(172)))));
            this.hoursIconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.hoursIconBtn.IconSize = 30;
            this.hoursIconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hoursIconBtn.Location = new System.Drawing.Point(0, 228);
            this.hoursIconBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hoursIconBtn.Name = "hoursIconBtn";
            this.hoursIconBtn.Size = new System.Drawing.Size(262, 114);
            this.hoursIconBtn.TabIndex = 4;
            this.hoursIconBtn.Text = "Hours and Schedule";
            this.hoursIconBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.hoursIconBtn.UseVisualStyleBackColor = false;
            this.hoursIconBtn.Click += new System.EventHandler(this.hoursIconBtn_Click);
            // 
            // emailIconBtn
            // 
            this.emailIconBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(22)))), ((int)(((byte)(47)))));
            this.emailIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailIconBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.emailIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailIconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailIconBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(223)))), ((int)(((byte)(172)))));
            this.emailIconBtn.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.emailIconBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(223)))), ((int)(((byte)(172)))));
            this.emailIconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.emailIconBtn.IconSize = 30;
            this.emailIconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emailIconBtn.Location = new System.Drawing.Point(0, 114);
            this.emailIconBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailIconBtn.Name = "emailIconBtn";
            this.emailIconBtn.Size = new System.Drawing.Size(262, 114);
            this.emailIconBtn.TabIndex = 3;
            this.emailIconBtn.Text = "Email";
            this.emailIconBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.emailIconBtn.UseVisualStyleBackColor = false;
            this.emailIconBtn.Click += new System.EventHandler(this.emailIconBtn_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(22)))), ((int)(((byte)(47)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(223)))), ((int)(((byte)(172)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(223)))), ((int)(((byte)(172)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(262, 114);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Profile";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // fEmployeeProfile1
            // 
            this.fEmployeeProfile1.BackColor = System.Drawing.Color.Gray;
            this.fEmployeeProfile1.Location = new System.Drawing.Point(264, 1);
            this.fEmployeeProfile1.Margin = new System.Windows.Forms.Padding(5);
            this.fEmployeeProfile1.Name = "fEmployeeProfile1";
            this.fEmployeeProfile1.Size = new System.Drawing.Size(917, 567);
            this.fEmployeeProfile1.TabIndex = 0;
            this.fEmployeeProfile1.Visible = false;
            // 
            // hoursF1
            // 
            this.hoursF1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hoursF1.Location = new System.Drawing.Point(273, 1);
            this.hoursF1.Margin = new System.Windows.Forms.Padding(5);
            this.hoursF1.Name = "hoursF1";
            this.hoursF1.Size = new System.Drawing.Size(908, 567);
            this.hoursF1.TabIndex = 2;
            // 
            // emailF1
            // 
            this.emailF1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.emailF1.Location = new System.Drawing.Point(273, 1);
            this.emailF1.Margin = new System.Windows.Forms.Padding(5);
            this.emailF1.Name = "emailF1";
            this.emailF1.Size = new System.Drawing.Size(908, 567);
            this.emailF1.TabIndex = 1;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1179, 567);
            this.Controls.Add(this.fEmployeeProfile1);
            this.Controls.Add(this.workerLeftPanel);
            this.Controls.Add(this.hoursF1);
            this.Controls.Add(this.emailF1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "WorkerForm";
            this.Text = "Clock In Employee";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
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
        private FEmployeeProfile fEmployeeProfile1;
        private EmailF emailF1;
        private HoursF hoursF1;
    }
}