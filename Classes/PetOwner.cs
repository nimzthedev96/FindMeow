using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindMeow.Classes
{
    public class PetOwner
    {
        private string PetOwnerID;
        private string Name;
        private string Surname;
        private string DateOfBirth;
        private string Gender;
        

        public PetOwner(string n, string s, string db, string g)
        {
            Name = n;
            Surname = s;
            DateOfBirth = db;
            Gender = g;

        }


    }
}
