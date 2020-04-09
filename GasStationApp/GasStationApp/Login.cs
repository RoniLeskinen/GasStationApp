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
using System.Security.Cryptography;

namespace GasStationApp
{
    public partial class Login : Form
    {
        private Rectangle username_textOriginalRect;
        private Rectangle username_boxOriginalRect;
        private Rectangle password_textOriginalRect;
        private Rectangle password_boxOriginalRect;
        private Rectangle show_boxOriginalRect;
        private Size formOriginalSize;

        public string username;
        public string password;
        public string userfeed;

        // Initializing txt.file for username & password

        public string credentials = AppDomain.CurrentDomain.BaseDirectory + @"\Credentials.txt";
        public Login()
        {
            // Checking if credentials file exist, if not then method is called
            // and the file is created
            if (!File.Exists(credentials))
            {
                createCredentials();
            }

            // Calling for methods
            InitializeComponent();
            ReadUserCredentials();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Password encryption
            username_box.UseSystemPasswordChar = true;
            password_box.UseSystemPasswordChar = true;

            // Adjusting txt.box positions based on the size of the form
            formOriginalSize = this.Size;
            username_textOriginalRect = new Rectangle(username_text.Location.X, username_text.Location.Y, 
            username_text.Width, username_text.Height);
        }

        // Method creating password md5 encryption
        private string checkPassword(string password)
        {
            MD5CryptoServiceProvider md5Kryptaaja = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = md5Kryptaaja.ComputeHash(data);
            string md5tiiviste = "";

            for (int i = 0; i < data.Length; i++)
            {
                md5tiiviste += data[i].ToString("x2").ToLower();
            }

            return md5tiiviste;
        }

        // Method that creates and writes credentials to credentials file.
        private void createCredentials()
        {
            string password = "1234";
            password = checkPassword(password);

            using (StreamWriter outputFile = new StreamWriter(credentials))
            {
                outputFile.WriteLine("username = Admin");
                outputFile.WriteLine("password = " + password);
            }
        }

        // Method that reads information from credentials file.
        private void ReadUserCredentials()
        {
            using (StreamReader sr = new StreamReader(credentials))
            {
                username = sr.ReadLine();
                username = prosessLine(username);
                password = sr.ReadLine();
                password = prosessLine(password);
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

        // Method calling another method
        private void resizeChildrenControls()
        {
            resizeControl(username_textOriginalRect, username_text);
        }

        // Adjusting the sizes of the items on the form
        private void resizeControl(Rectangle originalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Width) / (float)(formOriginalSize.Height);

            int newX = (int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);

            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeight = (int)(originalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        // Method that calls another method when user resizes login form.
        private void Login_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }

        // Method that shows the user message box when pressing "login" button on the form.
        // If user has written wrong input, nothing or correct cedentials, message box appears.
        private void login_button_Click(object sender, EventArgs e)
        {
            if (username_box.Text == username && userfeed == password)
            {
                Main main = new Main();
                MessageBox.Show("Correct username & password!", "Welcome!");
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "Try again!");
                username_box.Text = "";
                password_box.Text = "";
            }
        }

        // Method that closes login form and send user back to start page when "return" button is clicked.
        private void return_button_Click(object sender, EventArgs e)
        {
            StartPage startPage = new StartPage();

            if (startPage.IsDisposed)
            {
                startPage = new StartPage();
            }

            startPage.Show();
            this.Hide();
        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {
            userfeed = password_box.Text;
            userfeed = checkPassword(userfeed);
        }

        // Method that controls the "show" button on the form.
        // It either shows what is written or hides it.
        private void show_box_CheckedChanged(object sender, EventArgs e)
        {
            if (show_box.Checked)
            {
                username_box.UseSystemPasswordChar = false;
                password_box.UseSystemPasswordChar = false;
            }
            else
            {
                username_box.UseSystemPasswordChar = true;
                password_box.UseSystemPasswordChar = true;
            }
        }

        // Method that takes user to main page or start page depending user input
        // and if the credentials are written correctly.
        private void password_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && username_box.Text == username && userfeed == password)
            {
                Main main = new Main();
                MessageBox.Show("Correct username & password!", "Welcome!");
                main.Show();
                this.Hide();
            }

            if (e.KeyCode == Keys.Enter && username_box.Text != username && userfeed != password)
            {
                Main main = new Main();
                Login login = new Login();
                MessageBox.Show("Wrong username & password!", "Try again!");
            }

            else if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("Returning to startup");
                StartPage startPage = new StartPage();
                startPage.Show();
                this.Hide();
            }
        }

        // Method that takes user to main page or start page depending user input
        // and if the credentials are written correctly.
        private void username_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && username_box.Text == username && userfeed == password)
            {
                Main main = new Main();
                MessageBox.Show("Correct username & password!", "Welcome!");
                main.Show();
                this.Hide();
            }

            if (e.KeyCode == Keys.Enter && username_box.Text != username && userfeed != password)
            {
                Main main = new Main();
                Login login = new Login();
                MessageBox.Show("Wrong username & password!", "Try again!");
            }
            else if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("Returning to startup");
                StartPage startPage = new StartPage();
                startPage.Show();
                this.Hide();
            }
        }
    }
}
