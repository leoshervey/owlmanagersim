using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWLSimGame
{
    class Gameplay
    {
        public Gameplay()
        {

        }
        public string winLoss(int team1, int team2)
        {
            Random rnd = new Random();
            int weaker, stronger, num;
            string weakTeam, strongTeam;
            double winPercent;
            if (team1 > team2)
            {
                weaker = team2;
                weakTeam = "team2";
                stronger = team1;
                strongTeam = "team1";
            }
            else if (team1 < team2)
            {
                weaker = team1;
                weakTeam = "team1";
                stronger = team2;
                strongTeam = "team2";
            }
            else
            {
                num = rnd.Next(0, 1);
                if (num == 0)
                {
                    weaker = team1;
                    team1 = 49;
                    weakTeam = "team1";
                    stronger = team2;
                    team2 = 51;
                    strongTeam = "team2";
                }
                else
                {
                    weaker = team2;
                    team2 = 49;
                    weakTeam = "team2";
                    stronger = team1;
                    team1 = 51;
                    strongTeam = "team1";
                }
            }
            winPercent = (((double)weaker / stronger) * 100) / 2;
            if (winPercent < 5)
            {
                winPercent = 5;
            }
            num = rnd.Next(1, 101);
            if (num > winPercent)
            {
                return strongTeam;
            }
            else
            {
                return weakTeam;
            }
        }
    }
}
