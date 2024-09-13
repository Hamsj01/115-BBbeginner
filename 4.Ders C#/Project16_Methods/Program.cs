namespace Project16_Methods;

class Program
{
    /*
        <Erişim belirleyici> <Geri dönüş tipi> MetotAdı(parametre1_tipi parametre1_adı, parametre2_tipi parametre2_adı....)
        {
            Metot gövdesi:
            İşlemleri burada gerçekleştireceğiz.
            return geri_döndürelecek_değer;
            return keywordü sadece metot geriye bir değer döndürülecekse kullanılır.
        }

        DRY-Don't Repeat Yourself!
    */

    static void Greet()
    {
        Console.WriteLine("Merhaba Drogba");
    }
    static string Greet2(string name, bool gender)

    {
        if(gender)
        {
            return $"Merhaba {name} Hanım ..";
        }
        return $"Merhaba {name} Bey ..";


    }

    static int Sum1()
    {
        int a=40, b=50, c=a+b;
        return c;  //tüm kod yolları döndüremiyor
    }

    static int Sum2(int number1, int number2)
    {
        int result = number1+number2;
        return result;

    }

    static double SumSqrt(double number1, double number2)
    {
        double total= number1+number2;
        double result = Math.Sqrt(total);
        return result;
    }
    static void SamperNumberValue(ref int originalNumber) //ref alttaki koda yansıdı
{
        originalNumber+=3;
        System.Console.WriteLine($"Metodun içindeki yazdırma satırı:{originalNumber}");

}

static void Bolme(int bolunen, int bolen, out int bolum, out int kalan)
{
    bolum = bolunen / bolen;
    kalan = bolunen % bolen;


}
    static void Main(string[] args)
    {
        int bolum;
        int kalan;
        Bolme(8, 3, out bolum, out kalan); // out ile yukarıdaki referans ile çalışıyor.
        Console.WriteLine($"8/3={bolum}\n8/3 işleminden kalan: {kalan}");
        
        // Greet();            //(): parantezi metotu çalıştır komutunu
        // int x = Sum1();     //abs mutlak değer.
        // int y= Sum2(50,70);
        // int z=Sum2(90,250);
        // System.Console.WriteLine(x+y+z);

        // double result1 = SumSqrt(5, 11); //4
        // double result2 = SumSqrt(4, 12); //4
        // double result3 = SumSqrt(7, 42); //7
        // double result4 = SumSqrt(2, 23); //5
        // System.Console.WriteLine(Greet2("Burhan", false ));
        // System.Console.WriteLine(Greet2("Miraç" , false ));


        // int originalNumber=15;
        // System.Console.WriteLine($"Metot çağırılmadan önceki orijinalNumber değeri: {originalNumber}");

        // SamperNumberValue(ref originalNumber); //burada yansıdı

        // System.Console.WriteLine($"Metot çağırılmadan sonraki orijinalNumber değeri: {originalNumber}");



    }

}
