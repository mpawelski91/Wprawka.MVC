using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Common.ViewModels.User
{
    public class UserListViewModel
    {
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [DisplayName("Birth Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime BirthDate { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Phone Number")]
        public string Phone { get; set; }

        [DisplayName("Add Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime AddDate { get; set; }

        [DisplayName("Modified")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? ModifiedDate { get; set; }

        [DisplayName("Books Borrowed")]
        public int BooksBorrowed { get; set; }

        [DisplayName("Active")]
        public string Active { get { return IsActive ? "yes" : "no"; } }

        public int UserID { get; set; }

        public bool IsActive { get; set; }
    }
}
