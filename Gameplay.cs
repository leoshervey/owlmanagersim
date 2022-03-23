using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace OWLSimGame
{
    class Gameplay
    {
        private int _gameWeek;
        private int _userTeamStrength;
        private string _userTeamName;
        public string[] results = new string[10];
        public int userMatch;

        public Gameplay(int week, int userTeamStrength, string userTeamName)
        {
            _gameWeek = week;
            _userTeamStrength = userTeamStrength;
            _userTeamName = userTeamName;
            runGameWeek();
        }

        private void runGameWeek()
        {
            string teamAName = "", teamBName = "", winner = "",result;
            string filename = "LeagueSchedule/Matchday" + _gameWeek+".csv";
            string [,] schedule = new string[10,2];
            //read in gameweek schedule
            using (var reader = new StreamReader(@filename))
            {
                for (int x=0;x<10;x++)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(",");
                    schedule[x,0] = values[0];
                    schedule[x,1] = values[1];
                }
            }

            for (int x=0; x<10; x++)
            {
                int teamAWins = 0, teamBWins = 0,teamALosses = 0, teamBLosses = 0, teamAStrength, teamBStrength;
                teamAName = schedule[x,0];
                teamBName = schedule[x,1];
                if (teamAName == _userTeamName)
                {
                    teamAStrength = _userTeamStrength;
                    teamBStrength = getCPUTeamStrength(teamBName);
                }
                else if (teamBName == _userTeamName)
                {
                    teamBStrength = _userTeamStrength;
                    teamAStrength = getCPUTeamStrength(teamAName);
                }
                else
                {
                    teamAStrength = getCPUTeamStrength(teamAName);
                    teamBStrength = getCPUTeamStrength(teamBName);
                }
                do
                {
                    winner = winLoss(teamAStrength, teamBStrength);
                    if (winner == "team1")
                    {
                        teamAWins++;
                        teamBLosses++;
                    }
                    else
                    {
                        teamBWins++;
                        teamALosses++;
                    }
                } while (teamAWins < 3 && teamBWins < 3);
                if (teamAWins == 3)
                {
                    saveResult(teamAName, teamAWins, teamALosses, true);
                    saveResult(teamBName, teamBWins, teamBLosses, false);
                }
                else
                {
                    saveResult(teamAName, teamAWins, teamALosses, false);
                    saveResult(teamBName, teamBWins, teamBLosses, true);
                }
                if ((teamAName == _userTeamName) || (teamBName == _userTeamName))
                {
                    userMatch = x;
                }
                result = teamAName + "          " + teamAWins + "       vs      " + teamBWins + "          " + teamBName;
                results[x] =result;
            }
        }

        private int getCPUTeamStrength(string teamName)
        {
            int teamStrength = 0, tankStrength = 0, supportStrength = 0, damageStrength = 0;
            List<int> support = new List<int>();
            List<int> damage = new List<int>();
            List<int> tank = new List<int>();
            //read in team strength from db
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                conn.Open();
                string query = @"SELECT roles.role, players.overall
                                FROM players, teams, roles
                                WHERE players.teamID = teams.ID AND players.role = roles.ID and teams.team = @name";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", teamName);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if ((string)reader[0] == "Support")
                    {
                        support.Add(Convert.ToInt32(reader[1]));
                    }
                    else if ((string)reader[0] == "Damage")
                    {
                        damage.Add(Convert.ToInt32(reader[1]));
                    }
                    else if ((string)reader[0] == "Tank")
                    {
                        tank.Add(Convert.ToInt32(reader[1]));
                    }
                }
                if (tank.Count > 1)
                {
                    Random rnd = new Random();
                    int tankChoice = rnd.Next(tank.Count - 1);
                    tankStrength += tank[tankChoice];
                }
                else
                {
                    tankStrength += tank[0];
                }
                if (support.Count > 2)
                {
                    for (int x= 0; x <2; x++)
                    {
                        Random rnd = new Random();
                        int supportChoice = rnd.Next(support.Count - 1);
                        supportStrength += support[supportChoice];
                    }
                }
                else
                {
                    supportStrength += support[0] + support[1];
                }
                if (damage.Count > 2)
                {
                    for (int x = 0; x < 2; x++)
                    {
                        Random rnd = new Random();
                        int damageChoice = rnd.Next(damage.Count - 1);
                        damageStrength += damage[damageChoice];
                    }
                }
                else
                {
                    damageStrength += damage[0] + damage[1];
                }
                Random rdn = new Random();
                int cpuHeroStrengths = rdn.Next(25, 50);
                teamStrength = tankStrength + supportStrength + damageStrength + cpuHeroStrengths;
                return teamStrength;
            }
        }

        private void saveResult(string teamName, int mapWins, int mapLosses, bool result)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                conn.Open();
                string query = @"SELECT  leaguetable.Wins, leaguetable.MapDiff, leaguetable.MapWon, leaguetable.MapLoss, leaguetable.Played, leaguetable.Losses
                                FROM leaguetable, teams
                                WHERE teams.ID = leaguetable.ID AND teams.team = @team;";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@team", teamName);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int wins = Convert.ToInt32(reader[0]);
                    int diff = Convert.ToInt32(reader[1]);
                    int mW = Convert.ToInt32(reader[2]);
                    int mL = Convert.ToInt32(reader[3]);
                    int played = Convert.ToInt32(reader[4]);
                    int loss = Convert.ToInt32(reader[5]);
                    played++;
                    if (result == true)
                    {
                        wins++;
                    }
                    else
                    {
                        loss++;
                    }
                    mW += mapWins;
                    mL += mapLosses;
                    diff += (mapWins - mapLosses);
                    string query2 = @"UPDATE leaguetable
                                        SET Played = @p, Wins = @w, MapDiff = @md, MapWon = @mw, MapLoss = @ml, Losses = @l
                                        WHERE leaguetable.ID IN (SELECT teams.ID FROM teams WHERE teams.team = @team);";
                    SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@team", teamName);
                    cmd2.Parameters.AddWithValue("@p", played);
                    cmd2.Parameters.AddWithValue("@w", wins);
                    cmd2.Parameters.AddWithValue("@md", diff);
                    cmd2.Parameters.AddWithValue("@mw", mW);
                    cmd2.Parameters.AddWithValue("@ml", mL);
                    cmd2.Parameters.AddWithValue("@l", loss);
                    cmd2.ExecuteNonQuery();
                }
            }
        }


        private string winLoss(int team1, int team2)
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
