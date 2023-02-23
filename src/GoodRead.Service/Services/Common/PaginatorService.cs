using GoodRead.Service.DTOs.Common;
using GoodRead.Service.Interfaces.Common;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace GoodRead.Service.Services.Common
{
    public class PaginatorService : IPaginatorService
    {
        private readonly IHttpContextAccessor _accessor;

        public PaginatorService(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }
        public void ToPagenator(PaginationMetaData metaData)
        {
            _accessor.HttpContext.Response.Headers.Add("X-Pagination",
                JsonConvert.SerializeObject(metaData));
        }
    }
}
