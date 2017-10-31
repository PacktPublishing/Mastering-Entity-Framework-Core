﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasteringEFCore.Concurrencies.Final.Data;
using MasteringEFCore.Concurrencies.Final.Models;
using System.Linq.Expressions;
using MasteringEFCore.Concurrencies.Final.Core.Queries.Posts;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.EntityFrameworkCore;

namespace MasteringEFCore.Concurrencies.Final.Infrastructure.QueriesWithExpressions.Expressions.Posts
{
    public class GetPaginatedPostByKeywordQueryExpression : IQueryExpression<Post>
    {
        public string Keyword { get; set; }

        public Expression<Func<Post, bool>> AsExpression()
        {
            return (x => x.Title.ToLower().Contains(Keyword.ToLower())
                                                                || x.Blog.Title.ToLower().Contains(Keyword.ToLower())
                    || x.Blog.Subtitle.ToLower().Contains(Keyword.ToLower())
                    || x.Category.Name.ToLower().Contains(Keyword.ToLower())
                    || x.Content.ToLower().Contains(Keyword.ToLower())
                    || x.Summary.ToLower().Contains(Keyword.ToLower())
                    || x.Author.Username.ToLower().Contains(Keyword.ToLower())
                    || x.Url.ToLower().Contains(Keyword.ToLower()));
        }
    }
}
