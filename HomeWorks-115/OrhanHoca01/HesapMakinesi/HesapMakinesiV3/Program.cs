namespace HesapMakinesiV3;

/* - Kullanıcı rakam girip yapmak istediği işlemi seçsin.
Örneğin 5 girsin sonra toplama işlemi için seçim yapsın.
Her işlem sonrasında sonucu ekranda göstermeliyiz.
Kullanıcı "e" girmediği sürece hesaplama işlemi devam etsin */

class Program
{
    static void Main()
    {
        decimal result = 0;
        string input = "";

        while (input != "e")
        {
            Console.WriteLine("Bir rakam girin:");
            decimal number;
            while (!decimal.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir rakam girin:");
            }

            Console.WriteLine("Yapmak istediğiniz işlemi seçin: (+, -, *, /) ya da çıkmak için 'e' yazın:");
            input = Console.ReadLine();

            if (input == "e")
            {
                Console.WriteLine("Programdan çıkılıyor...");
                break;
            }

            Console.WriteLine("Sonucu şu ana kadar: " + result);
            switch (input)
            {
                case "+":
                    result += number;
                    Console.WriteLine("Toplama işlemi yapıldı. Sonuç: " + result);
                    break;
                case "-":
                    result -= number;
                    Console.WriteLine("Çıkarma işlemi yapıldı. Sonuç: " + result);
                    break;
                case "*":
                    result *= number;
                    Console.WriteLine("Çarpma işlemi yapıldı. Sonuç: " + result);
                    break;
                case "/":
                    if (number == 0)
                    {
                        Console.WriteLine("Sıfıra bölme hatası. Lütfen farklı bir sayı girin.");
                    }
                    else
                    {
                        result /= number;
                        Console.WriteLine("Bölme işlemi yapıldı. Sonuç: " + result);
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem seçimi. Lütfen (+, -, *, /) işlemlerinden birini seçin.");
                    break;
            }
        }
    }
}
