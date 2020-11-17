namespace geldautomaat
{
    partial class withdraw
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
            this.navbarBar = new System.Windows.Forms.Panel();
            this.lblNavOpnemen = new System.Windows.Forms.Label();
            this.lblNavSaldo = new System.Windows.Forms.Label();
            this.lblNavStorten = new System.Windows.Forms.Label();
            this.lblNavName = new System.Windows.Forms.Label();
            this.logo_label = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.withdrawSmall_label = new System.Windows.Forms.Label();
            this.withdraw_label = new System.Windows.Forms.Label();
            this.lblTransactionCount = new System.Windows.Forms.Label();
            this.numWithdraw = new System.Windows.Forms.NumericUpDown();
            this.navbarBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWithdraw)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarBar
            // 
            this.navbarBar.BackColor = System.Drawing.SystemColors.Control;
            this.navbarBar.Controls.Add(this.lblNavOpnemen);
            this.navbarBar.Controls.Add(this.lblNavSaldo);
            this.navbarBar.Controls.Add(this.lblNavStorten);
            this.navbarBar.Controls.Add(this.lblNavName);
            this.navbarBar.Controls.Add(this.logo_label);
            this.navbarBar.Location = new System.Drawing.Point(1, 1);
            this.navbarBar.Name = "navbarBar";
            this.navbarBar.Size = new System.Drawing.Size(800, 58);
            this.navbarBar.TabIndex = 4;
            // 
            // lblNavOpnemen
            // 
            this.lblNavOpnemen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavOpnemen.Location = new System.Drawing.Point(564, 20);
            this.lblNavOpnemen.Name = "lblNavOpnemen";
            this.lblNavOpnemen.Size = new System.Drawing.Size(117, 23);
            this.lblNavOpnemen.TabIndex = 5;
            this.lblNavOpnemen.Text = "Opnemen";
            this.lblNavOpnemen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNavOpnemen.Click += new System.EventHandler(this.lblNavOpnemen_Click);
            // 
            // lblNavSaldo
            // 
            this.lblNavSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavSaldo.Location = new System.Drawing.Point(389, 20);
            this.lblNavSaldo.Name = "lblNavSaldo";
            this.lblNavSaldo.Size = new System.Drawing.Size(92, 23);
            this.lblNavSaldo.TabIndex = 4;
            this.lblNavSaldo.Text = "Saldo";
            this.lblNavSaldo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNavSaldo.Click += new System.EventHandler(this.lblNavSaldo_Click);
            // 
            // lblNavStorten
            // 
            this.lblNavStorten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavStorten.Location = new System.Drawing.Point(471, 20);
            this.lblNavStorten.Name = "lblNavStorten";
            this.lblNavStorten.Size = new System.Drawing.Size(100, 23);
            this.lblNavStorten.TabIndex = 3;
            this.lblNavStorten.Text = "Storten";
            this.lblNavStorten.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNavStorten.Click += new System.EventHandler(this.lblNavStorten_Click);
            // 
            // lblNavName
            // 
            this.lblNavName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavName.Location = new System.Drawing.Point(687, 20);
            this.lblNavName.Name = "lblNavName";
            this.lblNavName.Size = new System.Drawing.Size(107, 23);
            this.lblNavName.TabIndex = 2;
            this.lblNavName.Text = "Archibald";
            this.lblNavName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(359, 179);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(87, 28);
            this.btnWithdraw.TabIndex = 12;
            this.btnWithdraw.Text = "Opnemen";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // withdrawSmall_label
            // 
            this.withdrawSmall_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawSmall_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.withdrawSmall_label.Location = new System.Drawing.Point(321, 102);
            this.withdrawSmall_label.Name = "withdrawSmall_label";
            this.withdrawSmall_label.Size = new System.Drawing.Size(162, 29);
            this.withdrawSmall_label.TabIndex = 10;
            this.withdrawSmall_label.Text = "Bedrag";
            this.withdrawSmall_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // withdraw_label
            // 
            this.withdraw_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.withdraw_label.Location = new System.Drawing.Point(320, 62);
            this.withdraw_label.Name = "withdraw_label";
            this.withdraw_label.Size = new System.Drawing.Size(162, 40);
            this.withdraw_label.TabIndex = 9;
            this.withdraw_label.Text = "Opnemen";
            this.withdraw_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTransactionCount
            // 
            this.lblTransactionCount.AutoSize = true;
            this.lblTransactionCount.Location = new System.Drawing.Point(306, 159);
            this.lblTransactionCount.Name = "lblTransactionCount";
            this.lblTransactionCount.Size = new System.Drawing.Size(201, 17);
            this.lblTransactionCount.TabIndex = 13;
            this.lblTransactionCount.Text = "Transacties over vandaag: 3/3";
            // 
            // numWithdraw
            // 
            this.numWithdraw.DecimalPlaces = 2;
            this.numWithdraw.Location = new System.Drawing.Point(309, 134);
            this.numWithdraw.Name = "numWithdraw";
            this.numWithdraw.Size = new System.Drawing.Size(191, 22);
            this.numWithdraw.TabIndex = 14;
            // 
            // withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numWithdraw);
            this.Controls.Add(this.lblTransactionCount);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.withdrawSmall_label);
            this.Controls.Add(this.withdraw_label);
            this.Controls.Add(this.navbarBar);
            this.Name = "withdraw";
            this.Text = "withdraw";
            this.navbarBar.ResumeLayout(false);
            this.navbarBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWithdraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navbarBar;
        private System.Windows.Forms.Label lblNavOpnemen;
        private System.Windows.Forms.Label lblNavSaldo;
        private System.Windows.Forms.Label lblNavStorten;
        private System.Windows.Forms.Label lblNavName;
        private System.Windows.Forms.Label logo_label;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label withdrawSmall_label;
        private System.Windows.Forms.Label withdraw_label;
        private System.Windows.Forms.Label lblTransactionCount;
        private System.Windows.Forms.NumericUpDown numWithdraw;
    }
}