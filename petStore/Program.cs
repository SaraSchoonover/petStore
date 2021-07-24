using System;
using PetStore.Pets;

namespace PetStore
{
    class Program
    {
        //static means shared across all instances.
        static void Main(string[] args)
        {

            var melba = new Dog("Melba", 60, "Medium");
            //Console.WriteLine("Hello World!");
            //  melba.Name = "Melba";
            // melba.Size = "Medium";
            // melba.Weight = 60;
            melba.Bark();
            melba.Eat("Healthy food");

            // this won't work, can't deynamically add properties to a class in c#
            // melba.CoatType = "Short";

            var barley = new Dog("Barley", 50, "Medium");
            // barley.Name = "Barley";
            // barley.Size = "Medium";
            // barley.Weight = 50;
            barley.Bark();
            barley.Eat("table scraps");

            // object initializer
            // allows to assign values to the fields or properties at the time of creating an object without invoking a constructor.
            var tiger = new Tiger
            {
                Name = "Kisa",
                NumberOfKills = 0,
                Size = "Medium",
            };
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");

            var bear = new Bear("Yogi", "Brown");
            bear.EatFish(5);
            
        

    }
    }
}