
namespace Vending
{
    partial class Page1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
            this.WELCOME = new System.Windows.Forms.PictureBox();
            this.VENDING = new System.Windows.Forms.PictureBox();
            this.SORRAPOY = new System.Windows.Forms.PictureBox();
            this.BGStart = new System.Windows.Forms.Panel();
            this.Start2 = new System.Windows.Forms.Button();
            this.Exit1 = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WELCOME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SORRAPOY)).BeginInit();
            this.BGStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // WELCOME
            // 
            this.WELCOME.BackColor = System.Drawing.Color.Transparent;
            this.WELCOME.BackgroundImage = global::Vending.Properties.Resources.WELCOME;
            this.WELCOME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WELCOME.Location = new System.Drawing.Point(325, 75);
            this.WELCOME.Name = "WELCOME";
            this.WELCOME.Size = new System.Drawing.Size(304, 73);
            this.WELCOME.TabIndex = 0;
            this.WELCOME.TabStop = false;
            // 
            // VENDING
            // 
            this.VENDING.BackColor = System.Drawing.Color.Transparent;
            this.VENDING.BackgroundImage = global::Vending.Properties.Resources.Vending3;
            this.VENDING.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VENDING.Location = new System.Drawing.Point(327, 150);
            this.VENDING.Name = "VENDING";
            this.VENDING.Size = new System.Drawing.Size(299, 396);
            this.VENDING.TabIndex = 1;
            this.VENDING.TabStop = false;
            this.VENDING.Click += new System.EventHandler(this.VENDING_Click);
            // 
            // SORRAPOY
            // 
            this.SORRAPOY.BackColor = System.Drawing.Color.Transparent;
            this.SORRAPOY.BackgroundImage = global::Vending.Properties.Resources.sorrapoy;
            this.SORRAPOY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SORRAPOY.Location = new System.Drawing.Point(325, 549);
            this.SORRAPOY.Name = "SORRAPOY";
            this.SORRAPOY.Size = new System.Drawing.Size(303, 155);
            this.SORRAPOY.TabIndex = 2;
            this.SORRAPOY.TabStop = false;
            // 
            // BGStart
            // 
            this.BGStart.BackColor = System.Drawing.Color.Transparent;
            this.BGStart.BackgroundImage = global::Vending.Properties.Resources.Start12;
            this.BGStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BGStart.Controls.Add(this.Start2);
            this.BGStart.Location = new System.Drawing.Point(381, 733);
            this.BGStart.Name = "BGStart";
            this.BGStart.Size = new System.Drawing.Size(205, 89);
            this.BGStart.TabIndex = 4;
            // 
            // Start2
            // 
            this.Start2.BackgroundImage = global::Vending.Properties.Resources.Start21;
            this.Start2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Start2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start2.Location = new System.Drawing.Point(0, 43);
            this.Start2.Name = "Start2";
            this.Start2.Size = new System.Drawing.Size(205, 37);
            this.Start2.TabIndex = 5;
            this.Start2.UseVisualStyleBackColor = true;
            this.Start2.Click += new System.EventHandler(this.Start2_Click);
            // 
            // Exit1
            // 
            this.Exit1.BackColor = System.Drawing.Color.Transparent;
            this.Exit1.BackgroundImage = global::Vending.Properties.Resources.Exit;
            this.Exit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit1.Location = new System.Drawing.Point(788, 856);
            this.Exit1.Name = "Exit1";
            this.Exit1.Size = new System.Drawing.Size(139, 61);
            this.Exit1.TabIndex = 5;
            this.Exit1.UseVisualStyleBackColor = false;
            this.Exit1.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.Transparent;
            this.Info.BackgroundImage = global::Vending.Properties.Resources.Info;
            this.Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Info.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Info.Location = new System.Drawing.Point(43, 860);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(150, 57);
            this.Info.TabIndex = 6;
            this.Info.UseVisualStyleBackColor = false;
            this.Info.Click += new System.EventHandler(this.button1_Click);
            // 
            // Product
            // 
            this.Product.BackColor = System.Drawing.Color.Transparent;
            this.Product.BackgroundImage = global::Vending.Properties.Resources.frame1;
            this.Product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Product.Location = new System.Drawing.Point(43, 791);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(117, 63);
            this.Product.TabIndex = 7;
            this.Product.UseVisualStyleBackColor = false;
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Vending.Properties.Resources.BG3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Exit1);
            this.Controls.Add(this.BGStart);
            this.Controls.Add(this.SORRAPOY);
            this.Controls.Add(this.VENDING);
            this.Controls.Add(this.WELCOME);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Page1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRPVENDING";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Page1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Page1_FormClosed);
            this.Load += new System.EventHandler(this.Page1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WELCOME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SORRAPOY)).EndInit();
            this.BGStart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox WELCOME;
        private System.Windows.Forms.PictureBox VENDING;
        private System.Windows.Forms.PictureBox SORRAPOY;
        private System.Windows.Forms.Panel BGStart;
        private System.Windows.Forms.Button Start2;
        private System.Windows.Forms.Button Exit1;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Button Product;
    }
}

