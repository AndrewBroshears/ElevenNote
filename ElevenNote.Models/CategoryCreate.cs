using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    class CategoryCreate
    {
        public int CategoryId { get; set; }
        [MaxLength(15, ErrorMessage = "There are too many characters in this field. (Max 15)")]
        [Required]
        public string CategoryName { get; set; }
        public override string ToString() => CategoryName;
    }
}
