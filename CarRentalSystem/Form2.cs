using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csc221CarRentalSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private bool validate()
        {
            //to ensure the text fields are not empty
            if (nametextBox.Text.Trim() == String.Empty || userIdtextBox.Text.Trim() == String.Empty || emailtextBox.Text.Trim() == String.Empty || phonenotextBox.Text.Trim() == String.Empty)
                return false;
            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string userID, name, email, phoneNumber;
                if (validate())
                {

                    userID = userIdtextBox.Text;
                    name = nametextBox.Text;
                    email = emailtextBox.Text;
                    phoneNumber = phonenotextBox.Text;

                    string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=carrentaldb;";
                    string query = "insert into carrentalsystem values (@UserID,@Name, @Email,@PhoneNumber)";
                    MySqlConnection conn = new MySqlConnection(connectionstring);
                    MySqlCommand cmd = new MySqlCommand(query, conn);   //creates connection with database
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    try
                    {
                        conn.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("You are now registered!");
                            nametextBox.Clear(); userIdtextBox.Clear(); emailtextBox.Clear();
                            phonenotextBox.Clear();
                        }
                        else
                            MessageBox.Show("Unsuccessful Database entry");
                        conn.Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("An error occured, details as follows: " + ex.Message);
                    }

                }
                else
                    MessageBox.Show("Check all the text fields, none should be empty");

            }
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rentrecords.Columns.Add("Column 1,150");
            rentrecords.Columns.Add("Column 2,100");
            rentrecords.Columns.Add("Column 3,120");
            rentrecords.Columns.Add("Column 4,100");

            string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=carrentaldb;";
            string query = "SELECT CarID,CarModel, Color, Duetime FROM borrowedcarrecords ";
            MySqlConnection conn = new MySqlConnection(connectionstring);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            while (myreader.Read())
            {
               
                //to read data from each row
                ListViewItem item = new ListViewItem(myreader["CarID"].ToString());
                ListViewItem item2 = new ListViewItem(myreader["CarModel"].ToString());
                ListViewItem item3 = new ListViewItem(myreader["Color"].ToString());
                ListViewItem item4 = new ListViewItem(myreader["Duetime"].ToString());

                rentrecords.Items.Add(item);
                rentrecords.Items.Add(item2);
                rentrecords.Items.Add(item3);
                rentrecords.Items.Add(item4);


            }
            myreader.Close();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
        
    

