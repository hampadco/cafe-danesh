#pragma checksum "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\detailfactor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aa001ae4462b697428fbfe495d04301918167cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_order_detailfactor), @"mvc.1.0.view", @"/Areas/Admin/Views/order/detailfactor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aa001ae4462b697428fbfe495d04301918167cc", @"/Areas/Admin/Views/order/detailfactor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20036d9652529551c055619970abddeed186726", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_order_detailfactor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

    <!-- BEGIN: Content-->
<section id=""data-list-view"" class=""data-list-view-header"">
  <!-- DataTable starts -->
                                                            <div class=""table-responsive"">
                                                              <table class=""table data-list-view"">
                                                                <thead>
                                                                  <tr>
                                                                    <th></th>
                                                                    <th>ردیف</th>
                                                                    <th>کد صفحه  </th>
                                                                    <th> نام صفحه    </th>
                                                                     <th>تعداد</th>
                                                                    <th>مبلغ (تومان)</th>
                                                              ");
            WriteLiteral(@"       <th>مبلغ کل (تومان)</th>
                                                                    <th> شناسه پیگیری</th>
                                                                  </tr>
                                                                </thead>
                                                                <tbody>
");
#nullable restore
#line 21 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\detailfactor.cshtml"
                                                                    
                                                                      if (ViewBag.order != null)
                                                                      {
                                                                        int i=1;
                                                                        foreach (var item in ViewBag.order)
                                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                            <tr>
                                                                                <td></td>
                                                                                <td class=""product-category""> ");
#nullable restore
#line 29 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\detailfactor.cshtml"
                                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                <td class=\"product-name\">");
#nullable restore
#line 30 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\detailfactor.cshtml"
                                                                                                    Write(item.Product_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                <td class=\"product-category\">");
#nullable restore
#line 31 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\detailfactor.cshtml"
                                                                                                        Write(item.product_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                                                                <td class=\"product-category\">");
#nullable restore
#line 32 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\detailfactor.cshtml"
                                                                                                        Write(item.Product_Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                                                                <td class=\"product-name\">");
#nullable restore
#line 33 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\detailfactor.cshtml"
                                                                                                    Write(item.product_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                <td class=\"product-name\">");
#nullable restore
#line 34 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\detailfactor.cshtml"
                                                                                                    Write(item.Total_sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                <td class=\"product-name\">");
#nullable restore
#line 35 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\detailfactor.cshtml"
                                                                                                    Write(item.RFactor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                            </tr>\n");
#nullable restore
#line 37 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\order\detailfactor.cshtml"
                                                                           i++;
                                                            
                                                                        }
                                                            
                                                                      }
                                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                </tbody>
                                                              </table>
                                                            </div>

      

      </section>
<!-- Data list view end -->
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
