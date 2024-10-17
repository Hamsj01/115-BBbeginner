using System.Reflection.Metadata;

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



        // int[] price={40, 50, 60, 70, 80};
        //price dizisinin içindeki fiyatlara %10 zam gelmiştir. zamlı fiyatları yazdır.

        // foreach (var pr in price)
        // {
        //     System.Console.WriteLine($"fiyat:{pr}");
        // }

        // for (int i = 0; i < price.Length; i++)
        // {
        //     int zamlı=price[i]*110/100;
        //     System.Console.WriteLine($"Zamlı fiyat: {zamlı}");
        // }


        //a=30, b=50, c=45 şeklinde elimizde bulunan 3 sayıdan en büyüğünü bulduran kodu yazdınız.

        // int a=40;
        // int b=50;
        // int c=45;
        // int max = int.MinValue;
        // if(a>max)
        // {
        //     max=a;
        // }
        // if(b>max)
        // {
        //     max=b;
        // }
        // if (c>max)
        // {
        //     max=c;
        // }

        // System.Console.WriteLine(max);

        // 20 elemanlı bir int dizisine rasgele değerler atayalım. Ardından bu dizinin içindeki en küçük ve en büyük değeri tespit edip ekranra yazdıralım.

        //Dizimizi oluşturup içine rastgele değerler atıyoruz.
        // Random rnd = new Random();
        // int[] numbers= new int[20];

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i]=rnd.Next(1,101); //Next: teki 1 en küçük yüz en büyük 100
        //     System.Console.WriteLine(numbers[i]);
        // }

        // //En büyük ve en küçüğü bulduruyoruz.
        // int max=int.MinValue;
        // int min=int.MaxValue;
        // foreach (var number in numbers) 
        // {
        //     if (number>max) max=number;
        //     if(number<min) min=number;

        // }
        // //En büyük ve en küçük değerleri yazdırıyoruz
        // System.Console.WriteLine($"En küçük: {min}\nEn büyük: {max}");



        // Random rnd = new Random();
        // int[] numbers = new int[10];

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1, 1001); 
        //     System.Console.WriteLine(numbers[i]);
        // }
        // Array.Sort(numbers);
        // System.Console.WriteLine("Dizinin küçükten büyüğe sıralı hali: ");
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     System.Console.WriteLine(numbers[i]);
        // }

        // Array.Reverse(numbers);
        // System.Console.WriteLine("Dizinin Büyükten küçüğe sıralı hali: ");
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     System.Console.WriteLine(numbers[i]);
        // }



        // Random rnd = new Random();
        // int[] numbers = new int[10];

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1, 1001);
        // }
        // numbers[5]=99;
        // for (int i = 0; i < numbers.Length; i++)

        // {
        //     System.Console.WriteLine($"Index: {i} - Number: {numbers[i]}");
        // }
        // System.Console.WriteLine(Array.IndexOf(numbers, "engin")); //bulamadığında -1 yazar




        // string firstName="Alex de Souza";
        // System.Console.WriteLine(firstName[3]);



        // string text= "Macbook ile Yazılım Geliştirme Ortamının Hazırlanması";
        // string[] reslut = text.Split("a");
        // System.Console.WriteLine(reslut[0]);


        // string text = "çok hava çok güzel.";
        // string[] reslut = text.Split("çok");
        // System.Console.WriteLine(reslut[0]);
        // int wordCount=reslut.Length-1;
        // System.Console.WriteLine(wordCount);




        //DİZİLERİ KOPYALAMAK
        // string[] names= {"AYŞEN", "UMAY", "CEYDA", "BEGÜM"} ;
        // string[] newNames=names;

        // names[0]="Heda";
        // System.Console.WriteLine(newNames[0]);

        // string[] names = { "AYŞEN", "UMAY", "CEYDA", "BEGÜM" };
        // string[] newNames=new string[names.Length];
        // Array.Copy(names, newNames, names.Length); //copy(kaynak dizi, nereye, boyut)

        // foreach (var name  in names)
        // {
        //    System.Console.WriteLine(name); 
        // }

        // System.Console.WriteLine("---------");
        // newNames[0]="Heda";
        // foreach (var name in newNames)
        // {
        //     System.Console.WriteLine(name);
        // }

        //DİZİDE VAR/ YOK KONTROLÜ YAPMAK
        // int[] numbers={3,6,7,12};
        // bool exists=Array.Exists(numbers, n => n>16);  //exists var yok 
        // System.Console.WriteLine(exists?"var":"yok");

        // DİZİDE BELİRTİLEN KOŞULA UYGUN İLK ELEMANI GETİRMEK :
        // int[] numbers={3,6,7,12};
        // int reslut=Array.Find(numbers, n=>n==6);      //find eleman bulma
        // System.Console.WriteLine(reslut);          


        // DİZİDE, BELİRTİLEN TÜM KOŞULA UYGUN İLK ELEMANI GETİRMEK :
        // int[] numbers = { 3, 6, 7, 12,6 };
        // int[] reslut = Array.FindAll(numbers, n => n > 6);      //findALL bir dizi döndüreceği için reslut ' u diziye dönüştürmek gerekiyor.
        // System.Console.WriteLine(reslut);
        
        // foreach (var n in reslut)
        // {
        //     System.Console.WriteLine(n);
        // }

        //DİZİNİN BOYUTUNU (ELEMAN SAYISINI) DEĞİŞTİRMEK
        // int[] numbers={3,6,8};
        // System.Console.WriteLine(numbers.Length);
        // Array.Resize(ref numbers,numbers.Length+1);
        // numbers[3]=55;
        // System.Console.WriteLine(numbers.Length);





        //DİZİNİN BELİRLİ BİR BÖLÜMÜNÜ TEMİZLEMEK
        // int[] numbers = {4,5,6,7,8,9,9,12};
        // System.Console.WriteLine($"Dizinin orijinal hali: ");
        // foreach (int number in numbers)
        // {
        //     System.Console.WriteLine(number);
        // }

        // Array.Clear(numbers,2,3);
        // System.Console.WriteLine("Dizinin temizlenmiş hali: ");
        // foreach (var number in numbers)
        // {
            
        //     System.Console.WriteLine(number);
        // }


        








    }
}
