namespace arayuzler_ornek
{
    public class Corolla : IOtomobil
    {
        public Marka hangiMarkaninAraci()
        {
            return Marka.Toyata;
        }

        public int kacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk standartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}