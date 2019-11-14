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
    public partial class Form4 : Form
    {
        string source = @"Data Source = DESKTOP-AS6AMUV\SQLEXPRESS; Initial Catalog = Carreon; Integrated Security = True";

        public Form4()
        {
            InitializeComponent();
        }
        //CODED BY CARREON, GABRIEL F.

        private void BalanceW_Click_1(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            string acc = "\t SELECT Money FROM LA4_Carreon WHERE UserPin = '" + Form1.count + "'";
            SqlCommand command = new SqlCommand(acc, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                BalanceD.Text = reader.GetValue(0).ToString();
            }
            connection.Close();
        }

        private void EnterAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            
        }

        private void Done_Click(object sender, EventArgs e)
        {
  
        }

        private void Deposit_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(source);
            connection.Open();

            string add = "Update LA4_Carreon set Money = Money + '" + EnterAmount.Text + "' where UserPin =  '" + Form1.count + "'";
            SqlCommand addition = new SqlCommand(add, connection);
            addition.ExecuteNonQuery();
            MessageBox.Show("Deposited Successfuly");
            this.Hide();
            Form4 depositform = new Form4();
            depositform.Show();
        }

        private void EnterAmount_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Done_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 homeform = new Form2();
            homeform.Show();
        }
    }
}
