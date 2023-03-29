using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classs
{
    public class PlayerStats
    {
        public int Kills { get; set; }
        public int Assists { get; set; }
        public int Deaths { get; set; }

        public PlayerStats() { }
        public PlayerStats(int kills, int assists, int deaths)
        {
            Kills = kills;
            Assists = assists;
            Deaths = deaths;
        }

        public override string ToString()
        {
            return $"Kills: {Kills} Assists: {Assists} Deaths: {Deaths}";
        }
    }
}