using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Entities
{
    public class DictBookGenre
    {
        [Key]
        public int BookGenreID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
