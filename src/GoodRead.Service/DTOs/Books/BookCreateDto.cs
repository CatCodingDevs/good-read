﻿using GoodRead.Domain.Entities.Books;

namespace GoodRead.Service.DTOs.Books
{
    public class BookCreateDto
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

        public long? AuthorId { get; set; }

        public virtual ICollection<Genre> Genre { get; set; } = null!;

        public static implicit operator Book(BookCreateDto bookCreateDto)
        {
            return new Book()
            {
                Title = bookCreateDto.Title,
                Description = bookCreateDto.Description,
                Price = bookCreateDto.Price,
                ImagePath = bookCreateDto.ImagePath,
                PageNumber = bookCreateDto.PageNumber,
                BookLanguage = bookCreateDto.BookLanguage,
                ISBN = bookCreateDto.ISBN,
                PublishedYear = bookCreateDto.PublishedYear,
                PublisherId = bookCreateDto.PublisherId,
                AuthorId = bookCreateDto.AuthorId,
                Genre = bookCreateDto.Genre,
            };
        }
    }
}