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
    public partial class Login : Form
    {
        private Rectangle username_textOriginalRect;
        private Rectangle username_boxOriginalRect;
        private Rectangle password_textOriginalRect;
        private Rectangle password_boxOriginalRect;
        private Rectangle show_boxOriginalRect;
        private Size formOriginalSize;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Adjusting txt.box positions based on the size of the form
            formOriginalSize = this.Size;
            username_textOriginalRect = new Rectangle(username_text.Location.X, username_text.Location.Y, 
            username_text.Width, username_text.Height);
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

        private void Login_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }
    }
}
