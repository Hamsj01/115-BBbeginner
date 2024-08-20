namespace HomeWork07;

class Program
{
    static void Main(string[] args)
    {
        int pakistanNufus=235000000;
        byte bytePakistanNufus=(byte)pakistanNufus;
        System.Console.WriteLine(bytePakistanNufus);

        // int tipi byte'a örtülü dönüştürme yapılamaz. Çünkü int'in değer aralığı byte'dan daha geniş bu yüzden açık dönüştürme yapılır. Yinede çıktıda byte'ın alabileceği maximum değer 255 olduğu için çıktıda görülecek değer 256'nın kalan sınıfları olucaktır. Örneğin 200'ün görüntüsü 200, 255'in görüntüsü 255, 256'nun görüntüsü 0, 257'nin görüntüsü 1, 258'in görüntüsü 2; o zaman 235000000'in görüntüsü 192 olacaktır.
        // çıktı :192

    }
}
