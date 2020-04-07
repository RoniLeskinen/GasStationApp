namespace GasStationApp
{
    partial class Billboard
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
            this.rETURNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHUTDOWNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pricelabel_95 = new System.Windows.Forms.Label();
            this.pricelabel_98 = new System.Windows.Forms.Label();
            this.pricelabel_dsl = new System.Windows.Forms.Label();
            this.ad_label = new System.Windows.Forms.Label();
            this.ad_txtbox = new System.Windows.Forms.TextBox();
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
            this.rETURNToolStripMenuItem,
            this.sHUTDOWNToolStripMenuItem});
            this.uSERMENUToolStripMenuItem.Name = "uSERMENUToolStripMenuItem";
            this.uSERMENUToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.uSERMENUToolStripMenuItem.Text = "USERMENU";
            // 
            // rETURNToolStripMenuItem
            // 
            this.rETURNToolStripMenuItem.Name = "rETURNToolStripMenuItem";
            this.rETURNToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.rETURNToolStripMenuItem.Text = "RETURN";
            this.rETURNToolStripMenuItem.Click += new System.EventHandler(this.rETURNToolStripMenuItem_Click);
            // 
            // sHUTDOWNToolStripMenuItem
            // 
            this.sHUTDOWNToolStripMenuItem.Name = "sHUTDOWNToolStripMenuItem";
            this.sHUTDOWNToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.sHUTDOWNToolStripMenuItem.Text = "SHUTDOWN";
            this.sHUTDOWNToolStripMenuItem.Click += new System.EventHandler(this.sHUTDOWNToolStripMenuItem_Click);
            // 
            // pricelabel_95
            // 
            this.pricelabel_95.Location = new System.Drawing.Point(423, 140);
            this.pricelabel_95.Name = "pricelabel_95";
            this.pricelabel_95.Size = new System.Drawing.Size(171, 51);
            this.pricelabel_95.TabIndex = 1;
            this.pricelabel_95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pricelabel_98
            // 
            this.pricelabel_98.Location = new System.Drawing.Point(423, 212);
            this.pricelabel_98.Name = "pricelabel_98";
            this.pricelabel_98.Size = new System.Drawing.Size(171, 51);
            this.pricelabel_98.TabIndex = 2;
            this.pricelabel_98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pricelabel_dsl
            // 
            this.pricelabel_dsl.Location = new System.Drawing.Point(423, 287);
            this.pricelabel_dsl.Name = "pricelabel_dsl";
            this.pricelabel_dsl.Size = new System.Drawing.Size(171, 51);
            this.pricelabel_dsl.TabIndex = 3;
            this.pricelabel_dsl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ad_label
            // 
            this.ad_label.AutoSize = true;
            this.ad_label.Location = new System.Drawing.Point(287, 351);
            this.ad_label.Name = "ad_label";
            this.ad_label.Size = new System.Drawing.Size(119, 20);
            this.ad_label.TabIndex = 4;
            this.ad_label.Text = "Offer of the day";
            // 
            // ad_txtbox
            // 
            this.ad_txtbox.Location = new System.Drawing.Point(423, 373);
            this.ad_txtbox.MaximumSize = new System.Drawing.Size(4, 200);
            this.ad_txtbox.MinimumSize = new System.Drawing.Size(171, 60);
            this.ad_txtbox.Name = "ad_txtbox";
            this.ad_txtbox.Size = new System.Drawing.Size(171, 60);
            this.ad_txtbox.TabIndex = 5;
            this.ad_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Billboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GasStationApp.Properties.Resources.Billboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ad_txtbox);
            this.Controls.Add(this.ad_label);
            this.Controls.Add(this.pricelabel_dsl);
            this.Controls.Add(this.pricelabel_98);
            this.Controls.Add(this.pricelabel_95);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Billboard";
            this.Text = "Billboard";
            this.Load += new System.EventHandler(this.Billboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uSERMENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rETURNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHUTDOWNToolStripMenuItem;
        private System.Windows.Forms.Label pricelabel_95;
        private System.Windows.Forms.Label pricelabel_98;
        private System.Windows.Forms.Label pricelabel_dsl;
        private System.Windows.Forms.Label ad_label;
        private System.Windows.Forms.TextBox ad_txtbox;
    }
}