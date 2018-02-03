using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Common.ViewModels.User
{
    public class EditUserViewModel
    {
        [Required(ErrorMessage = "First name is required")]
        [StringLength(20, ErrorMessage = "First name is too long")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(20, ErrorMessage = "Last name is too long")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Birth date is required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Range(type: typeof(DateTime), minimum: "1900-1-1", maximum: "2017-1-1", ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [DisplayName("Birth Date")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Phone Number")]
        public string Phone { get; set; }

        [DisplayName("Active")]
        public bool IsActive { get; set; }

        public int UserID { get; set; }

        public int BooksBorrowed { get; set; }
    }
}
