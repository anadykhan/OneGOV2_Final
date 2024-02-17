﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class CommentDTO
    {
        public int Id { get; set; }
        [Required]
        public string CommentText { get; set; }
        [Required]
        public DateTime Time { get; set; }

        public string CommentedBy { get; set; }

        public int BlogId { get; set; }

    }
}
