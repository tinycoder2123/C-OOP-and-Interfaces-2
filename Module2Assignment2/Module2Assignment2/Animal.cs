using System;
using System.Collections.Generic;
using System.Text;

namespace Module2Assignment2
{
    public interface Animal
    {
        int age { get; set; }
        String species { get; set; }
        void RequestUniqueCharacteristic();
        void GetDescription();

    }
}