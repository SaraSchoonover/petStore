using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Bear
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int NumberOfFishEaten { get; private set; }
        public string EducationLevel { get; set; } = "GED";
        public Tiger BestTigerFriend { get; set; }

        // read only property
        public bool LovesHoney { get; }

        public Bear(string name, string type)
        {
            Name = name;
            Type = type;
            EducationLevel = "GED";

            if (name == "Winnie the Pooh")
            {
                LovesHoney = true;
            } else if (name == "Yogi")
            {
                EducationLevel = "Above Average";
            } 
        }

        public void EatFish(int howMany)
        {
            if (howMany <= 0) return;

            NumberOfFishEaten += howMany;
        }
    }
}
