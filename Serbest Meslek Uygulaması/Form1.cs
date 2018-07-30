using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serbest_Meslek_Uygulaması
{
    public partial class anafrm : Form
    {
        public anafrm()
        {
            InitializeComponent();
        }

        private void serbestMeslekMakbuzuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerbestMeslekMakbuzuFormu smm = new SerbestMeslekMakbuzuFormu();
            smm.MdiParent = this;
            smm.Show();
        }
    }
}
