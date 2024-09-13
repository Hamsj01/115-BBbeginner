namespace Project18_MethodSamples;

class Program
{
    //Kendisine gönderilen int tipindeki sayı listesinde yer alan negatif sayıları döndüren bir metot haızrlayalım.
    static List<int> GetNegativeNumber(List<int> numbers)
    {
        List<int> negativeNumbers=new List<int>();
        foreach (var number in numbers)
        {
            if (number<0)
            {
                negativeNumbers.Add(number);
            }
        }
        return negativeNumbers;
    }
    
    static double TotalOfSquaers(double sayi1, double sayi2)
    {
        double sayi1kare=Math.Pow(sayi1,2);
        double sayi2kare=Math.Pow(sayi2,2);
        double toplam = sayi1kare+sayi2kare; //sayi1 ve sayi2 nin karelerini bulup toplayıp geri döndüren method

        return toplam;
    }

    static void Main(string[] args)
    {
        // List<int>numbers=[ 5,7,8,-5,-4,3,-12,4,5,7 ];
        // List<int> resultNumbers=GetNegativeNumber(numbers);
        // foreach (var number in resultNumbers)
        // {
        //     System.Console.WriteLine(number);
        // }


        
        Console.WriteLine(TotalOfSquaers(14,9));  //5 ve 7 nin karelerini bulup toplayıp geri döndüren method


    }
}
