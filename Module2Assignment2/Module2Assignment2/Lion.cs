using System;
using System.Collections.Generic;
using System.Text;

namespace Module2Assignment2
{
    public class Lions : Animal
    {
        public int age { get; set; }
        public string species { get; set; }
        public string maneColour { get; set; }
        public void GetDescription()
        {
            Console.WriteLine($" {this.age}-year-old lion with a {this.maneColour} mane.");
        }

        void Animal.RequestUniqueCharacteristic()
        {
            Console.WriteLine("What colour is its mane?");
            this.maneColour = Console.ReadLine();
        }
    }
}
