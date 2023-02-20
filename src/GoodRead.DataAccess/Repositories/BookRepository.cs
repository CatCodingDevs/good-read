using GoodRead.DataAccess.DbContexts;
using GoodRead.DataAccess.Interfaces;
using GoodRead.Domain.Entities.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.DataAccess.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(AppDbContext dbContext) : base(dbContext)
        {
        }


    }
}
