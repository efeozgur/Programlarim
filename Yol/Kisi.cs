using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yol
{
    public class Kisi
    {
        private string adSoyad, unvani, dairesi, butceYili, ayrilisTarihi,baslangicYeri, varisYeri, akrabalikDerecesi, amirAdSoyad, amirUnvan;

        public Kisi(string adSoyad, string unvani, string dairesi, string butceYili, string ayrilisTarihi, string baslangicYeri, string varisYeri, string akrabalikDerecesi, string amirAdSoyad, string amirUnvan)
        {
            this.adSoyad = adSoyad;
            this.unvani = unvani;
            this.dairesi = dairesi;
            this.butceYili = butceYili;
            this.ayrilisTarihi = ayrilisTarihi;
            this.baslangicYeri = baslangicYeri;
            this.varisYeri = varisYeri;
            this.akrabalikDerecesi = akrabalikDerecesi;
            this.amirAdSoyad = amirAdSoyad;
            this.amirUnvan = amirUnvan;
        }
    }
}
