using System;

namespace Project23_InheritanceSamples.CarManagementSystem;

public class Car : Vehicle
{
    public Car(string brand, string model, int year, int countOfDoors) : base(brand, model, year)
    {
        CountOfDoors = countOfDoors;
    }
    public int CountOfDoors { get; set; }
    public void OpenTruck ()
    {
        System.Console.WriteLine("Arabanın üstü açıldı");
    }
    public void CloseTruck ()
    {
        System.Console.WriteLine("Arabanın üstü kapandı");
    }
    public override void DisplayCarinfo()
    {
        base.DisplayCarinfo();
        System.Console.WriteLine($"Kapı sayısı: {CountOfDoors}");
        
    }

    public override void GetSinyal()
    {
        throw new NotImplementedException();
    }
}
