namespace Project08_DateTimes;

class Program
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;

        // System.Console.WriteLine($"Şu anki tarih/saat: {now}"); //çıktı: Şu anki tarih/saat: 30.08.2024 20:56:09
        // System.Console.WriteLine($"3 hafta sonraki tarih: {now.AddDays(21)}");
        // System.Console.WriteLine($"3 ay sonraki tarih: {now.AddMonths(3)}"); //çıktı: 30.11.2024 21:01:18

        // System.Console.WriteLine(now.ToString("dd/MM/yyyy")); //çıktı: 30.08.2024
        // System.Console.WriteLine(now.ToString("HH:mm:ss")); // çıktı: şu anki saat 21:04:33
        // System.Console.WriteLine(now.ToString("d")); // çıktı: 30.08.2024
        // System.Console.WriteLine(now.ToString("D")); // çıktı: 30 Ağustos 2024 Cuma

        // System.Console.WriteLine(now.ToString("MMMM yyyy")); //çıktı: Ağustos 2024

        // System.Console.WriteLine(now.ToShortDateString());
        // System.Console.WriteLine(now.ToShortTimeString());

        int day=5;
        int mounth=6;
        int year=1988;
        DateTime date = new DateTime(year, month, day, 4, 5, 0);
        System.Console.WriteLine(date);
        System.Console.WriteLine(date.AddMonths(-3));







    }
}
