using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStationApp
{
    public partial class Prices : Form
    {
        public static string price95;
        public static string price98;
        public static string priceDsl;

        public static string price_95;
        public static string price_98;
        public static string price_Dsl;

        public string Gas95;
        public string Gas98;
        public string Dsl;

        public string Advertise1;
        public static string Ad_toNewForm;

        // Routing filepath.
        public string filePath = 
            "C:/Users/ronles1/Documents/GitHub/GasStationApp/GasStationApp/GasStationApp/bin/debug/Prices.txt";

        // Checking if filepath exist, if yes then method is called
        // to read data from the file.
        public Prices()
        {
            if (!File.Exists(filePath))
            {
                writeToFile();
            }

            InitializeComponent();
            readPrices();
        }

        // When form opens, this method gives values for labels.
        private void Prices_Load(object sender, EventArgs e)
        {
            label_95_price.Text = price_95;
            label_98_price.Text = price_98;
            label_dsl_price.Text = price_Dsl;
        }

        // Method that writes data to prices file.
        private void writeToFile()
        {
            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                outputFile.WriteLine("Price95 = 1,500");
                outputFile.WriteLine("Price98 = 1,600");
                outputFile.WriteLine("PriceDsl = 1,400");
            }
        }

        // Method that reads information from prices file and checks if it exists.
        private void readPrices()
        {
            if (!File.Exists(filePath))
            {
                writeToFile();
            }
            using (StreamReader sr = new StreamReader(filePath))
            {
                price_95 = sr.ReadLine();
                price_95 = prosessLine(price_95);
                price_98 = sr.ReadLine();
                price_98 = prosessLine(price_98);
                price_Dsl = sr.ReadLine();
                price_Dsl = prosessLine(price_Dsl);
            }
        }

        // Method, that prosesses credentials.file by removing spaces between text
        // and takes information after = sign.
        private string prosessLine(string str)
        {
            str = str.Replace(" ", string.Empty);
            string[] tmp = str.Split('=');
            return tmp[1];
        }

        // Method that sends data from "prices page" to "billboard page" when export button is clicked.
        private void button_export_Click(object sender, EventArgs e)
        {
            Billboard billboard = new Billboard();
            billboard.ad_ToNewForm = txtbox_ad.Text;

            price95 = txtbox_95.Text;
            price98 = txtbox_98.Text;
            priceDsl = txtbox_dsl.Text;

            Gas95 = label_95_price.Text;
            billboard.gas95(Gas95.ToString());
            Gas98 = label_98_price.Text;
            billboard.gas98(Gas98.ToString());
            Dsl = label_dsl_price.Text;
            billboard.dsl(Dsl.ToString());

            Advertise1 = txtbox_ad.Text;
            billboard.advertise1(Advertise1.ToString());

            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                outputFile.WriteLine("Price95 = " + price95);
                outputFile.WriteLine("Price98 = " + price98);
                outputFile.WriteLine("PriceDsl = " + priceDsl);
            }

            billboard.Show();
            this.Close();
        }

        // Method that writes new data to prices file if user has done modifications.
        private void button_change_Click(object sender, EventArgs e)
        {
            price95 = txtbox_95.Text;
            price98 = txtbox_98.Text;
            priceDsl = txtbox_dsl.Text;
            label_95_price.Text = price95;
            label_98_price.Text = price98;
            label_dsl_price.Text = priceDsl;

            // Method that writes data to prices file.
            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                outputFile.WriteLine("Price95 = " + price95);
                outputFile.WriteLine("Price98 = " + price98);
                outputFile.WriteLine("PriceDsl = " + priceDsl);
            }
        }

        // Method that closes login form and send user back to main page when "return" button is clicked.
        private void rETURNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();

            if (main.IsDisposed)
            {
                main = new Main();
            }

            main.Show();
            this.Hide();
        }

        // Clicking this shutdown button will close the program.
        private void sHUTDOWNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Program is closing", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                MessageBox.Show("Program was not closed", "Program is still running");
            }
        }
    }
}
