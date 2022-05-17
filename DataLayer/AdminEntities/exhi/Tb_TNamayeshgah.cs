using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.AdminEntities.Experts {
    public class Tb_TNamayeshgah {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int NamayeshgahId { get; set; }



    }

}