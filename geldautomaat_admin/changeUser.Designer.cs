namespace geldautomaat_admin
{
    partial class changeUser
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
            this.logo_label = new System.Windows.Forms.Label();
            this.navbarBar = new System.Windows.Forms.Panel();
            this.changeUser_label = new System.Windows.Forms.Label();
            this.navbarBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo_label
            // 
            this.logo_label.AutoSize = true;
            this.logo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_label.Location = new System.Drawing.Point(12, 9);
            this.logo_label.Name = "logo_label";
            this.logo_label.Size = new System.Drawing.Size(162, 39);
            this.logo_label.TabIndex = 1;
            this.logo_label.Text = "INB Bank";
            // 
            // navbarBar
            // 
            this.navbarBar.BackColor = System.Drawing.SystemColors.Control;
            this.navbarBar.Controls.Add(this.logo_label);
            this.navbarBar.Location = new System.Drawing.Point(0, 1);
            this.navbarBar.Name = "navbarBar";
            this.navbarBar.Size = new System.Drawing.Size(800, 58);
            this.navbarBar.TabIndex = 4;
            // 
            // changeUser_label
            // 
            this.changeUser_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeUser_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changeUser_label.Location = new System.Drawing.Point(261, 62);
            this.changeUser_label.Name = "changeUser_label";
            this.changeUser_label.Size = new System.Drawing.Size(279, 40);
            this.changeUser_label.TabIndex = 10;
            this.changeUser_label.Text = "Gebruiker veranderen";
            this.changeUser_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // changeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeUser_label);
            this.Controls.Add(this.navbarBar);
            this.Name = "changeUser";
            this.Text = "changeUser";
            this.navbarBar.ResumeLayout(false);
            this.navbarBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label logo_label;
        private System.Windows.Forms.Panel navbarBar;
        private System.Windows.Forms.Label changeUser_label;
    }
}