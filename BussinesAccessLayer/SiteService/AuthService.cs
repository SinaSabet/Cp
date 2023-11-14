using BussinesAccessLayer.Dto.LogInAndRegisterDto;
using BussinesAccessLayer.Interface.ISiteService;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositoreis.UserRepository;

namespace BussinesAccessLayer.SiteService
{
    public class AuthService : IAuthService
    {
        private IUserRepo _userrepo;
        private Random Random;
        public AuthService(IUserRepo userRepo, Random random)
        {
            Random = random;
            _userrepo = userRepo;
        }

        public bool ActivationUser(ActivationCode activationCode, string Phone, out string Message)
        {
            var user = _userrepo.GetList().Result.FirstOrDefault(x => x.Mobile == Phone);

            if (user.SecurityKey == activationCode.Code)
            {
                user.IsActive = true;
                _userrepo.Attach(user);
                Message = "موفق";
                return true;
            }
            else
            {
                Message = "کد مورد نظر همخوانی ندارد.";
                return false;
            }

        }

        public bool LoginStepOne(LoginAndSignIn loginAndSignIn, out string Message)
        {
            var Exiset = _userrepo.GetList().Result.FirstOrDefault(x => x.Mobile == loginAndSignIn.PhoneNumber);
            if (Exiset == null)
            {
                int SecurityKey = Random.Next(10000, 99999);
                User users = new User()
                {
                    Mobile = loginAndSignIn.PhoneNumber,
                    CreatedAt = DateTime.Now,
                    IsActive = false,
                    SecurityKey = SecurityKey.ToString(),


                };
                _userrepo.Insert(users);
                Message = "موفق";
                return true;
            }
            else
            {
                int SecurityKey = Random.Next(10000, 99999);
                Exiset.Mobile = loginAndSignIn.PhoneNumber;
                Exiset.SecurityKey = SecurityKey.ToString();
                _userrepo.Attach(Exiset);


                Message = "موفق";

                return true;



            }
        }
    }
}
