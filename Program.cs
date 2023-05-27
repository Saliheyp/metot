using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erişim belirteci geri_dönüş tipi metot_adi(parametrelerListesi/arguman)
            //{
                //komutlar
                //return
            //}
           int a = 2;
           int b = 3;
           Console.WriteLine(a+b);
           
           int sonuc = Topla(a,b);
           Console.WriteLine(sonuc);

           metodlar ornek = new metodlar();
           ornek.EkranaYazdir(Convert.ToString(sonuc));
           int sonuc2 = ornek.ArttirVeTopla(ref a,ref b);
           ornek.EkranaYazdir(Convert.ToString(sonuc2));
           Console.WriteLine(a+b);


           
           
        }

        static int Topla(int deger1,int deger2)
        {
            return(deger1+deger2);

        }
    }
    class metodlar
    {
        public void EkranaYazdir(string a)
        {
            Console.WriteLine(a);
        }
        public int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1++;
            deger2++;
            return (deger1 + deger2);
        }
    }
}