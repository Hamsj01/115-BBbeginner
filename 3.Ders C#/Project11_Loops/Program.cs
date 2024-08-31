namespace Project11_Loops;

class Program
{
    static void Main(string[] args)
    {
        #region for
        //     for(int counter=1; counter <= 200; counter= counter+1)
        //     {
        //     //Döngü gövdesi: Döngü içerisinde tekrar tekrar çalıştırmasını istediğimiz kodlar
        //         System.Console.WriteLine($"{counter}.Merhaba dünya!"); //Burada sadece merhaba dünya yazsaydık bize 200 tane "Merhaba dünya!" yazıcaktı eğer $"{counter}.Merhaba dünya!" yazarsak başına 1. , 2. , 3. , ... koyar.
        // } 

        // for (int i =1; i<=1255; i = i+1)
        // {
        //     System.Console.WriteLine();
        // }


        //ekrana 1-10 arasındaki sayıları yazdıran progrmaı hazırlayınız.
        // string message;
        // int counter=1;
        // for (int i = 100 ; i <= 200; i++)
        // {
        //     message=$"Sayı{counter++}: {i}";
        //     System.Console.WriteLine(message);
        // }


        //1-10 arasındaki çift sayıları ekrana yazdırın.
        // for (int i = 1; i <= 10; i++)
        // {
        // if (i % 2 == 0) // 2 ye bölümünden kalan 0 ise yazdır
        // {
        //   System.Console.WriteLine(i);  
        // }
        // }


        // Kullanıcıdan iki sayı alın. Bu iki sayıdan çift olanı alın.
        // System.Console.WriteLine("Alt sınırı giriniz: ");
        // int min= int.Parse(Console.ReadLine());
        // min = min % 2 == 0 ? min: ++min;
        // System.Console.WriteLine("Üst sınırı giriniz: ");
        // int max = int.Parse(Console.ReadLine());

        // for (int i = min; i <= max; i+=2)
        // {
        //     System.Console.WriteLine(i);
        // }

        // Kullanıcının firdiği sayının faktörüyelini hesaplayan programı yazınız.
        // System.Console.WriteLine("Faktöriyel hesapla: ");
        // int value=int.Parse(Console.ReadLine());
        // int factorial=1;
        // for (int i = 2; i <= value; i++)
        // {
        //     factorial*=i;
        // }
        // System.Console.WriteLine($"{value}!={factorial}");

        // System.Console.WriteLine("Faktöriyel hesapla: ");
        // int value = int.Parse(Console.ReadLine());
        // int factorial = 1;
        // for (int i = value-1; i > 1; i--)
        // {
        //     factorial *= i;
        // }
        // System.Console.WriteLine($"{value}!={factorial}");
        #endregion


        #region örnek++


        // int a =33;
        // int b= ++a + 3; //başa ++ yazıldığında çıktı : 34 37
        // System.Console.WriteLine(a); // sona ++ yazıldığında çıktı: 34 36
        // System.Console.WriteLine(b);
        #endregion


        #region while
        // int i=1;
        // while (i <=5)
        // {
        //     System.Console.WriteLine($"{i} Merhamet edin efendim");
        //     i++;
        // } çıktı:1 Merhamet edin efendim
                // 2 Merhamet edin efendim
                // 3 Merhamet edin efendim
                // 4 Merhamet edin efendim
                // 5 Merhamet edin efendim


        // int total = 0;
        // string input="";
        // while (input!="exit")
        // {
        //     System.Console.WriteLine("Sayı(Çıkış için exit): ");
        //     input = Console.ReadLine();
        //     if (int.TryParse(input, out int intputNumber))
        //     {
        //         total += intputNumber;
        //     }
        //     else if (input !="exit")
        //     {
        //         System.Console.WriteLine("Geçerli bir değer giriniz!");
        //     }
        // }


        // Kullanıcıdan arka arakya alınacak sayıalrı toplayan kodu hazırlayınız. Ancak kullanıcının girdiği sayıların toplamı 100'den büyük veya eşitse program sona ersin toplamı ekrana yazsın.


        int a=0;
        string input="";
        while (a=100)
        {
            System.Console.WriteLine("Toplamı 100'den küçük sayılar girin.");
            input=Console.ReadLine();
            if (int.TryParse(input, out int intputNumber))
            {
                a +=intputNumber;
            }
            else if (input = 100)

            {
                System.Console.WriteLine("");
            }
        }


        System.Console.WriteLine($"Toplam: {total}");
        #endregion
    }
}
