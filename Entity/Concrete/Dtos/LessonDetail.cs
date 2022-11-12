﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class LessonDetail:IDto
    {
        [Required]
        public int LessonId { get; set; }
        [Required]
        public string LessonName { get; set; }
    }
}
