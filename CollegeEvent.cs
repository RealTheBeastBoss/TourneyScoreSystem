using System;
using System.Collections.Generic;
using System.Text;

namespace TourneyScoreSystem
{
    public class CollegeEvent
    {
        public string eventTitle;
        public bool isTeamEvent;
        public List<Team> teams = new List<Team>();
        public List<Player> players = new List<Player>();
    }
}
