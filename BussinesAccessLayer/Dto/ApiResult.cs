using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesAccessLayer.Dto
{
    public class ApiResult<T>
    {

        public T Result { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }


    }
}
