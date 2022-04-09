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
    public partial class Page6 : Form
    {
        public Page6()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Page1 p1 = new Page1();
            p1.Tag = this;
            p1.Show(this);
            Hide();
        }

        private void Page6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Page6_Load(object sender, EventArgs e)
        {

        }
    }
}
