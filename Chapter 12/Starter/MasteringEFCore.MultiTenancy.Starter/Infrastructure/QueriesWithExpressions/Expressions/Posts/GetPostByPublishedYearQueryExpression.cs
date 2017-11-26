﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MasteringEFCore.MultiTenancy.Starter.Data;
using MasteringEFCore.MultiTenancy.Starter.Core.Queries.Posts;
using MasteringEFCore.MultiTenancy.Starter.Core.Queries;
using MasteringEFCore.MultiTenancy.Starter.Models;
using Microsoft.EntityFrameworkCore;

namespace MasteringEFCore.MultiTenancy.Starter.Infrastructure.QueriesWithExpressions.Expressions.Posts
{
    public class GetPostByPublishedYearQueryExpression : IQueryExpression<Post>
    {
        public int Year { get; set; }

        public Expression<Func<Post, bool>> AsExpression()
        {
            return (x => x.PublishedDateTime.Year.Equals(Year));
        }
    }
}
