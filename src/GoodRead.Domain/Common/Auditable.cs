namespace GoodRead.Domain.Common
{
    public abstract class Auditable : BaseEntity
    {
        public DateTime CreatedAt { get; set; }
    }
}
