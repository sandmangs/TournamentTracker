﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCUI.Models
{
    public class TournamentMVCDetailsModel
    {
        /// <summary>
        /// Represents the name for the given tournament.
        /// </summary>
        [Display(Name = "Tournament Name")]
        public string TournamentName { get; set; }

        public List<RoundMVCModel> Rounds { get; set; } = new List<RoundMVCModel>();

        public List<MatchupMVCModel> Matchups { get; set; }

    }
}