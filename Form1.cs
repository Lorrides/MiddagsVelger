using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddagsVelger
{
    public partial class Form1 : Form
    {
        MiddagLager meny = new MiddagLager() { Tilfeldig = new Random() };

        public Form1()
        {
            InitializeComponent();
            label1.Text = meny.GetMenuItem();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = meny.GetMenuItem();
        }
    }
}
