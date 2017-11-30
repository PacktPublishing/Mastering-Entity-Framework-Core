﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.MultiTenancy.Final.Models
{
    public class Person
    {
        public int Id { get; set; }
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabets were allowed")]
        public string FirstName { get; set; }
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabets were allowed")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Nickname is required")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabets were allowed")]
        public string NickName { get; set; }
        [Url(ErrorMessage = "Provide a valid url")]
        public string Url { get; set; }
        public string Biography { get; set; }
        [Url(ErrorMessage = "Provide a valid url")]
        public string ImageUrl { get; set; }
        [Phone(ErrorMessage = "Provide a valid phone number")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(12)]
        public string PhoneNumber { get; set; }
        public DateTime? CreatedAt { get; set; }
        //[ConcurrencyCheck]
        public DateTime? ModifiedAt { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }
        public Guid? TenantId { get; set; }
        public Tenant Tenant { get; set; }
        [JsonIgnore]
        public virtual ICollection<Comment> Comments { get; set; }
        //[Timestamp]
        //public byte[] Timestamp { get; set; }
    }
}
