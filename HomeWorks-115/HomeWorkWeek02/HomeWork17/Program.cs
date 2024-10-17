namespace HomeWork17;

class Program
{
    static void Main(string[] args)
    {
        byte quaresma=7;
        int intQuaresma=7;
        long longQuaresma=7;
        short shortQuaresma=7;
        System.Console.WriteLine("quaresma:" +  sizeof(byte));  
        System.Console.WriteLine("intQuaresma:" + sizeof(int));
        System.Console.WriteLine( "longQuaresma:" + sizeof(long));
        System.Console.WriteLine("shortQuaresma:"+ sizeof(short));
        // çıktı: quaresma:1
        //       intQuaresma: 4
        //       longQuaresma: 8
        //       shortQuaresma: 2
    }
}
