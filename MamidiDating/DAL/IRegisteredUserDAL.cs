using MamidiDating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamidiDating.DAL
{
    public interface IRegisteredUserDAL
    {
        bool RegisterNewUser(RegisteredUserViewModel newUser);
        RegisteredUserViewModel GetUser(string username);
        RegisteredUserViewModel GetUser(string username, string password);
        bool AddRegisteredUserInfo(NewUserViewModel userInfo);
    }
}
