using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CritterProgramUpdated
{
    class Critter
    {
        private int Happiness { get; set; }
        private int Hunger { get; set; }
        private bool Alive { get; set; }

        public Critter()
        {
            Happiness = 10; // Max happiness is 10
            Hunger = 5; // Max hunger is 5 and lowest 0
            Alive = true;
        }

        public override string ToString()
        {
            return Happiness + ";" + Hunger;
        }

        public string CheckHappinessStat()
        {
            if (Happiness >= 6)
            {
                return "Very happy!";
            }
            else if (Happiness >= 3 && Happiness <=5)
            {
                return "Happy";
            }
            else
            {
                return "Dissatisfied";
            }
        }

        public string CheckHungerStat()
        {
            if(Hunger >= 4)
            {
                return "Full";
            }
            else if (Hunger >= 2 && Hunger <=3)
            {
                return "Normal";
            }
            else
            {
                return "Hungry";
            }
        }

        public bool AliveCheck()
        {
            if (Hunger >= 1)
            {
                return true;
            }
            else
            {
                Alive = false;
                return false;
            }
        }

        public string PlayWithCritter()
        {
            Hunger = Hunger - 1;
            if (Happiness >= 5)
            {
                Happiness = 10;
                return "Critter Plays joyfull!";
            }
            else
            {
                Happiness = Happiness + 5;
                return "Critter plays";
            }            
        }

        public string FeedCritter()
        {
            if(Hunger >= 4)
            {
                Hunger = 5;
                return "Critter is full";
            }
            else
            {
                Hunger = Hunger + 2;
                return "Critter munches away";
            }
        }        
    }
}
