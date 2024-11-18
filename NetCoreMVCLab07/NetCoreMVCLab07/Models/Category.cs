using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreMVCLab07.Models
{
    [Table("Categories")]
    public class Category
    {
        public int CategoryId {  get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }
        public string Image {  get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set;}
    }
}
