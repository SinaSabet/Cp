using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesAccessLayer.Dto.LogInAndRegisterDto
{
    public class LoginAndSignIn
    {
        [Display(Name = "شماره موبایل")]
        [MaxLength(11, ErrorMessage = "شماره موبایل باید 11 رقم باشد")]
        [Required(ErrorMessage = "شماره موبایل خود را وارد نمایید.")]
        [RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "شماره موبایل وارد شده صحیح نمی باشد")]
        public string PhoneNumber { get; set; }
    }
    public class ActivationCode
    {
        [Display(Name = "کدفعالسازی")]
        [Required(ErrorMessage = "لطفا کد فعالسازی را وارد کنید.")]

        public string Code { get; set; }
    }
}
