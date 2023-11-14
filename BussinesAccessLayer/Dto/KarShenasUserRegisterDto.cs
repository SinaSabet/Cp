using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Dtos
{
    public class GetAllKarShenasUserDto
    {
        public string FullName { get; set; }
        public string Name { get; set; }
        public string KarShenasiOption { get; set; }
        public string Address { get; set; }
        public string TehranLocation { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class KarShenasUserRegisterDto
    {
        public string FullName { get; set; }
        public string Name { get; set; }
        public string KarShenasiOption { get; set; }
        public string Address { get; set; }
        public string TehranLocation { get; set; }
        public string PhoneNumber { get; set; }
        public string lat { get; set; }
        public string Lng { get; set; }
    }
    public class KarShenasiRequestDetail
    {
        public int LocationId { get; set; }
        public int KarShenasiOptionId { get; set; }
    }
    public class KarShenas
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string KarShenasiOption { get; set; }
        public string Address { get; set; }
        public string TehranLocation { get; set; }
        public string PhoneNumber { get; set; }

    }
}
