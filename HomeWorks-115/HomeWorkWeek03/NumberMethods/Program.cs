namespace NumberMethods;

class Program
{
    static void Main(string[] args)
    {
        #region 1.Ondalıklı tam sayıya
            //round en yakın tam sayıya yuvarlar floor sayıyı aşağı yuvarlar ceiling sayıyı yukarı yuvarlar
                // System.Console.WriteLine("En yakın tam sayıya yuvarlamak istediğin ondalık sayıyı yaz:");
             // double sayi=double.Parse(Console.ReadLine());
                // double yuvarlanmısSayi=Math.Round(sayi);
             // System.Console.WriteLine(yuvarlanmısSayi);
        #endregion

        #region 2.Hangisi büyük
        // System.Console.WriteLine("Karşılaştırmak istediğiniz 2 sayıyı giriniz:");
        // System.Console.WriteLine("Birinci sayı:");
        //     int a=int.Parse(Console.ReadLine());
        // System.Console.WriteLine("İkinci sayı:");
        //     int b=int.Parse(Console.ReadLine());
        //     if (a>b)
        //     {
        //         System.Console.WriteLine($"{a} sayısı büyüktür {b} sayısından");
        //     }
        //     if (b>a)
        //     {
        //         System.Console.WriteLine($"{b} sayısı büyüktür {a} sayısından.");
            // }
        #endregion

        #region 3.Mutlak değer
            // abs kodu mutlak değer hesaplar

            // System.Console.WriteLine("Mutlak değerini hesaplamak istediğiniz sayıyı giriniz: ");
            // int sayi=int.Parse(Console.ReadLine());
            // int mutlakDeğer= Math.Abs(sayi);
            // System.Console.WriteLine(mutlakDeğer);
        #endregion 
    
        #region 4.Karekök 
            // System.Console.WriteLine("Karekök hesaplamak istediğiniz sayıyı giriniz:");
            // float sayi=float.Parse(Console.ReadLine());
            // double karekök=Math.Sqrt(sayi);
            // if (sayi<0)
            // {
            //     System.Console.WriteLine("Bu sayının karekökü reel değildir.");
            // }
            // else
            // {
            //  System.Console.Write($"{sayi} sayısının karekökü{karekök} olur.");

            // }
           
        #endregion
    
        #region 5.Üs

        //math.pow sayının üssünü hesaplar
            // System.Console.WriteLine("Sayı");
            // double sayi=double.Parse(Console.ReadLine());
            // System.Console.WriteLine("Girdiğiniz sayının kaçıncı kuvveti hesaplansın");
            // double us=double.Parse(Console.ReadLine());
            // double sayiUs=Math.Pow(sayi , us);
            // System.Console.WriteLine(sayiUs);
        #endregion
    
        #region 6.Sinüs değeri
     //    Console.Write("Bir açı değeri (derece olarak) girin: ");
        // string input = Console.ReadLine();

        //Math.PI/180.0 radyana çevirmek içi
        //Math. Sin  sinüsü hesaplayan kod

        // Girdi kontrolü ve dönüşüm
        // if (double.TryParse(input, out double derece))
        // {
        //     // Dereceyi radyan cinsine dönüştür
        //     double radyan = derece * (Math.PI / 180.0);
        //     // Sinüs değerini hesapla
        //     double sinüs = Math.Sin(radyan);
        //     // Sonucu ekrana yazdır
        //     Console.WriteLine($"Açının sinüs değeri: {sinüs}");
        // }
        // else
        // {
        //     Console.WriteLine("Geçerli bir derece değeri girin.");
        // }
         #endregion   
    
        #region 7.Açıyı; Radyana çevirme
            // System.Console.WriteLine("Radyana çevirmek istediğin derece: ");
            // double açı= double.Parse(Console.ReadLine());
            // double rad=açı*Math.PI/180; //burası önemli çevirmek istediğin açıyı radyan değişkenine bu şekilde atamam gerekiyor formül zaten normade: rad/açı = phi/180
            // System.Console.WriteLine(rad);
        #endregion
         
        #region 8.Log
        // System.Console.WriteLine("Logaritma hesapla: ");
        // double sayi=double.Parse(Console.ReadLine());
        // System.Console.WriteLine("Hangi tabanda: ");
        // double taban=double.Parse(Console.ReadLine());
        // double logSayi= Math.Log(sayi, taban);
        // System.Console.WriteLine(logSayi);
        #endregion
    
        #region 9.Küçük sayı bulma 2. de var
            
        #endregion
    
        #region 10.Ondalıklı belirtilen basamağa göre yuvarlama

            // System.Console.WriteLine("Sayı giriniz:");
            // double sayi =double.Parse(Console.ReadLine());
            // System.Console.WriteLine("Yuvarlamak istediğiniz basamağı seçiniz");
            // int basamak=int.Parse(Console.ReadLine());
            // double yuvarla=Math.Round(sayi , basamak);
            // System.Console.WriteLine(yuvarla);

        #endregion   
    
    }
}
