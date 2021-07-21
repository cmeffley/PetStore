using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Dog //implicitly internal
    {

        //Access Modifiers:
        // private: only things in THIS Class can use it, default in a class
        // public: everything that can see the class can access it
        // internal: anything in this project can access it
        // protected: anything that inherits from me can access

        //Properties
        //access modifer then type then name
        public string Size { get; set; } //auto-property
        public short Weight { get; private set; }
        public string Name { get; set; }

        //constructor (constructor method) has to be the name of the class
        public Dog(string name, short weight, string size)
        {
            Name = name;
            Weight = weight;
            Size = size;
        }


        //Method Signature: access modifier, return type, name and list of parameters
        // void means not returning anything
        public void Bark()
        {
            Console.WriteLine($"{Name} barks noisily.");
        }

        //pararmeters are camelCase
        public void Eat(string typeOfFood)
        {
            if (typeOfFood.ToLower() == "healthy food")
            //if (string.Equals(typeOfFood, "healthy food", StringComparison.OrdinalIgnoreCase))
            {
                Weight -= 1;
            }

            Console.WriteLine($"{Name} just ate {typeOfFood}. {Name} weighs {Weight}");
        }

    }
}
