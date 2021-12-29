using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigAMarKing.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ThumbnailImagePath { get; set; }
        [ForeignKey("CategoryID")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }
        [ForeignKey("CategoryID")]
        public virtual ICollection<UserCategory> UserCategories { get; set; }
    }
}
