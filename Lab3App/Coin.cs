using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        public int Value;

        public Coin(String desc, int score, int value)
        {
            this.Description = desc;
            this.Score = score;
            this.Value = value;
        }
        public void UpdateTotalValue()
        {
            this.Board.TotalValue += this.Value;
            Console.WriteLine("Total Value is updated to: " + this.Board.TotalValue);
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + this.Description + " is displayed");
        }

        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);
            UpdateTotalValue();
        }
    }
}
