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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace csc221CarRentalSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private bool validate()
        {
            //to ensure the text fields are not empty
            if (carIDcomboBox.Text.Trim() == String.Empty || carModelCombo.Text.Trim() == String.Empty || colorCombo.Text.Trim() == String.Empty || rentalDate.Text.Trim() == String.Empty || returnDate.Text.Trim() == String.Empty)
                return false;
            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CarID, color, carModel;

            if (validate())
            {
                CarID = carIDcomboBox.Text;
                carModel = carModelCombo.SelectedItem.ToString();
                color = colorCombo.SelectedItem.ToString();
              
                string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=carrentaldb;";
                string query = "insert into rentalrecords values (@CarID,@CarModel, @Color, @RentalDate,@ReturnDate)";
                MySqlConnection conn = new MySqlConnection(connectionstring);
                MySqlCommand cmd = new MySqlCommand(query, conn);   //creates connection with database
               
                cmd.Parameters.AddWithValue("@CarID", CarID);
                cmd.Parameters.AddWithValue("@CarModel", carModel);
                cmd.Parameters.AddWithValue("@Color", color);
                cmd.Parameters.AddWithValue("@RentalDate",rentalDate.Value);
                cmd.Parameters.AddWithValue("@ReturnDate", returnDate.Value);
              
                

                try
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("You have picked a car");
                       
                    }
                    else
                        MessageBox.Show("Please try again");
                     
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("An error occured, details as follows: " + ex.Message);
                }

            }
            else
                MessageBox.Show("Check all the text fields, none should be empty");


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.Show();
            Visible = false;
        }
    }
}
    
    
    
    

