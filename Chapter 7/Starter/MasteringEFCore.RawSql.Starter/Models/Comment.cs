﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MasteringEFCore.RawSql.Starter.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; }
        public DateTime CommentedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        [Required(ErrorMessage = "Post is required")]
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int? PersonId { get; set; }
        public Person Person { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}