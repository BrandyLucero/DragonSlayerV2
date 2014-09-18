using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayerV2
{
    class Game
    {
        public Player Player { get; set; }
        public Enemy Enemy { get; set; }

        //Constructor
        public Game()
        {
            this.Player = new Player("the Mighty Brandy", 100);
            this.Enemy = new Enemy("the Mighter Pat", 200);

        }
        private void DisplayInfo()

        {
            Console.WriteLine("(0), {1} HP vs (2) (3) HP");

                while (Player .isAlive && Enemy.Name.
        }
    }
}
