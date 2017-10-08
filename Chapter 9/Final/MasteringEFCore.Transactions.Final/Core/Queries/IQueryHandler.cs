﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasteringEFCore.Transactions.Final.Models;

namespace MasteringEFCore.Transactions.Final.Core.Queries
{
    public interface IQueryHandler<out TReturn> : IQueryRoot
    {
        TReturn Handle();
    }
}
