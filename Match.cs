using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWLSimGame
{
    class Match
    {

        protected int winLoss(int team1, int team2, int heroStrength1, int heroStrength2)
        {
            int weaker, stronger;
            double winPercent;
            if (team1 > team2)
            {
                weaker = team2;
                stronger = team1;
            }
            else if (team1 < team2)
            {
                weaker = team1;
                stronger = team2;
            }
            else
            {
                Random rnd = new Random();
                int 
            }
        }
    }
}