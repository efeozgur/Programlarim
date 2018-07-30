using System;
using Lists;
using Yol;


namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Yolluk yol = new Yolluk(2,121,23,20,1,true);
            Console.WriteLine("Yevmiye : " + yol.yevmiye());
            Console.WriteLine("Mesafe Ücreti : " + yol.yolMesafeUcreti());
            Console.WriteLine("Taşıt Ücreti : " + yol.tasitUcreti());
            Console.WriteLine("Seyahat Süresi : " + yol.seyahatSure());
            
            Console.WriteLine("Toplam : " + yol.toplam());
            Console.Read(); 
        }


        public static void hesapla1()
        {
        }
        public static void hesapla2()
        {
            bool cikis = true;

            while (cikis)
            {
                Console.Write("Miktarı Girin : ");
                var read = Console.ReadLine();

                if (!read.Equals(""))
                {
                    ISmmF sm = new SmmF(Double.Parse(read));

                    Console.WriteLine("Brüt tutar           : " + sm.brutTutar().ToString("#.##"));
                    Console.WriteLine("%18 KDV              : " + sm.kdv().ToString("#.##"));
                    Console.WriteLine("Stopaj               : " + sm.stopaj().ToString("#.##"));
                    Console.WriteLine("Kesinti Tutarı       : " + sm.kesintiToplam().ToString("#.##"));
                    Console.WriteLine("Net Ücret            : " + sm.netUcret().ToString("#.##"));


                    Console.Write("\nçıkmak için [q] devam için [enter] ");
                    string devam = Console.ReadLine();
                    if (devam == "q")
                    {
                        cikis = false;
                    }

                }
            }
        }

    }

}


class SmmF : ISmmF
{
    private double toplam;

    public SmmF(double toplam)
    {
        this.toplam = toplam;
    }

    public double brutTutar()
    {
        return toplam / 1.18;
    }

    public double kdv()
    {
        return brutTutar() * 18 / 100;
    }

    public double stopaj()
    {
        return brutTutar() * 20 / 100;
    }


    public double kesintiToplam()
    {
        return stopaj();
    }



    public double netUcret()
    {
        return toplam - kesintiToplam();
    }
}


