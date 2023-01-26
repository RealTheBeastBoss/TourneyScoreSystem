using System;
using System.Collections.Generic;
using System.Text;

namespace TourneyScoreSystem
{
    public class Team
    {
        public string name { get; set; }
        public int ID;
        public List<Player> players = new List<Player>();
        public int teamPoints;
        public List<(Player, int)> playerOrder = new List<(Player, int)>();

        public Team(int _ID)
        {
            ID = _ID;
        }
    }
}
