#pragma checksum "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\categoryshop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54cd6fd4eaa11b513561a59318044398b011140b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Mobile_Views_Home_categoryshop), @"mvc.1.0.view", @"/Areas/Mobile/Views/Home/categoryshop.cshtml")]
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
#line 1 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\_ViewImports.cshtml"
using pransa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\_ViewImports.cshtml"
using pransa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54cd6fd4eaa11b513561a59318044398b011140b", @"/Areas/Mobile/Views/Home/categoryshop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20036d9652529551c055619970abddeed186726", @"/Areas/Mobile/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Mobile_Views_Home_categoryshop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ViewModels.AdminViewModel.Product.Vm_Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("  <!-- ماشین آلات اداری-->\r\n");
            WriteLiteral(@"      <div class=""featured-products-wrapper py-3"">
        <div class=""container"" style=""margin-top: 50px !important;"">
          <div class=""section-heading d-flex align-items-center justify-content-between"">
            <h1 class=""text-center alert alert-light form-control"">  ");
#nullable restore
#line 6 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\categoryshop.cshtml"
                                                                Write(TempData["cat"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n          </div>\r\n          <div class=\"row g-3\">\r\n            <!-- Featured Product Card-->\r\n\r\n");
#nullable restore
#line 11 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\categoryshop.cshtml"
              if (Model != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\categoryshop.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <div class=\"col-6 col-md-4 col-lg-3\" >\r\n                        <div class=\"card featured-product-card\">\r\n                          <div");
            BeginWriteAttribute("class", " class=\"", 781, "\"", 789, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""min-height: 170px;"">
                            <!-- Badge--><span class=""badge badge-warning custom-badge""><i class=""lni lni-star""></i></span>
                            <div class=""product-thumbnail-side"">
                              <!-- Wishlist Button -->
                              <!-- Thumbnail --><a class=""product-thumbnail d-block""");
            BeginWriteAttribute("href", " href=\"", 1151, "\"", 1183, 2);
            WriteAttributeValue("", 1158, "home/detailsshop/", 1158, 17, true);
#nullable restore
#line 21 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\categoryshop.cshtml"
WriteAttributeValue("", 1175, item.Id, 1175, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1189, "\"", 1225, 2);
            WriteAttributeValue("", 1195, "/fileupload/", 1195, 12, true);
#nullable restore
#line 21 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\categoryshop.cshtml"
WriteAttributeValue("", 1207, item.ImageMainPro, 1207, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1226, "\"", 1232, 0);
            EndWriteAttribute();
            WriteLiteral(" ></a>\r\n                            </div>\r\n                            <div class=\"product-description\">\r\n                              <!-- Product Title --><a class=\"product-title d-block\"");
            BeginWriteAttribute("href", " href=\"", 1424, "\"", 1456, 2);
            WriteAttributeValue("", 1431, "home/detailsshop/", 1431, 17, true);
#nullable restore
#line 24 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\categoryshop.cshtml"
WriteAttributeValue("", 1448, item.Id, 1448, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-overflow: ellipsis;white-space: nowrap;padding: 5px;overflow: hidden; \">");
#nullable restore
#line 24 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\categoryshop.cshtml"
                                                                                                                                                                                                     Write(item.TitleProductPro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                              <!-- Price -->\r\n                              \r\n                            </div>\r\n                          </div>\r\n                        </div>\r\n                      </div>\r\n");
#nullable restore
#line 31 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\categoryshop.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\categoryshop.cshtml"
                     

                }else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <p class=\"form-control text-center\">هیچ خدمت یا کالایی ثبت نشده فعلا برای این دسته بندی...</p>\r\n");
#nullable restore
#line 36 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\categoryshop.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n          </div>\r\n        </div>\r\n      </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ViewModels.AdminViewModel.Product.Vm_Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
