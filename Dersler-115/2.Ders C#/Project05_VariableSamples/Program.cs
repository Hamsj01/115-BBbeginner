namespace Project05_VariableSamples;

class Program
{
    static void Main(string[] args)
    {
        #region Yaş Hesaplama
        // Kullanıcıdan doğum tarihini alıp yaşını hesaplıyacak kod
        // System.Console.WriteLine("Doğum Yılınızı girin:");
        // string input = Console.ReadLine(); //1998

        // int birthYear = int.Parse(input); //1998
        // int calculatedAge = DateTime.Now.Year-birthYear;
        // string message = "Yaşınız: " + calculatedAge;
        // System.Console.WriteLine(message);

        #endregion
        #region Ürün Fiyatı Belirleme
        // Bir ürünün kdv'li fiyatı hesaplama ekrana yazdırma.
        // System.Console.WriteLine("Ürün fiyatını giriniz: ");
        // decimal productPrice = decimal.Parse(Console.ReadLine());

        // double vatRate = 0.18;
        // double vat = (double)productPrice * vatRate;
        // decimal totalProductPrice = productPrice + (decimal)vat;

        // string resultMessage = $@"Ürün Fiyatı: {productPrice}
        // KDV: {vat}
        // KDV Dahil Fiyat: {totalProductPrice}";

        // System.Console.WriteLine(resultMessage);

        #endregion
        #region Sıcaklık Dönüştürme
        //Kullanıcıdan Celsius cinsinden alınan sıcaklık değerini, Fahrenheit cinsine çevirip ekrana her ikisini de alt alta yazdıran kodu hazırlıyoruz.
        // System.Console.WriteLine("Celsius sıcaklık değerini giriniz: ");
        // double celsius=double.Parse(Console.ReadLine());
        // double fahrenheit = (celsius*1.8)+32;
        // string resultMessage=$"Celsius:{Convert.ToInt32(celsius)}\nFahrenheit:{Convert.ToInt32(fahrenheit)}";
        // Console.Clear(); //Normalde bu satır o anda consolda ne varsa temizler. Fakat şu an hata alıyoruz bakcağız 
        //         System.Console.WriteLine("Sonuç");
        //         System.Console.WriteLine("-----");
        //         System.Console.WriteLine(resultMessage);


        #endregion
        #region Ağırlık Dönüştürme 
        //Kullanıcının girdiği kg cinsinden ağırlığı gram'a çevirip sonucu ekrana yazdıran kodu hazırlayınız. 
        //Not: Küsüratlı değerler girilebilir.
        //Not: Sonuç ekranında hem kg hem gr değerlerini düzgünce göstermemiz gerekiyor.
        // System.Console.WriteLine("Kg cinsinden ağırlık miktarını giriniz: ");
        // double kg=double.Parse(Console.ReadLine());
        // double gr=kg*1000;
        // string resultMessage=$"Kg:{kg}\nGr:{(int)gr}";
        // System.Console.WriteLine("Sonuç");
        // System.Console.WriteLine("-----");
        // System.Console.WriteLine(resultMessage);
        #endregion

    }
}
