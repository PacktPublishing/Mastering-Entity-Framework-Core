﻿using MasteringEFCore.Concurrencies.Starter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.Concurrencies.Starter.Core.Queries.Comments
{
    interface IGetCommentsByPostQuery<in T> :
        IQueryHandler<IEnumerable<Comment>>, IQueryHandlerAsync<IEnumerable<Comment>>
    {
        int PostId { get; set; }
    }
}
