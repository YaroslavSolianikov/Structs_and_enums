using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_and_enums_005
{
    class Accauntant
    {
        public static bool AskForBonus(Workers worker, int hours)
        {
            bool bonus = false;
            switch (worker)
            {
                case Workers.Junior:
                    if ((int)Workers.Junior < hours)
                    {
                        bonus = true;
                    }
                    break;
                case Workers.Middle:
                    if ((int)Workers.Middle < hours)
                    {
                        bonus = true;
                    }
                    break;
                case Workers.Senior:
                    if ((int)Workers.Senior < hours)
                    {
                        bonus = true;
                    }
                    break;
                case Workers.TeamLead:
                    if ((int)Workers.TeamLead < hours)
                    {
                        bonus = true;
                    }
                    break;
            }
            return bonus;
        }
    }
    enum Workers
    {
        TeamLead = 50,
        Senior = 35,
        Middle = 25,
        Junior = 20
    }
}
