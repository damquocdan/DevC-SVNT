using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson06.TheoryCF8.Models
{
    [Table("Book")]
    public class Book
    {
        public string BookId { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public int? PublisherId { get; set; }
        public Category Category { get; set; }
        public Publisher Publisher { get; set; }
    }
}
