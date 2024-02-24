using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.unite_uygulama_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2 ;
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);
            if (rbTopla.Checked == true)
            {
                string sonuc = (sayi1 + sayi2).ToString();
                MessageBox.Show(sonuc);
                    
            }
            else
            {
                string sonuc = (sayi1 - sayi2).ToString();
                MessageBox.Show(sonuc);
            }

        }
    }
}
