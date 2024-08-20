namespace HomeWork16;

class Program
{
    static void Main(string[] args)
    {
        double phi= 3.14159265358979323846;
        float floatPhi=(float)phi;
        System.Console.WriteLine(phi);
        System.Console.WriteLine(floatPhi); // çıktı: 3,141592653589793
                                            //        3,1415927
    }                                       // double, floattan 8 basamak daha hassas
}
