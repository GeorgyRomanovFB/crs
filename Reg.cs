using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BlumBlumShub
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }
        Auth auth;
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            User reguser = new User(loginbox.Text, null);

            if (checkallfields())
            {
                MessageBox.Show("Поле логина/пароля заполненно неверно! Удостоверьтесь, что поле содержит символы/не заполненно только пробелами");
                return;
            }
            else
            {
                if (new DB("Data Source=DB.db;Version=3").CheckLogin(reguser) == true)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                    return;
                }
                else
                {
                    if (passworbox.Text == acceptpasswordbox.Text)
                    {

                        new DB("Data Source=DB.db;Version=3").createUser(loginbox.Text, passworbox.Text);

                        MessageBox.Show("Регистрация успешна!");
                        auth = new Auth();
                        this.Dispose();
                        auth.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают!");
                        return;
                    }
                }
            }

        }
        private bool fieldcheck(string field)
        {
            if (String.IsNullOrWhiteSpace(field))
                return true;
            return false;
        }
        private bool checkallfields()
        {
            if (fieldcheck(loginbox.Text)||fieldcheck(passworbox.Text))
                return true;
            return false;
        }
        private void Reg_Load(object sender, EventArgs e)
        {
            loginbox.Text = null;
            passworbox.Text = null;
        }
        private void Reg_Closed(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;

        }
    }
}
