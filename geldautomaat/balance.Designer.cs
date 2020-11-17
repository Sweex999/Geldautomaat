namespace geldautomaat
{
    partial class balance
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
            this.lblNavOpnemen = new System.Windows.Forms.Label();
            this.lblNavSaldo = new System.Windows.Forms.Label();
            this.lblNavStorten = new System.Windows.Forms.Label();
            this.lblNavName = new System.Windows.Forms.Label();
            this.balance_label = new System.Windows.Forms.Label();
            this.transaction_label = new System.Windows.Forms.Label();
            this.tbxBalance = new System.Windows.Forms.TextBox();
            this.DgvLastTransactions = new System.Windows.Forms.DataGridView();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.navbarBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLastTransactions)).BeginInit();
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
            this.navbarBar.Controls.Add(this.lblNavOpnemen);
            this.navbarBar.Controls.Add(this.lblNavSaldo);
            this.navbarBar.Controls.Add(this.lblNavStorten);
            this.navbarBar.Controls.Add(this.lblNavName);
            this.navbarBar.Controls.Add(this.logo_label);
            this.navbarBar.Location = new System.Drawing.Point(1, 1);
            this.navbarBar.Name = "navbarBar";
            this.navbarBar.Size = new System.Drawing.Size(800, 58);
            this.navbarBar.TabIndex = 3;
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
            // balance_label
            // 
            this.balance_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.balance_label.Location = new System.Drawing.Point(320, 62);
            this.balance_label.Name = "balance_label";
            this.balance_label.Size = new System.Drawing.Size(162, 40);
            this.balance_label.TabIndex = 4;
            this.balance_label.Text = "Saldo";
            this.balance_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // transaction_label
            // 
            this.transaction_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_label.Location = new System.Drawing.Point(268, 130);
            this.transaction_label.Name = "transaction_label";
            this.transaction_label.Size = new System.Drawing.Size(273, 40);
            this.transaction_label.TabIndex = 5;
            this.transaction_label.Text = "Laatste transacties";
            this.transaction_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxBalance
            // 
            this.tbxBalance.Location = new System.Drawing.Point(320, 105);
            this.tbxBalance.Name = "tbxBalance";
            this.tbxBalance.ReadOnly = true;
            this.tbxBalance.Size = new System.Drawing.Size(162, 22);
            this.tbxBalance.TabIndex = 6;
            // 
            // DgvLastTransactions
            // 
            this.DgvLastTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLastTransactions.Location = new System.Drawing.Point(229, 173);
            this.DgvLastTransactions.Name = "DgvLastTransactions";
            this.DgvLastTransactions.RowHeadersWidth = 51;
            this.DgvLastTransactions.RowTemplate.Height = 24;
            this.DgvLastTransactions.Size = new System.Drawing.Size(343, 150);
            this.DgvLastTransactions.TabIndex = 7;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1, 62);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(82, 26);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log uit";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.DgvLastTransactions);
            this.Controls.Add(this.tbxBalance);
            this.Controls.Add(this.transaction_label);
            this.Controls.Add(this.balance_label);
            this.Controls.Add(this.navbarBar);
            this.Name = "balance";
            this.Text = "Saldo";
            this.Load += new System.EventHandler(this.balance_Load);
            this.navbarBar.ResumeLayout(false);
            this.navbarBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLastTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logo_label;
        private System.Windows.Forms.Panel navbarBar;
        private System.Windows.Forms.Label balance_label;
        private System.Windows.Forms.Label transaction_label;
        private System.Windows.Forms.TextBox tbxBalance;
        private System.Windows.Forms.Label lblNavOpnemen;
        private System.Windows.Forms.Label lblNavSaldo;
        private System.Windows.Forms.Label lblNavStorten;
        private System.Windows.Forms.Label lblNavName;
        private System.Windows.Forms.DataGridView DgvLastTransactions;
        private System.Windows.Forms.Button btnLogOut;
    }
}