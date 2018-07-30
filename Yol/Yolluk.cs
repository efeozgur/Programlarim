using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yol
{
    public class Yolluk
    {

        private const double UstDerece = 39.85;
        private const double AltDerece = 38.75;
        private const double EkC = 45.20;
        private const double EkB = 48.15;
        private const double EkA = 51.60;

        private readonly int _kadroDerecesi;
        private readonly int _kacKm;
        private readonly int _kacKisi;
        private readonly int _seyahatSuresi;
        private readonly double _tasitUcret;
        private readonly bool _esDurumu; 


        public Yolluk(int kadroDerecesi, int kacKm, int seyahatSuresi, double tasitUcret, int kacKisi, bool esDurumu)
        {
            _kadroDerecesi = kadroDerecesi;
            _esDurumu = esDurumu;
            _kacKm = kacKm;
            _seyahatSuresi = seyahatSuresi;
            _tasitUcret = tasitUcret;
            _kacKisi = kacKisi; 
        }



        public double YevmiyeMiktari()
        {
            if (_kadroDerecesi >= 1 && _kadroDerecesi <= 4)
            {
                return UstDerece;
            }

            if (_kadroDerecesi >= 5 && _kadroDerecesi <= 15)
            {
                return AltDerece;

            }

            if (_kadroDerecesi >= 3000 && _kadroDerecesi < 5800)
            {
                return EkC;
            }

            if (_kadroDerecesi >= 5800 && _kadroDerecesi < 8000)
            {
                return EkB;
            }

            if (_kadroDerecesi >= 8000)
            {
                return EkA;
            }

            return AltDerece;
        }




        public double yevmiye()
        {
            int digerleri = 0, kendi=0;
            double ailesi=0, kendisi=0; 

            if (_kacKisi>=1 && _kacKisi<=4)
            {
                digerleri = _kacKisi - 1;
                kendi = _kacKisi - digerleri;
                ailesi = digerleri * YevmiyeMiktari() * 10;
                if (_esDurumu)
                {
                    kendisi = kendi * YevmiyeMiktari() * 20/2;
                } else
                    kendisi = kendi * YevmiyeMiktari() * 20;

            }
            return ailesi + kendisi;



        }


       public double yolMesafeUcreti()
       {
           if (!_esDurumu)
           {
               double oran = YevmiyeMiktari() * 5 / 100;
               return oran * _kacKm;

            }

           return 0; 
       }

        public double seyahatSure()
        {
            if (_seyahatSuresi>24)
            {
                return YevmiyeMiktari() * 2*_kacKisi;
            }

            return YevmiyeMiktari()*_kacKisi;
        }

        public double tasitUcreti()
        {
            return _tasitUcret*_kacKisi;
        }

        public double toplam()
        {
            return yevmiye() + yolMesafeUcreti() + seyahatSure() + tasitUcreti();
        }
    }
}


