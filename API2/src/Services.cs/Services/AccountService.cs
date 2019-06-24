using Contracts.DTO;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessContracts.Interface.Identity;
using Contracts.Interface.Service;

namespace Services.Services
{
    public class AccountService : IAccountService
    {
        private IAuthRepository _authRepository;

        public AccountService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public IdentityUser FindUser(string userName, string password)
        {
            return _authRepository.FindUser(userName, password);
        }
    }
}
