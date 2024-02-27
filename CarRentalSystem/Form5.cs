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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private bool validate()
        {
            //to ensure the text fields are not empty
            if (comboBox3.Text.Trim() == String.Empty || comboBox1.Text.Trim() == String.Empty || comboBox2.Text.Trim() == String.Empty )
             return false; 
            return true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string CarID, color, carModel;

            if (validate())
            {
                CarID = comboBox3.Text;
                carModel = comboBox1.SelectedItem.ToString();
                color = comboBox2.SelectedItem.ToString();

            }
            string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=carrentaldb;";
            string query = "SELECT * From listOfCars ";
            MySqlConnection conn = new MySqlConnection(connectionstring);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            if (myreader.Read())
            {
                CarID = comboBox3.Text;
                carModel = comboBox1.SelectedItem.ToString();
                color = comboBox2.SelectedItem.ToString();


                comboBox3.Text = myreader["CarID"].ToString();
                comboBox1.SelectedItem = myreader["CarModel"].ToString();
                comboBox2.SelectedItem = myreader["Color"].ToString();


                // string query2 = "SELECT * From listOfCars Where CarID=@CarID, carModel=@CarModel and color=@Color";
                //MySqlConnection connection = new MySqlConnection(connectionstring);
                //MySqlCommand command = new MySqlCommand(query2, conn);
                //command.Parameters.AddWithValue("@CarID",CarID);
                //command.Parameters.AddWithValue("@CarModel", carModel);
                //command.Parameters.AddWithValue("@Color", color);

                try
                {

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string availability = myreader["Availability"].ToString();
                        availability = result.ToString();
                        MessageBox.Show("Availability=='A'" + availability);
                    }
                    else
                    {
                        MessageBox.Show("No available car for this combination ");
                    }

                
                    myreader.Close();
                    conn.Close();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("An error ocurred, details: " + ex.Message);
                }
            }

        }
    }
}
    



