using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Dog : Animal
    {
        public string favoriteDogFood;
        public Dog(string name, string favoriteDogFood) : base(name)
        {
            this.favoriteDogFood = favoriteDogFood;

        }

        public override string MakeSound()
        {
            return "Bark"; 
        }

        public override string ToString()
        {
            return $"{base.ToString()} favorite Dog Food : {favoriteDogFood} ";
        }
    }
}
