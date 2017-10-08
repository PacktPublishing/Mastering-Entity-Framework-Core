﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.QueryObjectPattern.Final.Queries
{
    public class GetPostByPublishedYearQuery
    {
        public GetPostByPublishedYearQuery(int year, bool includeData)
        {
            this.Year = year;
            this.IncludeData = includeData;
        }

        public int Year { get; set; }
        public bool IncludeData { get; set; }
    }
}
