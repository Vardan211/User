using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskVardan.Domain.Models
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Token { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
    }
}
