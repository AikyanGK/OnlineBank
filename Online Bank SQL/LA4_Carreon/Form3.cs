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
    public partial class Form3 : Form
    {
        string source = @"Data Source = DESKTOP-AS6AMUV\SQLEXPRESS; Initial Catalog = Carreon; Integrated Security = True";

        public Form3()
        {
            InitializeComponent();

        }
        //CODED BY CARREON, GABRIEL F.

        private void BalanceW_Click_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            string acc = "\t SELECT Money FROM LA4_Carreon WHERE UserPin = '" + Form1.count + "'";
            SqlCommand command = new SqlCommand(acc, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                BalanceW.Text = reader.GetValue(0).ToString();
            }
            connection.Close();
        }

            private void EnterAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            DataTable dt = new DataTable();

            //string select = "select Money from LA4_Carreon where UserPin = '" + Form1.count+"'";
            //SqlCommand check = new SqlCommand(select, connection);
           // check.Parameters.Add

            string minus =  "Update LA4_Carreon set Money = Money - '"+EnterAmount.Text+"' where UserPin =  '" +Form1.count+"'";
            
            SqlCommand subtract = new SqlCommand(minus, connection);
            subtract.ExecuteNonQuery();
            MessageBox.Show("Withdrawed Successfuly");
            this.Hide();
            Form3 withdrawform = new Form3();
            withdrawform.Show();

        }

        private void Done_Click(object sender, EventArgs e)
        {
            Form2 homeform = new Form2();
            this.Hide();
            homeform.Show();

        }
    }
}
