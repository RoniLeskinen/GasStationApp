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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {

        }

        // Start of method
        // Start page --> Usermenu --> Login button
        // Clicking this button will take the user from "Start page" to "Login page". 

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            if (login.IsDisposed)
            {
                login = new Login();
            }

            login.Show();
            this.Hide();
        }

        // End of last method

        // Start of method
        // Start page --> Usermenu --> Shutdown button
        // Clicking this button will close the program.

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

        // End of last method
    }
}
