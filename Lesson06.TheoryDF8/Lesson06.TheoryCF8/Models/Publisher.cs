using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson06.TheoryCF8.Models
{
    [Table("Publishers")]
    public class Publisher
    {
        public int PublisherId {  get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book> Books { get; set; }    

    }
}
