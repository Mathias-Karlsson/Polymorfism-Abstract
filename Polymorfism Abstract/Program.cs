using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism_Abstract
{
    abstract class Player
    {
        public Player()
        {
            Console.WriteLine("A Player attacks!");
        }
        public abstract void Attack();
    }

    class Mage : Player
    {
        public override void Attack()
        {
            Console.WriteLine("A Mage attacks with a fireball!");
        }
    }

    class Warrior : Player
    {
        public override void Attack()
        {
            Console.WriteLine("A Warrior attacks with a sword!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            players.Add(new Mage());
            players.Add(new Warrior());

            foreach (Player p in players)
            {
                p.Attack();
            }
            Console.ReadLine();
        }
    }
}
