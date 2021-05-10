using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_PROJEKT_NR_1
{
    public partial class Create_Login : Form
    {
        public Create_Login()
        {
            InitializeComponent();
            User admin = new User("admin", "admin1");
            User.AddUser(admin);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            if (textBoxUserName.Text.Contains(" ") || string.IsNullOrWhiteSpace(textBoxUserName.Text))
            {
                MessageBox.Show("Login nie może zawierać spacji!");
            }
            else
            {
                if (!textBoxRePassword.Text.Contains(" "))
                {
                    if (textBoxUserName.TextLength > 3)
                    {
                        if (textBoxRePassword.TextLength >= 6)
                        {
                            if (textBoxRePassword.Text == textBoxReRPassword.Text)
                            {
                                if (checkBoxRODO.Checked)
                                {
                                    if (!User.Uzyszkodnicy.ContainsKey(textBoxUserName.Text))
                                    {
                                        User.AddUser(new User(textBoxUserName.Text, textBoxRePassword.Text));
                                        MessageBox.Show("Dodano użytkownika!!!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Istnieje już taki użytkownik!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Nie zaakceptowano RODO!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Hasło nie jest identyczne!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Za krótkie hasło!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Za krótki login!");
                    }
                }

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) || textBoxLogin.Text.Contains(" "))
            {
                MessageBox.Show("Login nie może zawierać spacji!");
            }
            else
            {
                if (textBoxLogin.TextLength > 3)
                {
                    if (textBoxLoginPassword.TextLength >= 6)
                    {
                        if (User.Uzyszkodnicy.ContainsKey(textBoxLogin.Text))
                        {
                            if (User.Uzyszkodnicy.ContainsKey(textBoxLogin.Text) && User.Uzyszkodnicy.ContainsValue(textBoxLoginPassword.Text))
                            {
                                MessageBox.Show($"Zalogowano użytkownika: {textBoxLogin.Text}!");
                            }
                            else
                            {
                                MessageBox.Show("Błędne hasło!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nie ma takiego użytkownika!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Za krótkie hasło!");
                    }
                }
                else
                {
                    MessageBox.Show("Za krótki login!");
                }
            }
        }
    }

}


