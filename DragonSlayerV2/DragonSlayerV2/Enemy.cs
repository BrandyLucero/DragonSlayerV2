using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayerV2
{
    class Enemy
    {
        private string _name;

        public string Name
        {
            get { return _name;}
            set { _name = value;}
        }//Health of enemy 
        private int _hp;
        public int HP;

        Random rng = new Random ();

        public Enemy (string name, int startingHP)
        {
            //intitialize the object
            this.HP = startingHP;
            this.Name = name;
        }
        //Do out attack Method
        public void Attack(Player player)
        {
            //80% chance to hit 
            if (rng.Next(0, 11) > 2)
            { 
                //its a hit
                int damage = rng.Next(5, 16);

            // er eill hit the player
                player.HP -= damage; 
                Console.WriteLine("{0} hit {1}for {2} damage!" , this.Name, player.name);


                //layers name 
  
	}
	
            }

        }
    }

