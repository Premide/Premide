using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace csc221CarRentalSystem
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private bool validate()
        {
            //to ensure the text fields are not empty
            if (carIDtextBox.Text.Trim() == String.Empty || modeltextBox.Text.Trim() == String.Empty || colortextBox.Text.Trim() == String.Empty)
                return false;
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                double PriceofCar;
                string CarID, color, carModel, cost;
                CarID = carIDtextBox.Text;
                carModel = modeltextBox.Text;
                color = colortextBox.Text;
             
                string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=carrentaldb;";
                string query = "SELECT CarID,CarModel,Color,CarCost FROM listofcars WHERE CarID=@CarID AND carModel=@CarModel AND color=@Color";
                MySqlConnection connection = new MySqlConnection(connectionstring);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@CarID", CarID);
                cmd.Parameters.AddWithValue("@CarModel", carModel);
                cmd.Parameters.AddWithValue("@Color", color);
                

                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    CarID = reader.GetString("CarID");
                    carModel = reader.GetString("CarModel");
                    color = reader.GetString("Color");
                    cost = reader.GetString("CarCost");
                    double.TryParse(cost,out PriceofCar);
                 
                    double taxRate = 0.2;
                    double taxAmount = PriceofCar * taxRate;
                    double totalCost=PriceofCar+ taxAmount;
                    string payment = string.Format("Car ID: {0} \nCar Model:{1}\n Color:{2}\n Price:{3:C}\n Tax:{4:C}\n Car Cost:{5:C}", CarID, carModel, color, PriceofCar, taxAmount, totalCost);
                    MessageBox.Show(payment, "CarCost");

                }
                else
                {
                    MessageBox.Show("Car is not available");
                }
                reader.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
