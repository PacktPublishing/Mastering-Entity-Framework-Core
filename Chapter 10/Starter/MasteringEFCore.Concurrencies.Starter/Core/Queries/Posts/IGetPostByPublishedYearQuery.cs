﻿using MasteringEFCore.Concurrencies.Starter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.Concurrencies.Starter.Core.Queries.Posts
{
    public interface IGetPostByPublishedYearQuery<T> : 
        IQueryHandler<IEnumerable<Post>>, IQueryHandlerAsync<IEnumerable<Post>>
    {
        int Year { get; set; }
    }
}
