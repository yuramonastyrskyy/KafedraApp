using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.IServices
{
    public interface IRequestIdentityService
    {
        bool CheckIdentity(string hashedToken, string id);
        bool CheckIdentity(string hashFromRequest, string hashedToken, string[] roles, out string id);
    }
}
