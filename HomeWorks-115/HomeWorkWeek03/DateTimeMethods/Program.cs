using System.Diagnostics.CodeAnalysis;

namespace DateTimeMethods;

class Program
{
    static void Main(string[] args)
    {
  
        #region 1.Haftanın hangi günü bulma
        // System.Console.WriteLine("Haftanın hangi günü öğrenmek istediğiniz tarihi giriniz:");

        // System.Console.WriteLine("Yıl:");
        // int year=Convert.ToInt32(Console.ReadLine());

        // System.Console.WriteLine("Ay:");
        // int month=Convert.ToInt32(Console.ReadLine());

        // System.Console.WriteLine("Gün: ");
        // int day=Convert.ToInt32(Console.ReadLine());

        // DateTime date = new DateTime(year, month, day);
        // DayOfWeek dayOfWeek=date.DayOfWeek;
        // System.Console.WriteLine($"Tarih: {date}");
        // System.Console.WriteLine(date.DayOfWeek);
       #endregion

        #region 2.Şu an tarih saat
            // DateTime now=DateTime.Now;
            // System.Console.WriteLine(now);
        #endregion
  
        #region 3.Gün ekle
            // System.Console.WriteLine("Bir tarih giriniz: ");

                        
            // System.Console.WriteLine("Gün: ");
            // int day=int.Parse(Console.ReadLine());

            // System.Console.WriteLine("Ay: ");
            // int month=int.Parse(Console.ReadLine());

            // System.Console.WriteLine("Yıl: ");
            // int year=int.Parse(Console.ReadLine());

            // DateTime date=new DateTime(year, month, day);

            // System.Console.WriteLine("Kaç gün eklensin: ");
            // int eklenenGun= int.Parse(Console.ReadLine());

            // System.Console.WriteLine($"Girdiğiniz tarih: {date}");

            // System.Console.WriteLine($"{eklenenGun} gün eklenirse {date.AddDays(eklenenGun)}");

        #endregion
  
        #region 4.Tarihler arası fark
        // // İlk tarihi alalım
        // Console.Write("Lütfen birinci tarihi girin (GG.AA.YYYY formatında): ");
        // string ilkTarihGirisi = Console.ReadLine();
        
        // // İkinci tarihi alalım
        // Console.Write("Lütfen ikinci tarihi girin (GG.AA.YYYY formatında): ");
        // string ikinciTarihGirisi = Console.ReadLine();
        
        // // Tarihleri DateTime tipine çevirelim
        // DateTime ilkTarih = DateTime.ParseExact(ilkTarihGirisi, "dd.MM.yyyy", null);
        // DateTime ikinciTarih = DateTime.ParseExact(ikinciTarihGirisi, "dd.MM.yyyy", null);
        
        // // İki tarih arasındaki farkı bulalım
        // TimeSpan fark = ikinciTarih - ilkTarih;
        
        // // Farkı gün cinsinden ekrana yazdıralım
        // Console.WriteLine("İki tarih arasındaki fark: " + fark.TotalDays + " gün");




        #endregion
  
        #region 5.Yılın kaçıncı günü

            // System.Console.WriteLine("Tarih giriniz: ");
            // System.Console.WriteLine("Gün: ");
            // int day=int.Parse(Console.ReadLine());

            // System.Console.WriteLine("Ay: ");
            // int month=int.Parse(Console.ReadLine());

            // System.Console.WriteLine("Yıl: ");
            // int year=int.Parse(Console.ReadLine());

            // DateTime date=new DateTime(year, month, day);
            // System.Console.WriteLine($"Bu tarih yılın {date.DayOfYear}. günüdür.");


        #endregion
  
        #region 6.Artık yıl
            
            // System.Console.WriteLine("Artık yıl bulucu: ");
            // System.Console.WriteLine("Gün: ");
            // int day=int.Parse(Console.ReadLine());

            // System.Console.WriteLine("Ay: ");
            // int month=int.Parse(Console.ReadLine());

            // System.Console.WriteLine("Yıl: ");
            // int year=int.Parse(Console.ReadLine());

            // DateTime date=new DateTime(year, month, day);
            // if (year%4==0)
            // {
            //     System.Console.WriteLine("Artık yıldır. ");

            // }
            // else
            // {
            //     System.Console.WriteLine("Artık yıl değildir");
            // }


        #endregion
   
        #region 7.Belirli tarih formatı
            
        #endregion
    
        #region 8.Şu anki ay

        // DateTime now=DateTime.Now;
        // int a= now.Month;
        // if (a==1)
        // {
        //     System.Console.WriteLine("Ocak");
        // }
        //  if (a==2)
        // {
        //     System.Console.WriteLine("Şubat");
        // }
        //  if (a==3)
        // {
        //     System.Console.WriteLine("Mart");
        // }
        //  if (a==4)
        // {
        //     System.Console.WriteLine("Nisan");
        // }
        //  if (a==5)
        // {
        //     System.Console.WriteLine("Mayıs");
        // }
        //  if (a==6)
        // {
        //     System.Console.WriteLine("Haziran");
        // }
        //  if (a==7)
        // {
        //     System.Console.WriteLine("Temmuz");
        // }
        //  if (a==8)
        // {
        //     System.Console.WriteLine("Ağustos");
        // }
        //  if (a==9)
        // {
        //     System.Console.WriteLine("Eylül");
        // }
        //  if (a==10)
        // {
        //     System.Console.WriteLine("Ekim");
        // }
        //  if (a==11)
        // {
        //     System.Console.WriteLine("Kasım");
        // }
        //  if (a==12)
        // {
        //     System.Console.WriteLine("Aralık");
        // }

        #endregion
    
        #region 10.format
        //             // Kullanıcıdan saati 12 saat formatında alalım
        // Console.Write("Lütfen saati girin (hh:mm tt formatında, örn: 02:30 PM): ");
        // string saat12 = Console.ReadLine();

        // // 12 saat formatındaki saati 24 saat formatına çevirelim
        // DateTime saat24;
        // if (DateTime.TryParseExact(saat12, "hh:mm tt", null, System.Globalization.DateTimeStyles.None, out saat24))
        // {
        //     Console.WriteLine("24 saat formatında: " + saat24.ToString("HH:mm"));
        // }
        // else
        // {
        //     Console.WriteLine("Geçersiz saat formatı! Lütfen tekrar deneyin.");
        //     return;
        // }

        // // 24 saat formatındaki saati 12 saat formatına çevirelim
        // string saat12Tekrar = saat24.ToString("hh:mm tt");
        // Console.WriteLine("12 saat formatında tekrar: " + saat12Tekrar);
        // #endregion
    
    
    
    }
}
