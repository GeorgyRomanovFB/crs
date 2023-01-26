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
    public partial class Auth : Form
    {
        Reg reg;
        BlumBlum blum;
        public Auth()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reg = new Reg();
            this.Hide();
            reg.ShowDialog();
            if (reg.DialogResult==DialogResult.Abort)
            {
                this.Show();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkallfields())
            {
                MessageBox.Show("Поле логина/пароля заполненно неверно! Удостоверьтесь, что поле содержит символы/не заполненно только пробелами");
                return;
            }
            else
            {
                User user = new User(loginbox.Text, passwordbox.Text);
                if (user.IsCorrect() == true)
                {
                    MessageBox.Show("Авторизация успешна!");
                    blum = new BlumBlum();
                    this.Hide();
                    blum.Show();

                }
                else MessageBox.Show("Ошибка авторизации!");
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
            if (fieldcheck(loginbox.Text) || fieldcheck(passwordbox.Text))
                return true;
            return false;
        }
        private void Auth_Load(object sender, EventArgs e)
        {
            
        }
    }
}
