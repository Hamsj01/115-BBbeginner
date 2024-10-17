namespace Projec07_NumberMethods;

class Program
{
    static void Main(string[] args)
    {
        #region Aritmetik Operatörler
        int a = 10;
        int b = 4;

        int result;
        result = a + b;
        result = a - b;
        result = a * b;
        result = a / b;
        result = a % b;

        result = Math.Abs(-10);   //Abs: Mutlak değer.
        result = (int)Math.Pow(4, 5);   //Pow: (TABAN, ÜS)
        double result2;
        result2 = Math.Sqrt(16);  //Karekökü alınır.
        result2 = Math.Round(7.25);
        result2 = Math.Round(7.51);  //En yakın tam sayıya yuvarlar (Round)
        result2 = Math.Ceiling(7.25);  //Yukarı doğru yuvarla (Ceiling)
        result2 = Math.Floor(7.99);   // Aşağı yuvarla (Floor)

        //Math.Tan, Math.Sin, Math.Cos...
        //Bu kodun çıktısı en son result2 Mat.Floor(7.99); olduğu için çıktı:7


        System.Console.WriteLine(result2);
        #endregion
    }
}
