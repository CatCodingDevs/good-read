using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.Interfaces.Common
{
    public interface IPaginatorService
    {
        void ToPagenator(PaginationMetaData metaData);
    }
}
