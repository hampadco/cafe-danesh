using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.AdminEntities.Experts {
    public class Tb_city {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


    }

}