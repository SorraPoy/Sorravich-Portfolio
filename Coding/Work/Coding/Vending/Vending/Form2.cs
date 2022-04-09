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
    public partial class Page2 : Form
    {
        public static string PassText;
        public Page2()
        {
            InitializeComponent();

        }

        private void INSERT_MONEY_Click(object sender, EventArgs e)
        {

        }

        public void Save_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MoneyHole.Show();
                Coin.Show();
                timer1.Start();
                Continue.Show();

                
                int money = int.Parse(Text_money.Text);
                Page3 pg = new Page3(money);
                pg.Value = money;
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Coin.Location = new Point(Coin.Location.X, Coin.Location.Y + 5);
            if (Coin.Location.Y >= 105)
            {
                timer1.Stop();
            }
        }

        private void BackP2_Click(object sender, EventArgs e)
        {
            Page1 p1 = new Page1();
            p1.Tag = this;
            p1.Show(this);
            Hide();
        }

        public void Text_money_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Text_money_Click(object sender, EventArgs e)
        {
            
        }

        private void Text_money_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Text_money.Text))
            {
                e.Cancel = true;
                Text_money.Focus();
                errorProvider1.SetError(Text_money, "Please enter number !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Text_money, null);
            }
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            PassText = Text_money.Text;
            Page3 pg3 = new Page3();
            pg3.Show();
            Hide();
        }

        private void MoneyHole_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void BackP3_Click(object sender, EventArgs e)
        {
            var p3 = (Page3)Tag;
            p3.Show();
            Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Page2_Load(object sender, EventArgs e)
        {

        }

        private void Page2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
