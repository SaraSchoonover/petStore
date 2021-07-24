using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// groups of code that are all related to one another (namespaces)

   
    namespace PetStore.Pets
{
    //rough equivalent to JS objects
    //containers for: behaviors-METHODs(ex: dog: bite, bark), data PROPERTIES(statefulness)(ex: fur color), internal data FIELDS.
    class Dog // implicitly internal, TitleCase
    {
        // ACCESS MODIFIERS:
        // private: only things in this class can use it, default access modifier of a class
        // public: everything that can see the class can access it. Most will be public.
        // internal: anything in this project can access it. 
        // protected: anything that inherits from me can access it. 

        // PROPERTIES: 
        // ways to store bits of information about a thing/ ways to expose data
        // access modifier // type // property name
        // every word gets capitalized
        public string Size { get; set; } //auto-property
        public short Weight { get; set; } //kinda like useState(state, setState)
        public string Name { get; set; } // way to expose data
        
        // constructor, constructor method
        // specialized kind of method
        // access modifier, name is same as class,
        public Dog(string name, short weight, string size)
        {
            Size = size;
            Name = name;
            Weight = weight;
        }

        // Methods Signature: access modifier, return type, name, parameters
        // void means not returning anything
        // roughly eqivalent to funcitons in JS
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
