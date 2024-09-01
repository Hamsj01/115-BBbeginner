namespace Project13_GuessNumber;

class Program
{
    static void Main(string[] args)
    {
        Random rnd= new Random(); // rnd int tipinde rasgele sayı
        int generatedNumber = rnd.Next(1, 101);
        System.Console.WriteLine($"Hile: {generatedNumber}");
        System.Console.WriteLine("******************");
        System.Console.WriteLine();

        int guessNumber;
        int live=1;
        int liveLimit=5;
        string resultMessage= "";
        

        do
        {
            Console.Write($"{live}.Hak(1-100): ");
            guessNumber=int.Parse(Console.ReadLine());
            if (guessNumber < generatedNumber)
            {
                resultMessage="Daha büyük bir sayı giriniz!";
            }
            else if (guessNumber>generatedNumber)
            {
                resultMessage="Daha küçük bir sayı giriniz.";

            }
            if (guessNumber!=generatedNumber)
            {
                live++;
            }
            if (live<=liveLimit && guessNumber!=generatedNumber)
            {
                System.Console.WriteLine(resultMessage);
            }
        } while (guessNumber!=generatedNumber && live<=liveLimit);
        resultMessage=guessNumber==generatedNumber?$"Kazandın :\nPuanın: {(liveLimit+1 - live)*10}":"Kaybettin";
        System.Console.WriteLine(resultMessage);
        System.Console.WriteLine("Tekrar oynamak için Evet yaz.");
        System.Console.WriteLine("Çıkış için Enter");
        System.Console.ReadLine();
        do
        {
            if (Console.ReadLine)
            {
                
            }
        } while (true);
    }
}
/*
Sayı tahmin oyunu uygulamamızın rasgele üreteceği 1-100 arasındaki bir sayıyı kullanıcının tahmin ederek bulmasını sağlayan bir kod yazacağız.

-Kullanıcının tahmini üretilen sayıdan küçükse yada büyükse buna göre yönlendirme yapılsın.
-Kullanıcının 5 tahmin hakkı vardır.
-Kullanıcı doğru tahmin yaptıysa yada tahmin hakkı dolduysa uygun mesajla oyun sona ersin.
-Doğru tahmin: Bravoo doğru sayı
-Yanlış tahmin: Bulamadın
*/
