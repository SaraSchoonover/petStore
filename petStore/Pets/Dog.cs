using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Dog // implicitly internal
    {
        // Access Modifiers:
        // private: only things in this class can use it.
        // public: everything that can see the class can access it.
        // internal: anything in this project can access it. 
        // protected: anything that inherits from me can access it. 

        // Properties
        // access modifier // type
        public string Size { get; set; } //auto-property
        public short Weight { get; set; }
        public string Name { get; set; }
        
        // constructor, constructor method
        public Dog(string name, short weight, string size)
        {
            Size = size;
            Name = name;
            Weight = weight;
        }

        // Methods Signature: access modifier, return type, name, parameters
        // void means not returning anything
        public void Bark()
        {
            Console.WriteLine($"{Name} barks noisily.");
        }

        // parameters are camelCase
        public void Eat(string typeOfFood)
        {
            // if (string.Equals(typeOfFood, "healthy food",StringComparison.OrdinalIgnoreCase));
            if (typeOfFood.ToLower() == "healthy food")
            {
                Weight -= 1;
            }
            Console.WriteLine($"{Name} just ate {typeOfFood}. {Name} weighs {Weight}");
        }
    }
}
