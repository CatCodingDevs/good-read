using GoodRead.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Domain.Entities.Books
{
    public class Book : Auditable
    {
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public string ImagePath { get; set; } = String.Empty;
        public int PageNumber { get; set; }
        public string BookLanguage { get; set; } = String.Empty;
        public string ISBN { get; set; } = String.Empty;
        public DateTime PublishedYear { get; set; }

        public long? PublisherId { get; set; }
        public virtual Publisher? Publisher { get; set; }

        public long? AuthorId { get; set; }
        public virtual Author? Author { get; set; }

        public long CategoryId { get; set; }
        public virtual Category? BookCategory { get; set; }

        public virtual ICollection<Genre> Genre { get; set; }
    }
}
