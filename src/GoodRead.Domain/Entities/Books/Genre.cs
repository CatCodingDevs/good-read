using GoodRead.Domain.Common;

namespace GoodRead.Domain.Entities.Books
{
    public class Genre : Auditable
    {
        /// <summary>
        /// Gets or Sets Genre name
        /// </summary>
        public string Name { get; set; } = String.Empty;
    }
}
