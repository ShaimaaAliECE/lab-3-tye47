using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Axe : Tool
    {
        public Axe(String desc)
        {
            this.Description = desc;
        }
        public override void Display()
        {
            Console.WriteLine("Axe " + this.Description + " is displayed");
        }
        public override void DoAction()
        {
            Console.WriteLine("Axe is used");
        }
    }
}
