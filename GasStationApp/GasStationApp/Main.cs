using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStationApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // Method that takes user to "prices" form when button is clicked.
        private void pRICESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prices prices = new Prices();
            prices.Show();
            this.Close();
        }

        // Method that takes user to "billboard" form when button is clicked.
        private void rETURNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Billboard billboard = new Billboard();
            billboard.Show();
            this.Close();
        }

        // Method that closes login form and send user back to login page when "return" button is clicked.
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            if (login.IsDisposed)
            {
                login = new Login();
            }

            login.Show();
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
