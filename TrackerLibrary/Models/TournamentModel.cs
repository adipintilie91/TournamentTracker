using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents the Tournament/
    /// </summary>
    class TournamentModel
    {
        /// <summary>
        /// A name for the Tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// An entry fee sum of money.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Teams that entered this tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// List of prizes for this tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
