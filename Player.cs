using System;
using System.Collections.Generic;
using System.Text;

namespace TourneyScoreSystem
{
    public class Player
    {
        public string name { get; set; }
        public int ID;
        public int points;

        public Player(int _ID)
        {
            ID = _ID;
        }
    }
}
