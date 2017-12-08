﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.Transactions.Starter.Queries
{
    public class GetPostByTitleQuery
    {
        public GetPostByTitleQuery(string title, bool includeData)
        {
            this.Title = title;
            this.IncludeData = includeData;
        }

        public string Title { get; set; }
        public bool IncludeData { get; set; }
    }
}
