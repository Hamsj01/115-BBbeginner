using System.Runtime.InteropServices;

namespace StringMethod;

class Program
{
    static void Main(string[] args)
    {
        #region 1.Split kelime sayısı
        // 1.Kullanıcıdan alınan bir cümledeki kelime sayısını bulan bir program yazın. (Split metodunu araştırınız.)
        // string input;
        // System.Console.WriteLine("Harf sayısını öğrenmek istediğiniz cümleyi yazınız: ");
        // input=Console.ReadLine();
        // string[] input1 = input.Split(' ');
        // int len = input1.Length;
        // System.Console.WriteLine(len);
        #endregion




        #region 2.Cümle harf büyütme
       // 2.Kullanıcıdan alınan bir metni tüm harfleri büyük olacak şekilde ve tüm harfleri küçük olacak şekilde alt alta tek bir Console.Write ile ekrana yazdıran bir program yazın.
    //    System.Console.WriteLine("Tüm harfleri büyük ve tüm harfleri küçük yazmak istediğiniz cümleyi giriniz: ");
    //     string input=Console.ReadLine();
    //     string inputBig=input.ToUpper();
    //     string inputLow = input.ToLower();

    //     System.Console.WriteLine(inputBig);
    //     System.Console.WriteLine(inputLow);
        #endregion



        #region 3.Belirtilen kelimenin sayısı
            // System.Console.WriteLine("Bir cümle girin");
            // string input=Console.ReadLine();
            // System.Console.WriteLine("Bu cümlede sayısını bulmak istediğiniz kelimeyi girin: ");
            // string kelime=Console.ReadLine();
            // string [] input1 =input.Split(kelime);
            // int kelimeSayısı=input1.Length;
            // System.Console.WriteLine(kelimeSayısı-1);
        #endregion



        #region 4.Boşluk kaldırma
        //4. Kullanıcıdan alınan bir cümlenin başındaki ve sonundaki boşlukları kaldıran bir program yazın. (Trim metotlarını araştırınız.)

        // System.Console.WriteLine("Cümle giriniz: ");
        // string Cumle=Console.ReadLine();
        // string ozelCumle= Cumle.Trim();
        // System.Console.WriteLine(ozelCumle);    
        #endregion



        #region 5.Metinde metin
            //5. Kullanıcıdan alınan bir metinde, yine kullanıcıdan alınan başka bir metni arayan ve varsa ilk bulunduğu indeksi yazdıran bir program yazın.
        System.Console.WriteLine("Bir metin girin.");
        string metin=Console.ReadLine();
        System.Console.WriteLine("İndex bul");
        string arananMetin= Console.ReadLine();
        int index=metin.IndexOf(arananMetin);
        if (index !=-1 )
        {
            Console.WriteLine($"Metinin içinde bulundu indexi: {index}");
        }
        else
        {
            System.Console.WriteLine("Metinin içinde bulunamadı.");
        }
        


        

        #endregion
    }
}
