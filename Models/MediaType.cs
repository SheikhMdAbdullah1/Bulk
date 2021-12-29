using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigAMarKing.Models
{
    public class MediaType
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [Required]
        public string ThumbnailImagePath { get; set; }
        [Required]
        [ForeignKey("CategoryID")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }
    }
}
