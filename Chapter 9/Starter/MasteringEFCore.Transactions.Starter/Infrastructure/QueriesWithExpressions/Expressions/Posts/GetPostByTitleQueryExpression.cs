﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MasteringEFCore.Transactions.Starter.Data;
using MasteringEFCore.Transactions.Starter.Core.Queries.Posts;
using MasteringEFCore.Transactions.Starter.Core.Queries;
using MasteringEFCore.Transactions.Starter.Models;
using Microsoft.EntityFrameworkCore;

namespace MasteringEFCore.Transactions.Starter.Infrastructure.QueriesWithExpressions.Expressions.Posts
{
    public class GetPostByTitleQueryExpression : IQueryExpression<Post>
    {
        public string Title { get ; set ; }

        public Expression<Func<Post, bool>> AsExpression()
        {
            return (x => x.Title.ToLower().Contains(Title.ToLower()));
        }
    }
}
