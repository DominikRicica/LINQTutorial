using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_TrainingApp
{
    class Owner
    {
        public string Name { get; set; }
        public int Owner_ID { get; set; }

        public Owner(string name, int ownerID)
        {
            Name = name;
            Owner_ID = ownerID;
        }

        public override string ToString()
        {
            return "Owner: " + Name;
        }

    }
}
