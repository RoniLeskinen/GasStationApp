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
    public partial class Billboard : Form
    {
        public static string Advertisement = "Hello!";

        public string Gas95; //
        public string Gas98; // Variables for taking data from prices form
        public string Dsl;   //

        string Advertise1;
        public string ad_ToNewForm;

        // Routing filepath.
        Prices prices = new Prices();

        public string AdvertisementFile = 
            "C:/Users/ronles1/Documents/GitHub/GasStationApp/GasStationApp/GasStationApp/bin/debug/Advertisements.txt";

        public Billboard()
        {
            if (!File.Exists(AdvertisementFile))
            {
                writeToAdvertisementFile();
            }

            readAdvertisementFile();
            InitializeComponent();
        }

        // Method that sends data to Advertisement file that user has written.
        // Checks if form item is empty and inputs data from prices form.
        private void Billboard_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ad_ToNewForm))
            {
                ad_txtbox.Text = Advertisement;
            }

            else if (ad_ToNewForm != "")
            {
                ad_txtbox.Text = (ad_ToNewForm);
                using (StreamWriter outputFile = new StreamWriter(AdvertisementFile))
                {
                    outputFile.WriteLine("Advertisement = " + ad_ToNewForm);
                }
            }

            pricelabel_95.Text = (Gas95.ToString()); //
            pricelabel_98.Text = (Gas98.ToString()); // Data from prices form
            pricelabel_dsl.Text = (Dsl.ToString());  //
        }

        /// Method that writes data to Advertisement file.
        private void writeToAdvertisementFile()
        {
            using (StreamWriter outputFile = new StreamWriter(AdvertisementFile))
            {
                outputFile.WriteLine("Advertisement = " + Advertisement);
            }
        }

        // Method that reads information from Advertisement file and checks if it exists.
        private void readAdvertisementFile()
        {
            if (!File.Exists(AdvertisementFile))
            {
                writeToAdvertisementFile();
            }

            using (StreamReader sr = new StreamReader(AdvertisementFile))
            {
                Advertisement = sr.ReadLine();
                Advertisement = prosessLine(Advertisement);
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

        //Method that converts variables.
        public void gas95(string a)
        {
            Gas95 = a.ToString();
        }

        public void gas98(string b)
        {
            Gas98 = b.ToString();
        }

        public void dsl(string c)
        {
            Dsl = c.ToString();
        }

        public void advertise1(string a)
        {
            Advertise1 = a.ToString();
        }

        // Method that closes login form and send user back to main page when "return" button is clicked.
        private void rETURNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prices prices = new Prices();

            if (prices.IsDisposed)
            {
                prices = new Prices();
            }

            prices.Show();
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
