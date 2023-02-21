using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.DTOs.Common
{
    public class ErrorResponse
    {
        public int StatusCode { get; set; }

        public string Message { get; set; } = null!;
    }
}
