﻿using MasteringEFCore.Performance.Starter.Core.Commands;
using MasteringEFCore.Performance.Starter.Core.Queries;
using MasteringEFCore.Performance.Starter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.Performance.Starter.Repositories
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> Get<T>(T query) 
            where T : IQueryHandler<IEnumerable<Comment>>;
        Task<IEnumerable<Comment>> GetAsync<T>(T query) 
            where T : IQueryHandlerAsync<IEnumerable<Comment>>;
        int Execute<T>(T command) where T : ICommandHandler<int>;
        Task<int> ExecuteAsync<T>(T command) where T : ICommandHandlerAsync<int>;
    }
}
