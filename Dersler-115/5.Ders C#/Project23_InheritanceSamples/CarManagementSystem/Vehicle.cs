using System;

namespace Project23_InheritanceSamples.CarManagementSystem;

public abstract class Vehicle //kendisinden nesne yaratılamayan class olması için abstarct classı dedik abstact=genel bir class demek
{
    public void Start()
    {
        System.Console.WriteLine($"{Model} Araba çalışıyor");
        
    }
    public void Stop()
    {
        System.Console.WriteLine($"{Model} Araba Durdu");
    }
    public Vehicle(string brand, string model, int year)
    {
        Brand=brand;
        Model=model;
        Year=year;
    }
public string Brand { get; set; }
public string Model { get; set; }
public int Year { get; set; }

public  virtual void DisplayCarinfo()
{
    System.Console.WriteLine($"Marka: {Brand} \nModel: {Model} \nYıl: {Year}");
}

public abstract void GetSinyal();




}
