using Project23_InheritanceSamples.CarManagementSystem;
using Project23_InheritanceSamples.SchoolSystem; //bu kod sayesinde schoolsystemdeki her clası kullanabilir oluyoruz.

namespace Project23_InheritanceSamples;

class Program
{
    static void Main(string[] args)
    {
            // Kisi kisi1=new Kisi("Ceren","Turna",new DateTime(1990,6,14));
            // kisi1.BilgileriEkaranaYaz();
            // System.Console.WriteLine($"Kişinin Yaşı: {kisi1.Yas}");

            // Ogretmen ogretmen1=new Ogretmen("Miraç", "Katmer", new DateTime(1998,11,26), "Matematik",17002);
            // ogretmen1.BilgileriEkaranaYaz();

            Car car1=new Car("WV","Golf",2023, 5);
            car1.DisplayCarinfo();
            car1.Start();
            car1.OpenTruck();
            MotorCycle motor=new MotorCycle("Honda","xyz22",2020,"Su Soğutması");
            motor.DisplayCarinfo();













        // Cat cat1 = new Cat("Heda", 5, "Siyah");
        // cat1.MakeSound();
        // Dog dog1=new Dog("Ares",3,4,"3 yavrusu var");
        // dog1.MakeSound();
        // dog1.swim();
    }
}
