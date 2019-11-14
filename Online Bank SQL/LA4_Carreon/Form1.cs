using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LA4_Carreon
{
    public partial class Form1 : Form
    {
        string source = @"Data Source = DESKTOP-AS6AMUV\SQLEXPRESS; Initial Catalog = Carreon; Integrated Security = True";
        Form2 homeform = new Form2();
        Form5 signupform = new Form5();
        public Form1()
        {
            InitializeComponent();
            string count = AccNumTextBox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AccNumTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void PinTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(source);
           
            connection.Open();
            string select = "select Username, UserPin from LA4_Carreon where Username = '" + AccNumTextBox.Text + "'and UserPin = '" + PinTextBox.Text + "'";
            count = PinTextBox.Text; 
            SqlCommand command = new SqlCommand(select, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            try
            {
                adapter.Fill(Table);
            }
            catch(Exception)
            {
                MessageBox.Show("   Invalid Input");
            }

            if(Table.Rows.Count > 0)
            {
                this.Hide();
                MessageBox.Show("   Log In Successful");
                homeform.ShowDialog();

            }
            else
            {

                MessageBox.Show("   Incorrect credentials");
            }
            connection.Close();
        }
        public static string count;
        public string data;

        private void create_Click(object sender, EventArgs e)
        {
            this.Hide();
            signupform.Show();
        }

        private void GroupBoxForm1_Enter(object sender, EventArgs e)
        {

        }
    }
}
