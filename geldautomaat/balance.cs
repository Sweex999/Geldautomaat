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
using MySql.Data.MySqlClient;

namespace geldautomaat
{
    public partial class balance : Form
    {
        User User;
        public balance(int AccountNumber)
        {
            InitializeComponent();
            this.User = new User(AccountNumber);
            lblNavName.Text = string.Format("{0} {1}", User.FirstName, User.LastName);
            DataTable DataTable = new DataTable();
            MySqlDataAdapter Data = User.getAllTransaction();
            Data.Fill(DataTable);
            DgvLastTransactions.DataSource = DataTable;
            DgvLastTransactions.ReadOnly = true;
            tbxBalance.Text = string.Format("€ {0}", this.User.Balance);
        }

        private void lblNavSaldo_Click(object sender, EventArgs e)
        {
            balance balance = new balance(this.User.AccountNumber);
            this.Hide();
            balance.ShowDialog();
            this.Close();
        }

        private void lblNavStorten_Click(object sender, EventArgs e)
        {
            deposit deposit = new deposit(this.User.AccountNumber);
            this.Hide();
            deposit.ShowDialog();
            this.Close();
        }

        private void lblNavOpnemen_Click(object sender, EventArgs e)
        {
            withdraw withdraw = new withdraw(this.User.AccountNumber);
            this.Hide();
            withdraw.ShowDialog();
            this.Close();
        }

        private void balance_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }
    }
}
