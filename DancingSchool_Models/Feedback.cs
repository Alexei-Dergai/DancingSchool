﻿using System.ComponentModel.DataAnnotations;

namespace DancingSchool_Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
