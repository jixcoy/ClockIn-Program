namespace ClockIn
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clockInLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconStartButton = new FontAwesome.Sharp.IconButton();
            this.logInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clockInLabel
            // 
            this.clockInLabel.AutoSize = true;
            this.clockInLabel.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockInLabel.ForeColor = System.Drawing.Color.White;
            this.clockInLabel.Location = new System.Drawing.Point(500, 158);
            this.clockInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clockInLabel.Name = "clockInLabel";
            this.clockInLabel.Size = new System.Drawing.Size(172, 47);
            this.clockInLabel.TabIndex = 0;
            this.clockInLabel.Text = "Clock In";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(564, 375);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 36);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(500, 375);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // iconStartButton
            // 
            this.iconStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconStartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconStartButton.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconStartButton.IconColor = System.Drawing.Color.White;
            this.iconStartButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconStartButton.Location = new System.Drawing.Point(0, 0);
            this.iconStartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconStartButton.Name = "iconStartButton";
            this.iconStartButton.Size = new System.Drawing.Size(1179, 567);
            this.iconStartButton.TabIndex = 0;
            this.iconStartButton.UseVisualStyleBackColor = false;
            this.iconStartButton.Click += new System.EventHandler(this.iconStartButton_Click);
            // 
            // logInBtn
            // 
            this.logInBtn.Location = new System.Drawing.Point(509, 427);
            this.logInBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(193, 43);
            this.logInBtn.TabIndex = 3;
            this.logInBtn.Text = "Enter";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1179, 567);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clockInLabel);
            this.Controls.Add(this.iconStartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Clock In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clockInLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconStartButton;
        private System.Windows.Forms.Button logInBtn;
    }
}

