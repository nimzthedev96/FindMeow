using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindMeow.Classes
{
    public class Pet
    {
        /* Properties */
        protected string PetID { get; set; }
        protected string Name { get; set; }
        protected string Size { get; set; }  /* Small / medium / large */
        protected decimal Weight { get; set; }
        protected int AgeYears { get; set; }

        private string _colour;
        protected string Colour
        {
            get { return _colour; }

            set {
                /* First validate colour */

                _colour = Colour;
            
            }
        }
        protected virtual string Breed { get; set; }
        private string UniqueMarkings { get; set; }
        private bool Missing { get; set; }
        private DateTime LastSeen { get; set; }
        private int NumTimesMissing { get; set; }

        /* Methods */
        public Pet(string n, string s, decimal w, int a, string c, string b, string m) {
            Name = n;
            Size = s;
            Weight = w;
            AgeYears = a;
            Colour = c;
            Breed = b;
            UniqueMarkings = m;
            Missing = false;
        }

        public Pet(string id)
        {
            
            /* Fetch from DB using ID */

            /*Name = n;
            Size = s;
            Weight = w;
            AgeYears = a;
            Colour = c;
            Breed = b;
            UniqueMarkings = m;
            Missing = false;*/
        }

        public virtual void savePet()
        {
           
        }

        public virtual void markPetAsMissing(DateTime dt)
        {
            LastSeen = dt;
            Missing = true;
        }

        public virtual void markPetAsFound()
        {
            LastSeen = DateTime.Now;
            Missing = false;
            NumTimesMissing = NumTimesMissing + 1;
        }
    }
}
