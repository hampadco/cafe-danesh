#pragma checksum "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\detailfactor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93487ff5814056e9500f72a5d5120f55b20903b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_detailfactor), @"mvc.1.0.view", @"/Views/Profile/detailfactor.cshtml")]
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
#line 5 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\detailfactor.cshtml"
using pransa.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\detailfactor.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93487ff5814056e9500f72a5d5120f55b20903b2", @"/Views/Profile/detailfactor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20036d9652529551c055619970abddeed186726", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Profile_detailfactor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.Area.Questions.Vm_Questions>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\detailfactor.cshtml"
  
    Layout = "_Layoutprofile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-12 dt-sl dt-sn mb-3"">
                                <div class=""profile-menu-section dt-sl"">
                                    <div class=""label-profile-menu mt-2 mb-2"">
                                        <span> سفارشات شما</span>
                                    </div>
                                    <div class=""profile-menu"">
                                        <ul>
                                            <li>
                                                <a href=""/profile/Index"">
                                                    <i class=""mdi mdi-account-circle-outline""></i>
                                                    پروفایل
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""/profile/update"">
                                                    <i class=""mdi mdi-account-ed");
            WriteLiteral(@"it-outline""></i>
                                                    ویرایش اطلاعات شخصی 
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""/profile/factor"" class=""active"">
                                                    <i class=""mdi mdi-basket""></i>
                                                    همه سفارش ها
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""/profile/nazarat"" >
                                                    <i class=""mdi mdi-backburger""></i>
                                                     پرسش و پاسخ
                                                </a>
                                            </li>
                                            <li>
           ");
            WriteLiteral(@"                                     <a href=""/profile/favorite"">
                                                    <i class=""mdi mdi-heart-outline""></i>
                                                    لیست علاقمندی ها
                                                </a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>


                            <!-- Start Content -->
                    <div class=""col-xl-9 col-lg-8 col-md-8 col-sm-12 mt-5 pr-4"">
                        <div class=""row"">
                            <div class=""col-12"">
                                <div class=""px-3 px-res-0"">
                                    <div
                                        class=""section-title text-sm-title title-wide mb-1 no-after-title-wide dt-sl mb-2 px-res-1"">
                ");
            WriteLiteral(@"                        <h2> جزئیات سفارش من </h2>
                                    </div>
                                    <div class=""form-ui additional-info dt-sl dt-sn pt-1"">
                                        <div class=""ah-tab-content-wrapper dt-sl px-res-0"">
                                            <div class=""ah-tab-content dt-sl"" data-ah-tab-active=""true"">
                                                <div class=""row mx-0 px-res-0"">
                                                            <div class=""table-responsive"">
                                                              <table class=""table data-list-view"">
                                                                <thead>
                                                                  <tr>
                                                                    <th></th>
                                                                    <th>ردیف</th>
                                                                    <");
            WriteLiteral(@"th>کد صفحه  </th>
                                                                    <th> نام صفحه    </th>
                                                                     <th>تعداد</th>
                                                                    <th>مبلغ (تومان)</th>
                                                                     <th>مبلغ کل (تومان)</th>
                                                                    <th> شناسه پیگیری</th>
                                                                  </tr>
                                                                </thead>
                                                                <tbody>
");
#nullable restore
#line 81 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\detailfactor.cshtml"
                                                                    
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
#line 89 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\detailfactor.cshtml"
                                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                <td class=\"product-name\">");
#nullable restore
#line 90 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\detailfactor.cshtml"
                                                                                                    Write(item.Product_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                <td class=\"product-category\">");
#nullable restore
#line 91 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\detailfactor.cshtml"
                                                                                                        Write(item.product_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                                                                <td class=\"product-category\">");
#nullable restore
#line 92 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\detailfactor.cshtml"
                                                                                                        Write(item.Product_Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                                                                <td class=\"product-name\">");
#nullable restore
#line 93 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\detailfactor.cshtml"
                                                                                                    Write(item.product_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                <td class=\"product-name\">");
#nullable restore
#line 94 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\detailfactor.cshtml"
                                                                                                    Write(item.Total_sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                <td class=\"product-name\">");
#nullable restore
#line 95 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\detailfactor.cshtml"
                                                                                                    Write(item.RFactor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                            </tr>\n");
#nullable restore
#line 97 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\detailfactor.cshtml"
                                                                           i++;
                                                            
                                                                        }
                                                            
                                                                      }
                                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                </tbody>
                                                              </table>
                                                            </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- End Content -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModels.Area.Questions.Vm_Questions> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
