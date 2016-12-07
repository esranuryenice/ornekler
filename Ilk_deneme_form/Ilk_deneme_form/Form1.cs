using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ilk_deneme_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Merhaba");
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ad" + ad_txt.Text + "\nsifre" + sifre_txt.Text);
        }
    }
}
