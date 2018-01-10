using MamidiDating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamidiDating.DAL
{
    public interface ILoginDAL
    {
        bool RegisterUser(LoginViewModel login);
        LoginViewModel GetUsername(string username);
    }
}
