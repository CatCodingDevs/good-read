using GoodRead.DataAccess.DbContexts;
using GoodRead.DataAccess.Interfaces;

namespace GoodRead.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository UserRepository { get; }

        public IBookRepository BookRepository { get; }

        public IAuthorRepository AuthorRepository { get; }

        public IGenreRepository GenreRepository { get; }

        public IPublisherRepository PublisherRepository { get; }

        public IOrderRepository OrderRepository { get; }

        public IOrderDetailRepository OrderDetailRepository { get; }

        public UnitOfWork(AppDbContext dbContext)
        {
            UserRepository = new UserRepository(dbContext);
            BookRepository = new BookRepository(dbContext);
            AuthorRepository = new AuthorRepository(dbContext);
            GenreRepository = new GenreRepository(dbContext);
            PublisherRepository = new PublisherRepository(dbContext);
            OrderRepository = new OrderRepository(dbContext);
            OrderDetailRepository = new OrderDetailRepository(dbContext);
        }
    }
}
