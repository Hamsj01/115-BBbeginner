namespace AlışverişHesaplama;
/* v1
- Kullanıcıya hazır ürünler çıkaralım.Örneğin market alışverinde olabilecek şeyler. Paralel dizi ile fiyatlarını da listeyelim.
- Kullanıcı hangi ürünleri istiyorsa onun fiyatını toplam fiyata ekleyelim.eğer t harfini girerse toplam gösterip sonuçlandıralım
 */
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bim'e hoş geldiniz");
        System.Console.WriteLine("******************");
        System.Console.WriteLine("Ürünler ve fiyatları:");
        string[] product = { "ekmek", "süt", "yumurta", "peynir", "makarna", "domates", "elma", "tuz" };
        int[] price = { 5, 12, 20, 35, 10, 8, 15, 3 };
        for (int b = 0; b < product.Length; b++)
        {
            System.Console.WriteLine($"{product[b]}: {price[b]}TL");
        }
        int total = 0;
        string customer = "";
        int i = 0;
        while (customer != "t")
        {
            int a = 0;
            System.Console.WriteLine("Almak istediğiniz ürünü giriniz:");
            customer = Console.ReadLine().ToLower();
            if (customer == "t")
            {
                break; // 't' girildiğinde döngüden çık
            }
            while (a != 19)  //ürün ve fiyat bulucu bence çok güzel oldu
            {
                if (product[i] == customer)
                {
                    total += price[i];
                    a = 19; //bunu döngüden çıkarmak için
                    i=-1;
                }
                i++;
            }
        }
        System.Console.WriteLine($"Toplam fiyat {total}");

















    }
}
