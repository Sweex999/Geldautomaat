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
    public partial class withdraw : Form
    {
        User User;
        public withdraw(int AccountNumber)
        {
            InitializeComponent();
            this.User = new User(AccountNumber);
            lblTransactionCount.Text = string.Format("Transacties over vandaag: {0} / 3", 3 - this.User.WithdrawCount);
            numWithdraw.Maximum = 1000M;
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

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (numWithdraw.Value != 0.00M)
            {
                if (this.User.Balance - (double)numWithdraw.Value < 0)
                {
                    MessageBox.Show("Het is niet mogelijk in het rood te staan.");
                }
                else
                {
                    if ((double)numWithdraw.Value > 500)
                    {
                        MessageBox.Show("Het bedrag mag niet hoger zijn dan €500,00");
                    }
                    else
                    {
                        this.User.Withdraw((double)-(numWithdraw.Value));
                        MessageBox.Show("Het bedrag is van uw rekening afgehaald.");
                        lblTransactionCount.Text = string.Format("Transacties over vandaag: {0} / 3", 3 - this.User.WithdrawCount);
                        balance balance = new balance(this.User.AccountNumber);
                        this.Hide();
                        balance.ShowDialog();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Het minimale bedrag is € 0,01");
            }
        }

    }
}
