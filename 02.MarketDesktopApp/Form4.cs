using _02.MarketDesktopApp.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.MarketDesktopApp
{
    public partial class Form4 : Form
    {
        int _id;
        Form3 _form3;
        string connectionString = Connection.ConnectionString;
        SqlConnection connection;
        public Form4(Form3 form3, int id)
        {
            InitializeComponent();
            _id = id;
            _form3 = form3;
            connection = new(connectionString);
        }

        private void GetProductById()
        {
            connection.Open();
            string query = "Select Top 1 * From Products where Id=@Id";
            SqlCommand cmd = new(query, connection);
            cmd.Parameters.AddWithValue("@Id", _id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtName.Text = reader["Name"].ToString();
                txtPrice.Text = reader["Price"].ToString();
            }
            connection.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            GetProductById();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "Update Products Set Name=@Name, Price=@Price where Id=@Id";
            SqlCommand cmd = new(query, connection);
            cmd.Parameters.AddWithValue("@Id", _id);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Update is successful!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _form3.GetAllProducts();
            this.Close();
        }
    }
}
