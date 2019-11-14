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
    public partial class Form2 : Form
    {
        
        string source = @"Data Source = DESKTOP-AS6AMUV\SQLEXPRESS; Initial Catalog = Carreon; Integrated Security = True";
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            string acc = "\t SELECT Firstname +  Lastname FROM LA4_Carreon WHERE UserPin = '"+ Form1.count+ "'";
            SqlCommand command = new SqlCommand(acc, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                label2.Text = reader.GetValue(0).ToString();
            }
            connection.Close();

        }


        private void Balance_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            string balance = "Select Money from LA4_Carreon where UserPin = '"+Form1.count+"'";
            SqlCommand command = new SqlCommand(balance, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("   Your current balance is " + reader.GetValue(0).ToString());
            }
            connection.Close();
            
        }


        private void LogOut_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            this.Hide();
            loginform.Show();
        }



        private void Withdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 withdrawform = new Form3();
            withdrawform.Show();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 depositform = new Form4();
            depositform.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
