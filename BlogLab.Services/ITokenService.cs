using System;
using System.Collections.Generic;
using System.Text;
using BlogLab.Models.Account;

namespace BlogLab.Services
{
    public interface ITokenService
    {
        public string CreateToken(ApplicationUserIdentity user);
    }
}
