using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhispersOfTheGarden
{
    public abstract class Character
    {
        private string name;
        public string Name { 
            get { return name; }
            set { name = value; }
        }

        public Character(string name)
        {
            Name = name;
        }
        public abstract void Interact();
    }
}
