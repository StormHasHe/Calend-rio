using Contracts.DTO;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface.Service
{
    public interface IAccountService
    {
        IdentityUser FindUser(string userName, string password);
    }
}
