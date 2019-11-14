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
    public partial class Form5 : Form
    {
        string source = @"Data Source = DESKTOP-AS6AMUV\SQLEXPRESS; Initial Catalog = Carreon; Integrated Security = True";

        public Form5()
        {
          InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(source);
            string query = "Insert Into LA4_Carreon (Username, UserPin, LastName, FirstName) Values (@Username, @UserPin, @LastName, @FirstName)";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            
            command.Parameters.AddWithValue("@Username", Username.Text);
            command.Parameters.AddWithValue("@UserPin", UserPin.Text);
            command.Parameters.AddWithValue("@Firstname", Firstname.Text);
            command.Parameters.AddWithValue("@Lastname", Lastname.Text);
            int i;
            try
            {
                int result = command.ExecuteNonQuery();
                if (result <= 0)
                {
                    MessageBox.Show("   Account created Successfuly");
                    this.Hide();
                    Form1 firstform = new Form1();
                    firstform.Show();

                }
                if (int.TryParse(Username.Text, out i))
                {
                    MessageBox.Show("   The user name is only a letter field");
                }
                if (int.TryParse(Lastname.Text, out i))
                {
                    MessageBox.Show("   The last name only a letter field");
                }
                if (int.TryParse(Firstname.Text, out i))
                {
                    MessageBox.Show("   The first name only a letter field");
                }


                
                
            }
            catch(System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("   Please choose another User Pin");

            }
            connection.Close();


        }
    }
}
