﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class PetWolf : Wolf
    {
        
        public PetWolf(string name, string favoriteDogFood, string nameOfPack) : base(name, favoriteDogFood, nameOfPack)
        {
            

        }
        public override string MakeSound()
        {
            return "";
        }
        public override string ToString()
        {
            return $"{base.ToString()}";
        }

    }
}
