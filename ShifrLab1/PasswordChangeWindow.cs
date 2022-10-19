using ShifrLab1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShifrLab1
{
    public partial class PasswordChangeWindow : Form
    {
        public PasswordChangeWindow()
        {
            InitializeComponent();
            OldPassword.PasswordChar = '*';
            NewPassword.PasswordChar = '*';
            NewPasswordCheck.PasswordChar = '*';
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            bool logCheck = false;
            foreach (var x in Program.dbController._listOfData)
            {
                if (x.login == EnterWindow.login)
                {
                    if (OldPassword.Text == x.password)
                    {
                        logCheck = true;
                    }
                    else
                    {
                        MessageBox.Show("Пароль не верный");
                        return;
                    }
                    if (NewPassword.Text == NewPasswordCheck.Text && logCheck)
                    {
                        if (x.passwordIsLimited)
                        {
                            if (!PasswordLimit.CheckLimit(NewPassword.Text))
                            {
                                MessageBox.Show("Новый пароль не подходит под установленное ограничение на пароли.\n Смените его или обратитесь к администратору");
                                return;
                            }
                        }

                        x.password = NewPassword.Text;
                        Program.dbController.SaveData();

                        FormCollection forms = Application.OpenForms;
                        forms[1].Visible = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают");
                        return;
                    }
                }
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormCollection forms = Application.OpenForms;
            forms[1].Visible = true;
            this.Close();
        }
    }
}
