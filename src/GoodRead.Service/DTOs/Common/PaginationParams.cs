using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.DTOs.Common
{
    public class PaginationParams
    {
        private const int maxPageSize = 50;
        private int pageSize = 10;

        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; } = 1;

        [JsonProperty("pageSize")]
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > maxPageSize) ? maxPageSize : value; }
        }

        public PaginationParams(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

        public PaginationParams()
        {
        }
    }
}
