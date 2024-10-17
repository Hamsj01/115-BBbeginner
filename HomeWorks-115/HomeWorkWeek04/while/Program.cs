using System.Diagnostics;

namespace While;

class Program
{
    static void Main(string[] args)
    {
        #region 1. 0 yazınca girilen sayıları topla
            /* Kullanıcıdan pozitif tam sayılar girmesini isteyin. Kullanıcı sıfır girdiğinde, program sona erer ve girilen tüm sayıların toplamını ekrana yazdırır. Her sayının toplanmasından sonra kullanıcıya yeni bir sayı girmesi istenir. Program sadece sıfır girildiğinde sona ermelidir. */


            // bool dondurucu=true;
            // int toplam=0;
            // while (dondurucu=true)
            // {
            // System.Console.WriteLine("Sayi giriniz: ");
            // int sayi=int.Parse(Console.ReadLine());
            // toplam+=sayi;
            // if (sayi==0)
            // {
            //     dondurucu=false;
            //     break;
            // }
            // }
            // System.Console.WriteLine($"Girilen sayıların toplamı:{toplam}");


            
            


        #endregion
   
        #region 2. Büyük harfe çeviren while
            
            //Kullanıcıdan bir metin alın. Bu metindeki tüm harfleri büyük harfe çeviren bir program yazın. Sadece harf karakterleri büyük harfe çevrilmeli, diğer karakterler (noktalama işaretleri vb.) olduğu gibi kalmalıdır. Örneğin, "Merhaba Dünya!" metni "MERHABA DÜNYA!" olarak ekrana yazdırılmalıdır.

            // System.Console.WriteLine("Bir metin giriniz: ");
            // string metin=Console.ReadLine();
            // string bigMetin=metin.ToUpper();
            // System.Console.WriteLine("^^^^^^^^^^");
            // System.Console.WriteLine(bigMetin);

            // string metin = Console.ReadLine();
            // string sonuc = ""; //sonucun tutulacağı değişken
            // int i = 0; //başlangıç indexi

            // While döngüsü ile metindeki her karakteri kontrol et
            // while (i < metin.Length)
            // {
            //   char karakter = metin[i]; //Metinde o andaki karakter


            //   if (char.IsLetter(karakter)) // Eğer karakter bir harfse büyük harfe çevir
            //     sonuc += char.ToUpper(karakter); //büyük hrfe çevir ve ekle
            //   else
            //     sonuc += karakter; //harf değilse olduğu gibi ekler 

            //   i++; //bir sonraki harfe geçer.
            // }

            // Console.WriteLine(sonuc);
    


        #endregion
   
        #region 3. Negatif sayı girince pozitiflerin karesini alan program*

        // Kullanıcıdan sürekli pozitif tam sayılar alın. Kullanıcı negatif bir sayı girdiğinde, program sona erer ve bu sayılardan her birinin karesini ekrana yazdırır. Örneğin, 4, 5, -1 girildiğinde, program 16 ve 25'i gösterir, ardından sonlanır.

        // System.Console.WriteLine("Karesini almak istediğiniz pozitif sayıları girin: ");
        // bool pozitif=true;
        // double kare=1;
        // while (pozitif=true)
        // {
        //     double pozitifSayi=double.Parse(Console.ReadLine());
        //     if (pozitifSayi<0)
        //     {
        //         pozitif=false;
        //         break;
        //     }
        //     kare=Math.Pow(pozitifSayi,2);
        // }
        // System.Console.WriteLine(kare);
        


            
        #endregion
   
        #region 4. Rakamların toplamı
            
            // Kullanıcıdan bir sayı alın ve bu sayının rakamlarının toplamını while döngüsü ile hesaplayın. Sonucu ekrana yazdırın. Örneğin, 245 sayısı girildiğinde, program 2+4+5 işlemini yaparak sonucu ekranda göstermelidir.


            // System.Console.WriteLine("Rakamlarının toplamını bulmak istediğiniz sayı: ");
            // int sayi=int.Parse(Console.ReadLine());
            // int toplam=0;
            // while (sayi!=0)
            // {
            //    toplam +=sayi%10; // 666/10 kalan 6 
            //    sayi/=10; // 666/10 bölüm=66
            // }
            // System.Console.WriteLine(toplam);

        #endregion
   
        #region 5. Sayıyı tersine çevir
            
        //Kullanıcıdan alınan pozitif bir tam sayıyı tersine çeviren bir program yazın. Örneğin, kullanıcı 1234 girdiyse, program 4321 olarak ekrana yazdırmalıdır.

        // System.Console.WriteLine("Sayıyı çevir: ");
        // int sayi=int.Parse(Console.ReadLine());
        // int terssayi=0;

        // while (sayi>0)
        // {
        //     int sonBasamak=sayi%10;
        //     terssayi=terssayi*10+sonBasamak;
        //     sayi/=10;
        // }
        // System.Console.WriteLine(terssayi);

            



        #endregion
   
        #region 6. Metni tersine çevir
        
        //Kullanıcıdan bir metin alın ve bu metni tersten yazarak ekrana yazdırın. Örneğin, "Merhaba" girdisi "abahreM" olarak yazdırılmalıdır.

        // string metin=Console.ReadLine();
        
        

            
        

 
        #endregion
   
        #region 7. İki katına çıkarma
            
        //Kullanıcıdan bir pozitif tam sayı ve bir üst sınır değeri alın. İlk sayı üst sınırdan küçük olduğu sürece, sayıyı iki katına çıkararak yeniden kontrol edin. Bu işlem sayı üst sınırı geçene kadar devam etmelidir. Sonucu her aşamada ekrana yazdırın.

        // System.Console.WriteLine("Sürekli ikiye katlamak istediğiniz sayı nedir?: ");
        // int sayi=int.Parse(Console.ReadLine());
        // System.Console.WriteLine("Sınırı yazın: ");
        // int sinir=int.Parse(Console.ReadLine());
        // while (sayi<=sinir)
        // {
        //     System.Console.WriteLine(sayi);
        //     sayi*=2;
            
        // }


        #endregion
   
        #region 8. Kullanıcıdan pozitif tam sayılar girmesini isteyin. Kullanıcı 100’den büyük bir sayı girdiğinde program sona erer. Kaç tane sayı girildiğini, girilen sayıların toplamını ve girilen sayıların ortalamasını ekrana yazdırın.*(sadece while ile olur mu? ve 100 süz nasıl gireriz.)

    //     System.Console.WriteLine("Sayılar girin: ");
    //    bool sonlandır=true;
    //     int ortalama;
    //     int sayaç=0;
    //     int toplam=0;
    //    while (sonlandır=true)
    //    {
    //     int sayi=int.Parse(Console.ReadLine());
    //     toplam+=sayi;
    //     sayaç++;
    //     ortalama=toplam/sayaç;
    //         if (sayi>100)
    //         {
    //            System.Console.WriteLine($"Girilen sayı adedi: {sayaç}"); 
    //            System.Console.WriteLine($"Sayıların toplamı: {toplam}");
    //            System.Console.WriteLine($"Sayıların ortalaması: {ortalama}");
    //            break;
    //         }
    //    } 
        #endregion
   
        #region 9.
            
        #endregion
    
        #region 10. 2 sayı arası çarpım

        //     System.Console.WriteLine("İki sayı arasındaki tüm sayıları çarpan programa hoş geldiniz.");
        //     System.Console.WriteLine("-------------------------------------------------------------");
        //     System.Console.Write("Birinci sayıyı giriniz: ");
        //     int sayi1=int.Parse(Console.ReadLine());
        //     System.Console.Write("İkinci sayıyı giriniz: ");
        //     int sayi2=int.Parse(Console.ReadLine());
        //     int toplam=1;

        //     if (sayi1<=sayi2)
        // {
        //     int i=sayi1;
        //     while( i <= sayi2)
        //     {
        //         toplam*=i;
        //         i++;
        //     }
        // }
        //     else if (sayi1>sayi2)
        //     {
        //         int i=sayi2  ;
        //     while (i <= sayi1 )
        //         {
        //         toplam*=i;
        //         i++;
        //         }
        //     }
        //     System.Console.WriteLine($"{sayi1} ile {sayi2} arasındaki sayıların çarpımı: {toplam}");
            
        #endregion
   
   
   
   
   
   
   
    }
}
