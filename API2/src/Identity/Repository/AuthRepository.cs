
using Identity.Context;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessContracts.Interface.Identity;
using Contracts.DTO;
using Exceptions.BusinessExceptions;

namespace Identity.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private AuthenticationContext _ctx;

        public AuthRepository(AuthenticationContext ctx)
        {
            _ctx = ctx;
        }

        public IdentityUser FindUser(string userName, string password)
        {
            var user = _ctx.Employee.Where(x => x.txtLogin == userName && x.txtPassword == password).FirstOrDefault();

            if (user == null)
                throw new WrongLoginOrPasswordException();

            var identityUser = new IdentityUser();
            identityUser.UserName = userName;

            return identityUser;
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
