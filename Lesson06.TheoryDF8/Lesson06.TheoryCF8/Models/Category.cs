using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson06.TheoryCF8.Models
{
    [Table("Categories")]
    public class Category
    {
        public int CategoryId {  get; set; }
        public string CategoryName { get; set; }

        public ICollection<Book> Books { get; set;}
    }
}
