using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlaner.Domain.Entites
{
    public class User
    {
        public required int UserId { get; set; }
        public string FirstName { get; set; } = default;
        public string LastName { get; set; } = default;
        public string Email { get; set; } = default;
        public string Password { get; set; } = default;

    }
}
