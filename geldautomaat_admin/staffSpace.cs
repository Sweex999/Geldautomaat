using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using geldautomaat_ClassLibrary;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace geldautomaat_admin
{
    public partial class staffSpace : Form
    {
        Users Users = new Users();
        int UserId = 0;
        DataTable DataTable;
        public staffSpace()
        {
            InitializeComponent();
            this.getUserData();
            DgvUsers.ReadOnly = true;
            numAccountnumber.Maximum = decimal.MaxValue;
            numPincode.Maximum = 9999m;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (this.UserId == 0)
            {
                try
                {
                    this.Users.Create((int)numAccountnumber.Value, (int)numPincode.Value, tbxFirstname.Text.Trim(), tbxLastname.Text.Trim(), (bool)this.chbBlocked.Checked);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
            else
            {
                try
                {
                    this.Users.Update(this.UserId, (int)numAccountnumber.Value, tbxFirstname.Text.Trim(), tbxLastname.Text.Trim(), (bool)this.chbBlocked.Checked);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
            this.getUserData();
        }

        private void getUserData()
        {
            this.DataTable = new DataTable();
            MySqlDataAdapter Data = this.Users.getAll();
            Data.Fill(this.DataTable);
            DgvUsers.DataSource = this.DataTable;
            DgvUsers.Columns[0].Visible = false;
        }

        /*
        * this event is triggerd when the user clicks on it
        */
        private void DgvUsers_DoubleClick(object sender, EventArgs e)
        {
            if (this.DgvUsers.CurrentRow.Index != -1)
            {
                this.UserId = (int)this.DgvUsers.CurrentRow.Cells[0].Value;
                int AccountNumber = (int)this.DgvUsers.CurrentRow.Cells[1].Value;
                string FirstName = (string)this.DgvUsers.CurrentRow.Cells[3].Value;
                string LastName = (string)this.DgvUsers.CurrentRow.Cells[4].Value;
                bool IsBlocked = (bool)this.DgvUsers.CurrentRow.Cells[5].Value;
                this.numAccountnumber.Value = AccountNumber;
                this.tbxFirstname.Text = FirstName;
                this.tbxLastname.Text = LastName;
                this.chbBlocked.Checked = IsBlocked;
            }
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            DataView Dv = new DataView();
            if (this.tbxSearchAccountnum.Text.Trim() != string.Empty && this.tbxSearchLastname.Text.Trim() != string.Empty)
            {
                Dv = new DataView(this.DataTable, String.Format("last_name = '{0}' AND account_number='{1}'", this.tbxSearchLastname.Text.Trim(), this.tbxSearchAccountnum.Text.Trim()), "last_name Desc", DataViewRowState.CurrentRows);
                this.DgvUsers.DataSource = Dv;
            }
            if (this.tbxSearchAccountnum.Text.Trim() == string.Empty && this.tbxSearchLastname.Text.Trim() != string.Empty)
            {
                Dv = new DataView(this.DataTable, String.Format("last_name = '{0}'", this.tbxSearchLastname.Text.Trim()), "last_name Desc", DataViewRowState.CurrentRows);
                this.DgvUsers.DataSource = Dv;
            }
            if (this.tbxSearchAccountnum.Text.Trim() == string.Empty && this.tbxSearchLastname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Er moet tenminste 1 veld ingevuld worden.");
                this.getUserData();
            }
            else
            {
                Dv = new DataView(this.DataTable, String.Format("account_number='{0}'", this.tbxSearchAccountnum.Text.Trim()), "last_name Desc", DataViewRowState.CurrentRows);
                this.DgvUsers.DataSource = Dv;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.getUserData();
        }
    }
}
