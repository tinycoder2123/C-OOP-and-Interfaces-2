using System;
using System.Collections.Generic;
using System.Text;

namespace Module2Assignment2
{
    public class Bears : Animal
    {
        public int age { get; set; }
        public string species { get; set; }
        public bool isGrizzly { get; set; }
        public void GetDescription()
        {
            if (this.isGrizzly)
                Console.WriteLine($" {this.age}-year-old grizzly bear.");
            else
                Console.WriteLine($" {this.age}-year-old non-grizzly bear.");
        }
        void Animal.RequestUniqueCharacteristic()
        {
            Console.WriteLine("Is it a grizzly bear? (true/false)");
            var boolString = (Console.ReadLine());
            if (boolString == "true")
                this.isGrizzly = true;
            else
                this.isGrizzly = false;
        }
    }
}

