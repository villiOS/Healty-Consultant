using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YSA_Deneme
{
    public partial class Resim : Form
    {
        public Resim()
        {
            InitializeComponent();
        }

        private void Resim_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Width = this.ClientSize.Width;
            pictureBox1.Height = this.ClientSize.Height;
        }

        private void Resim_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Load(this.Text);
        }
    }
}
