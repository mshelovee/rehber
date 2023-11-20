using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace rehber__96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtAranan.Text;
            int sayac = 0;
            for (int i = 0; i < lbAdlar.Items.Count; i++)
            {
                if (aranan == lbAdlar.Items[i].ToString())
                {
                    sayac++;
                }
            }
            if (sayac == 0)
            {
                lblSonuc.Text= "Kişi Bulunamadı";
            }
            else
            {
                lblSonuc.Text =sayac + "  Kişi Bulundu";
            }
        }
    }
}
