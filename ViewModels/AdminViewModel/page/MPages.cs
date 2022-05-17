using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using Microsoft.AspNetCore.Http;

namespace ViewModel.AdminViewModel.Page
{
    public class MPages
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string MainCat{ get; set; }
        public string SubCat { get; set; }
        public string MainImage { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Citys { get; set; }
        public string TypeSend { get; set; }
        public string TypePay { get; set; }
        public string LocationPay{ get; set; }
        public string description{ get; set; }
        public IFormFile MainImagef { get; set; }
        public IFormFile Image1f { get; set; }
        public IFormFile Image2f { get; set; }
        public IFormFile Image3f { get; set; }
        public IFormFile Image4f { get; set; }

        
    }
}
