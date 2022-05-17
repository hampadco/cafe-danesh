using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ViewModels.Area.Questions
{
    public class Vm_Questions
    {
        public string Id { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public string Answer { get; set; }
        public int ProductId { get; set; }
        public string State { get; set; }
        public string color { get; set; }
        
        
    }
}