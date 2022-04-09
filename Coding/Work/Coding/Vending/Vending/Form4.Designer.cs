
namespace Vending
{
    partial class Page4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page4));
            this.ItemHole = new System.Windows.Forms.Panel();
            this.Bag = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Receive = new System.Windows.Forms.Button();
            this.ChangeHole = new System.Windows.Forms.Panel();
            this.YourChange = new System.Windows.Forms.Label();
            this.ChangeBag = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.PickUp = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ItemHole.SuspendLayout();
            this.ChangeHole.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemHole
            // 
            this.ItemHole.BackColor = System.Drawing.Color.Transparent;
            this.ItemHole.BackgroundImage = global::Vending.Properties.Resources.Item_hole;
            this.ItemHole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ItemHole.Controls.Add(this.Bag);
            this.ItemHole.Location = new System.Drawing.Point(328, 38);
            this.ItemHole.Name = "ItemHole";
            this.ItemHole.Size = new System.Drawing.Size(302, 142);
            this.ItemHole.TabIndex = 0;
            this.ItemHole.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Bag
            // 
            this.Bag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bag.BackgroundImage")));
            this.Bag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bag.Location = new System.Drawing.Point(128, -50);
            this.Bag.Name = "Bag";
            this.Bag.Size = new System.Drawing.Size(46, 65);
            this.Bag.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Receive
            // 
            this.Receive.BackColor = System.Drawing.Color.Transparent;
            this.Receive.BackgroundImage = global::Vending.Properties.Resources.Receive;
            this.Receive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Receive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Receive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Receive.Location = new System.Drawing.Point(396, 209);
            this.Receive.Name = "Receive";
            this.Receive.Size = new System.Drawing.Size(176, 88);
            this.Receive.TabIndex = 1;
            this.Receive.UseVisualStyleBackColor = false;
            this.Receive.Click += new System.EventHandler(this.Receive_Click);
            // 
            // ChangeHole
            // 
            this.ChangeHole.BackColor = System.Drawing.Color.Transparent;
            this.ChangeHole.BackgroundImage = global::Vending.Properties.Resources.Receive_coin_hole;
            this.ChangeHole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeHole.Controls.Add(this.YourChange);
            this.ChangeHole.Controls.Add(this.ChangeBag);
            this.ChangeHole.Location = new System.Drawing.Point(168, 325);
            this.ChangeHole.Name = "ChangeHole";
            this.ChangeHole.Size = new System.Drawing.Size(636, 265);
            this.ChangeHole.TabIndex = 2;
            this.ChangeHole.Visible = false;
            // 
            // YourChange
            // 
            this.YourChange.AutoSize = true;
            this.YourChange.Font = new System.Drawing.Font("Pixeboy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YourChange.Location = new System.Drawing.Point(260, 185);
            this.YourChange.Name = "YourChange";
            this.YourChange.Size = new System.Drawing.Size(264, 27);
            this.YourChange.TabIndex = 1;
            this.YourChange.Text = "Your Change : ";
            this.YourChange.Visible = false;
            this.YourChange.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChangeBag
            // 
            this.ChangeBag.BackgroundImage = global::Vending.Properties.Resources.Money_Bag;
            this.ChangeBag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeBag.Location = new System.Drawing.Point(430, -70);
            this.ChangeBag.Name = "ChangeBag";
            this.ChangeBag.Size = new System.Drawing.Size(60, 89);
            this.ChangeBag.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Interval = 25;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // PickUp
            // 
            this.PickUp.BackColor = System.Drawing.Color.Transparent;
            this.PickUp.BackgroundImage = global::Vending.Properties.Resources.Pick_up;
            this.PickUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PickUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PickUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PickUp.Location = new System.Drawing.Point(403, 607);
            this.PickUp.Name = "PickUp";
            this.PickUp.Size = new System.Drawing.Size(164, 85);
            this.PickUp.TabIndex = 1;
            this.PickUp.UseVisualStyleBackColor = false;
            this.PickUp.Visible = false;
            this.PickUp.Click += new System.EventHandler(this.PickUp_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Home.Location = new System.Drawing.Point(403, 807);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(164, 74);
            this.Home.TabIndex = 3;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Visible = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::Vending.Properties.Resources.Exit;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Location = new System.Drawing.Point(805, 828);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(137, 53);
            this.Exit.TabIndex = 4;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Visible = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Page4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Vending.Properties.Resources.BG3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.PickUp);
            this.Controls.Add(this.ChangeHole);
            this.Controls.Add(this.Receive);
            this.Controls.Add(this.ItemHole);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Page4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRPVENDING";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Page4_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Page4_FormClosed);
            this.Load += new System.EventHandler(this.Page4_Load);
            this.ItemHole.ResumeLayout(false);
            this.ChangeHole.ResumeLayout(false);
            this.ChangeHole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ItemHole;
        private System.Windows.Forms.Panel Bag;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Receive;
        private System.Windows.Forms.Panel ChangeHole;
        private System.Windows.Forms.Panel ChangeBag;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button PickUp;
        private System.Windows.Forms.Label YourChange;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Exit;
    }
}