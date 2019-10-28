using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_TrainingApp
{
    class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public bool Mammal { get; set; }
        public int Animal_ID { get; set; }

        public Animal(string name, double weight, double height, bool mammal, int animalID)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Mammal = mammal;
            Animal_ID = animalID;
        }

        public override string ToString()
        {
            return "A " + Name + "has" + Weight + "kg and his/her height is:" + Height;
        }
    }
}
