using System;
using System.ComponentModel.DataAnnotations;

namespace ViewModels.AdminViewModel.exhi
 {
    public class MTNamayeshgah {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int NamayeshgahId { get; set; }



    }

}