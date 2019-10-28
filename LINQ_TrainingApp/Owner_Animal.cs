using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_TrainingApp
{
    class Owner_Animal
    {
        public int OwnerID { get; set; }
        public int AnimalID { get; set; }

        public Owner_Animal(int ownerID, int animalID)
        {
            OwnerID = ownerID;
            AnimalID = animalID;
        }
    }
}
