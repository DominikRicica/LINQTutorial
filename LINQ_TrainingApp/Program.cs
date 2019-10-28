using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_TrainingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            List<Owner_Animal> owns = new List<Owner_Animal>();
            List<Owner> owners = new List<Owner>();
            
            Animal dog = new Animal("Border Colia", 15, 25, true, 1);
            Animal elephant = new Animal("Elephant", 500, 150, true, 2);
            Animal cat = new Animal("Seli", 5, 15, true, 3);
            Animal tiger = new Animal("Sid", 200, 50, true, 4);
            Animal bear = new Animal("Bumbo", 300, 200, true, 5);

            Owner dominik = new Owner("Dominik",1);
            Owner simona = new Owner("Simona", 2);

            Owner_Animal d_tiger = new Owner_Animal(1, 4);
            Owner_Animal d_bear = new Owner_Animal(1, 5);
            Owner_Animal d_dog = new Owner_Animal(1,1);
            Owner_Animal s_dog = new Owner_Animal(2,1);
            Owner_Animal s_tiger = new Owner_Animal(2, 4);

            owners.Add(dominik);
            owners.Add(simona);

            owns.Add(d_tiger);
            owns.Add(d_bear);
            owns.Add(d_dog);
            owns.Add(s_dog);
            owns.Add(s_tiger);

            animals.Add(dog);
            animals.Add(elephant);
            animals.Add(cat);
            animals.Add(tiger);
            animals.Add(bear);

            PrintHelper printHelper = new PrintHelper();
            printHelper.animals = animals;
            printHelper.owners = owners;
            printHelper.owns = owns;

            printHelper.PrintOwnersAnimals(1);
            Console.WriteLine("___________________________________________________");
            printHelper.PrintOwnersAnimals(2);


        }
    }
}
