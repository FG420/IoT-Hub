using Microsoft.Azure.Devices;
using System.Data.SqlClient;
using System.Text;

namespace WinForm_IoT
{
    public partial class Form1 : Form
    {
        static ServiceClient myService;
        static string connString = "Your DB Connection to SQL";
        
        // Your Azure Cloud IoT-Hub connection string
        static string cloudString = " IoT-Hub connection string";

        // devices' names
        static List<string> deviceIds = new List<string> { "device1", "device2", "and so on" };
        SqlConnection mysql = null;

        public Form1()
        {
            InitializeComponent();
            Connection();
            comboBoxDevices.DataSource = deviceIds;
            comboBoxDevices.DisplayMember = "ToString";
            btnSendM.Click += BtnSendM_Click;
            btnViewM.Click += BtnViewM_Click;
        }

        private void BtnViewM_Click(object? sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Connection()
        {
            try
            {
                mysql = new SqlConnection(connString);
                mysql.Open();
                myService = ServiceClient.CreateFromConnectionString(cloudString);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSendM_Click(object? sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // The query required
                    SqlCommand selectMaxId = new SqlCommand("SELECT Query", connection);
                    object maxValue = selectMaxId.ExecuteScalar();
                    int newId = (maxValue == DBNull.Value) ? 1 : Convert.ToInt32(maxValue) + 1;
                    SqlCommand insert = connection.CreateCommand();

                    // the query required
                    insert.CommandText = "INSERT Query";
                    insert.Parameters.AddWithValue("@Value1", newId);
                    insert.Parameters.AddWithValue("@Value2", txtBMessage.Text);
                    insert.Parameters.AddWithValue("@Value3", DateTime.Now);
                    insert.Parameters.AddWithValue("@Value4", comboBoxDevices.Text);
                    insert.Parameters.AddWithValue("@Value5", false);

                    int rowsAffected = insert.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        var message = new Microsoft.Azure.Devices.Message(Encoding.ASCII.GetBytes(txtBMessage.Text));
                        if(comboBoxDevices.Text == deviceIds[0])
                        {
                             myService.SendAsync(deviceIds[0], message).Wait();
                        }
                        if(comboBoxDevices.Text == deviceIds[1])
                        {
                            myService.SendAsync(deviceIds[1], message).Wait();
                        }

                        MessageBox.Show("Message insert in DB successfully and sent to the device!");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong...");
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during Insert into DB: " + ex.Message);
            }
        }
    }
}
