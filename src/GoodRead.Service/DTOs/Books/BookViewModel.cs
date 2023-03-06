using GoodRead.Domain.Entities.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.DTOs.Books
{
    public class BookViewModel
    {
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public string ImagePath { get; set; } = String.Empty;
        public int PageNumber { get; set; }
        public string BookLanguage { get; set; } = String.Empty;
        public string ISBN { get; set; } = String.Empty;
        public DateTime PublishedYear { get; set; }
        public Publisher? Publisher { get; set; }

        public static implicit operator BookViewModel(Book book)
        {
            return new BookViewModel()
            {
                Title = book.Title,
                Description = book.Description,
                Price = book.Price,
                ImagePath = book.ImagePath,
                PageNumber = book.PageNumber,
                BookLanguage = book.BookLanguage,
                ISBN = book.ISBN,
                Publisher = book.Publisher,
                PublishedYear = book.PublishedYear,
                //Publisher = (Publisher)book.Publisher
            };
        }
    }
}
