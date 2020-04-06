namespace GasStationApp
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username_box = new System.Windows.Forms.TextBox();
            this.username_text = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.show_box = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // username_box
            // 
            this.username_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_box.Location = new System.Drawing.Point(335, 220);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(242, 26);
            this.username_box.TabIndex = 0;
            this.username_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_box_KeyDown);
            // 
            // username_text
            // 
            this.username_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_text.AutoSize = true;
            this.username_text.Location = new System.Drawing.Point(206, 220);
            this.username_text.Name = "username_text";
            this.username_text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.username_text.Size = new System.Drawing.Size(105, 20);
            this.username_text.TabIndex = 1;
            this.username_text.Text = "USERNAME:";
            // 
            // password_text
            // 
            this.password_text.AutoSize = true;
            this.password_text.Location = new System.Drawing.Point(206, 271);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(107, 20);
            this.password_text.TabIndex = 3;
            this.password_text.Text = "PASSWORD:";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(335, 271);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(242, 26);
            this.password_box.TabIndex = 2;
            this.password_box.TextChanged += new System.EventHandler(this.password_box_TextChanged);
            this.password_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_box_KeyDown);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(464, 316);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(113, 41);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(335, 316);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(113, 41);
            this.return_button.TabIndex = 5;
            this.return_button.Text = "RETURN";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // show_box
            // 
            this.show_box.AutoSize = true;
            this.show_box.Location = new System.Drawing.Point(606, 272);
            this.show_box.Name = "show_box";
            this.show_box.Size = new System.Drawing.Size(75, 24);
            this.show_box.TabIndex = 6;
            this.show_box.Text = "Show";
            this.show_box.UseVisualStyleBackColor = true;
            this.show_box.CheckedChanged += new System.EventHandler(this.show_box_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GasStationApp.Properties.Resources.Oil;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.show_box);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.username_box);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Resize += new System.EventHandler(this.Login_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Label username_text;
        private System.Windows.Forms.Label password_text;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.CheckBox show_box;
    }
}