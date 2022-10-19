using SharpHash.Base;
using ShifrLab1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ShifrLab1
{
    public partial class EnterKeyWindow : Form
    {
        string key = "2D7B32185F227AC830A7CCB5D0867F37"; // "enter"

        public EnterKeyWindow()
        {
            TopMost = true;
            InitializeComponent();
            KeyStr.PasswordChar = '*';
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для работы программы необходимо ввести ключ для дешифровки базы данных");
            Application.Exit();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            var result = HashFactory.Crypto.CreateMD2().ComputeString(KeyStr.Text, Encoding.UTF8).ToString(); // this realization comes from NuGet SharpHash

            if (result == key)
            {
                this.Close();
                Program.encrController = new encryptionData("key");
                Program.dbController = new DBController();
            }
            else
            {
                MessageBox.Show("Введён неправильный ключ");
                Application.Exit();
            }
            
        }

        private void KeyStr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
