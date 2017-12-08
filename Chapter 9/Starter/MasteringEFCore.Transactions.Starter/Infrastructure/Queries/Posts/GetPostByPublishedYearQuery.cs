﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasteringEFCore.Transactions.Starter.Data;
using MasteringEFCore.Transactions.Starter.Core.Queries.Posts;
using MasteringEFCore.Transactions.Starter.Core.Queries;
using MasteringEFCore.Transactions.Starter.Models;
using Microsoft.EntityFrameworkCore;

namespace MasteringEFCore.Transactions.Starter.Infrastructure.Queries.Posts
{
    public class GetPostByPublishedYearQuery : QueryBase, IGetPostByPublishedYearQuery<GetPostByPublishedYearQuery>
    {
        public GetPostByPublishedYearQuery(BlogContext context) : base(context)
        {
        }

        public int Year { get; set; }
        public bool IncludeData { get; set; }

        public IEnumerable<Post> Handle()
        {
            return IncludeData
                        ? Context.Posts
                            .Where(x => x.PublishedDateTime.Year.Equals(Year))
                            .Include(p => p.Author).Include(p => p.Blog).Include(p => p.Category)
                            .ToList()
                        : Context.Posts
                            .Where(x => x.PublishedDateTime.Year.Equals(Year))
                            .ToList();
        }

        public async Task<IEnumerable<Post>> HandleAsync()
        {
            return IncludeData
                        ? await Context.Posts
                            .Where(x => x.PublishedDateTime.Year.Equals(Year))
                            .Include(p => p.Author).Include(p => p.Blog).Include(p => p.Category)
                            .ToListAsync()
                        : await Context.Posts
                            .Where(x => x.PublishedDateTime.Year.Equals(Year))
                            .ToListAsync();
        }
    }
}
