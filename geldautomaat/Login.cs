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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User User = new User(int.Parse(tbxBanknum.Text.Trim()));
            int LoginResult = User.Login(this.tbxPincode.Text.Trim());
            Console.WriteLine(LoginResult);
            switch (LoginResult)
            {
                case 0:
                    MessageBox.Show("Account bestaat niet, Neem alstublieft contact met ons op om een rekening te openen.");
                    break;
                case 1:
                    MessageBox.Show("U account is momenteel geblokeerd. Neem alstublieft contact met ons op.");
                    break;
                case 2:
                    MessageBox.Show("U pincode is verkeerd, probeer het opnieuw.");
                    break;
                case 3:
                    balance balance = new balance(User.AccountNumber);
                    this.Hide();
                    balance.ShowDialog();
                    this.Close();
                    break;
            }
        }
    }
}
