﻿using GoodRead.Domain.Enums;
using GoodRead.Service.Interfaces.Common;
using GoodRead.Service.Interfaces.Managments;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.Services.Managments
{
    public class IdentityHelperService : IIdentityHelperService
    {
        private readonly IHttpContextAccessor _accessor;

        public IdentityHelperService(IHttpContextAccessor accessor)
        {
            this._accessor = accessor;
        }

        public string GetUserEmail()
        {
            var res = _accessor.HttpContext!.User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress");
            return res is not null ? res.Value : string.Empty;
        }

        public long? GetUserId()
        {
            var res = _accessor.HttpContext!.User.FindFirst("Id");
            return res is not null ? long.Parse(res.Value) : null;
        }

        public string GetUserName()
        {
            var res = _accessor.HttpContext!.User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name");
            return res is not null ? res.Value : string.Empty;
        }

        public UserRole? GetUserRole()
        {
            var res = _accessor.HttpContext!.User.FindFirst("http://schemas.microsoft.com/ws/2008/06/identity/claims/role");
            return res is not null ? Enum.Parse<UserRole>(res.Value) : null;
        }
    }
}
