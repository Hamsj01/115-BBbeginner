using System;

namespace Project23_InheritanceSamples.SchoolSystem;
/*
    -Öğrenci bir kişi dir
    -Öğrenci'nin ek olarak öğrenci numarası özelliği vardır.
    -Öğrenci'nin bilgileri ekrana yazdırılırken öğrenci numarası da yazdırılmalıdır.




*/
public class Ogrenci:Kisi
{
    public Ogrenci(string ad, string soyad, DateTime dogumTarihi, int ogrenciNo) : base(ad, soyad, dogumTarihi)
    {
        OgrenciNo = ogrenciNo;
    }
    public int OgrenciNo { get; set; }
    public override void BilgileriEkaranaYaz()
    {
        base.BilgileriEkaranaYaz();
        System.Console.WriteLine($"Numara: {OgrenciNo}");
    }
}



