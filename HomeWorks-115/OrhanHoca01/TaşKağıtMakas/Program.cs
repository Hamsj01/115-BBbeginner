namespace TaşKağıtMakas;
/*      Taş Kağıt Makas Oyunu
        v1
        - string dizisi içinde taş kağıt makas seçenekleri olsun.
        - kullanıcıya hangi seçeneği seçtiğini sorun
        -durumlara bağlı olarak kazandın veya kaybettin deyin
        v2
        - düzenli olarak ekrana skor bilgisi yazın.kullanıcı "çıkış" yazarsa uygulama sonlansın
 */

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine($"TAŞ KAĞIT MAKAS OYUNUNNA HOŞ GELDİNİZ.");
        System.Console.WriteLine("----------------------------------------------");

        string player1 = "";
        int seninPuanın = 0;
        int rakibinPuanı = 0;

        while (player1 != "çıkış")
        {
            string[] TKM = { "taş", "kağıt", "makas" };
            Random rnd = new Random();
            int ai = rnd.Next(0, 3);
            System.Console.WriteLine($"TAŞ KAĞIT MAKAS!");
            player1 = Console.ReadLine().ToLower();
            if (player1 == "taş" && TKM[ai] == "taş")
            {
                System.Console.WriteLine($"Sen:{player1} Rakip:{TKM[ai]} BERABERE!");
            }
            else if (player1 == "taş" && TKM[ai] == "kağıt")
            {
                System.Console.WriteLine($"Sen:{player1} Rakip:{TKM[ai]} KAĞIT TAŞI SARARR!");
                rakibinPuanı++;
            }
            else if (player1 == "taş" && TKM[ai] == "makas")
            {
                System.Console.WriteLine($"Sen:{player1} Rakip:{TKM[ai]} TAŞ MAKASI KIRARR!");
                seninPuanın++;
            }
            else if (player1 == "kağıt" && TKM[ai] == "makas")
            {
                System.Console.WriteLine($"Sen:{player1} Rakip:{TKM[ai]} MAKAS KAĞIDI KESERR!");
                rakibinPuanı++;
            }
            else if (player1 == "kağıt" && TKM[ai] == "taş")
            {
                System.Console.WriteLine($"Sen:{player1} Rakip:{TKM[ai]} TAŞ MAKASI KIRAR!");
                seninPuanın++;
            }
            else if (player1 == "kağıt" && TKM[ai] == "kağıt")
            {
                System.Console.WriteLine($"Sen:{player1} Rakip:{TKM[ai]} BERABERE!");
            }
            else if (player1 == "makas" && TKM[ai] == "makas")
            {
                System.Console.WriteLine($"Sen:{player1} Rakip:{TKM[ai]} BERABERE!");
            }
            else if (player1 == "makas" && TKM[ai] == "kağıt")
            {
                System.Console.WriteLine($"Sen:{player1} Rakip:{TKM[ai]} MAKAS KAĞIDI KESERRR!");
                seninPuanın++;
            }
            else if (player1 == "makas" && TKM[ai] == "taş")
            {
                System.Console.WriteLine($"Sen:{player1} Rakip:{TKM[ai]} TAŞ MAKASI KIRARR!");
                rakibinPuanı++;
            }

            else
            {
                System.Console.WriteLine("!!!!! yanlış hamle taş kağıt yada makas!!!!!!");
            }
            System.Console.WriteLine($"SEN:{seninPuanın} RAKİP:{rakibinPuanı}     çıkmak için çıkış yazabilirsin");
        }
    }
}