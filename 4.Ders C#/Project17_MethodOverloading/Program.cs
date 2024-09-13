using System.ComponentModel;
using System.Data;

namespace Project17_MethodOverloading;

class Program
{
    static int Sum(int a, int b)
    {
        return a+b;
    }
    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
    static int Sum(int a, int b, int c, int d)
    {
        return a + b + c + d;
    }
    static void Greet(string name, byte age)
    {
        System.Console.WriteLine($"Merhaba {age} yaşındaki {name}");
    }
    static string GetCoffe(string coffeType, int quantitySugar=0, bool withMilk = false)
    {
        string coffe = $"{coffeType} kahve ";
        coffe += quantitySugar > 0 ? $", {quantitySugar} şekerli":"şekersiz";
        if (withMilk)
        {
            coffe+=", sütlü";
        }
        else
        {
            coffe+=", sade";
        }
        coffe+="\nKahveniz hazır";
        return coffe;

    }
    static void Main(string[] args)
    {
        System.Console.WriteLine(GetCoffe("Americano"));
        System.Console.WriteLine(GetCoffe("Americano",2));
        System.Console.WriteLine(GetCoffe("Americano", 2, true));













        // System.Console.WriteLine(Sum(18,5,5,8));
        // System.Console.WriteLine(Sum(18,5,5));
        // Greet("Miraç", 25);
        

    }
}
