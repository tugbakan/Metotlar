using System;

public class Program
{
    public static void Main(string[] args)
    {
        //   ***METOTLAR***
        //      erişim_belirteci geridönüş_tipi metot_adi(parametreListesi/Arguman)
        //      { 
        //       komutlar
        //      }
        int a=2;
        int b=3;
        Console.WriteLine(a+b);

        int result = Topla(a,b);

        Console.WriteLine(result);

        Metot ornek = new Metot();
        ornek.EkranaYazdir(Convert.ToString(result));

        int result2= ornek.ArttirveTopla(ref a, ref b);
        ornek.EkranaYazdir(Convert.ToString(result2));
        ornek.EkranaYazdir(Convert.ToString(a+b));
    }

    public static int Topla(int deger1, int deger2)
    {
        return(deger1+deger2);
    }
}

class Metot
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public int ArttirveTopla(ref int deger1, ref int deger2)
    {
        deger1 += 1;
        deger2 += 1;
        return deger1+deger2;
    }
}