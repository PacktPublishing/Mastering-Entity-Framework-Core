﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.Concurrencies.Starter.ViewModels
{
    public class GetPostByHighestVisitorsQuery
    {
        public GetPostByHighestVisitorsQuery(bool includeData)
        {
            this.IncludeData = includeData;
        }
        public bool IncludeData { get; set; }
    }
}
