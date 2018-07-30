using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lists;

namespace Serbest_Meslek_Uygulaması
{
    public partial class SerbestMeslekMakbuzuFormu : Form
    {
        public SerbestMeslekMakbuzuFormu()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                SMM smm = new SMM(Double.Parse(tbTutar.Text));
                tbBrut.Text = smm.brutTutar().ToString("#.##");
                tbKdv.Text = smm.kdv().ToString("#.##");
                tbStopaj.Text = smm.stopaj().ToString("#.##");
                tbKesinti.Text = smm.kesintiToplam().ToString("#.##");
                tbNetOdenen.Text = smm.netUcret().ToString("#.##");
            }
            catch (Exception exception)
            {

                MessageBox.Show("Bu alan boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTutar.Focus();
            }

        }

        private void tbTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            var c = e.KeyChar;
            if (!Char.IsDigit(c) && !Char.IsControl(c) && c != ',')
            {
                MessageBox.Show("Bu alana sadece rakam girilebilir!!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }


    }
}
