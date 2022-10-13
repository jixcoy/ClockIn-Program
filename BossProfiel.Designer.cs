
namespace ClockIn
{
    partial class BossProfiel
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
            this.RoleLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.BossUserIcn = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BossUserIcn)).BeginInit();
            this.SuspendLayout();
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.Location = new System.Drawing.Point(436, 283);
            this.RoleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(65, 29);
            this.RoleLabel.TabIndex = 7;
            this.RoleLabel.Text = "Role";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(436, 245);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(134, 29);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "UserName";
            // 
            // BossUserIcn
            // 
            this.BossUserIcn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.BossUserIcn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.BossUserIcn.IconColor = System.Drawing.Color.White;
            this.BossUserIcn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BossUserIcn.IconSize = 94;
            this.BossUserIcn.Location = new System.Drawing.Point(329, 230);
            this.BossUserIcn.Margin = new System.Windows.Forms.Padding(4);
            this.BossUserIcn.Name = "BossUserIcn";
            this.BossUserIcn.Size = new System.Drawing.Size(99, 94);
            this.BossUserIcn.TabIndex = 5;
            this.BossUserIcn.TabStop = false;
            // 
            // BossProfiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.BossUserIcn);
            this.Name = "BossProfiel";
            this.Size = new System.Drawing.Size(908, 567);
            this.Load += new System.EventHandler(this.BossProfiel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BossUserIcn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private FontAwesome.Sharp.IconPictureBox BossUserIcn;
    }
}
