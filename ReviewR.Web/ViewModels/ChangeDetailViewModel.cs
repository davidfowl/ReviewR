﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReviewR.Web.ViewModels
{
    public class ChangeDetailViewModel
    {
        public ReviewDetailViewModel Review { get; set; }
        public DiffFileViewModel Diff { get; set; }
    }
}
