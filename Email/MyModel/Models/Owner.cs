using System;
using System.Collections.Generic;

namespace Email.MyModel.Models
{
    public partial class Owner
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public int? ForeignId { get; set; }
        public string? Fullname { get; set; }
        public string? Number { get; set; }
        public string? Kind { get; set; }
    }
}
