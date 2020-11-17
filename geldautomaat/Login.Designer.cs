namespace geldautomaat
{
    partial class Login
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
            this.login_label = new System.Windows.Forms.Label();
            this.navbarBar = new System.Windows.Forms.Panel();
            this.banknum_label = new System.Windows.Forms.Label();
            this.tbxBanknum = new System.Windows.Forms.TextBox();
            this.pincode_label = new System.Windows.Forms.Label();
            this.tbxPincode = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
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
            // login_label
            // 
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(356, 61);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(87, 40);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "Log in";
            // 
            // navbarBar
            // 
            this.navbarBar.BackColor = System.Drawing.SystemColors.Control;
            this.navbarBar.Controls.Add(this.logo_label);
            this.navbarBar.Location = new System.Drawing.Point(0, 0);
            this.navbarBar.Name = "navbarBar";
            this.navbarBar.Size = new System.Drawing.Size(800, 58);
            this.navbarBar.TabIndex = 2;
            // 
            // banknum_label
            // 
            this.banknum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banknum_label.Location = new System.Drawing.Point(294, 101);
            this.banknum_label.Name = "banknum_label";
            this.banknum_label.Size = new System.Drawing.Size(203, 31);
            this.banknum_label.TabIndex = 3;
            this.banknum_label.Text = "Rekeningnummer";
            this.banknum_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxBanknum
            // 
            this.tbxBanknum.Location = new System.Drawing.Point(316, 135);
            this.tbxBanknum.Name = "tbxBanknum";
            this.tbxBanknum.Size = new System.Drawing.Size(162, 22);
            this.tbxBanknum.TabIndex = 4;
            // 
            // pincode_label
            // 
            this.pincode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pincode_label.Location = new System.Drawing.Point(316, 160);
            this.pincode_label.Name = "pincode_label";
            this.pincode_label.Size = new System.Drawing.Size(162, 28);
            this.pincode_label.TabIndex = 5;
            this.pincode_label.Text = "Pincode";
            this.pincode_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxPincode
            // 
            this.tbxPincode.Location = new System.Drawing.Point(316, 191);
            this.tbxPincode.Name = "tbxPincode";
            this.tbxPincode.PasswordChar = '*';
            this.tbxPincode.Size = new System.Drawing.Size(162, 22);
            this.tbxPincode.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(361, 219);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 28);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPincode);
            this.Controls.Add(this.pincode_label);
            this.Controls.Add(this.tbxBanknum);
            this.Controls.Add(this.banknum_label);
            this.Controls.Add(this.navbarBar);
            this.Controls.Add(this.login_label);
            this.Name = "Login";
            this.Text = "Log in";
            this.navbarBar.ResumeLayout(false);
            this.navbarBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label logo_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Panel navbarBar;
        private System.Windows.Forms.Label banknum_label;
        private System.Windows.Forms.TextBox tbxBanknum;
        private System.Windows.Forms.Label pincode_label;
        private System.Windows.Forms.TextBox tbxPincode;
        private System.Windows.Forms.Button btnLogin;
    }
}

