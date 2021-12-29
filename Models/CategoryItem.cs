using System.ComponentModel.DataAnnotations;

namespace DigAMarKing.Models
{
    public class CategoryItem
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime TimeRelease { get; set; }
        public int CategoryID { get; set; }
        [Required]
        public int MediaTypeID { get; set; }
    }
}
