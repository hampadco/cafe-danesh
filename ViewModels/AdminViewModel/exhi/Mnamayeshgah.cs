using System;
using System.ComponentModel.DataAnnotations;

namespace ViewModels.AdminViewModel.exhi {
    public class Mnamayeshgah {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int cityId { get; set; }



    }

}