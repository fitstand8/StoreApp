using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StoreApp
{
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();
        }

        private void StoreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM products", db.Connection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            ProductList.Items.Clear();
            foreach(DataRow prod in table.Rows)
            {
                ProductList.Items.Add($"{prod["ProductName"]} | {prod["Manufacturer"]} | {prod["Price"]}$ | {prod["Count"]}");
                ProductList.Items.Add("");
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (CommandField.Text == "") return;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM products WHERE " + CommandField.Text, db.Connection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            ProductList.Items.Clear();
            foreach (DataRow prod in table.Rows)
            {
                ProductList.Items.Add($"{prod["ProductName"]} | {prod["Manufacturer"]} | {prod["Price"]}$ | {prod["Count"]}");
                ProductList.Items.Add("");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CommandField.Text == "") return;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("DELETE FROM products WHERE " + CommandField.Text, db.Connection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            command = new MySqlCommand("SELECT * FROM products", db.Connection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            ProductList.Items.Clear();
            foreach (DataRow prod in table.Rows)
            {
                ProductList.Items.Add($"{prod["ProductName"]} | {prod["Manufacturer"]} | {prod["Price"]}$ | {prod["Count"]}");
                ProductList.Items.Add("");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddField.Text == "") return;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT Products(ProductName, Manufacturer, Price, Count) VALUES " + AddField.Text, db.Connection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            command = new MySqlCommand("SELECT * FROM products", db.Connection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            ProductList.Items.Clear();
            foreach (DataRow prod in table.Rows)
            {
                ProductList.Items.Add($"{prod["ProductName"]} | {prod["Manufacturer"]} | {prod["Price"]}$ | {prod["Count"]}");
                ProductList.Items.Add("");
            }
        }
    }
}
