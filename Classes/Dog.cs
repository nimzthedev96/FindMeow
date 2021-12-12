using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindMeow.Classes
{
    public class Dog : Pet
    {
        protected override string Breed
        {
            get => base.Breed;
            set
            {
                /* Validate dog breeds */
                base.Breed = value;
            }
        }

        private string FurType;

        public Dog(string n, string s, decimal w, int a, string c, string b, string m, string f) : base(n, s, w, a, c, b, m)
        {
            FurType = f;

        }

        public Dog(string id) : base(id)
        {

        }
    }
}
