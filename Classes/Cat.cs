﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindMeow.Classes
{
    public class Cat : Pet
    {
        protected override string Breed 
        { 
            get => base.Breed; 
            set
            { 
                /* Validate cat breeds */
                base.Breed = value; 
            }
        }

        private string FurType;

        public Cat(string n, string s, decimal w, int a, string c, string b, string m, string f) : base(n, s, w, a, c, b, m)
        {
            FurType = f;
        
        }

        public Cat(string id) : base(id)
        {

        }

    }
}
