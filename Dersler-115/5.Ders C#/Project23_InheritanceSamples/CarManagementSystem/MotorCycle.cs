using System;

namespace Project23_InheritanceSamples.CarManagementSystem;

public class MotorCycle : Vehicle
{
    public MotorCycle(string brand, string model, int year, string coolingSystem) : base(brand, model, year)
    {
        CoolingSystem = coolingSystem;
    }
    public string CoolingSystem { get; set; }
    public int MyProperty { get; set; }
    public override void DisplayCarinfo()
    {
        base.DisplayCarinfo();
        System.Console.WriteLine($"Bu arabada {CoolingSystem}");

    }


}
