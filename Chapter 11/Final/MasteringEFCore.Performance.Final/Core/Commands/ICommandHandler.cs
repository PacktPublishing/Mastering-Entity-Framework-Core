﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.Performance.Final.Core.Commands
{
    public interface ICommandHandler<out TReturn>
    {
        TReturn Handle();
    }
}
