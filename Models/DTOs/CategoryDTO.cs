﻿using System.ComponentModel.DataAnnotations;

namespace CourseNest.Models.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string CategoryName { get; set; }
    }
}
