﻿using MasteringEFCore.MultiTenancy.Starter.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.MultiTenancy.Starter.Infrastructure.Commands
{
    public class CommandBase
    {
        internal readonly BlogContext Context;

        public CommandBase(BlogContext context)
        {
            Context = context;
        }
    }
}
