using System;

namespace Project23_InheritanceSamples.SchoolSystem;
/*
- Öğretmen bir kişidir
- Öğretmennin ek olarak branş ve maaş bilgisi
- Maaş bilgisinin negatif değer olarak girilmesine izin verilmeyecek() sadece "hata" mesajı yeter.
- Öğretmenin bilgileri yazdırılırken branş ve maaş bilgileride yazdırılıcak.
*/
public class Ogretmen : Kisi
{
    public Ogretmen(string ad, string soyad, DateTime dogumTarihi, string brans, decimal Maas) : base(ad, soyad, dogumTarihi)
    {
        Brans = brans;
        Maas = maas;
    }
    public string Brans {get;set;}
    decimal maas;
    public decimal Maas
    {
        get
        {
            return maas;
        }
        set
        {
            if(value<0)
            {
                throw new ArgumentException("Negatif bir maaş bilgisi olamaz!");
            }
            maas=value;
        }

    }
    public override void BilgileriEkaranaYaz()
    {
        base.BilgileriEkaranaYaz();
        System.Console.WriteLine($"Branş: {Brans} \nMaaş: {Maas}");
    }

}
