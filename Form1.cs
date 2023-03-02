using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICTURE_BOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar.Visible = true; this.pictureBoxMostrar2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar.Visible = false; this.pictureBoxMostrar2.Visible = false;
        }
    }
}
