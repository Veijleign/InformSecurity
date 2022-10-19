using ShifrLab1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShifrLab1
{
    

    public partial class EnterWindow : Form
    {
        public static string login;
        private int _cntPasswordEnter = 0;

        public EnterWindow()
        {
            InitializeComponent();
            Password.Text = "";
            Password.PasswordChar = '*'; // for hiding password
            NewPasswordCheck.PasswordChar = '*';
            OldPassword.PasswordChar = '*';

            EnterKeyWindow key = new EnterKeyWindow();
            key.Show();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            login = Login.Text;
            bool logCheck = false;

            foreach (var user in Program.dbController._listOfData)
            {
                if (login == user.login)
                {
                    if (user.isBlocked)
                    {
                        MessageBox.Show("Вы заблокированы. Обратитесь к администратору");
                        Application.Exit();
                    }
                    if (user.password =="" && Password.Text != "" && OldPassword.Visible==false) // the second can't be needed
                    {
                        MessageBox.Show("Пароль неверный"); // the DataBase was just created, the passsword must be empty
                        return;
                    }

                    logCheck = true;
                    if (user.password == "")
                    {
                        if (!repeatPassword.Visible)
                        {
                            MessageBox.Show("Установите пароль для входа в систему");
                            repeatPassword.Visible = true;
                            NewPasswordCheck.Visible = true;
                            OldPassword.Visible = true;
                            Oldpasswordtext.Visible = true; // changed places
                            return;
                        }
                        if (Password.Text == NewPasswordCheck.Text && Password.Text != "")
                        {
                            if (user.passwordIsLimited)
                            {
                                if (!PasswordLimit.CheckLimit(Password.Text))
                                {
                                    MessageBox.Show("Ваш пароль не подходит под установленное ограничение на пароли.\n Смените его или обратитесь к администратору");
                                    repeatPassword.Visible = true;
                                    NewPasswordCheck.Visible = true;
                                    OldPassword.Visible = true;
                                    Oldpasswordtext.Visible = true; // changed places
                                    return;
                                }
                                else if (NewPasswordCheck.Visible)
                                {
                                    if (Password.Text == NewPasswordCheck.Text && Password.Text != "")
                                    {
                                        if (!PasswordLimit.CheckLimit(Password.Text))
                                        {
                                            MessageBox.Show("Пароль не подходит под установленное ограничение на пароли.");
                                            return;
                                        }
                                        else
                                        {
                                            if (OldPassword.Text != user.password)
                                            {
                                                MessageBox.Show("Старый пароль не совпадает");
                                                return;
                                            }
                                            user.password = Password.Text;
                                            Program.dbController.SaveData();
                                            repeatPassword.Visible = false;
                                            NewPasswordCheck.Visible = false;
                                            OldPassword.Visible = false;
                                            Oldpasswordtext.Visible = false;
                                            Password.Text = "";
                                            Login.Text = "";
                                            MessageBox.Show("Пароль изменён");
                                            return;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (OldPassword.Text != user.password)
                                {
                                    MessageBox.Show("Старый пароль не совпадает");
                                    return;
                                }
                                user.password = Password.Text;
                                Program.dbController.SaveData();
                                repeatPassword.Visible = false;
                                NewPasswordCheck.Visible = false;
                                OldPassword.Visible = false;
                                Oldpasswordtext.Visible = false;
                                Password.Text = "";
                                Login.Text = "";
                                MessageBox.Show("Пароль изменён");
                                return;
                            }
                        }
                        else
                        {
                            logCheck = false;
                        }
                    }
                    else
                    {
                        if (user.passwordIsLimited)
                        {
                            if (!PasswordLimit.CheckLimit(Password.Text))
                            {
                                MessageBox.Show("Ваш пароль не подходит под установленное ограничение на пароли.\n Смените его или обратитесь к администратору");
                                repeatPassword.Visible = true;
                                NewPasswordCheck.Visible = true;
                                OldPassword.Visible = true;
                                Oldpasswordtext.Visible = true;
                                return;
                            }
                            else if (NewPasswordCheck.Visible)
                            {
                                if (Password.Text == NewPasswordCheck.Text && Password.Text != "")
                                {
                                    if (!PasswordLimit.CheckLimit(Password.Text))
                                    {
                                        MessageBox.Show("Пароль не подходит под установленное ограничение на пароли.");
                                        return;
                                    }
                                    else
                                    {
                                        if (OldPassword.Text != user.password)
                                        {
                                            MessageBox.Show("Старый пароль не совпадает");
                                            return;
                                        }
                                        user.password = Password.Text;
                                        Program.dbController.SaveData();
                                        repeatPassword.Visible = false;
                                        NewPasswordCheck.Visible = false;
                                        OldPassword.Visible = false;
                                        Oldpasswordtext.Visible = false;
                                        Password.Text = "";
                                        Login.Text = "";
                                        MessageBox.Show("Пароль изменён");
                                        return;
                                    }
                                }
                            }
                        }

                        if (user.password == Password.Text)
                        {
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Пароль не верный");
                            if (_cntPasswordEnter < 2)
                                _cntPasswordEnter++;
                            else Application.Exit();
                            return;

                        }
                    }
                }
            }
            
            if (!logCheck)
            {
                MessageBox.Show("Такого логина не существует");
            }
            else
            {
                MainWindow main = new MainWindow(Login.Text.ToLower() == "admin");
                this.Visible = false;
                main.Show();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OldPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
