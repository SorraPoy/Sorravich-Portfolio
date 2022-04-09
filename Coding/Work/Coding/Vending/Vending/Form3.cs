using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vending
{
    public partial class Page3 : Form
    {
        public static int Price;
        public Page3()
        {
            InitializeComponent();
            
        }
        public Page3(int money)
        {
            InitializeComponent();
            //YourBalance.Text = money;
            this.Value = money;
        }
        public int Value { get; set; }


        private void Page3_Load(object sender, EventArgs e)
        {
            YourBalance.Text = string.Format("YOUR BALANCE : " + Page2.PassText);
            int Money = int.Parse(Page2.PassText);
            if (Money < 35 && Money >= 30)
            {
                PizzaBaht.Visible = false;
                HamburgerBaht.Visible = false;
                PizzaNIG.Visible = true;
                HamburgerNIG.Visible = true;
            }
            else if (Money < 30 && Money >= 25)
            {
                PizzaBaht.Visible = false;
                HamburgerBaht.Visible = false;
                FrenchfriesBaht.Visible = false;
                PizzaNIG.Visible = true;
                HamburgerNIG.Visible = true;
                FrenchfriesNIG.Visible = true;
            }
            else if (Money < 25 && Money >= 20)
            {
                PizzaBaht.Visible = false;
                HamburgerBaht.Visible = false;
                FrenchfriesBaht.Visible = false;
                IcecreamBaht.Visible = false;
                PizzaNIG.Visible = true;
                HamburgerNIG.Visible = true;
                FrenchfriesNIG.Visible = true;
                IcecreamNIG.Visible = true;
            }
            else if (Money < 20 && Money >= 15)
            {
                PizzaBaht.Visible = false;
                HamburgerBaht.Visible = false;
                FrenchfriesBaht.Visible = false;
                IcecreamBaht.Visible = false;
                DonutBaht.Visible = false;
                ChocolateBaht.Visible = false;
                CupcakeBaht.Visible = false;
                PizzaNIG.Visible = true;
                HamburgerNIG.Visible = true;
                FrenchfriesNIG.Visible = true;
                IcecreamNIG.Visible = true;
                DonutNIG.Visible = true;
                ChocolateNIG.Visible = true;
                CupcakeNIG.Visible = true;
            }
            else if (Money < 15 && Money >= 0)
            {
                PizzaBaht.Visible = false;
                HamburgerBaht.Visible = false;
                FrenchfriesBaht.Visible = false;
                IcecreamBaht.Visible = false;
                DonutBaht.Visible = false;
                ChocolateBaht.Visible = false;
                CupcakeBaht.Visible = false;
                SushiBaht.Visible = false;
                JuiceBaht.Visible = false;
                CookieBaht.Visible = false;
                PizzaNIG.Visible = true;
                HamburgerNIG.Visible = true;
                FrenchfriesNIG.Visible = true;
                IcecreamNIG.Visible = true;
                DonutNIG.Visible = true;
                ChocolateNIG.Visible = true;
                CupcakeNIG.Visible = true;
                SushiNIG.Visible = true;
                JuiceNIG.Visible = true;
                CookieNIG.Visible = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackP3_Click(object sender, EventArgs e)
        {
            Page2 p2 = new Page2();
            p2.Tag = this;
            p2.Show(this);
            Hide();
            
        }

        private void Balance_Click(object sender, EventArgs e)
        {

        }

        private void Balance_Click_1(object sender, EventArgs e)
        {

        }

        private void Balance_TextChanged(object sender, EventArgs e)
        {

        }

        private void CookieBaht_Click(object sender, EventArgs e)
        {
            Price = 15;
            Page4 p4 = new Page4();
            p4.Show();
            Hide();
        }

        private void JuiceBaht_Click(object sender, EventArgs e)
        {
            Price = 15;
            Page4 p4 = new Page4();
            p4.Show();
            Hide();
        }

        private void SushiBaht_Click(object sender, EventArgs e)
        {
            Price = 15;
            Page4 p4 = new Page4();
            p4.Show();
            Hide();
        }

        private void CupcakeBaht_Click(object sender, EventArgs e)
        {
            Price = 20;
            Page4 p4 = new Page4();
            p4.Show();
            Hide();
        }

        private void ChocolateBaht_Click(object sender, EventArgs e)
        {
            Price = 20;
            Page4 p4 = new Page4();
            p4.Show();
            Hide();
        }

        private void DonutBaht_Click(object sender, EventArgs e)
        {
            Price = 20;
            Page4 p4 = new Page4();
            p4.Show();
            Hide();
        }

        private void IcecreamBaht_Click(object sender, EventArgs e)
        {
            Price = 25;
            Page4 p4 = new Page4();
            p4.Show();
            Hide();
        }

        private void FrenchfriesBaht_Click(object sender, EventArgs e)
        {
            Price = 30;
            Page4 p4 = new Page4();
            p4.Show();
            Hide();
        }

        private void HamburgerBaht_Click(object sender, EventArgs e)
        {
            Price = 35;
            Page4 p4 = new Page4();
            p4.Show();
            Hide();
        }

        private void PizzaBaht_Click(object sender, EventArgs e)
        {
            Price = 35;
            Page4 p4 = new Page4();
            p4.Show();
            Hide();
        }

        private void Page3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
