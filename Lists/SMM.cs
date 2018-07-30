namespace Lists
{
    public class SMM : ISmmF
    {
        private double toplam;

        public SMM(double toplam)
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
}
