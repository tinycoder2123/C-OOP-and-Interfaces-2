using System;
using System.Collections.Generic;
using System.Text;

namespace Module2Assignment2
{
    public class Wolves : Animal
    {
        public int age { get; set; }
        public string species { get; set; }
        public int speed { get; set; }
        public void GetDescription()
        {
            Console.WriteLine($" {this.age}-year-old wolf that runs {this.speed} km/h.");
        }
        void Animal.RequestUniqueCharacteristic()
        {
            Console.WriteLine("How fast can it run (in km/h)?");
            this.speed = Convert.ToInt32(Console.ReadLine());
        }
    }
}
