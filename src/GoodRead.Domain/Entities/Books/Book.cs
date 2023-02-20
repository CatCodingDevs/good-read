using GoodRead.Domain.Common;

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

        public virtual ICollection<Genre> Genre { get; set; }
    }
}
