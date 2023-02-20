﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Domain.Common
{
    public abstract class Auditable : BaseEntity
    {
        public DateTime CreatedAt { get; set; }
    }
}
