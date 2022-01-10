using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskVardan.DataAccess;

namespace TaskVardan.Domain
{
    public interface IJwtGenerator
    {
        string CreateToken(ApplicationUser user, List<string> roles);
    }
}
