namespace HomeWork08;

class Program
{
    static void Main(string[] args)
    {
        double phi=3.14;
        int intPhi=(int)phi;
        System.Console.WriteLine(intPhi); 
        // Burada örtülü dönüştürme yapılamaz. Sebebi double'ın değer aralığı daha fazla hemde rasyonel sayılarıda kapsıyor içinde. O yüzden açık dönüşüm yapılır. Yinede int tipinde rasyonel sayılar olmadığı için çıktıda sadece tam sayı görürüz.
        // çıktı: 3
    }
}
