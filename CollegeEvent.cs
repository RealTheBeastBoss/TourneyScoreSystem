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

        public CollegeEvent(int _ID)
        {
            ID = _ID;
        }
    }
}
