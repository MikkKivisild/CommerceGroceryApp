﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommerceGroceryApp.Api.Properties.Data.Entities
{
    [Table(nameof(Category))]
    public class Category
    {
        [Key]
        public short Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        [Required, MaxLength(20)]
        public string Image { get; set; }
        public short ParentId { get; set; }
        [MaxLength(150)]
        public string? Credit { get; set; }

        public bool IsMainCategory => ParentId == 0;
    }
}

