using System;
using System.Collections.Generic;
using System.Text;

namespace TourneyScoreSystem
{
    public class CollegeEvent
    {
        public string eventTitle;
        public int ID;
        public bool isTeamEvent;
        public List<Team> teams = new List<Team>();
        public List<Player> players = new List<Player>();
        public Dictionary<int, Player> playerRanking = new Dictionary<int, Player>();
        public Dictionary<int, Team> teamRanking = new Dictionary<int, Team>();
        public List<(Team, int, int)> teamOrderPoints = new List<(Team, int, int)>();
        public List<(Player, int, int)> playerOrderPoints = new List<(Player, int, int)>();

        public CollegeEvent(int _ID)
        {
            ID = _ID;
        }
    }
}
