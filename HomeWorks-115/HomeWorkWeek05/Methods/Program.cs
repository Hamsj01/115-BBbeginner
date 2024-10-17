using System.Reflection.Metadata.Ecma335;

namespace Methods;

class Program
{
    //Bir kişinin yaşını kontrol eden bir metot yazın. Eğer kişi 65 yaşından büyükse "Emeklilik yaşında", değilse "Çalışma yaşında" şeklinde bir mesaj döndürsün.
     static string YasKontrol(int yas)
    {
        if (yas > 65)
        {
            return "Emeklilik yaşında";
        }
        else
        {
            return "Çalışma yaşında";
        }
    }
    
    //İki sayıyı karşılaştıran ve en büyüğünü döndüren bir metot yazın.
    static string hangisiBuyuk(int sayi1, int sayi2)
    {
        System.Console.WriteLine("Büyük olan sayı");
        if (sayi1>sayi2)
        {
            return $"{sayi1}";
        }
        else
        {
            return $"{sayi2}";
        }
    }
    
    //Parametre olarak bir kelime alıp, bu kelimeyi tersine çevirerek geri döndüren bir metot yazın.
    static void ters(string kelime);
    

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    static void Main(string[] args)
    {
        #region 1.
//Bir kişinin yaşını kontrol eden bir metot yazın. Eğer kişi 65 yaşından büyükse "Emeklilik yaşında", değilse "Çalışma yaşında" şeklinde bir mesaj döndürsün.



        // System.Console.WriteLine("Yaşınızı girin: ");
        // int yas=int.Parse(Console.ReadLine());
        // System.Console.WriteLine(YasKontrol(yas));

            
        #endregion
    
        #region 2.
    //İki sayıyı karşılaştıran ve en büyüğünü döndüren bir metot yazın.


            //  System.Console.WriteLine("İki sayı giriniz: ");
            // int sayi1=int.Parse(Console.ReadLine());
            // int sayi2=int.Parse(Console.ReadLine());
            // System.Console.WriteLine(hangisiBuyuk(sayi1,sayi2));
        #endregion
    
        #region 3.
            e
        #endregion
    
    
    
    
    
    
    
    
    
    
    
    
   
    
    
    
    
    
    }
}
