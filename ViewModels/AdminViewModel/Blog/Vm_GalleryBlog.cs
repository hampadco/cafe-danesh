using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace ViewModels.AdminViewModel.Blog {
    public class Vm_GalleryBlog {
        [Key]
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public string ImagePath { get; set; }
        public string Language { get; set; }

    }

}