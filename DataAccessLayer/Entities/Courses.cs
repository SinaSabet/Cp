﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Courses:BaseEntity
    {
        public string? CourseName { get; set; }
        public string? PicturePath { get; set; }
        public string? Phone { get; set; }
        public string? Description { get; set; }
    }
}
