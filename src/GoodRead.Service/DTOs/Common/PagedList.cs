﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.DTOs.Common
{
    public class PagedList<T> : List<T>
    {
        public PaginationMetaData MetaData { get; set; } = default!;

        public PagedList(List<T> items, int count, PaginationParams @params)
        {
            MetaData = new PaginationMetaData(count, @params.PageSize, @params.PageNumber);
            AddRange(items);
        }
        public async static Task<PagedList<T>> ToPagedListAsync(IQueryable<T> query, PaginationParams @params)
        {
            var count = await query.CountAsync();
            var items = await query.Skip((@params.PageNumber - 1) * @params.PageSize)
                                    .Take(@params.PageSize).ToListAsync();
            return new PagedList<T>(items, count, @params);
        }
        public static PagedList<T> ListToPagedList(List<T> list, int count, PaginationParams @params)
        {
            return new PagedList<T>(list, count, @params);
        }
    }
}
