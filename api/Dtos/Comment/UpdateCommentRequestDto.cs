using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be at least 5 characters long.")]
        [MaxLength(100, ErrorMessage = "Title must be at most 100 characters long.")]
        public string Title { get; set; } = string.Empty;
        
        [Required]
        [MinLength(10, ErrorMessage = "Content must be at least 10 characters long.")]
        [MaxLength(500, ErrorMessage = "Content must be at most 500 characters long.")]
        public string Content { get; set; } = string.Empty;
    }
}