﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.Transactions.Starter.Core.Commands
{
    public interface ICommandHandler<out TReturn>
    {
        TReturn Handle();
    }
}
