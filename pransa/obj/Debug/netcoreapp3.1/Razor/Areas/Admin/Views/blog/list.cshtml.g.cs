#pragma checksum "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\blog\list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7860c58907e789408e36ef15563c04d48ebf146"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_blog_list), @"mvc.1.0.view", @"/Areas/Admin/Views/blog/list.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7860c58907e789408e36ef15563c04d48ebf146", @"/Areas/Admin/Views/blog/list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20036d9652529551c055619970abddeed186726", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_blog_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n    <!-- BEGIN: Content-->\n<section id=\"data-list-view\" class=\"data-list-view-header\">\n");
#nullable restore
#line 5 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\blog\list.cshtml"
    if (ViewBag.er != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-success\">");
#nullable restore
#line 7 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\blog\list.cshtml"
                              Write(ViewBag.er);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 8 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\blog\list.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <!-- DataTable starts -->
  <div class=""table-responsive"">
    <table class=""table data-list-view"">
      <thead>
        <tr>
          <th></th>
          <th>ردیف</th>
          <th> عنوان خبر  </th>
          
          <th> تصویر اصلی </th>
        >
          <th> عملیات</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 24 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\blog\list.cshtml"
 if ( ViewBag.list != null)
{
int i=1;
    foreach (var item in ViewBag.list)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr>\n          <td></td>\n          <td class=\"product-category\">");
#nullable restore
#line 31 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\blog\list.cshtml"
                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td class=\"product-name\">");
#nullable restore
#line 32 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\blog\list.cshtml"
                              Write(item.TitleBLo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            \n\n           <td class=\"product-category\">  <img style=\"width: 60px;\"");
            BeginWriteAttribute("src", " src=\"", 801, "\"", 837, 2);
            WriteAttributeValue("", 807, "/fileupload/", 807, 12, true);
#nullable restore
#line 35 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\blog\list.cshtml"
WriteAttributeValue("", 819, item.ImageMainBlo, 819, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 838, "\"", 844, 0);
            EndWriteAttribute();
            WriteLiteral(">  </td>\n            \n                     \n           <td class=\"product-action\">\n             <div class=\"col-lg-3 col-md-3 mb-1\">\n                <div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">\n                  <a");
            BeginWriteAttribute("href", " href=\"", 1078, "\"", 1116, 2);
            WriteAttributeValue("", 1085, "/admin/Blog/updateblog/", 1085, 23, true);
#nullable restore
#line 41 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\blog\list.cshtml"
WriteAttributeValue("", 1108, item.Id, 1108, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\">مشاهده</a>\n                  <a onclick=\"return confirm(\'آیا از حذف رکورد مورد نظر مطمئن هستید؟\')\"");
            BeginWriteAttribute("href", " href=\"", 1247, "\"", 1278, 2);
            WriteAttributeValue("", 1254, "/admin/Blog/del/", 1254, 16, true);
#nullable restore
#line 42 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\blog\list.cshtml"
WriteAttributeValue("", 1270, item.Id, 1270, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">حذف</a>\n                  <a");
            BeginWriteAttribute("href", " href=\"", 1338, "\"", 1376, 2);
            WriteAttributeValue("", 1345, "/admin/Blog/updateblog/", 1345, 23, true);
#nullable restore
#line 43 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\blog\list.cshtml"
WriteAttributeValue("", 1368, item.Id, 1368, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success  btn-sm\">ویرایش</a>\n                </div>\n              </div>\n          </td>\n        </tr>\n");
#nullable restore
#line 48 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\blog\list.cshtml"
        i++;
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("       \n\n\n      \n\n\n      </tbody>\n    </table>\n  </div>\n  <!-- DataTable ends -->\n\n  <!-- add new sidebar starts -->\n \n  <!-- add new sidebar ends -->\n</section>\n<!-- Data list view end -->\n");
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
