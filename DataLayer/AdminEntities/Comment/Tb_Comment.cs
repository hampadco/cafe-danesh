using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.AdminEntities.Comment {
    public class Tb_Comment {
        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public int product_id { get; set; }
        public string Answer { get; set; }
        public bool State { get; set; }
        public string Language { get; set; }

    }

}