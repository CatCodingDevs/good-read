namespace GoodRead.DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IBookRepository BookRepository { get; }
        IAuthorRepository AuthorRepository { get; }
        IGenreRepository GenreRepository { get; }
        IPublisherRepository PublisherRepository { get; }
        IOrderRepository OrderRepository { get; }
        IOrderDetailRepository OrderDetailRepository { get; }
    }
}
