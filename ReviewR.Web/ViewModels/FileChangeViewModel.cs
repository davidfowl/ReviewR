﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReviewR.Web.Models;

namespace ReviewR.Web.ViewModels
{
    public class FileChangeViewModel
    {
        public int Id { get; set; }
        public FileChangeType ChangeType { get; set; }
        public string FileName { get; set; }
    }
}
