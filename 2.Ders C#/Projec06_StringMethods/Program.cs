namespace Projec06_StringMethods;

class Program
{
    static void Main(string[] args)
    {
        #region 1.
            // string fullName= "Halil Umut MELER";
            // int len = fullName.Length;
            // System.Console.WriteLine(len);
            // System.Console.WriteLine(fullName.ToUpper()); // ToUpper tüm harfleri büyütür.
            // string address1 = "Yeni Umut Sitesi E Blok";
            // string address2 = "No: 12 D:5";
            // string district = "Kadıköy";
            // string province = "İstanbul";

            // string fullAddress1 = address1 + " "+ address2 + " " + district + "/" + province;
            // string fullAddres2 = $"{address1} {address2} {district}/{province}";
            // System.Console.WriteLine(fullAddress1);
            // System.Console.WriteLine(fullAddres2);

            // string text1 ="Nişantaşı";
            // string text2 ="Üniversitesi";
            // string loc1="Bayrampaşa";
            // string currentLoc="Sarıyer";
            // string date1="09.09.2009";
            // string date2="05.05.2018";
            // string resultMessage1= text1 + " " + text2 + ", " + date1 + " tarihinde İstanbul'un " + loc1 + "ilçesinde faliyete başladı. Ardından " + date2 + " tarihinde yine İstanbul'un " + currentLoc + " ilçesinde kurulan TechCampus'e taşındı. ";
            // string resultMessage2 = $"{text1} {text2}, {date1} tarihinde İstanbul'un {loc1} ilçesinde faaliyete başladı. Ardından {date2} tarihinde yine İstanbul'un {currentLoc} ilçesinde kurulan TechCampus'e taşındı.";
            // string resultMessage3 = String.Concat(text1," ",text2,", ",date1," tarihinde İstanbul'un ",loc1, " ilçesinde faaliyete başladı. Ardından ", date2, " tarihinde yine İstanbul'un ", currentLoc, " ilçesinde kurulan TechCampus'e taşındı.");
            // System.Console.WriteLine(resultMessage1);
            // System.Console.WriteLine(resultMessage2);
            // System.Console.WriteLine(resultMessage3);
        #endregion
        #region 2.
        // string fullname = "halil Umut MELER";
        // string findText = "Halil Umut";
        // bool response = fullname.ToLower().Contains(findText.ToLower());
        // System.Console.WriteLine(response);
        #endregion
        #region 3.
        // string firstName = "Begüm";
        // System.Console.WriteLine(firstName.IndexOf("m")); //IndexOf karakter aramak için kullanılır kaçıncı dizide olduğunu söyler çıktı : 4
        #endregion
        #region 4.
        // string firstName = "Ayşen Umay";
        // System.Console.WriteLine(firstName.StartsWith("Ayşen"));
        // System.Console.WriteLine(firstName.EndsWith("ay"));  // StartsWith ve EndWith belli bir karakter dizisiyle başlayıp başlamadığını kontrol eder çıktı :true true
        #endregion
        #region 5.
        string newsTitle = "Dolar'ın ateşi çıktı!";
        string newsId = "15698U44";
        string newsCategory = "Ekonomi";
        string newsUrl= newsTitle.ToLower();
        newsUrl = newsUrl.Replace(" ", "-");
        newsUrl = newsUrl.Replace("'", "");
        newsUrl = newsUrl.Replace("!", "");
        newsUrl = newsUrl.Replace("ı", "i");
        newsUrl = newsUrl.Replace("ç", "c");
        newsUrl = newsUrl.Replace("ş", "s");
        newsUrl = $"{newsUrl}-{newsId}-{newsCategory.ToLower()}";

        System.Console.WriteLine(newsUrl);
            
        #endregion
    }
}
