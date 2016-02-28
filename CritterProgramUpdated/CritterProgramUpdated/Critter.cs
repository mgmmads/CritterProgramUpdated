using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CritterProgramUpdated
{
    class Critter
    {
        private bool Alive { get; set; }
        private int Happiness { get; set; }
        private int Hunger { get; set; }
        private int Clean { get; set; }
        private int Rest { get; set; }

        public Critter()
        {
            Alive = true;
            Happiness = 10; // Max happiness is 10
            Hunger = 5; // Max hunger is 5 and lowest 0
            Clean = 10; // Max clean is 10 and lowest 0
            Rest = 10; // Max rest is 10 and lowest 1
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
            else if (Happiness >= 3 && Happiness <= 5)
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
            if (Hunger >= 4)
            {
                return "Full";
            }
            else if (Hunger >= 2 && Hunger <= 3)
            {
                return "Normal";
            }
            else
            {
                return "Hungry";
            }
        }

        public string CheckCleanStat()
        {
            if (Clean >=8)
            {
                return "Sparkling";
            }
            else if (Clean >= 4 && Clean <=7)
            {
                return "Clean";
            }
            else
            {
                return "Dirty";
            }
        }

        public string CheckRestStat()
        {
            if (Rest >= 6)
            {
                return "Well rested";
            }
            else if (Rest >= 2 && Rest <= 5)
            {
                return "Slighty tired";
            }
            else
            {
                return "Tired";
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
            Clean = Clean - 2;

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
            Clean = Clean - 1;

            if (Hunger >= 4)
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

        public string BathCritter()
        {
            Hunger = Hunger - 1;
            Happiness = Happiness - 2;

            if (Clean >= 5)
            {
                Clean = 10;
                return "Critter splashes around in the water";
            }
            else
            {
                Clean = Clean + 5;
                return "Critter enjoys the bath";
            }
        }

        public string RestCritter()
        {
            Hunger = Hunger - 2;
            Happiness = Happiness - 3;
            Clean = Clean - 5;

            Rest = 10;
            return "Critter sleeps soundly";
        }
    }
}
