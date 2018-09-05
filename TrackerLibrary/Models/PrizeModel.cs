using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// PrizeModel represents the class for tournament prizes.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the value for place the team finished in.
        /// </summary>
        [Display(Name = "Place Number")]
        [Range(1, 2)]
        [Required]
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the name given for the place the team finished in.  i.e. First Place, Runner Up, etc...
        /// </summary>
        [Display(Name = "Place Name")]
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents that prize amount designated for each place.
        /// </summary>
        [Display(Name = "Prize Amount")]
        [DataType(DataType.Currency)]
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the prize percentage, if used.
        /// </summary>
        [Display(Name = "Prize Percentage")]
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
