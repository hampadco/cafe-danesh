#pragma checksum "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6bca5a24ab11ed6ecd1f49fa8980cbd7a750f38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_order_show), @"mvc.1.0.view", @"/Areas/Admin/Views/order/show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6bca5a24ab11ed6ecd1f49fa8980cbd7a750f38", @"/Areas/Admin/Views/order/show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20036d9652529551c055619970abddeed186726", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_order_show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- BEGIN: Content-->\n<section id=\"data-list-view\" class=\"data-list-view-header\">\n  <!-- DataTable starts -->\n");
#nullable restore
#line 4 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\show.cshtml"
   if (ViewBag.er != null)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p class=\"alert alert-success\">");
#nullable restore
#line 6 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\show.cshtml"
                            Write(ViewBag.er);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 7 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\show.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <div class=""table-responsive"">
    <table class=""table data-list-view"">
      <thead>
        <tr>
          <th></th>
          <th>ردیف</th>
          <th> عنوان صفحه   </th>
          <th>شماره فاکتور </th>
         
          <th> قیمت </th>
          <th> تعداد</th>
          <th> جمع کل</th>

          
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 25 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\show.cshtml"
         if ( ViewBag.listp != null)
        {

        int i=1;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\show.cshtml"
         foreach (var item in ViewBag.listp)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n          <td></td>\n          <td class=\"product-category\"> ");
#nullable restore
#line 34 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\show.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td class=\"product-name\">");
#nullable restore
#line 35 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\show.cshtml"
                              Write(item.product_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td class=\"product-category\">");
#nullable restore
#line 36 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\show.cshtml"
                                  Write(item.Id_Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n          <td class=\"product-category\">");
#nullable restore
#line 38 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\show.cshtml"
                                  Write(item.product_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n          <td class=\"product-category\">");
#nullable restore
#line 39 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\show.cshtml"
                                  Write(item.Product_Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n          <td class=\"product-category\">");
#nullable restore
#line 41 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\show.cshtml"
                                  Write(item.Total_sum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n\n         \n        </tr>\n");
#nullable restore
#line 45 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\show.cshtml"
i++;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\show.cshtml"
         

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"







      </tbody>
    </table>
  </div>
  <!-- DataTable ends -->

  <!-- add new sidebar starts -->

  <!-- add new sidebar ends -->
</section>
<!-- Data list view end -->
<p class=""alert alert-info text-center"" style=""color: black !important;"">جمع کل: ");
#nullable restore
#line 67 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\show.cshtml"
                                                                            Write(ViewBag.sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<div class=\"text-center\">\n\n</div>\n");
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
