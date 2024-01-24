using Microsoft.Azure.Amqp.Framing;
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

namespace WinForm_IoT
{
    // Form for the messages' view
    public partial class Form2 : Form
    {
        
        static string connString = "Your DB Connection to SQL";
        SqlConnection mysql = null;

        public Form2()
        {
            InitializeComponent();
            
            btnClear.Click += BtnClear_Click;
            btnViewID.Click += BtnViewID_Click;
            btnViewDate.Click += BtnViewDate_Click;
            btnViewText.Click += BtnViewText_Click;
        }


        private void BtnClear_Click(object? sender, EventArgs e)
        {
            txtBDevice.Text = "";
            txtBText.Text = txtBDevice.Text;
            txtBFrom.Text = txtBDevice.Text;
            txtBTo.Text = txtBDevice.Text;
            dataVMessages.Columns.Clear();
        }
        private void BtnViewText_Click(object? sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand select = conn.CreateCommand();
            // The query required
            select.CommandText = "SELECT Query";
            SqlDataReader reader = select.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            dataVMessages.DataSource = dataTable;

            reader.Close();
            conn.Close();

        }

        private void BtnViewDate_Click(object? sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand select = conn.CreateCommand();
            // The query required
            select.CommandText = "SELECT Query";

            DateTime startDate;
            DateTime endDate;

            if (DateTime.TryParse(txtBFrom.Text, out startDate) && DateTime.TryParse(txtBTo.Text, out endDate))
            {
                select.Parameters.AddWithValue("@start_date", startDate);
                select.Parameters.AddWithValue("@end_date", endDate);

                SqlDataReader reader = select.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataVMessages.DataSource = dataTable;

                reader.Close();
            }

            conn.Close();
        }

        private void BtnViewID_Click(object? sender, EventArgs e)
        {
            string Id = txtBDevice.Text;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand select = conn.CreateCommand();

            // The query required
            select.CommandText = "SELECT Query";
            select.Parameters.AddWithValue("@ID", Id);
            SqlDataReader reader = select.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            dataVMessages.DataSource = dataTable;

            reader.Close();
            conn.Close();
        }
    }
}
