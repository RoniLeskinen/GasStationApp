namespace GasStationApp
{
    partial class StartPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uSERMENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHUTDOWNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSERMENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uSERMENUToolStripMenuItem
            // 
            this.uSERMENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGINToolStripMenuItem,
            this.sHUTDOWNToolStripMenuItem});
            this.uSERMENUToolStripMenuItem.Name = "uSERMENUToolStripMenuItem";
            this.uSERMENUToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.uSERMENUToolStripMenuItem.Text = "USERMENU";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            this.lOGINToolStripMenuItem.Click += new System.EventHandler(this.lOGINToolStripMenuItem_Click);
            // 
            // sHUTDOWNToolStripMenuItem
            // 
            this.sHUTDOWNToolStripMenuItem.Name = "sHUTDOWNToolStripMenuItem";
            this.sHUTDOWNToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.sHUTDOWNToolStripMenuItem.Text = "SHUTDOWN";
            this.sHUTDOWNToolStripMenuItem.Click += new System.EventHandler(this.sHUTDOWNToolStripMenuItem_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GasStationApp.Properties.Resources.Start_Page;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartPage";
            this.Text = "Start Page";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uSERMENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHUTDOWNToolStripMenuItem;
    }
}

