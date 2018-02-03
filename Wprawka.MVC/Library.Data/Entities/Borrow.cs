using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Entities
{
    public class Borrow
    {
        [Key]
        public int BorrowID { get; set; }

        public int UserID { get; set; }

        public int BookID { get; set; }

        [Required]
        public DateTime FromDate { get; set; }

        [Required]
        public DateTime ToDate { get; set; }

        [Required]
        public bool IsReturned { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [ForeignKey("BookID")]
        public Book Book { get; set; }
    }
}
