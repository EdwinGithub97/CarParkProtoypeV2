using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkPrototype
{
    public partial class Start : Form
    {
        Form1 carPark;
        public Start()
        {
            InitializeComponent();
            carPark = new Form1();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            carPark.Show();
            this.Hide();
        }
    }
}
