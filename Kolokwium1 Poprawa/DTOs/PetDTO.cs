using System;

namespace Poprawa.Services
{
    public class PetDTO
    {

        public string Name { get; set; }
        public bool IsMale { get; set; }
        public DateTime DateRegistered { get; set; }
        public DateTime ApprcimateDateOfBirth { get; set; }
        public DateTime? DateAdopted { get; set; }
        public int BreedTypeIdBreedType { get; set; }


    }
}