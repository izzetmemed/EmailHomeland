﻿using System;
using System.Collections.Generic;

namespace Email.MyModel.Models
{
    public partial class CustomerEmail
    {
        public int Id { get; set; }
        public string? Fullname { get; set; }
        public string? Number { get; set; }
        public string? Email { get; set; }
    }
}
