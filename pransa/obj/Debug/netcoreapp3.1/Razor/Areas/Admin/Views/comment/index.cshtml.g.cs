#pragma checksum "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\comment\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "529dabe0f718853aaf19e5ea093ded82679eddd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_comment_index), @"mvc.1.0.view", @"/Areas/Admin/Views/comment/index.cshtml")]
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
#line 1 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\_ViewImports.cshtml"
using pransa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\_ViewImports.cshtml"
using pransa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"529dabe0f718853aaf19e5ea093ded82679eddd8", @"/Areas/Admin/Views/comment/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20036d9652529551c055619970abddeed186726", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_comment_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n    <!-- BEGIN: Content-->\n<section id=\"data-list-view\" class=\"data-list-view-header\">\n");
#nullable restore
#line 5 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\comment\index.cshtml"
   if (ViewBag.suc != null)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <span class=\"alert alert-success\">");
#nullable restore
#line 7 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\comment\index.cshtml"
                                   Write(ViewBag.suc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 8 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\comment\index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
  <!-- DataTable starts -->
  <div class=""table-responsive"">
    <table class=""table data-list-view"">
      <thead>
        <tr>
          <th></th>
          <th>ردیف</th>
          <th>  کاربر </th>
          <th>  تاریخ ثبت نظر</th>
          <th> عملیات</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 23 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\comment\index.cshtml"
 if (ViewBag.nazarat != null)
{
  int i=0;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\comment\index.cshtml"
     foreach (var item in ViewBag.nazarat)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n          <td>\n          \n          </td>\n\n          <td class=\"product-category\">");
#nullable restore
#line 34 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\comment\index.cshtml"
                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n         \n          <td class=\"product-name\">");
#nullable restore
#line 36 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\comment\index.cshtml"
                              Write(item.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td class=\"product-category\">");
#nullable restore
#line 37 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\comment\index.cshtml"
                                  Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n           <td class=\"product-action\">\n             <div class=\" mb-1\">\n                <div class=\"btn-group\"  aria-label=\"Basic example\">\n                  <a");
            BeginWriteAttribute("href", " href=\"", 959, "\"", 996, 2);
            WriteAttributeValue("", 966, "/admin/comment/Detail/", 966, 22, true);
#nullable restore
#line 41 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\comment\index.cshtml"
WriteAttributeValue("", 988, item.Id, 988, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  class=\"btn btn-primary btn-sm\" style=\"color: white;\">مشاهده نظر</a>\n                </div>\n              </div>\n          </td>\n        </tr>\n");
#nullable restore
#line 46 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\comment\index.cshtml"
        i++;
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\comment\index.cshtml"
 
   
}

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tbody>\n    </table>\n  </div>\n  <!-- DataTable ends -->\n\n  <!-- add new sidebar starts -->\n \n  <!-- add new sidebar ends -->\n</section>\n<!-- Data list view end -->\n");
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
