using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace DataLayer.AdminEntities.Users
{
    public class Tb_User
    {
        [Key]
        public int Id { get; set; }

        public string UserNameUs { get; set; }

        public string EmailUS { get; set; }

        public string PhoneUs { get; set; }

        public string PasswordUs { get; set; }

        public string AddressUs { get; set; }

        public string Post { get; set; }

        public string ProfileImageUs { get; set; }

        public string Language { get; set; }

        public string Token { get; set; }

        public string NationalCode { get; set; }

        public string UserFamilyUs { get; set; }

        public string typework { get; set; }

        //    new
        public string NameCompany { get; set; }

        public string Tel { get; set; }

        public string Ostan { get; set; }

        public string City { get; set; }

        public string Website { get; set; }

        public string Instagram { get; set; }

        public string Telegram { get; set; }

        public string WhatsApp { get; set; }

        public string Shoar { get; set; }

        public string CoverImage { get; set; }
    }
}
