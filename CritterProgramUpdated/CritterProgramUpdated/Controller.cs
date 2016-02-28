using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CritterProgramUpdated
{
    static public class Controller
    {
        static private int TimeCounter { get; set; }

        static Critter newCritter = new Critter();
        
        static public string CritterAction(string actionChoice)
        {
            if (actionChoice == "FeedCritter")
            {
                return newCritter.FeedCritter();
            }
            else if (actionChoice == "PlayWithCritter")
            {
                return newCritter.PlayWithCritter();
            }
            else if (actionChoice == "BathCritter")
            {
                return newCritter.BathCritter();
            }
            else if (actionChoice == "RestCritter")
            {
                return newCritter.RestCritter();
            }
            else
            {
                return ""; //returns nothing.
            }
        }

        static public string CritterHappiness()
        {
            return newCritter.CheckHappinessStat();
        }

        static public string CritterHunger()
        {
            return newCritter.CheckHungerStat();
        }

        static public string CritterCleanness()
        {
            return newCritter.CheckCleanStat();
        }

        static public string CritterRestness()
        {
            return newCritter.CheckRestStat();
        }

        static public bool CritterAliveCheck()
        {
            return newCritter.AliveCheck();
        }
    }
}
