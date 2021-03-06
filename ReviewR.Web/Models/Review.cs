﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewR.Web.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }

        public virtual User Creator { get; set; }
        public virtual ICollection<FileChange> Files { get; set; }
    }
}