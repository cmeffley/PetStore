using PetStore.Pets;
using System;

namespace PetStore
{
    class Program
    {
        //static means shared across all instances
        static void Main(string[] args)
        {
            var melba = new Dog("Melba", 60, "Medium");
            melba.Bark();

            //property is privately settable only
            //melba.Weight -= 15;

            Console.WriteLine($"What kind of food should {melba.Name} eat?");
            var typeOfFood = Console.ReadLine();

            melba.Eat(typeOfFood);

            var barley = new Dog("Barley", 50, "Medium");
          
            barley.Bark();

            barley.Eat("table scraps");

            //object initializer 
            var tiger = new Tiger
            {
                Name = "Kisa",
                NumberOfKills = 0,
                Size = "Medium"
            };

            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");

            var bear = new Bear("Yogi", "Brown");
            bear.EatFish(5);
            bear.EatFish(5);
            bear.EatFish(5);
            bear.EatFish(-5);

            //passing an object reference to a property
            bear.BestTigerFriend = new Tiger { Name = "Bob", Size = "Miniature" }; //creating a new Tiger right here. It's the same as Line 29 above

            bear.HangOutWithYourBestFriend();

            Console.WriteLine(bear.BestTigerFriend.Name);
        }
    }
}
