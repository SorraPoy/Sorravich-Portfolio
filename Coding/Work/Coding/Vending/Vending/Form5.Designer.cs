
namespace Vending
{
    partial class Page5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page5));
            this.Info = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.Transparent;
            this.Info.BackgroundImage = global::Vending.Properties.Resources.INFO_MACHINE;
            this.Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Info.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Info.Location = new System.Drawing.Point(177, 34);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(643, 733);
            this.Info.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BackgroundImage = global::Vending.Properties.Resources.Home;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Home.Location = new System.Drawing.Point(393, 814);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(187, 76);
            this.Home.TabIndex = 1;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Page5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vending.Properties.Resources.BG3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Info);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Page5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRPVENDING";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Page5_FormClosing);
            this.Load += new System.EventHandler(this.Page5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Info;
        private System.Windows.Forms.Button Home;
    }
}