#pragma checksum "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be4a5909c754d20fdd454b1a7f27d37696374fd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_calender), @"mvc.1.0.view", @"/Views/Home/calender.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\_ViewImports.cshtml"
using pransa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\_ViewImports.cshtml"
using pransa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be4a5909c754d20fdd454b1a7f27d37696374fd9", @"/Views/Home/calender.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20036d9652529551c055619970abddeed186726", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_calender : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.AdminViewModel.Calender.MCalender>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>\r\n");
            WriteLiteral(@"</style>
   
   
</style>

<div class=""mt-3 card"">


    <div class=""container"">

        <div class=""row justify-content-center"" style=""border:1px solid black;border-radius: 7px; padding: 5px;"">



            
                <h2 class=""form-control text-center card p"" style=""margin-top: 40px; white-space: normal;background-color:lightblue;"">

                   
                    ");
#nullable restore
#line 27 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h2>\r\n                <hr>\r\n           \r\n\r\n   <div class=\"row m \" style=\"padding-bottom: 70px;\">\r\n         <div class=\"col-12 card \">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 770, "\"", 800, 2);
            WriteAttributeValue("", 776, "/fileupload/", 776, 12, true);
#nullable restore
#line 34 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
WriteAttributeValue("", 788, Model.Baner, 788, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 801, "\"", 807, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 100%;border-radius: 15px;\"");
            BeginWriteAttribute("srcset", " srcset=\"", 849, "\"", 858, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>

            <div class=""col-12 "">

                <div class=""row justify-content-start "">

                    <div class=""col-12  mt-3 text-center card p  "" >
                       
                        <b class=""text-dark"">");
#nullable restore
#line 43 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                                        Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                       \r\n\r\n\r\n                    </div>\r\n\r\n\r\n                     <div class=\"col-12 text-left mt-3 text-center card p\">\r\n                        <b class=\"mamo\">زمان:</b>\r\n                        <b class=\"text-dark\">");
#nullable restore
#line 52 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                                        Write(Model.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 52 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                                                     Write(Model.Years);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                       \r\n\r\n\r\n                    </div>\r\n\r\n                    <div class=\"col-12 text-left mt-3  text-center card p\">\r\n                        <b class=\"mamo\">تاریخ تحویل سالن:</b>\r\n                        <b class=\"text-dark\">");
#nullable restore
#line 60 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                                        Write(Model.DataReceive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                       \r\n\r\n\r\n                    </div>\r\n                    <div class=\"col-12 text-left mt-3  text-center card p\">\r\n                        <b class=\"mamo\">تاریخ و تخریب غرفه:</b>\r\n                        <b class=\"text-dark\">");
#nullable restore
#line 67 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                                        Write(Model.DateDestruction);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                       \r\n\r\n\r\n                    </div>\r\n\r\n                    \r\n                <div class=\"col-12 mt-3 text-center card p\">\r\n                    <b class=\"mamo\">سال برگزاری:</b>\r\n                    <b> ");
#nullable restore
#line 76 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                   Write(Model.Years);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </div>\r\n\r\n                <div class=\"col-12 mt-3 text-center card p\">\r\n                    <b class=\"mamo\">روز شروع:</b>\r\n                    <b>");
#nullable restore
#line 81 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                  Write(Model.StartingDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 81 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                                      Write(Model.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-12 mt-3 text-center card p\">\r\n                    <b class=\"mamo\">روز پایان :</b>\r\n                    <b>");
#nullable restore
#line 87 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                  Write(Model.EndDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 87 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                                 Write(Model.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </div>\r\n\r\n\r\n                 <div class=\"col-12 mt-3 text-center card p \">\r\n                    <b class=\"mamo\">شهر نمایشگاه:</b>\r\n                    <b>");
#nullable restore
#line 93 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                  Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </div>\r\n\r\n                 <div class=\"col-12 mt-3 text-center card p  \">\r\n                    <b class=\"mamo\">محل نمایشگاه:</b>\r\n                    <b>");
#nullable restore
#line 98 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                  Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </div>\r\n\r\n                 <div class=\"col-12 mt-3 text-center card p \">\r\n                    <b class=\"mamo\">تاریخ تحویل سالن جهت غرفه سازی:</b>\r\n                    <b>");
#nullable restore
#line 103 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                  Write(Model.DataReceive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </div>\r\n\r\n\r\n                 <div class=\"col-12 mt-3 text-center card p \">\r\n                    <b class=\"mamo\">تاریخ تخریب غرفه:</b>\r\n                    <b>");
#nullable restore
#line 109 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                  Write(Model.DateDestruction);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </div>\r\n\r\n                 <div class=\"col-12 mt-3 text-center card p \">\r\n                    <b class=\"mamo\">زمان بازگشایی نمایشگاه:</b>\r\n                    <b>");
#nullable restore
#line 114 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                  Write(Model.TimeReceive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </div>\r\n\r\n\r\n                 <div class=\"col-12 mt-3  text-center card p\">\r\n                    <b class=\"mamo\">زمان بسته شدن نمایشگاه :</b>\r\n                    <b>");
#nullable restore
#line 120 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                  Write(Model.TimeDestruction);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </div>\r\n\r\n\r\n                 <div class=\"col-12 mt-3 text-center card p \">\r\n                    <b class=\"mamo\">مجری :</b>\r\n                    <b>");
#nullable restore
#line 126 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                  Write(Model.executing);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </div>\r\n\r\n\r\n                 <div class=\"col-12 mt-3 text-center card p \">\r\n                    <b class=\"mamo\">شماره تلفن ثابت اول :</b>\r\n                    <b>");
#nullable restore
#line 132 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                  Write(Model.Tel1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </div>\r\n\r\n\r\n                 <div class=\"col-12 mt-3 text-center card p \">\r\n                    <b class=\"mamo\">شماره تماس دوم :</b>\r\n                    <b>");
#nullable restore
#line 138 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                  Write(Model.Tel2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </div>\r\n\r\n\r\n                 <div class=\"col-12 mt-3 text-center card p  \">\r\n                    <b class=\"mamo\">ناظر نمایشگاه:</b>\r\n                    <b>");
#nullable restore
#line 144 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                  Write(Model.Supervisor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </div>\r\n\r\n                <div class=\"col-12 mt-3  text-center card p\">\r\n                    <b class=\"mamo\">تلفن ناظر:</b>\r\n                    <b>");
#nullable restore
#line 149 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                  Write(Model.SupervisorTel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </div>\r\n\r\n                 <div class=\"col-12 mt-3  text-center card p\">\r\n                    <b class=\"mamo\">وب سایت :</b>\r\n                    <b>");
#nullable restore
#line 154 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\calender.cshtml"
                  Write(Model.WebSite);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
                </div>

                   

                  
                    
                    

                   





                </div>


            </div>

   </div>
          


           






            </div>


        </div>


    </div>




</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModels.AdminViewModel.Calender.MCalender> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
