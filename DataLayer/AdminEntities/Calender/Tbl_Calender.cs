using System;
using System.ComponentModel.DataAnnotations;
namespace DataLayer.AdminEntities.Calender
{
    public class Tbl_Calender
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Years { get; set; }
        public string Month { get; set; }
        public int StartingDay { get; set; }
        public int EndDay { get; set; }
        public string City { get; set; }
        public string Baner { get; set; }
        public DateTime  DataReceive { get; set; }
        public DateTime  DateDestruction { get; set; }
        public int TimeReceive { get; set; }
        public int TimeDestruction { get; set; }
        public string executing { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Supervisor { get; set; }
        public string SupervisorTel { get; set; }
        public string WebSite { get; set; }
        public string Location { get; set; }
    }
}