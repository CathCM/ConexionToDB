using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConexionToDB
{
    public partial class Conexion : Form
    {
        private DatabaseManager dbManager;

        public Conexion()
        {
            InitializeComponent();
            string connectionString = "Data Source=200.234.224.123,54321;" +
                                      "Initial Catalog=CathyEmployees;" +
                                      "User ID=sa;" +
                                      "Password=Sql#123456789;";
            dbManager = new DatabaseManager(connectionString);
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.Connect();
                pictureBoxGreen.Visible = true;
                pictureBoxRed.Visible = false;
                progressBar.Value = 100;
                conectar.Enabled = false;
                desconectar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                pictureBoxGreen.Visible = false;
                pictureBoxRed.Visible = true;
                progressBar.Value = 0;
            }
        }

        private void buttonDesconectar_Click(object sender, EventArgs e)
        {
            dbManager.Disconnect();
            pictureBoxGreen.Visible = false;
            pictureBoxRed.Visible = true;
            progressBar.Value = 0;
            conectar.Enabled = true;
            desconectar.Enabled = false;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string first_name = "Cathy";
            string last_name = "Cardenas";
            string email = "cathcardenasm@gmail.com";
            string phone_number = "1234567890";
            DateTime hire_date = DateTime.Now;
            int job_id = 1;
            decimal salary = 50000;
            int manager_id = 176;
            int department_id = 1;

            try
            {
                dbManager.InsertEmployee(first_name, last_name, email, phone_number, hire_date, job_id, salary, manager_id, department_id);
                MessageBox.Show("Datos insertados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            desconectar.Enabled = false; 
            pictureBoxGreen.Visible = false; 
            pictureBoxRed.Visible = true; 
        }
    }
}
