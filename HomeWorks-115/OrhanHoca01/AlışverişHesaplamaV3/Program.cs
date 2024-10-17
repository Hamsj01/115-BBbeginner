namespace AlışverişHesaplamaV3;
/* v3
- Kullanıcıya para üstü bilgisi vermek adına ödediği tutarı da girelim */
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
            System.Console.WriteLine("Almak istediğiniz ürünü giriniz:      Alışveriş bittiyse:t");
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
                byte amount = byte.Parse(Console.ReadLine());
                    total += Price[i]*amount;
                    a = 19; //bunu döngüden çıkarmak için
                    i = -1;
                }
                i++;
            }
        }
        System.Console.WriteLine($"Toplam fiyat {total}");
        System.Console.WriteLine("Ödeme: ");
        int payment=int.Parse(Console.ReadLine());
        if (payment<total)
        {
            System.Console.WriteLine($"Yetersiz bakiye {total-payment}TL eksik");
        }
        else if (payment>total)
        {
            System.Console.WriteLine($"Para üstü: {payment-total}TL");
        }
        else if (payment==total)
        {
            System.Console.WriteLine($"Para üstü:0TL");
        }   
        System.Console.WriteLine("İyi günler ...");
    }
}
