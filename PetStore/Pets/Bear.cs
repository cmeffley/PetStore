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
        public string EducationLevel { get; set; } = "GED"; //setting a default value to GED
        public Tiger BestTigerFriend { get; set; }
        //public bool LovesHoney { get; } //read only property, can be set in constructor 
        
        //expression-bodied read only property
        public bool LovesHoney => Name == "Winnie the Pooh";

        //constructor - here: want to start a Bear class with specific parameters
        public Bear(string name, string type)
        {
            Name = name;
            Type = type;
            EducationLevel = "GED"; //also setting default value

            //if (name == "Winnie the Pooh")
            //{
              //  LovesHoney = true;
            //}
            if (name == "Yogi")
            {
                EducationLevel = "Above Average";
            }
        }

        //expression bodied method
        public Bear(string name, string type, string educationLevel) : this(name, type) => EducationLevel = educationLevel; 
       // {
       //    EducationLevel = educationLevel;
       //}

        public Bear(string name, string type, string educationLevel, int howManyFish) : this(name, type, educationLevel) //after the : looks at the constructor before it and so on
        {
            NumberOfFishEaten = howManyFish;
        }

        public void EatFish(int howMany)
        {
            if (howMany <= 0) return;

            NumberOfFishEaten += howMany;
        }

        public void HangOutWithYourBestFriend()
        {
            var output = $"{Name} the bear is hanging out with " +
                $"its best tiger friend, { BestTigerFriend.Name} " +
                $"the { BestTigerFriend.Size} sized tiger";
            Console.WriteLine(output);
        }
    }
}
