using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one Team.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// List of members on PersonModel format.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>(); //no need for ctor since C#6 
        /// <summary>
        /// Name of the team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
