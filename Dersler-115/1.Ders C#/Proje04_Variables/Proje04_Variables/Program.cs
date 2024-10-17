namespace Proje03;

class Program
{
    static void Main(string[] args)
    {
        #region Değişken İsimlendirme Kural ve Teknikleri
        /*  1) C# BÜYÜK/küçük haf duyarlı bir dildir
        ör: adSoyad ile AdSoyad aynı değildir.

        2) Özel karakterler değişken adı içerisinsde yer alamaz. _ hariç
        ör: Ad Soyad, ogrenci- numarası (boşluk ve tire den dolayı bunlar geçersiz)
        ör: _AdSoyad, Ad_Soyad
        ör: Sayi1, Sayi_2, Sayı2Var
        ör: 1sayi, 4not, bunlar geçersiz başında _ veya harf

        3) Anahtar sözcükler c#'ın özel anlam yüklediği  sözcükler değişken isim olarak kullanılamaz.
        ör: int static; (yanlış), string void; (yanlış)
        ör: int @static; (doğru)

        4) Değişkenler anlamlı bir şekilde isimlendirilmelidir.
        ör: string as, yerine string adsoyad;

        5) Değişken isimlendirilirken  camelCase tekniği kullanılmalıdır. 
        ör: string anneadi; string anneAdi; string anne_adi; string AnneAdi;,

        6) Değişken isimlendirirken Türkçe karakter kullanmak yasak değildir. Ancak tercih etmemeniz şiddetle önerilir.

        7) Sabit(Const) tanımlarken genellikle tamamen BÜYÜK HARF kullanılır.
        ör: const int MAX_AGE=40;
        MAX_AGE=43;
        ör: const double PI=3.14;
        
        #endregion

        #region TamSayılar
        //    int degiskenAdi=56;
        //    int desikenAdi2;  
        //    System.Console.WriteLine(degiskenAdi);
        //   "ctrl+ö", "ctrl+kc" ile comment yapılır.
        //   Tam sayılar sbyte
        // c# ta ayrıca belirtilmedikçe tüm sayısal değerler int tipinde varsayılır.
        // byte studentPoint = 256 ;
        // System.Console.WriteLine(studentPoint);
        // sbyte studentPoint2 = 75 ; //  sbyte bellekte 1 byte yer kaplar (8 bit)
        // short price = 500; // 16 bit
        // ushort price2 = 65535; // 16 bit
        // int number = -589; // 32 bit
        // uint number2 = 97; // 
        // long longNumber = -9889898; // 64 bit
        // ulong longNumber2 = 939231; // 64 bit
        #endregion
        #region Ondalık Sayılar
        float oran = 0.5F; // 32 bit, hassasiyet: 7 basamak
        double oran2 = 0.5;  // 64 bit, hassasiyet: 15-16 basamak
        decimal maas = 0.5m; // 128 bit, hassasiyet: 28-29 basamak
        #endregion
        #region Diğer Tipler
        bool varMi = true;
        bool geçerliMi = false  // 8 bit

            char cevap = 'H';
        char sembol = '&'; // UTF-16 16 bit
        #endregion

        #region Value Types(Değer Tipler)
        // Yukarıdaki tüm tiplere c# Value Types der. Value Types, bellekte içinde direkt olarak değer saklayan yapıları anlatır.
        // Ayrıca bunlara Primitive Types (İlkel Tip) denir.
        #endregion
        #region Reference Types(Referans Tipler)
        // Ram'in stack kısmında verinin yerine, verinin bulunduğu yerin adresini tutan veri tipleridir.
        // Yani bir reference type, bir nesneyi ya da değeri işaret eder.
        #endregion
        #region Temel Referans Tipler
        string adSoyad = "Miraç Katmer";
        object nesne = 15;
        object nesne2 = true;
        object nesne3 = "Merhaba";
        String ve Object tiplerinin bellekte ne kadar yer kapladığını araştırınız.

        #endregion
        
    */
    }

}
