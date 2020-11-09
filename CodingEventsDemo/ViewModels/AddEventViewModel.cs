using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Name needs to be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, ErrorMessage = "Description has a maximum length of 500 characters.")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        [Required]
        [StringLength(50, ErrorMessage ="Location has a max character length of 50")]
        public string Location { get; set; }

        [Range(0,100000, ErrorMessage = "Must be numbers from 0 to 100,000.")]
        public int NumOfAttendees { get; set; }
    }
}
