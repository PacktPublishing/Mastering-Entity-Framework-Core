﻿using MasteringEFCore.MultiTenancy.Starter.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.MultiTenancy.Starter.Infrastructure.Commands
{
    public class CommandFileBase
    {
        internal readonly BlogFilesContext Context;

        public CommandFileBase(BlogFilesContext context)
        {
            Context = context;
        }
    }
}
