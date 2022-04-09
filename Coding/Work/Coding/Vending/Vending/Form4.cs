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
    public partial class Page4 : Form
    {
        public static int Change;
        public Page4()
        {
            InitializeComponent();
        }

        private void Page4_Load(object sender, EventArgs e)
        {
            int Money = int.Parse(Page2.PassText);

            if(Page3.Price == 15)
            {
                Change = Money - 15;
                YourChange.Text = string.Format("YOUR CHANGE : " + Change);
            }
            else if(Page3.Price == 20)
            {
                Change = Money - 20;
                YourChange.Text = string.Format("YOUR CHANGE : " + Change);
            }
            else if (Page3.Price == 25)
            {
                Change = Money - 25;
                YourChange.Text = string.Format("YOUR CHANGE : " + Change);
            }
            else if (Page3.Price == 30)
            {
                Change = Money - 30;
                YourChange.Text = string.Format("YOUR CHANGE : " + Change);
            }
            else if (Page3.Price == 35)
            {
                Change = Money - 35;
                YourChange.Text = string.Format("YOUR CHANGE : " + Change);
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bag.Location = new Point(Bag.Location.X, Bag.Location.Y + 5);
            if (Bag.Location.Y >= 50)
            {
                timer1.Stop();
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Receive_Click(object sender, EventArgs e)
        {
            ItemHole.Visible = false;
            Bag.Visible = false;
            Receive.Visible = false;
            ChangeHole.Visible = true;

            if (Change == 0)
            {
                ChangeBag.Visible = false;
                PickUp.Visible = false;
                Home.Visible = true;
                Exit.Visible = true;
            }
            else
            {
                ChangeBag.Visible = true;
                PickUp.Visible = true;
                Home.Visible = false;
                Exit.Visible = false;
            }

            YourChange.Visible = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ChangeBag.Location = new Point(ChangeBag.Location.X, ChangeBag.Location.Y + 5);
            if (ChangeBag.Location.Y >= 70)
            {
                timer2.Stop();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PickUp_Click(object sender, EventArgs e)
        {
            ChangeBag.Visible = false;
            ChangeHole.Visible = false;
            YourChange.Visible = false;
            PickUp.Visible = false;
            Home.Visible = true;
            Exit.Visible = true;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Page1 p1 = new Page1();
            p1.Show();
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Page4_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Page4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
