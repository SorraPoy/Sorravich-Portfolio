
namespace Vending
{
    partial class Page2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page2));
            this.INSERT_MONEY = new System.Windows.Forms.PictureBox();
            this.Text_money = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.BackP2 = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MoneyHole = new System.Windows.Forms.Panel();
            this.Coin = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.INSERT_MONEY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.MoneyHole.SuspendLayout();
            this.SuspendLayout();
            // 
            // INSERT_MONEY
            // 
            this.INSERT_MONEY.BackColor = System.Drawing.Color.Transparent;
            this.INSERT_MONEY.BackgroundImage = global::Vending.Properties.Resources.Insert_money;
            this.INSERT_MONEY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.INSERT_MONEY.Location = new System.Drawing.Point(275, 215);
            this.INSERT_MONEY.Name = "INSERT_MONEY";
            this.INSERT_MONEY.Size = new System.Drawing.Size(421, 92);
            this.INSERT_MONEY.TabIndex = 0;
            this.INSERT_MONEY.TabStop = false;
            this.INSERT_MONEY.Click += new System.EventHandler(this.INSERT_MONEY_Click);
            // 
            // Text_money
            // 
            this.Text_money.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_money.BackColor = System.Drawing.Color.DarkViolet;
            this.Text_money.Font = new System.Drawing.Font("Pixeboy", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Text_money.Location = new System.Drawing.Point(346, 331);
            this.Text_money.MaxLength = 3;
            this.Text_money.Name = "Text_money";
            this.Text_money.Size = new System.Drawing.Size(281, 73);
            this.Text_money.TabIndex = 1;
            this.Text_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_money.Click += new System.EventHandler(this.Text_money_Click);
            this.Text_money.TextChanged += new System.EventHandler(this.Text_money_TextChanged);
            this.Text_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_money_KeyPress);
            this.Text_money.Validating += new System.ComponentModel.CancelEventHandler(this.Text_money_Validating);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Image = global::Vending.Properties.Resources.Save;
            this.Save.Location = new System.Drawing.Point(346, 446);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(281, 88);
            this.Save.TabIndex = 2;
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // BackP2
            // 
            this.BackP2.BackColor = System.Drawing.Color.Transparent;
            this.BackP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackP2.Image = global::Vending.Properties.Resources.Back;
            this.BackP2.Location = new System.Drawing.Point(50, 810);
            this.BackP2.Name = "BackP2";
            this.BackP2.Size = new System.Drawing.Size(200, 100);
            this.BackP2.TabIndex = 3;
            this.BackP2.UseVisualStyleBackColor = false;
            this.BackP2.Click += new System.EventHandler(this.BackP2_Click);
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.Transparent;
            this.Continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Continue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Continue.Image = global::Vending.Properties.Resources.Continue1;
            this.Continue.Location = new System.Drawing.Point(638, 830);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(298, 80);
            this.Continue.TabIndex = 4;
            this.Continue.UseVisualStyleBackColor = false;
            this.Continue.Visible = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MoneyHole
            // 
            this.MoneyHole.BackColor = System.Drawing.Color.Transparent;
            this.MoneyHole.BackgroundImage = global::Vending.Properties.Resources.Textbox;
            this.MoneyHole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MoneyHole.Controls.Add(this.Coin);
            this.MoneyHole.Location = new System.Drawing.Point(346, 600);
            this.MoneyHole.Name = "MoneyHole";
            this.MoneyHole.Size = new System.Drawing.Size(281, 100);
            this.MoneyHole.TabIndex = 6;
            this.MoneyHole.Visible = false;
            this.MoneyHole.Paint += new System.Windows.Forms.PaintEventHandler(this.MoneyHole_Paint);
            // 
            // Coin
            // 
            this.Coin.BackgroundImage = global::Vending.Properties.Resources.coin;
            this.Coin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Coin.Location = new System.Drawing.Point(122, -25);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(45, 43);
            this.Coin.TabIndex = 0;
            this.Coin.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Page2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Vending.Properties.Resources.BG3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.MoneyHole);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.BackP2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Text_money);
            this.Controls.Add(this.INSERT_MONEY);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Page2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRPVENDING";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Page2_FormClosing);
            this.Load += new System.EventHandler(this.Page2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.INSERT_MONEY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.MoneyHole.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox INSERT_MONEY;
        private System.Windows.Forms.Button BackP2;
        private System.Windows.Forms.Button Continue;
        public System.Windows.Forms.Button Save;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox Text_money;
        private System.Windows.Forms.Panel MoneyHole;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Coin;
        private System.Windows.Forms.Timer timer2;
    }
}