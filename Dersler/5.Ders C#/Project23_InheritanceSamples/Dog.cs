using System;

namespace Project23_InheritanceSamples;

public class Dog : Animal
{
    public Dog(string name, int age, int olfactionLevel,string breed) : base(name, age)
    {
        OlfactionLevel1=olfactionLevel;
        Breed=breed;

    }
    public int OlfactionLevel1 {get;set;}
    public string Breed {get;set;}
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} havladı!");
    }

    public void swim()
    {
        System.Console.WriteLine($"{Name} yüzdü!");
    }
}
