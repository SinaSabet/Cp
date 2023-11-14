using BussinesAccessLayer.Dto.LogInAndRegisterDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesAccessLayer.Interface.ISiteService
{
   public interface IAuthService
    {
        bool LoginStepOne(LoginAndSignIn loginAndSignIn, out string Message);
        bool ActivationUser(ActivationCode activationCode, string Phone, out string Message);
    }
}
