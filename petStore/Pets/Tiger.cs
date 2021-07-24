using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Tiger
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int NumberOfKills { get; set; }
        public short Speed { get; set; }

        // FIELDS
        // access modifier (generally private, info for inside the class that you don't want to share), type, name
        // name is prefixed with an underscore & then camelCase
        // works more like a variable, a class level variable
        // don't have to include a private access modifier bc private is default 
        int _numberOfBites;
        public void Bite(string handlerName)
        {
            _numberOfBites++;
            if (_numberOfBites > 5)
            {
                Console.WriteLine("This is a bitey tiger.");
            }
            Console.WriteLine($"{Name} the tiger just bit {handlerName}. That's the {_numberOfBites} time.");
        }



    }
}
