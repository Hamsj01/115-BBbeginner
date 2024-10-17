namespace HesapMakinesi;
/* v1
- Kullanıcıya kaç adet rakam toplamak istediğini soralım.
- Girdiği rakamlara göre toplam ve ortalama sonuç gösterelim. */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kaç adet rakam toplamak istersiniz");

        int NumeralAmount=int.Parse(Console.ReadLine());
        int i=0;
        decimal total=0;
        
        while (i<NumeralAmount) 
        {
            System.Console.WriteLine($"{i+1}. rakam");
            decimal numeral=int.Parse(Console.ReadLine());

            if (numeral>=0 && numeral<10) //sadece rakam yazabilmek için
           {
             total+=numeral;
             i++;
           }
           else
           {
            System.Console.WriteLine("Lütfen sadece rakam giriniz.");
            System.Console.WriteLine("*****************************"); //karmakarışık görünmesin diye boşluk
           }
        }
        System.Console.WriteLine("******************************"); //karmakarışık görünmesin diye boşluk
        decimal average=total/NumeralAmount;
        System.Console.WriteLine($"Rakamların toplamı:{total}\nGirilen Rakamların ortalaması:{average}");




    }
}
