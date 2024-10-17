using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO.Pipes;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
    #region 1. (yapamadım)
        
        // 10 elemanlı rastgele değerlerden oluşan bir tam sayı dizisi içinde, dizinin her bir elemanının yalnızca bir önceki ve bir sonraki elemanı ile kıyaslandığı bir algoritma yazın. Bu algoritma, yalnızca kendinden önceki sayı ve kendinden sonraki sayı büyük olan elemanları bulmalı ve bunları ekrana yazdırmalıdır.

        // int [] RndSayi= new int[10];
        // System.Console.WriteLine("Dizi: ");
        // for (int i = 0; i < 10; i++)
        // {
        //         Random rnd= new  Random();
        //         RndSayi[i]= rnd.Next(1,100);       
        //         System.Console.WriteLine(RndSayi[i]);
        // }
        // System.Console.WriteLine("Sırlama başlıyor: ..");

        //   for (int j = 1; j < 10; j++)
        //   {
        //     if (RndSayi[j-1]<RndSayi[j])
        //     {
        //         System.Console.Write($" {RndSayi[j]} > {RndSayi[j-1]}  ");
        //         if (j<9)
        //         {
        //             if(RndSayi[j]>RndSayi[j+1])
        //             Console.Write($" > {RndSayi[j+1]} ");
        //             if(RndSayi[j]<RndSayi[j+1])
        //             Console.Write($" < {RndSayi[j+1]} ");
                    
        //         }
        //     }
        //     else if (RndSayi[j-1]>RndSayi[j])
        //     {
        //         System.Console.Write($" {RndSayi[j]} < {RndSayi[j-1]} ");
        //         if (j<9)
        //         {
        //             if(RndSayi[j]>RndSayi[j+1])
        //             Console.Write($" < {RndSayi[j+1]} ");
        //             if(RndSayi[j]<RndSayi[j+1])
        //             Console.Write($" < {RndSayi[j+1]} ");
                    
        //         }
                    
        //     }
    
        //   }


            
    #endregion    

    #region 2. (diziden diziye çift)
        
        //Klavyeden girilen 10 sayıyı bir diziye atayın. Bu sayılardan çift olanları for döngüsü kullanarak ayrı bir diziye aktarın. Ardından bu çift sayı dizisini küçükten büyüğe sıralayın

        // int[] OnSayi={11,36,77,99,665,142,666,9498,22,78};
        // Console.WriteLine("Çift sayılar dizisi küçükten büyüğe sırlanışı: ");
        // for (int i = 0; i < OnSayi.Length; i++)
        // {
        //     Array.Sort(OnSayi);
        //     if(OnSayi[i]%2==0)
        //     {
        //         int a=OnSayi[i];
        //         int j=0;
        //         int[] CiftOnSayi=new int[6];
        //         CiftOnSayi[j]=a;
        //         System.Console.Write($"{CiftOnSayi[j]} ");
        //         j++;

                
        //     }
        // }
        



    #endregion

    #region 3. poz/neg
    //10 elemanlı rastgele değerlerden oluşan bir dizideki tüm pozitif sayıları ve negatif sayıları ayrı dizilere ayıran ve her iki diziyi de ekrana yazdıran bir program yazın. İşlemi gerçekleştirmek için while döngüsü kullanın.

        
    // Random rnd=new Random();
    // int[] sayilar = new int[10];
    // int[] Nsayilar = new int[10];
    // int[] Psayilar = new int[10];
    // int[] sıfır= new int[1];


    
    // int i=0 ;
    // while (i<sayilar.Length)
    // {
    //     sayilar[i]=rnd.Next(-50,+50);
    //     if (sayilar[i]<0)
    //     Nsayilar[i]=sayilar[i];
    //     if (sayilar[i]>0)
    //     Psayilar[i]=sayilar[i];
    //     if (sayilar[i]==0)
    //     sıfır[i]=sayilar[i];
    //     i++;
        
    // }

    // System.Console.WriteLine("Pozitif sayılar");
    // foreach (var ps in Psayilar)
    // {
    //     System.Console.WriteLine(ps);
    // }

    // System.Console.WriteLine("Negatif Sayılar");
    // foreach (var ns in Nsayilar)
    // {
    //     System.Console.WriteLine(ns);
    // }

    
        
    #endregion
    
    #region 4. (yapamadım)
        
    // 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde tekrar eden elemanları bulan bir program yazın. Diziyi tararken, elemanların hangi pozisyonlarda(kaçıncı indexte) tekrarlandığını ekrana yazdırın. Bu işlemi hem for hem de foreach döngüleri ile gerçekleştirin.

        // int sayaç=0;
        // int sayaç1 = 0;
        // int sayaç2= 0;
        // bool tekrar=false;
        // int[] dizi = new int[20];
        // int[] tekrarElDiz = new int[20];

        // int addSayaç=0;

        // Random rnd = new Random();

        // for (int i = 0; i < dizi.Length ; i++)
        // {
        //     dizi[i]=rnd.Next(1,21);
        // }

        // foreach (var eleman in dizi)
        // {
        //     System.Console.WriteLine($" {sayaç}. Elemanı =>{eleman}");
        //     sayaç++;
        // }

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     for (int j = 0; j < dizi.Length; j++)
        //     {
        //         if (dizi[i] == dizi[j])
        //         {
        //             Console.WriteLine($"Sayı {dizi[i]} index {i} ve index {j} tekrar ediyor.");
        //         }
        //     }
        // }
        



    #endregion
    
    #region 5.(yapamadım)

    //Klavyeden girilen bir sayının, 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde olup olmadığını kontrol eden bir algoritma yazın. Eğer sayı dizide varsa, sayının dizideki yerini ve tekrar sayısını ekrana yazdırın.

    #endregion
    
    #region 6.
        
    //100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde en büyük ve en küçük sayıyı bulan programı yazın.

    // Random rnd=new Random();
    // int [] Numbers=new int[100];
    // int max=int.MinValue;
    // int min=int.MaxValue;
    // System.Console.WriteLine("Rasgele sayılar: ");
    // for (int i = 0; i < Numbers.Length; i++)
    // {
    //     int RandomNumber=rnd.Next(-785,1001);
    //     Numbers[i]=RandomNumber;
    //     if (Numbers[i]>max)
    //     max=Numbers[i];
    //     if (Numbers[i]<min)
    //     min=Numbers[i];
    //     System.Console.WriteLine(Numbers[i]);
    // }
    // System.Console.WriteLine("-------------");
    // System.Console.WriteLine($"En büyük sayı {max}");
    // System.Console.WriteLine($"En küçük sayı {min}");

    #endregion
    
    #region 7.
        //50 elemanlı rastgele değerlerden oluşan bir tam sayı dizisindeki tüm çift sayıları toplayan ve bu toplamı ekrana yazdıran bir program yazın. foreach döngüsü kullanarak bu işlemi gerçekleştirin.

        // int[] sayilar=new int[50];
        // Random rnd=new Random();
        // int toplam=0;
        // System.Console.WriteLine("Rastgele Sayılar: ");
        // for (int i = 0; i < sayilar.Length; i++)
        // {
        //     sayilar[i]=rnd.Next(0,600);
        //     System.Console.WriteLine(sayilar[i]);
        // }
        // foreach (int sayi in sayilar)
        // {
        //     if (sayi%2==0)
        //     {
        //         toplam+=sayi;
        //     }
        // }
        // System.Console.WriteLine("***********************************************************");
        // System.Console.WriteLine("Rastgele sayıların içindeki çift sayıların toplamıııııııı:");
        // System.Console.WriteLine(toplam);

    #endregion
    
    #region 8.(yapamadım)

    //Klavyeden girilen bir sayıyı, 10 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde aratın. Eğer sayı dizide yoksa, diziyi sıralayın ve sayıyı dizinin doğru(olması gereken sıra) yerine ekleyin. Ekledikten sonra yeni diziyi ekrana yazdırın.

    // int[] sayilar=new int[10];
    // Random rnd=new Random();
    // int RasgeleSayilar=rnd.Next(0,100);
    // for (int i = 0; i < sayilar.Length; i++)
    // {
    //     sayilar[i]=RasgeleSayilar;
    // }
    //     Array.Sort(sayilar);

    // int kullaniciSayi=int.Parse(System.Console.ReadLine());
    // for (int j = 0; j < sayilar.Length; j++)
    // {
    // if (sayilar[j]==kullaniciSayi)
    // {
    //     foreach (var sayi in sayilar)
    //     {
    //         System.Console.WriteLine(sayi);
    //     }
    //     break;
    // }
    // else
    // {
        
    // }
        
    // }




    #endregion
    
    #region 9.
        
    //Verilen bir dizinin yalnızca pozitif sayılarını ters çeviren bir algoritma yazın. Diziyi tararken, sadece pozitif sayıların yerini değiştirmelisiniz, diğer elemanlar aynı kalmalı.

    // int[] numbers={19,7856,-98456,-1023,98874,6543,24,-775};
    
    // for (int i = 0; i < numbers.Length; i++)
    // {
    //     if (numbers[i]<0)
    //     {
    //         Array.Reverse(numbers[i]);
    //         return;
    //     }

    
    // }

    #endregion
    
    #region 10.
        //10 elemanlı bir dizi oluşturun ve bu dizinin elemanlarını bir başka diziye ters sırada kopyalayın. İlk dizideki sıralama değişmeyecek, sadece ikinci dizideki sıralama ters olacak.

        // System.Console.WriteLine("10 elemanlı 1. dizi:  ");
        // Random rnd= new Random();
        // int[] sayilar= new int[10];
        // for (int i = 0; i < sayilar.Length; i++)
        // {
        //     int RastgeleSayilar=rnd.Next(0,50);
        //     sayilar[i]=RastgeleSayilar;
        //     System.Console.WriteLine(sayilar[i]);
        // }

        // System.Console.WriteLine("-------------------");
        // System.Console.WriteLine("10 elemanlı dizinin tersi:  ");
        // Array.Reverse(sayilar);
        // foreach (var sayi in sayilar)
        // {
        //     System.Console.WriteLine(sayi);
            
        // }
    
    #endregion
    
    #region 11.
        //Klavyeden girilen bir cümlenin kelimelerini bir diziye aktarın. while döngüsü ile bu kelimeleri tersten ekrana yazdırın.

        // System.Console.WriteLine("Sabahlar sakin akşamlar hoppidik olur Kadıköyde...");
        // string[] kelimeler={"Sabahlar"," sakin "," akşamlar"," hoppidik", "olur", "Kadıköyde "};

        // System.Console.WriteLine("---------------------------------------");
        // int i=0;
        // while (i<kelimeler.Length)
        // {
        //     System.Console.Write(kelimeler[5-i]);
        //     i++;
        // }
        // System.Console.Write("...");
        

        
    #endregion
    
    #region 12.(yapamadım  )
        //100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde en sık tekrar eden elemanı bulan ve kaç defa tekrarlandığını ekrana yazdıran bir program yazın. Bu işlemi bir foreach döngüsü ile gerçekleştirin.

        // Random rastgele=new Random();
        // int[] sayilar=new int[100];
        // int sayaç=0;
        // for (int i = 0; i < sayilar.Length; i++)
        // {
        //     sayilar[i]=rastgele.Next(0,300);
        //     System.Console.WriteLine(sayilar[i]);
        // }



    #endregion
    
    #region 13.

    //Bir dizideki tek sayıları toplayan ve bu toplamın çift mi, tek mi olduğunu kontrol eden bir program yazın. Toplamla birlikte eğer toplam tek ise, "Toplam tek sayı" mesajı, çift ise "Toplam çift sayı" mesajı ekrana yazdırılmalı.

        // int[] sayilar= new int[10];
        // Random rnd=new Random();
        // System.Console.WriteLine("Sayılar: ");
        // int tekToplam=0;
        // for (int i = 0; i < sayilar.Length; i++)
        // {
        //     int rastgeleSayi=rnd.Next(0,51);
        //     sayilar[i]=rastgeleSayi;
        //     System.Console.WriteLine($"{sayilar[i]}");
        //     if (sayilar[i]%2==1)
        //     {
        //         tekToplam+=sayilar[i];
        //     }
        // }
        //     System.Console.WriteLine($"Sayıların içindeki tek sayıların toplamı: {tekToplam}");
        // if (tekToplam%2==0)
        // {
        //     System.Console.WriteLine("Bu yüzden toplam çift sayı.");
        // }
        // if (tekToplam%2==1)
        // {
        //     System.Console.WriteLine("Bu yüzden toplam tek sayı. ");
        // }


        





    #endregion
    
    #region 14.
        //20 elemanlı bir dizi oluşturun. Bu dizideki elemanların 3’e bölünebilenlerin toplamını bulan bir algoritma yazın. Sonucu ekrana yazdırırken her 5. elemandan sonra bir boşluk bırakın.

        // int[] sayilar= new int[20];
        // Random rnd=new Random();
        // System.Console.WriteLine("Sayılar: ");
        // int ucBToplam=0;
        // for (int i = 0; i < sayilar.Length; i++)
        // {
        //     int rastgeleSayi=rnd.Next(0,51);
        //     sayilar[i]=rastgeleSayi;
        //     if (i%5==0)
        //     System.Console.WriteLine("");
           
        //     System.Console.WriteLine($"{sayilar[i]}");
        //     if (sayilar[i]%3==0)
        //     ucBToplam+=sayilar[i];
            
            
        // }  
        // System.Console.WriteLine("Sayılar dizisindeki üçe bölünen sayıların toplamı: "); 
        // System.Console.WriteLine(ucBToplam); 

    #endregion
    
    #region 15.
    //Bir dizideki elemanları küçükten büyüğe sıralayan bir algoritma yazın. Ancak sıralama sırasında sadece tek sayılar sıralanmalı, çift sayılar yerlerinde kalmalıdır.

    // Random rnd=new Random();
    // int[] sayilar=new int[7];
    // for (int i = 0; i < sayilar.Length; i++)
    // {
    //     int RasgeleSayilar=rnd.Next(-10,+11);
    // }

    // System.Console.WriteLine();
    
    #endregion
    
    #region 16.
            
    //do-while döngüsü kullanarak, klavyeden girilen sayıları bir diziye ekleyin. Kullanıcı sıfır girdiğinde döngüden çıkın ve dizideki tüm sayılarla birlikte ortalamayı ekrana yazdırın.

    int[] sayilar=new int[10];
    int sayi=0;
    do
    {
    int sayi=int.Parse(Console.ReadLine());


    } while (sayi==0);



    #endregion

    
    
    
    
    
    
    
    
    
    
    
    }
}
