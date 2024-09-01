namespace Project12_Loopss;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan arka arakya alınacak sayıalrı toplayan kodu hazırlayınız. Ancak kullanıcının girdiği sayıların toplamı 100'den büyük veya eşitse program sona ersin toplamı ekrana yazsın.
        // int toplam = 0;
        // while (toplam < 100)
        // {
        //     System.Console.WriteLine("Selamlar toplamları 100'den küçük bir sayılar girin: ");
        //     int sayi = int.Parse(Console.ReadLine());
        //     toplam += sayi;
        //     System.Console.WriteLine(toplam);
        //     if (toplam >= 100)
        //     {
        //         System.Console.WriteLine("hooop");
        //     }
        // }



        // Sadece sayı girişi yaptır.
        // Console.ReadKey();  //Tuş bilgisi (keInfo)
        // ConsoleKeyInfo character;
        // string resultNumber ="";
        // Console.Write("Bir sayı giriniz: ");
        // do
        // {
        //     character=Console.ReadKey(true);     
        //     if(char.IsDigit(character.KeyChar))     
        //     {
        //         resultNumber += character.KeyChar.ToString();
        //         Console.Write(character.KeyChar.ToString());
        //     }   
        //     if (character.Key!=ConsoleKey.Backspace)
        //     {
        //         bool control = int.TryParse(character.KeyChar.ToString(), out int value);
        //         if (control)
        //         {
        //             resultNumber+=character.KeyChar.ToString();
        //         }
        //     }
        //     else
        //     {
        //         if (character.Key==ConsoleKey.Backspace && resultNumber.Length>0)
        //         {
        //             resultNumber=resultNumber.Substring(0,resultNumber.Length-1); //58745 ------ > 5874
        //             Console.Write("\b \b");
        //         }
        //     }
        // } while (character.Key!=ConsoleKey.Enter);
        





        //Girilen sayının asal sayı olup olmadığını tespit edip ekrana yazdıralım.

        // bool isPrime = true;
        // System.Console.WriteLine("Bir sayı giriniz: ");
        // int number = int.Parse(Console.ReadLine());
        // if (number <= 1)
        // {
        //     isPrime = false;
        // }
        // else
        // {
        //     for (int i = 2; i <= number-1; i++)
        //     {
        //         if (number %i == 0)
        //         {
        //             isPrime = false;
        //             break;
        //         }
        //     }
        // }
        // System.Console.WriteLine(isPrime==true?"Asal sayıdır.":"Asal sayı değildir.");




        bool isPrime = true;
        System.Console.WriteLine("Bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());
        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            int i=2;
            while (i<=number-1)
            {
               i++;
               if (number %i == 0)
               {
                isPrime=false;
               }
              break;
            }
        }
        System.Console.WriteLine(isPrime==true?"Asal sayıdır.":"Asal sayı değildir.");




    }
}
