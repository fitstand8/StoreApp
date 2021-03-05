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
    public partial class RegisterForm : Form
    {
        public bool IsUserExisting()
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @userLogin", db.Connection);
            command.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = RegLoginField.Text;
        

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm log = new LoginForm();
            log.Show();
        }

        private void RegSignUp_Click(object sender, EventArgs e)
        {
            string regLogin = RegLoginField.Text;
            string regPass = RegPasswordField.Text;
            string regRepeatPass = RegRepeatPasswordField.Text;
            
            if(regLogin == "" || regPass == "" || regRepeatPass == "")
            {
                MessageBox.Show("Some Fields Are Empty");
                return;
            }

            if(regPass != regRepeatPass)
            {
                MessageBox.Show("Passwords don't match!");
                return;
            }

            if (IsUserExisting())
            {
                MessageBox.Show($"That Login Already Exists. Please Choose Another Login");
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT users (Login, Pass) VALUES (@rL, @rP)", db.Connection);
            command.Parameters.Add("@rL", MySqlDbType.VarChar).Value = regLogin;
            command.Parameters.Add("@rP", MySqlDbType.VarChar).Value = regPass;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Accaunt is Created!");
            }
            else
            {
                MessageBox.Show("Accaunt isn't Created!");
            }

            db.CloseConnection();

            this.Hide();
            StoreForm store = new StoreForm();
            store.Show();
        }
    }
}
