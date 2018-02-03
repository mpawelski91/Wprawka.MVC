using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Entities
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime? ReleaseDate { get; set; }

        [Required]
        public string ISBN { get; set; }

        public int BookGenreID { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        public DateTime AddDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [ForeignKey("BookGenreID")]
        public DictBookGenre DicktBookGenre { get; set; }
    }
}
