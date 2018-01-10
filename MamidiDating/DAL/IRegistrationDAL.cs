using MamidiDating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamidiDating.DAL
{
    public interface IRegistrationDAL
    {
        bool AddRegistrationInfo(RegistrationViewModel registration);
        RegistrationViewModel GetRegistrationInformationById(int registrationId);
    }
}
