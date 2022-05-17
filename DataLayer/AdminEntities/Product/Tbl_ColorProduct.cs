using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.AdminEntities.Product
{
    public class Tbl_ColorProduct
    {
        [Key]
        public int Id { get; set; }
        public string ColorName { get; set; }
        public int IdProduct { get; set; }
    }
}