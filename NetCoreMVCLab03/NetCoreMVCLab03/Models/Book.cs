using Microsoft.AspNetCore.Mvc.Rendering;

namespace NetCoreMVCLab03.Models
{
    public class Book
    {
       public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenresId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }
            
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Chi Pheo",
                     AuthorId = 1,
                    GenresId = 1,
                    Image ="/images/products/1.jpg",
                    Price = 1,
                    TotalPage = 1,
                    Sumary=""
                },
                new Book()
                {
                    Id = 3,
                    Title = "Chi Pheo",
                     AuthorId = 1,
                    GenresId = 1,
                    Image ="/images/products/1.jpg",
                    Price = 1,
                    TotalPage = 1,
                    Sumary=""
                },
                new Book()
                {
                    Id = 3,
                    Title = "Chi Pheo",
                     AuthorId = 1,
                    GenresId = 1,
                    Image ="/images/products/1.jpg",
                    Price = 1,
                    TotalPage = 1,
                    Sumary=""
                },
                new Book()
                {
                    Id =4,
                    Title = "Chi Pheo",
                     AuthorId = 1,
                    GenresId = 1,
                    Image ="/images/products/1.jpg",
                    Price = 1,
                    TotalPage = 1,
                    Sumary=""
                },
                new Book()
                {
                    Id = 5,
                    Title = "Chi Pheo",
                     AuthorId = 1,
                    GenresId = 1,
                    Image ="/images/products/1.jpg",
                    Price = 1,
                    TotalPage = 1,
                    Sumary=""
                },
                new Book()
                {
                    Id = 6,
                    Title = "Chi Pheo",
                     AuthorId = 1,
                    GenresId = 1,
                    Image ="/images/products/1.jpg",
                    Price = 1,
                    TotalPage = 1,
                    Sumary=""
                },
            };
            return books;
        }
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b=> b.Id==id);
            return book;
        }
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1", Text="Nam Cao"},
            new SelectListItem{Value="2", Text="Ngo Tat To"},
            new SelectListItem{Value="3", Text="Adamkhum"},
            new SelectListItem{Value="4", Text="Thien Su"},
        };
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1", Text="Truyen tranh"},
            new SelectListItem{Value="2", Text="Van hoc duong dai"},
            new SelectListItem{Value="3", Text="Phat hoc pho thong"},
            new SelectListItem{Value="4", Text="Truyen cuoi"},
        };
    }
}
