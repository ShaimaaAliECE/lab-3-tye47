using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Treasure : Collectable
    {
        public int Score;
        public void UpdateTotalScore()
        {
            this.Board.TotalScore += this.Score;
            Console.WriteLine("Total Score is updated to: " + this.Board.TotalScore);
        }
        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");
            UpdateTotalScore();
        }
    }
}
