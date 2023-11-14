using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using BussinesAccessLayer.Dto.LogInAndRegisterDto;
using BussinesAccessLayer.Dto;
using BussinesAccessLayer.Interface.ISiteService;

namespace ZabanCp.Controllers
{
    public class AuthController : Controller
    {
        private IAuthService _userRepo;
        public AuthController(IAuthService userRepo)
        {
            _userRepo = userRepo;
        }
        [HttpPost]
        public JsonResult CreateNumber(string phonenumber)
        {
            string message;
            LoginAndSignIn loginAndSign = new LoginAndSignIn()
            {
                PhoneNumber = phonenumber
            };

            var ApiCinemaOwnerData = _userRepo.LoginStepOne(loginAndSign, out message);
            if (message == "موفق")
            {
                var Response = new ApiResult<bool>()
                {
                    Result = ApiCinemaOwnerData,
                    Success = true,
                    Message = message
                };
                ViewBag.Phone = phonenumber;
                var claims = new List<Claim>()
                     {
                     new Claim(ClaimTypes.Name,phonenumber),
                      new Claim(ClaimTypes.NameIdentifier ,phonenumber),

                     };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var properties = new AuthenticationProperties()
                {
                    IsPersistent = true
                };


                HttpContext.SignInAsync(principal, properties);
                ViewBag.Message = message;
                return Json(message);
            }
            else
            {
                var Response = new ApiResult<string>()
                {
                    Result = "",
                    Success = true,
                    Message = message
                };
                return Json(message);

            }



        }
    }
}
