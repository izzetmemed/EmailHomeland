using System;
using System.Collections.Generic;

namespace Email.MyModel.Models
{
    public partial class Metro
    {
        public int Id { get; set; }
        public int MetroForeignId { get; set; }
        public string MetroName { get; set; } = null!;

        public virtual MediaType MetroForeign { get; set; } = null!;
    }
}
