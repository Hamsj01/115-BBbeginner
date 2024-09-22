using System;

namespace Project23_InheritanceSamples.SchoolSystem;

public class Kisi
{
    public Kisi(string ad, string soyad, DateTime dogumTarihi)
    {
        Ad = ad;
        Soyad = soyad;                              
        DogumTarihi = dogumTarihi;
    }

    public string Ad {get; set;}
    public string Soyad { get; set; }
    public DateTime DogumTarihi { get; set; }
    public byte Yas 
    { 

        get
        {
            return (byte)(DateTime.Now.Year - DogumTarihi.Year); //kod bu şekilde yazılınca salt okunur olur yani sadece okunabilir. Sadece get kullanıldığı için.
        }
    
    }
    public virtual void BilgileriEkaranaYaz()
    {
    System.Console.WriteLine($"Ad: {Ad}\nSoyad: {Soyad}\nYaş: {Yas}");
    
    }
}

