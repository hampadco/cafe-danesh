#pragma checksum "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\selectcat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f383ceb8bffd0290e0d7ed2a3300c2bd90f473c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_selectcat), @"mvc.1.0.view", @"/Views/Home/selectcat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f383ceb8bffd0290e0d7ed2a3300c2bd90f473c", @"/Views/Home/selectcat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20036d9652529551c055619970abddeed186726", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_selectcat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" <div class=\"page-content-wrapper card\">\r\n      <div class=\"container card\">\r\n        <div class=\"pt-3\">\r\n\r\n");
            WriteLiteral("\r\n            <div id=\"khadamat\" >\r\n\r\n                                                                <p class=\"form-control text-center\" style=\"background-color: whitesmoke;\">انتخاب  زیر دسته </p>\r\n");
#nullable restore
#line 10 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\selectcat.cshtml"
                                                                 if (@ViewBag.slist != null)
                                                                {
                                                                  int c;

                                                                  

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\selectcat.cshtml"
                                                                   foreach (var item in @ViewBag.slist)
                                                                  {
                                                                    c=0;
                                                                      

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\selectcat.cshtml"
                                                                       foreach (var item1 in menu.cat)
                                                                      {
                                                                        if (item.Id==item1.FatherIdCat)
                                                                        {
                                                                           c++;
                                                                        }
                                                                       
                                                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\selectcat.cshtml"
                                                                         if (c != 0)
                                                                        {
                                                                          

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                              <a class=\"form-control \"  style=\"margin-top: 10px;\"");
            BeginWriteAttribute("href", "  href=\"", 1899, "\"", 1931, 2);
            WriteAttributeValue("", 1907, "/home/selectcat/", 1907, 16, true);
#nullable restore
#line 28 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\selectcat.cshtml"
WriteAttributeValue("", 1923, item.Id, 1923, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                              <i class=\"w-icon-category\"></i>\r\n                                                                              ");
#nullable restore
#line 30 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\selectcat.cshtml"
                                                                         Write(item.NameCat);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   \t\r\n                                                                              \r\n                                                                              </a>\r\n");
#nullable restore
#line 33 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\selectcat.cshtml"
                                                                            
                                                                          
                                                                        }else
                                                                        {
                                                                          

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                            <a class=\"form-control \"  style=\"margin-top: 10px;\"");
            BeginWriteAttribute("href", "  href=\"", 2850, "\"", 2881, 2);
            WriteAttributeValue("", 2858, "/home/category/", 2858, 15, true);
#nullable restore
#line 38 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\selectcat.cshtml"
WriteAttributeValue("", 2873, item.Id, 2873, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                            <i class=\"w-icon-category\"></i>\r\n                                                                            ");
#nullable restore
#line 40 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\selectcat.cshtml"
                                                                       Write(item.NameCat);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   \t\r\n                                                                            \r\n                                                                            </a>\r\n");
#nullable restore
#line 43 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\selectcat.cshtml"
                                                                        
                                                                        
                                                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\selectcat.cshtml"
                                                                       
                                                                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\selectcat.cshtml"
                                                                   
                                                                    
                                                                }
                                                                else
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                  <p class=\"alert alert-danger mt-7\">زیر مجموعه ای برای این دسته وجود ندارد </p>\r\n");
#nullable restore
#line 52 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Home\selectcat.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                           
                                            
                                       
<a class=""form-control text-center"" onclick=""history.back()"" style=""margin-top: 10px;background-color: whitesmoke;"">بازگشت</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
