﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasteringEFCore.MultiTenancy.Starter.Data;
using MasteringEFCore.MultiTenancy.Starter.Core.Queries.Posts;
using MasteringEFCore.MultiTenancy.Starter.Core.Queries;
using MasteringEFCore.MultiTenancy.Starter.Models;
using Microsoft.EntityFrameworkCore;

namespace MasteringEFCore.MultiTenancy.Starter.Infrastructure.Queries.Posts
{
    public class GetPostByHighestVisitorsQuery : QueryBase, IGetPostByHighestVisitorsQuery<GetPostByHighestVisitorsQuery>
    {
        public GetPostByHighestVisitorsQuery(BlogContext context) : base(context)
        {
        }

        public bool IncludeData { get; set; }

        public IEnumerable<Post> Handle()
        {
            return IncludeData
                        ? Context.Posts
                            .OrderByDescending(x => x.VisitorCount)
                            .Include(p => p.Author).Include(p => p.Blog).Include(p => p.Category)
                            .ToList()
                        : Context.Posts
                            .OrderByDescending(x => x.VisitorCount)
                            .ToList();
        }

        public async Task<IEnumerable<Post>> HandleAsync()
        {
            return IncludeData
                        ? await Context.Posts
                            .OrderByDescending(x => x.VisitorCount)
                            .Include(p => p.Author).Include(p => p.Blog).Include(p => p.Category)
                            .ToListAsync()
                        : await Context.Posts
                            .OrderByDescending(x => x.VisitorCount)
                            .ToListAsync();
        }
    }
}
