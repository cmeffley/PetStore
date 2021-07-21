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

        int _numberOfBites; //can write private or not since it's default

        public void Bite(string handlerName)
        {
            _numberOfBites++;
            if (_numberOfBites > 5)
            {
                Console.WriteLine("This is a bitey Tiger");
            }
            Console.WriteLine($"{Name} the Tiger just bit {handlerName}.");
        }



    }
}
