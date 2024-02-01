using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Collectable : Displayable
    {
        public String Description;
        public CollectionBoard Board;
        public virtual void Display() { Console.WriteLine("Displaying Collectible " + this.Description); }
        public virtual void AddMe(List<Collectable> collectables)
        {
            collectables.Add(this);
        }
    }
}
