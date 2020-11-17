namespace geldautomaat_admin
{
    partial class staffSpace
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
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.staffSpaceFirstname_label = new System.Windows.Forms.Label();
            this.staffSpaceAdd_label = new System.Windows.Forms.Label();
            this.tbxFirstname = new System.Windows.Forms.TextBox();
            this.tbxLastname = new System.Windows.Forms.TextBox();
            this.staffSpaceLastname_label = new System.Windows.Forms.Label();
            this.staffSpaceAccountnumber_label = new System.Windows.Forms.Label();
            this.staffSpacePincode_label = new System.Windows.Forms.Label();
            this.staffSpaceSearch_label = new System.Windows.Forms.Label();
            this.staffSpaceAccountnumberSearch_label = new System.Windows.Forms.Label();
            this.tbxSearchLastname = new System.Windows.Forms.TextBox();
            this.tbxSearchAccountnum = new System.Windows.Forms.TextBox();
            this.staffSpaceLastnameSearch_label = new System.Windows.Forms.Label();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.chbBlocked = new System.Windows.Forms.CheckBox();
            this.numAccountnumber = new System.Windows.Forms.NumericUpDown();
            this.numPincode = new System.Windows.Forms.NumericUpDown();
            this.btnBack = new System.Windows.Forms.Button();
            this.navbarBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccountnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPincode)).BeginInit();
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
            this.navbarBar.Location = new System.Drawing.Point(1, 0);
            this.navbarBar.Name = "navbarBar";
            this.navbarBar.Size = new System.Drawing.Size(800, 58);
            this.navbarBar.TabIndex = 3;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(362, 303);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(105, 28);
            this.btnAddAccount.TabIndex = 12;
            this.btnAddAccount.Text = "Voeg toe";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // staffSpaceFirstname_label
            // 
            this.staffSpaceFirstname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffSpaceFirstname_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.staffSpaceFirstname_label.Location = new System.Drawing.Point(240, 101);
            this.staffSpaceFirstname_label.Name = "staffSpaceFirstname_label";
            this.staffSpaceFirstname_label.Size = new System.Drawing.Size(162, 29);
            this.staffSpaceFirstname_label.TabIndex = 10;
            this.staffSpaceFirstname_label.Text = "Voornaam";
            this.staffSpaceFirstname_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // staffSpaceAdd_label
            // 
            this.staffSpaceAdd_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffSpaceAdd_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.staffSpaceAdd_label.Location = new System.Drawing.Point(285, 61);
            this.staffSpaceAdd_label.Name = "staffSpaceAdd_label";
            this.staffSpaceAdd_label.Size = new System.Drawing.Size(258, 40);
            this.staffSpaceAdd_label.TabIndex = 9;
            this.staffSpaceAdd_label.Text = "Voeg account toe";
            this.staffSpaceAdd_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxFirstname
            // 
            this.tbxFirstname.Location = new System.Drawing.Point(240, 133);
            this.tbxFirstname.Name = "tbxFirstname";
            this.tbxFirstname.Size = new System.Drawing.Size(162, 22);
            this.tbxFirstname.TabIndex = 13;
            // 
            // tbxLastname
            // 
            this.tbxLastname.Location = new System.Drawing.Point(408, 133);
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(162, 22);
            this.tbxLastname.TabIndex = 14;
            // 
            // staffSpaceLastname_label
            // 
            this.staffSpaceLastname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffSpaceLastname_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.staffSpaceLastname_label.Location = new System.Drawing.Point(408, 101);
            this.staffSpaceLastname_label.Name = "staffSpaceLastname_label";
            this.staffSpaceLastname_label.Size = new System.Drawing.Size(162, 29);
            this.staffSpaceLastname_label.TabIndex = 16;
            this.staffSpaceLastname_label.Text = "Achternaam";
            this.staffSpaceLastname_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // staffSpaceAccountnumber_label
            // 
            this.staffSpaceAccountnumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffSpaceAccountnumber_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.staffSpaceAccountnumber_label.Location = new System.Drawing.Point(335, 158);
            this.staffSpaceAccountnumber_label.Name = "staffSpaceAccountnumber_label";
            this.staffSpaceAccountnumber_label.Size = new System.Drawing.Size(162, 29);
            this.staffSpaceAccountnumber_label.TabIndex = 17;
            this.staffSpaceAccountnumber_label.Text = "Rekeningnummer";
            this.staffSpaceAccountnumber_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // staffSpacePincode_label
            // 
            this.staffSpacePincode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffSpacePincode_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.staffSpacePincode_label.Location = new System.Drawing.Point(335, 215);
            this.staffSpacePincode_label.Name = "staffSpacePincode_label";
            this.staffSpacePincode_label.Size = new System.Drawing.Size(162, 29);
            this.staffSpacePincode_label.TabIndex = 19;
            this.staffSpacePincode_label.Text = "Pincode";
            this.staffSpacePincode_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // staffSpaceSearch_label
            // 
            this.staffSpaceSearch_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffSpaceSearch_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.staffSpaceSearch_label.Location = new System.Drawing.Point(285, 348);
            this.staffSpaceSearch_label.Name = "staffSpaceSearch_label";
            this.staffSpaceSearch_label.Size = new System.Drawing.Size(258, 40);
            this.staffSpaceSearch_label.TabIndex = 21;
            this.staffSpaceSearch_label.Text = "Zoek accounts";
            this.staffSpaceSearch_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // staffSpaceAccountnumberSearch_label
            // 
            this.staffSpaceAccountnumberSearch_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffSpaceAccountnumberSearch_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.staffSpaceAccountnumberSearch_label.Location = new System.Drawing.Point(408, 388);
            this.staffSpaceAccountnumberSearch_label.Name = "staffSpaceAccountnumberSearch_label";
            this.staffSpaceAccountnumberSearch_label.Size = new System.Drawing.Size(162, 29);
            this.staffSpaceAccountnumberSearch_label.TabIndex = 25;
            this.staffSpaceAccountnumberSearch_label.Text = "Rekeningnummer";
            this.staffSpaceAccountnumberSearch_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxSearchLastname
            // 
            this.tbxSearchLastname.Location = new System.Drawing.Point(240, 420);
            this.tbxSearchLastname.Name = "tbxSearchLastname";
            this.tbxSearchLastname.Size = new System.Drawing.Size(162, 22);
            this.tbxSearchLastname.TabIndex = 24;
            // 
            // tbxSearchAccountnum
            // 
            this.tbxSearchAccountnum.Location = new System.Drawing.Point(408, 420);
            this.tbxSearchAccountnum.Name = "tbxSearchAccountnum";
            this.tbxSearchAccountnum.Size = new System.Drawing.Size(162, 22);
            this.tbxSearchAccountnum.TabIndex = 23;
            // 
            // staffSpaceLastnameSearch_label
            // 
            this.staffSpaceLastnameSearch_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffSpaceLastnameSearch_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.staffSpaceLastnameSearch_label.Location = new System.Drawing.Point(240, 388);
            this.staffSpaceLastnameSearch_label.Name = "staffSpaceLastnameSearch_label";
            this.staffSpaceLastnameSearch_label.Size = new System.Drawing.Size(162, 29);
            this.staffSpaceLastnameSearch_label.TabIndex = 22;
            this.staffSpaceLastnameSearch_label.Text = "Achternaam";
            this.staffSpaceLastnameSearch_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.Location = new System.Drawing.Point(327, 448);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(75, 28);
            this.btnSearchAccount.TabIndex = 26;
            this.btnSearchAccount.Text = "Zoeken";
            this.btnSearchAccount.UseVisualStyleBackColor = true;
            this.btnSearchAccount.Click += new System.EventHandler(this.btnSearchAccount_Click);
            // 
            // DgvUsers
            // 
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsers.Location = new System.Drawing.Point(34, 497);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.RowHeadersWidth = 51;
            this.DgvUsers.RowTemplate.Height = 24;
            this.DgvUsers.Size = new System.Drawing.Size(736, 413);
            this.DgvUsers.TabIndex = 28;
            this.DgvUsers.DoubleClick += new System.EventHandler(this.DgvUsers_DoubleClick);
            // 
            // chbBlocked
            // 
            this.chbBlocked.AutoSize = true;
            this.chbBlocked.Location = new System.Drawing.Point(362, 276);
            this.chbBlocked.Name = "chbBlocked";
            this.chbBlocked.Size = new System.Drawing.Size(111, 21);
            this.chbBlocked.TabIndex = 29;
            this.chbBlocked.Text = "Geblokkeerd";
            this.chbBlocked.UseVisualStyleBackColor = true;
            // 
            // numAccountnumber
            // 
            this.numAccountnumber.Location = new System.Drawing.Point(326, 190);
            this.numAccountnumber.Name = "numAccountnumber";
            this.numAccountnumber.Size = new System.Drawing.Size(183, 22);
            this.numAccountnumber.TabIndex = 30;
            // 
            // numPincode
            // 
            this.numPincode.Location = new System.Drawing.Point(326, 238);
            this.numPincode.Name = "numPincode";
            this.numPincode.Size = new System.Drawing.Size(183, 22);
            this.numPincode.TabIndex = 31;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(408, 448);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 27);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // staffSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 908);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.numPincode);
            this.Controls.Add(this.numAccountnumber);
            this.Controls.Add(this.chbBlocked);
            this.Controls.Add(this.DgvUsers);
            this.Controls.Add(this.btnSearchAccount);
            this.Controls.Add(this.staffSpaceAccountnumberSearch_label);
            this.Controls.Add(this.tbxSearchLastname);
            this.Controls.Add(this.tbxSearchAccountnum);
            this.Controls.Add(this.staffSpaceLastnameSearch_label);
            this.Controls.Add(this.staffSpaceSearch_label);
            this.Controls.Add(this.staffSpacePincode_label);
            this.Controls.Add(this.staffSpaceAccountnumber_label);
            this.Controls.Add(this.staffSpaceLastname_label);
            this.Controls.Add(this.tbxLastname);
            this.Controls.Add(this.tbxFirstname);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.staffSpaceFirstname_label);
            this.Controls.Add(this.staffSpaceAdd_label);
            this.Controls.Add(this.navbarBar);
            this.Name = "staffSpace";
            this.Text = "staffSpace";
            this.navbarBar.ResumeLayout(false);
            this.navbarBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccountnumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPincode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logo_label;
        private System.Windows.Forms.Panel navbarBar;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox tbxInfix;
        private System.Windows.Forms.Label staffSpaceFirstname_label;
        private System.Windows.Forms.Label staffSpaceAdd_label;
        private System.Windows.Forms.TextBox tbxFirstname;
        private System.Windows.Forms.TextBox tbxLastname;
        private System.Windows.Forms.Label staffSpaceInfix_label;
        private System.Windows.Forms.Label staffSpaceLastname_label;
        private System.Windows.Forms.Label staffSpaceAccountnumber_label;
        private System.Windows.Forms.TextBox tbxAccountnumber;
        private System.Windows.Forms.Label staffSpacePincode_label;
        private System.Windows.Forms.TextBox tbxPincode;
        private System.Windows.Forms.Label staffSpaceSearch_label;
        private System.Windows.Forms.Label staffSpaceAccountnumberSearch_label;
        private System.Windows.Forms.TextBox tbxSearchLastname;
        private System.Windows.Forms.TextBox tbxSearchAccountnum;
        private System.Windows.Forms.Label staffSpaceLastnameSearch_label;
        private System.Windows.Forms.Button btnSearchAccount;
        private System.Windows.Forms.RichTextBox rtbxShowAccounts;
        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.CheckBox chbBlocked;
        private System.Windows.Forms.NumericUpDown numAccountnumber;
        private System.Windows.Forms.NumericUpDown numPincode;
        private System.Windows.Forms.Button btnBack;
    }
}