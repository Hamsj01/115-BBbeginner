using System.Diagnostics.Contracts;

namespace Proje04_ConvertTypes;

class Program
{
    static void Main(string[] args)
    {
        #region Implicit Convert(Örtülü Dönüşüm)
        /*  int myAge = 25;
         long newMyAge = myAge; //int to long

         float rate = 0.87f;
         double newRate= rate; //float to double

         byte studentPoint=75;
         int newStudentPoint=studentPoint; //byte to int */
        #endregion

        #region Explicit Convert(Açık dönüştürme)
            // double myVaule = 123.58;
            // int newMyVaule = (int)myVaule;// Cast etmek ya da unboxing
            // System.Console.WriteLine("myVaule: " + myVaule);
            // System.Console.WriteLine("newMyVaule: " + newMyVaule);

            // string numberString = "125";
            // int result = Convert.ToInt32(numberString)+58;
            // System.Console.WriteLine(result);

            // long numberLong = 75;
            // int numberInt = Convert.ToInt32(numberLong);
            // System.Console.WriteLine(numberInt);

            // int numberInt=256;
            // byte numberByte=Convert.ToByte(numberInt);
            // System.Console.WriteLine(numberByte);

            // string age = "25";
            // byte ageByte = byte.Parse(age);             (PARSE EDEBİLDİ)
            // System.Console.WriteLine(ageByte);

            // string number = "125&";
            // int numberInt = int.Parse(number);   (PARSE EDEMEDİ)
            // System.Console.WriteLine(numberInt);

            // string number = "Miraç";
            // int numberInt;
            // bool result = int.TryParse(number, out numberInt );  // (Miraç kelimesini Parse etmeyi denedik olur yada olmaz sonuçları olduğundan dolayı bool result kullandık.)
            // System.Console.WriteLine(result);

            // int a = 567;
            // string b = a.ToString();
            // System.Console.WriteLine(b);

            int a = 6;
            int b = 175;

            string result = a.ToString()+b.ToString();
            string resultString2= (a+b).ToString();

            System.Console.WriteLine(result);    // çıktısı: 6175
            System.Console.WriteLine(resultString2); // çıktısı 181


        #endregion

    }
}
