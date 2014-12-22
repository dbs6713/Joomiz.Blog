﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Joomiz.Blog.WebApplication.ViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        public List<CommentViewModel> Comments { get; set; }
    }
}