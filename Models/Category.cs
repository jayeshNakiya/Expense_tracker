using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExpanseTrackerspro.Models
{
    public class Category
    {

        [Key]
        public int CatId { get; set; }
        [Required]
        public string? CatName { get; set; }

    }
}
