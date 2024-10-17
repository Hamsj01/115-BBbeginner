using System.Security.Cryptography.X509Certificates;

namespace AlışverişHesaplamaV2;
/* v2
- En az 10 tane ürün gösterelim
- Kullanıcı kaç adet ürün almak istediğini seçsin
- İşlemler tamamlandığında kullanıcıya neleri aldığını ve toplam tutarı söyleyelim */
class Program
{
    static void Main(string[] args)
    {
        string[] Products = { "su", "süt", "bal", "kaymak", "tulum peyniri", "10'lu yumurta", "şeker", "tavuk", "kırmızı et", "pirinç pilavı" };
        int[] Price = { 5, 10, 100, 50, 124, 40, 32, 120, 400, 55 };

        for (int c = 0; c < Products.Length; c++)
        {
            System.Console.WriteLine($"{Products[c]}: {Price[c]}TL");
        }

        int total = 0;
        string customer = "";
        int i =0;
        while (customer != "t")
        {
            int a = 0;
            System.Console.WriteLine("Almak istediğiniz ürünü giriniz: ");
            customer = Console.ReadLine().ToLower();
            if (customer == "t")
            {
                break; // 't' girildiğinde döngüden çık
            }
            while (a != 19)  //ürün ve fiyat bulucu bence çok güzel oldu
            {
                if (Products[i] == customer)
                {
                System.Console.WriteLine("Kaç tane: ");
                byte adet = byte.Parse(Console.ReadLine());
                    total += Price[i]*adet;
                    a = 19; //bunu döngüden çıkarmak için
                    i = -1;
                }
                i++;
            }
        }
        System.Console.WriteLine($"Toplam fiyat {total}");

    }
}
