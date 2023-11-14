using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesAccessLayer.Dto.ExhibitionAccountRegisterDto
{
  public  class ExhibitionAccountRegister
    {
        public string FullName { get; set; }
        public string Name { get; set; }
        public IFormFile Files { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public int LocationId { get; set; }
        public string lat { get; set; }
        public string Lng { get; set; }
        public bool SendSms { get; set; }
    }
    public class EditAccount
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public IFormFile ExhibitionPicture { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public int LocationId { get; set; }
        public string lat { get; set; }
        public string Lng { get; set; }
        public bool SendSms { get; set; }

    }
}
