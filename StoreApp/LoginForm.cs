using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string userLogin = LoginField.Text;
            string userPass = PasswordField.Text;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @userLogin AND pass = @userPass", db.Connection);
            command.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@userPass", MySqlDbType.VarChar).Value = userPass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show($"Welcome, {userLogin}!");
                this.Hide();
                StoreForm store = new StoreForm();
                store.Show();
            }
            else
            {
                MessageBox.Show("Wrong Login or Password");
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm reg = new RegisterForm();
            reg.Show();
        }
    }
}
