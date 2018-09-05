using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// PersonModel represents the main class for people.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the first name of the person.
        /// </summary>
        [Display(Name ="Given Name")]
        [StringLength(100,MinimumLength = 2)]
        [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// Represents the last name of the person.
        /// </summary>
        [Display(Name = "Last Name")]
        [StringLength(100, MinimumLength = 2)]
        [Required]
        public string LastName { get; set; }
        /// <summary>
        /// Represents the email address for notification purposes.
        /// </summary>
        [Display(Name = "Email Address")]
        [StringLength(200, MinimumLength = 6)]
        [Required]
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents the cell phone number for notification purposes (texting).
        /// </summary>
        [Display(Name = "Cellphone Number")]
        [StringLength(20, MinimumLength = 10)]
        [Required]
        public string CellPhoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } {LastName}";
            }
        }

    }
}
