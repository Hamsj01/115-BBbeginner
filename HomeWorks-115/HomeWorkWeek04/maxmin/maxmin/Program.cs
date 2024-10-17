using System.Numerics;

namespace maxmin;

class Program
{
    static void Main(string[] args)
    {
        /*/Min Max

    Aşağıdaki programı for ve while ile ayrı ayrı yazınız.
    Kullanıcının gireceği 5 sayı arasındaki en büyük ve en küçük değeri bulup ekrana yazdıran programı yazınız. Örneğin kullanıcı sırasıyla 90,4,55,3,66 sayılarını girmişse program

    En Büyük=90 En Küçük=3

    şeklinde sonuç vermelidir.*/
#region while
    // int sayi, enBuyuk, enKucuk, i = 1;

    //     Console.Write(" 1. sayıyı girin: ");
    //     sayi = Convert.ToInt32(Console.ReadLine());
    //     enBuyuk = sayi;
    //     enKucuk = sayi;

    //     while (i < 5)
    //     {
    //         Console.Write($" {i + 1}. sayıyı girin: ");
    //         sayi = Convert.ToInt32(Console.ReadLine());

    //         if (sayi > enBuyuk)
    //         {
    //             enBuyuk = sayi;
    //         }

    //         if (sayi < enKucuk)
    //         {
    //             enKucuk = sayi;
    //         }
    //         i++;
    //     }

    //     Console.WriteLine($"En Büyük = {enBuyuk}");
    //     Console.WriteLine($"En Küçük = {enKucuk}");
    #endregion


    // int enBuyuk = int.MinValue;
    // int enKucuk = int.MaxValue;
    // //Kullanıcıdan 5 sayı almak için for döngüsü açıyoruz.
    // for(int i=0; i<5; i++)
    // {
    //   Console.WriteLine("Bir sayı giriniz:");
    //   int sayi= Convert.ToInt32(Console.ReadLine());

    //   if(sayi>enBuyuk)
    //   {
    //     enBuyuk=sayi;
    //   }
    //   if(sayi<enKucuk)
    //   {
    //     enKucuk=sayi;
    //   }
    // }
    // Console.WriteLine("En büyük sayı: " + enBuyuk);
    // Console.WriteLine("En küçük sayı: "+enKucuk);





    }
}
