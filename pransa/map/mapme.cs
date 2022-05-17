using AutoMapper;
using ViewModels.AdminViewModel.Users;
using DataLayer.AdminEntities.Users;
using DataLayer.AdminEntities.Page;
using ViewModel.AdminViewModel.Page;
using DataLayer.AdminEntities.Calender;
using ViewModels.AdminViewModel.Calender;
using Extensions;
using pransa.Areas.Admin.Controllers;
using DataLayer.AdminEntities.Product;
using ViewModels.AdminViewModel.Product;
using DataLayer.AdminEntities.Blog;
using ViewModels.AdminViewModel.Blog;

public class mapme:Profile
{
    public mapme()
    {
         
        CreateMap<Tb_User,Vm_User>().ReverseMap();
         CreateMap<Tb_Blog,Vm_Blog>().ReverseMap();
        CreateMap<Tb_Product,Vm_Product>().ReverseMap();
        CreateMap<Tb_Product,Vm_Product>().ReverseMap();
        CreateMap<Tbl_Calender,MCalender>()
          .ForMember(a=>a.DataReceive,b=>b.MapFrom(c=>c.DataReceive.ToPersianDateString()))
           .ForMember(a=>a.DateDestruction,b=>b.MapFrom(c=>c.DateDestruction.ToPersianDateString()));

        CreateMap<MCalender, Tbl_Calender>()
        .ForMember(a => a.DataReceive, b => b.MapFrom(c => c.DataReceive.ToGeorgianDateTime()))
         .ForMember(a => a.DateDestruction, b => b.MapFrom(c => c.DateDestruction.ToGeorgianDateTime()));




    }
}