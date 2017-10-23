﻿using MasteringEFCore.Transactions.Final.Core.Commands.Posts;
using MasteringEFCore.Transactions.Final.Data;
using MasteringEFCore.Transactions.Final.Helpers;
using MasteringEFCore.Transactions.Final.Infrastructure.Commands.Files;
using MasteringEFCore.Transactions.Final.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace MasteringEFCore.Transactions.Final.Infrastructure.Commands.Posts
{
    public class DeletePostCommand : CommandBase, ICreatePostCommand<int>
    {
        public DeletePostCommand(BlogContext context) : base(context)
        {
        }

        public int Id { get; set; }
        public Guid FileId { get; set; }
        public ICollection<int> TagIds { get; set; }

        public int Handle()
        {
            int returnValue = 0;
            try
            {
                DeletePost();
                returnValue = Context.SaveChanges();

                DeleteTag();
                returnValue = Context.SaveChanges();
            }
            catch (Exception exception)
            {
                ExceptionDispatchInfo.Capture(exception.InnerException).Throw();
            }

            return returnValue;
        }

        public async Task<int> HandleAsync()
        {
            int returnValue = 0;
            try
            {
                DeletePost();
                returnValue = await Context.SaveChangesAsync();

                DeleteTag();
                returnValue = await Context.SaveChangesAsync();
            }
            catch (Exception exception)
            {
                ExceptionDispatchInfo.Capture(exception.InnerException).Throw();
            }

            return returnValue;
        }

        private void DeletePost()
        {
            var post = Context.Posts.SingleOrDefault(m => m.Id == Id);
            Context.Posts.Remove(post);
        }

        private void DeleteTag()
        {
            var tagPostsToBeDeleted = Context.TagPosts.Where(x => x.PostId.Equals(Id));
            Context.RemoveRange(tagPostsToBeDeleted);
        }
    }
}
