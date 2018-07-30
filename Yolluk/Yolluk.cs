namespace Yolluk
{
    public class Yolluk:IYolluk
    {
        private int kadroDerecesi, kimIcin, kacKm, seyahatSuresi;
        private double tasitUcret;
        

        public Yolluk(int kadroDerecesi, int kim, int kacKm, int seyahatSuresi, double tasitUcret)
        {
            this.kadroDerecesi = kadroDerecesi;
            kimIcin = kim;
            this.kacKm = kacKm;
            this.seyahatSuresi = seyahatSuresi;
            this.tasitUcret = tasitUcret;
        }

        public double yevmiye()
        {
            if ((kadroDerecesi>=1 && kadroDerecesi <=4) && kimIcin==1)
            {
                return 20 * 37.25;
            } else if (kadroDerecesi>4 && kadroDerecesi<=15 && kimIcin==2)
            {
                return 10 * 36.25;
            }

            return 0; 
        }

        public double yolMesafeUcreti()
        {
            double sonuc; 
            double ust = 37.25 * 5 / 100;
            double alt = 36.25 * 5 / 100;

            if (kadroDerecesi>=1 && kadroDerecesi<=4)
            {
                sonuc = kacKm * ust;
                return sonuc; 
            } else if (kadroDerecesi > 4 && kadroDerecesi <= 15)
            {
                return sonuc = kacKm * alt;
            }

            return 0; 

        }

        public double seyahatSure()
        {
            if (seyahatSuresi>24)
            {
                return yevmiye()*2;
            }
            else
            {
                return 37.25;
            }
        }

        public double tasitUcreti()
        {
            return tasitUcret;
        }

        public double toplam()
        {
            return yevmiye() + yolMesafeUcreti() + seyahatSure() + tasitUcreti();
        }
    }
}
