using GoodRead.Service.DTOs.Common;

namespace GoodRead.Service.Interfaces.Common
{
    public interface IPaginatorService
    {
        void ToPagenator(PaginationMetaData metaData);
    }
}
