using GoodRead.Domain.Entities.Books;
using GoodRead.Domain.Entities.Orders;
using GoodRead.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IBookRepository BookRepository { get; }
        IAuthorRepository AuthorRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IGenreRepository GenreRepository { get; }
        IPublisherRepository PublisherRepository { get; }
        IOrderRepository OrderRepository { get; }
        IOrderDetailRepository OrderDetailRepository { get; }
    }
}
