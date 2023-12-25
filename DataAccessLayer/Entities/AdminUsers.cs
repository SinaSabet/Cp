using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class AdminUsers
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Mobile { get; set; }

        public string? SecurityKey { get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsActive { get; set; }
    }
}
