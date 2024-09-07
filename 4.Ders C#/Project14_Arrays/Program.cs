namespace Project14_Arrays;

class Program
{
    static void Main(string[] args)
    {  
        // int[] numbers;          //[]:indexer
        // numbers = new int[5];   //[elemans sayısı]
        // numbers[0] = 45;
        // numbers[1] = 145;
        // numbers[2] = 245;
        // numbers[3] = 435;
        // numbers[4] = 4445;

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     System.Console.WriteLine($"{i+1}. elemanı: {numbers[i]}");
        // }

        // int[] numbers = {49,34,90,67,44}; //Boyutu: 5 new int [5] demiş gibi olunur.

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     System.Console.WriteLine($"{i+1}. elemanı: {numbers[i]}");
        // }

        // string[] studentNames = 
        // {
        //     "Ali",
        //     "Ayşe",
        //     "Muran",
        //     "Irmak",
        //     "Sezen"
        // };

        // for (int i = 0; i < studentNames.Length; i++)
        // {
        //     System.Console.WriteLine($"{studentNames[i]} Canoğlu");
        // }

        // foreach (var student in studentNames) // item yazan kısma eleman ismi; collection dizi adı; var yazan yere de elemanın tipi; dizinin elemanı bitene kadar döner.
        
        // {
        //     System.Console.WriteLine(student);
        // }

        // foreach (string student in studentNames) 

        // {
        //     //student değişkeni litaration variable yani döngü değişkeni olduğundan readonly özelliğine sahiptir. Yani, değeri değiştirilemez!
        //     student += "Canoğlu";
        // }



        int[] price={40, 50, 60, 70, 80};
        //price dizisinin içindeki fiyatlara %10 zam gelmiştir. zamlı fiyatları yazdır.

        foreach (var pr in price)
        {
            System.Console.WriteLine($"fiyat:{pr}");
        }

        for (int i = 0; i < price.Length; i++)
        {
            int zamlı=price[i]*110/100;
            System.Console.WriteLine($"Zamlı fiyat: {zamlı}");
        }






    }
}
