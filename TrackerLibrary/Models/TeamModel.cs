using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// TeamModel represents that main class for teams.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Represents a team's Ids
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the team name
        /// </summary>
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
        /// <summary>
        /// Represents a list of team members
        /// </summary>
        [Display(Name = "Team Member List")]
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    }
}
