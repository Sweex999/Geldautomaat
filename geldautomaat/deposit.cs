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

namespace geldautomaat
{
    public partial class deposit : Form
    {
        User User;
        public deposit(int AccountNumber)
        {
            InitializeComponent();
            this.User = new User(AccountNumber);
            numDeposit.Maximum = decimal.MaxValue;
            lblNavName.Text = string.Format("{0} {1}", User.FirstName, User.LastName);
        }

        private void lblNavSaldo_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.Text);
            balance balance = new balance(this.User.AccountNumber);
            this.Hide();
            balance.ShowDialog();
            this.Close();
        }

        private void lblNavStorten_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.Text);
            deposit deposit = new deposit(this.User.AccountNumber);
            this.Hide();
            deposit.ShowDialog();
            this.Close();
        }

        private void lblNavOpnemen_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.Text);
            withdraw withdraw = new withdraw(this.User.AccountNumber);
            this.Hide();
            withdraw.ShowDialog();
            this.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (numDeposit.Value != 0.00M)
            {
                this.User.Deposit((double)numDeposit.Value);
                MessageBox.Show("Het bedrag is toegevoegd aan uw rekening");
            }
            else
            {
                MessageBox.Show("Het minimale bedrag is € 0,01");
            }
            Console.WriteLine(this.Text);
            balance balance = new balance(this.User.AccountNumber);
            this.Hide();
            balance.ShowDialog();
            this.Close();
        }
    }
}
