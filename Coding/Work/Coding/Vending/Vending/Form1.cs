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
    public partial class Page1 : Form
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void VENDING_Click(object sender, EventArgs e)
        {

        }

        private void Start2_Click(object sender, EventArgs e)
        {
            Page2 p2 = new Page2();
            p2.Tag = this;
            p2.Show(this);
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page5 p5 = new Page5();
            p5.Tag = this;
            p5.Show(this);
            Hide();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            Page6 p6 = new Page6();
            p6.Tag = this;
            p6.Show(this);
            Hide();
        }

        private void Page1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Page1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Page1_Load(object sender, EventArgs e)
        {

        }
    }
}
