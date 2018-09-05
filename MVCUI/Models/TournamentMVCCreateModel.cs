using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUI.Models
{
    public class TournamentMVCCreateModel
    {
        /// <summary>
        /// Represents the name for the given tournament.
        /// </summary>
        [Display(Name = "Tournament Name")]
        [StringLength(100, MinimumLength = 2)]
        [Required]
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the entry fee paid by the team.
        /// </summary>
        [Display(Name = "Entry Fee")]
        [DataType(DataType.Currency)]
        [Required]
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents a list of all teams entered for this tournament.
        /// </summary>
        [Display(Name = "Entered Teams")]
        public List<SelectListItem> EnteredTeams { get; set; } = new List<SelectListItem>();

        public List<string> SelectedEnteredTeams { get; set; } = new List<string>();

        /// <summary>
        /// Represents the prizes assigned for this tournament.
        /// </summary>
        [Display(Name = "Prizes")]
        public List<SelectListItem> Prizes { get; set; } = new List<SelectListItem>();

        public List<string> SelectedPrizes { get; set; } = new List<string>();
    }
}