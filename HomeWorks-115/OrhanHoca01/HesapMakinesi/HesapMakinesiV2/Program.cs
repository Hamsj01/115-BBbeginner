namespace HesapMakinesiV2;
/* v2
- Kullanıcıya önce liste ile hangi matematik işlemi yapmak istediğini soralım.
- Kaç adet rakam ile işlem yapacağını soralım.
- Sonucu gösterelim */

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hangi işlemi yapmak istersiniz:");
        Console.WriteLine("*******************************");
        string[] processes = { "Toplama", "Çıkarma", "Çarpma", "Bölme" };
        foreach (var process in processes)
        {
            Console.WriteLine(process);
        }
        Console.WriteLine("*******************************");
        string useProcess = Console.ReadLine().ToLower(); 

        
        Console.WriteLine("Kaç adet rakam ile işlem yapılsın:");
        int numeralAmount = int.Parse(Console.ReadLine());

        
        Console.WriteLine("1. rakam:");
        decimal firstNumeral = decimal.Parse(Console.ReadLine());
        decimal value = firstNumeral;
       

        
        for (int i = 1; i < numeralAmount; i++)
        {
            Console.WriteLine($"{i + 1}. rakam:");
            decimal nextNumeral = decimal.Parse(Console.ReadLine());

            if (nextNumeral >= 0 && nextNumeral < 10) // Sadece rakam kabul ediyoruz
            {
                if (useProcess == "toplama")
                {
                    value += nextNumeral; // Toplama
                }
                else if (useProcess == "çıkarma")
                {
                    value -= nextNumeral; // Çıkarma
                }
                else if (useProcess == "çarpma")
                {
                    value *= nextNumeral; // Çarpma
                }
                else if (useProcess == "bölme")
                {
                    if (nextNumeral != 0)
                    {
                        value /= nextNumeral; // Bölme
                    }
                    else
                    {
                        Console.WriteLine("0'a bölme hatası!");
                        return; // Programı bitiriyoruz, çünkü 0'a bölme yapılamaz
                    }
                }
            }
            else
            {
                Console.WriteLine("Lütfen sadece 0-9 aralığında rakam giriniz.");
                Console.WriteLine("*****************************");
            }
        }

        
        Console.WriteLine($"Sonuç: {value}");
    }
}
