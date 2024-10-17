using System.Diagnostics;
using System.Runtime.InteropServices;

namespace For;

class Program
{
    static void Main(string[] args)
    {
        #region 1. Ardışık topla
        //1. Kullanıcıdan pozitif bir tam sayı girmesini isteyin. 1'den bu sayıya kadar olan tüm tam sayıların toplamını bulan ve sonucu ekrana yazdıran bir program yazın. Örneğin, kullanıcı 5 girdiğinde, program 1+2+3+4+5 toplamını hesaplayıp sonucu göstermelidir.

        // System.Console.WriteLine("Ardışık olarak hangi sayıya kadar toplansın: ");
        // int sayi=int.Parse(Console.ReadLine());
        // int toplam = 0;
        // for (int i = sayi; 0<=i ; i--)     
        // {
        //     toplam +=i;
        // }
        // System.Console.WriteLine(toplam);
        #endregion
       
        #region 2. Ardışık küpleri yazdır
       
            // System.Console.WriteLine("Hangi sayıya kadar küpleri görünsün:");
            // double kupleri=double.Parse(Console.ReadLine());
            // for (double i = kupleri ; kupleri >0; kupleri--)
            // {
                
            //     double sayiKupu= Math.Pow(kupleri,3);
            //     System.Console.WriteLine($"{kupleri} sayısının küpü={sayiKupu}");
            // }
            
        #endregion

        #region 3. Bölenler
            
            // System.Console.WriteLine("Bölen bulucu bir sayı giriniz: ");
            // double sayi=double.Parse(Console.ReadLine());
            // for (double i =sayi; i>=0; i-- ) 
            // {
            // if (sayi%i==0)
            // {
            //     System.Console.WriteLine(i);
            // }
            // }
        #endregion
    
        #region 4. Satır ***
        // System.Console.WriteLine("Yıldızlamak istediğiniz satır sayısı: ");
        // int satirSayi=int.Parse(Console.ReadLine());
        // for (int i = 1; i<=satirSayi; i++)
        // {
        //     for (int j = 1; j <=i; j++)
        //     {
        //         Console.Write("*");
        //     }
        // System.Console.WriteLine();
        // }
        #endregion
    
        #region 5. Asal sayı *

//         bool isPrime;
//         for (int i = 2; i <= 100; i++)
//         {
//          isPrime = true;  // Her sayı için isPrime'ı yeniden true yapıyoruz.
//         // 2 zaten asal sayıdır, onu direkt yazdırabiliriz.
//         if (i == 2)
//         {
//             System.Console.WriteLine(i);
//             continue; // 2 için döngünün geri kalanına gitmeden bir sonraki sayıya geçiyoruz.
//         }
//         // 3 ve üzeri sayılar için asal kontrolü
//         for (int bol = 2; bol < i; bol++)
//         {
//             if (i % bol == 0)  // Eğer i, herhangi bir sayıya tam bölünüyorsa asal değildir.
//             {
//                 isPrime = false;
//                 break;  // İlk bölünebilme durumunda döngüden çıkarız.
//             }
//         }
//         // Eğer isPrime hala true ise, bu sayı asaldır.
//         if (isPrime)
//         {
//             System.Console.WriteLine(i);
//         }
// }
        
        #endregion
        
        #region 6. 10 dan büyük kare
            //Kullanıcıdan 10'dan büyük bir pozitif tam sayı girmesini isteyin. 1’den bu sayıya kadar olan tüm sayıların karelerini hesaplayın ve her sayının karesini ekrana yazdırın. Örneğin, kullanıcı 12 girdiğinde, 1^2, 2^2, …, 12^2 sonuçlarını ekranda görmelidir.


            // System.Console.Write("10 dan büyük bir sayı giriniz: ");
            // int sayi=int.Parse(Console.ReadLine());
            // if (sayi<=10 )
            // {
            //     System.Console.WriteLine("Lütfen 10'dan büyük bir sayı giriniz");
                 
            // }
            // else
            // {
            // for (int i = 0; i <= sayi; i++)
            // {
            //     System.Console.WriteLine(Math.Pow(i,2));
            // }
            // }
        #endregion

        #region 7. Bu sayıya kadar olan çift sayıların toplamı
            
            //Kullanıcıdan bir pozitif tam sayı alın. Bu sayıya kadar olan çift sayıların toplamını hesaplayın ve sonucu ekrana yazdırın. Örneğin, kullanıcı 10 girerse, program 2+4+6+8+10 toplamını hesaplayıp sonucu göstermelidir.

            // System.Console.Write("Pozitif bir sayı giriniz: ");
            // int sayi=int.Parse(Console.ReadLine());
            // int toplam=0;

            // for (int i = 0; i <= sayi; i++)
            // {
            //     if ( i%2==0)
            //     {
            //          toplam +=i;
            //     }
            // }   
            // System.Console.WriteLine(toplam);         




        #endregion

        #region 8.
            
        #endregion

        #region 9
            
        #endregion

        #region 10. iki sayı arası çarpım

            //Kullanıcıdan iki pozitif tam sayı alın. İlk sayıdan başlayarak ikinci sayıya kadar olan sayıların çarpımını hesaplayan bir program yazın. Sonucu ekrana yazdırın. Örneğin, 3 ve 6 girildiğinde, 345*6 çarpımı hesaplanmalı ve ekranda gösterilmelidir.

        //     System.Console.WriteLine("İki sayı arasındaki tüm sayıları çarpan programa hoş geldiniz.");
        //     System.Console.WriteLine("-------------------------------------------------------------");
        //     System.Console.Write("Birinci sayıyı giriniz: ");
        //     int sayi1=int.Parse(Console.ReadLine());
        //     System.Console.Write("İkinci sayıyı giriniz: ");
        //     int sayi2=int.Parse(Console.ReadLine());
        //     int toplam=1;
        //     if (sayi1<=sayi2)
        // {
        //     for (int i=sayi1 ; i <= sayi2; i++)
        //     {
        //         toplam*=i;
        //     }
        // }
        //     else if (sayi1>sayi2)
        //     {
        //     for (int i=sayi2 ; i <= sayi1; i++)
        //         {
        //         toplam*=i;
        //         }

        //     }
        //     System.Console.WriteLine($"{sayi1} ile {sayi2} arasındaki sayıların çarpımı: {toplam}");
            #endregion









    }
}
    