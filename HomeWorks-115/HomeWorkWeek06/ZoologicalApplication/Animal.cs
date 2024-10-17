using System;

namespace ZoologicalApplication;

public class Animal
{
    public Animal(string name, byte age, string species)
    {
        Name = name;
        Age = age;
        Species = species;
    }

    public string Name { get; set; }
    public byte Age { get; set; }
    public string Species { get; set; }

    public virtual void AnimalShow()
    {
        System.Console.WriteLine($"{Age} yaşındaki {Species} {Name}");
    }









}
