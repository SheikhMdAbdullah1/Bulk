using System.ComponentModel.DataAnnotations;

namespace DigAMarKing.Models
{
    public class Content
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string HtmlContent { get; set; }
        public string VideoLink { get; set; }
        public CategoryItem CategoryItem { get; set; }
    }
}
