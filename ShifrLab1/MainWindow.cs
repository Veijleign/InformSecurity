using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShifrLab1
{
    public partial class MainWindow : Form
    {

        public MainWindow(bool adminCheck)
        {
            InitializeComponent();
            AddUser.Visible = adminCheck;
            labelUser.Visible = adminCheck;
            dataGrid.Visible = adminCheck;
            UserName.Visible = adminCheck;
            SaveBtn.Visible = adminCheck;
            ShowData();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            PasswordChangeWindow cngPass = new PasswordChangeWindow();
            cngPass.Show();
            this.Visible = false;
        }

        private void AboutProgramm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Горбунов Григорий, ИДБ-19-09");
        }

        private void ShowData()
        {
            dataGrid.Rows.Clear();
            foreach (var x in Program.dbController._listOfData)
            {
                if (x.login!="admin")
                    dataGrid.Rows.Add(x.login, x.isBlocked, x.passwordIsLimited);
            }
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UserName.Text))
            {
                Program.dbController._listOfData.Add(new Data.DataModel() { login = UserName.Text, password = "", isBlocked = false, passwordIsLimited = false });
                Program.dbController.SaveData();
            }
            ShowData();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            for (var i =0; i < dataGrid.Rows.Count; i++)
            {
                foreach (var x in Program.dbController._listOfData)
                {
                    if (dataGrid.Rows[i].Cells[0].Value.ToString() == x.login)
                    {
                        x.isBlocked = (bool)dataGrid.Rows[i].Cells[1].Value;
                        x.passwordIsLimited = (bool)dataGrid.Rows[i].Cells[2].Value;
                    }
                }
            }
            Program.dbController.SaveData();
        }
    }
}
