﻿using MasteringEFCore.MultiTenancy.Starter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.MultiTenancy.Starter.Core.Queries.People
{
    public interface IGetPersonByIdQuery<T> :
        IQueryHandler<Person>, IQueryHandlerAsync<Person>
    {
        int? Id { get; set; }
    }
}
