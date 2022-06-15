using System;
using System.Collections.Generic;

namespace FirstWebApplication.DB
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
