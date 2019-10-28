using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_TrainingApp
{
    class PrintHelper
    {
        public List<Animal> animals;
        public List<Owner> owners;
        public List<Owner_Animal> owns;
    public void PrintOwnersAnimals(int ownerID)
        {
            var owner_data = from owner in owners
                             join own in owns on owner.Owner_ID equals own.OwnerID
                             join anim in animals on own.AnimalID equals anim.Animal_ID
                             where owner.Owner_ID == ownerID
                             select new {OwnerName = owner.Name, OwnerID = owner.Owner_ID, AnimalID = own.AnimalID, AnimalName = anim.Name, AnimalWeight = anim.Weight } ;

            foreach (var owner in owner_data)
            {
                Console.WriteLine(owner.ToString());
            }
            Console.ReadLine();
        }
        
    }
}
