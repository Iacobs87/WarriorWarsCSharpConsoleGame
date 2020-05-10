using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WarriorWarsCSharpConsoleGame.Enum;

namespace WarriorWarsCSharpConsoleGame
{
    

    class EntryPoint
    {

        static Random rng = new Random();
        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior("Alex", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Andreea", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {

                if (rng.Next(0,10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }

                Thread.Sleep(100);

            }


        }
        
    }
}
