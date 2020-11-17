namespace geldautomaat
{
    partial class deposit
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
            this.deposit_label = new System.Windows.Forms.Label();
            this.depositSmall_label = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.numDeposit = new System.Windows.Forms.NumericUpDown();
            this.navbarBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeposit)).BeginInit();
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
            this.navbarBar.Location = new System.Drawing.Point(0, 0);
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
            // deposit_label
            // 
            this.deposit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deposit_label.Location = new System.Drawing.Point(319, 61);
            this.deposit_label.Name = "deposit_label";
            this.deposit_label.Size = new System.Drawing.Size(162, 40);
            this.deposit_label.TabIndex = 5;
            this.deposit_label.Text = "Storten";
            this.deposit_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // depositSmall_label
            // 
            this.depositSmall_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositSmall_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.depositSmall_label.Location = new System.Drawing.Point(320, 101);
            this.depositSmall_label.Name = "depositSmall_label";
            this.depositSmall_label.Size = new System.Drawing.Size(162, 29);
            this.depositSmall_label.TabIndex = 6;
            this.depositSmall_label.Text = "Bedrag";
            this.depositSmall_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(365, 161);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 28);
            this.btnDeposit.TabIndex = 8;
            this.btnDeposit.Text = "Storten";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // numDeposit
            // 
            this.numDeposit.DecimalPlaces = 2;
            this.numDeposit.Location = new System.Drawing.Point(314, 133);
            this.numDeposit.Name = "numDeposit";
            this.numDeposit.Size = new System.Drawing.Size(177, 22);
            this.numDeposit.TabIndex = 9;
            // 
            // deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numDeposit);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.depositSmall_label);
            this.Controls.Add(this.deposit_label);
            this.Controls.Add(this.navbarBar);
            this.Name = "deposit";
            this.Text = "Storten";
            this.navbarBar.ResumeLayout(false);
            this.navbarBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeposit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbarBar;
        private System.Windows.Forms.Label lblNavOpnemen;
        private System.Windows.Forms.Label lblNavSaldo;
        private System.Windows.Forms.Label lblNavStorten;
        private System.Windows.Forms.Label lblNavName;
        private System.Windows.Forms.Label logo_label;
        private System.Windows.Forms.Label deposit_label;
        private System.Windows.Forms.Label depositSmall_label;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.NumericUpDown numDeposit;
    }
}