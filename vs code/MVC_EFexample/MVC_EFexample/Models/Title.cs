﻿using System;
using System.Collections.Generic;

namespace MVC_EFexample.Models
{
    public partial class Title
    {
        public int? Workrefid { get; set; }
        public string? Title1 { get; set; }
        public DateTime? Affectedfrom { get; set; }

        public virtual Worker? Workref { get; set; }
    }
}
