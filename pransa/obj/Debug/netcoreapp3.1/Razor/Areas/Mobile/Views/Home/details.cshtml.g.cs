#pragma checksum "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d033ae9c97c9f2a245bb5dab6564c4cc5e3c0611"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Mobile_Views_Home_details), @"mvc.1.0.view", @"/Areas/Mobile/Views/Home/details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d033ae9c97c9f2a245bb5dab6564c4cc5e3c0611", @"/Areas/Mobile/Views/Home/details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20036d9652529551c055619970abddeed186726", @"/Areas/Mobile/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Mobile_Views_Home_details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel.AdminViewModel.Page.MPages>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"container card\" style=\"margin-top: 40px;\">\r\n   \r\n       <div class=\"pt-3\">\r\n\r\n           \r\n                <p class=\"product-title text-center form-control\">");
#nullable restore
#line 11 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
                                                             Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                \r\n               \r\n\r\n\r\n\r\n\r\n          <!-- Hero Slides-->\r\n          <div class=\"hero-slides owl-carousel\">\r\n            <!-- Single Hero Slide-->\r\n\r\n           \r\n                                  <div class=\"single-hero-slide\"");
            BeginWriteAttribute("style", " style=\"", 482, "\"", 543, 4);
            WriteAttributeValue("", 490, "background-image:", 490, 17, true);
            WriteAttributeValue(" ", 507, "url(\'/fileupload/", 508, 18, true);
#nullable restore
#line 23 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
WriteAttributeValue("", 525, Model.MainImage, 525, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 541, "\')", 541, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"slide-content h-100 d-flex align-items-center\">\r\n                                      <div class=\"slide-text\">\r\n");
            WriteLiteral("</div> \r\n                                    </div>\r\n                                  </div>\r\n\r\n\r\n                                   <div class=\"single-hero-slide\"");
            BeginWriteAttribute("style", " style=\"", 1341, "\"", 1399, 4);
            WriteAttributeValue("", 1349, "background-image:", 1349, 17, true);
            WriteAttributeValue(" ", 1366, "url(\'/fileupload/", 1367, 18, true);
#nullable restore
#line 33 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
WriteAttributeValue("", 1384, Model.Image1, 1384, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1397, "\')", 1397, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"slide-content h-100 d-flex align-items-center\">\r\n                                      <div class=\"slide-text\">\r\n");
            WriteLiteral("</div> \r\n                                    </div>\r\n                                  </div>\r\n\r\n                                   <div class=\"single-hero-slide\"");
            BeginWriteAttribute("style", " style=\"", 2195, "\"", 2253, 4);
            WriteAttributeValue("", 2203, "background-image:", 2203, 17, true);
            WriteAttributeValue(" ", 2220, "url(\'/fileupload/", 2221, 18, true);
#nullable restore
#line 42 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
WriteAttributeValue("", 2238, Model.Image2, 2238, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2251, "\')", 2251, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"slide-content h-100 d-flex align-items-center\">\r\n                                      <div class=\"slide-text\">\r\n");
            WriteLiteral("</div> \r\n                                    </div>\r\n                                  </div>\r\n\r\n                                   <div class=\"single-hero-slide\"");
            BeginWriteAttribute("style", " style=\"", 3049, "\"", 3107, 4);
            WriteAttributeValue("", 3057, "background-image:", 3057, 17, true);
            WriteAttributeValue(" ", 3074, "url(\'/fileupload/", 3075, 18, true);
#nullable restore
#line 51 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
WriteAttributeValue("", 3092, Model.Image3, 3092, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3105, "\')", 3105, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"slide-content h-100 d-flex align-items-center\">\r\n                                      <div class=\"slide-text\">\r\n");
            WriteLiteral("</div> \r\n                                    </div>\r\n                                  </div>\r\n                                   <div class=\"single-hero-slide\"");
            BeginWriteAttribute("style", " style=\"", 3901, "\"", 3959, 4);
            WriteAttributeValue("", 3909, "background-image:", 3909, 17, true);
            WriteAttributeValue(" ", 3926, "url(\'/fileupload/", 3927, 18, true);
#nullable restore
#line 59 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
WriteAttributeValue("", 3944, Model.Image4, 3944, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3957, "\')", 3957, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"slide-content h-100 d-flex align-items-center\">\r\n                                      <div class=\"slide-text\">\r\n");
            WriteLiteral(@"</div> 
                                    </div>
                                  </div>



                              
           
          </div>
        </div>


    <div class=""product product-single row"">
        
        <div class=""col-md-6 mb-4 mb-md-6"">
           
            <div class=""product-details"">
                 <img");
            BeginWriteAttribute("src", " src=\"", 4955, "\"", 5000, 2);
            WriteAttributeValue("", 4961, "/fileupload/", 4961, 12, true);
#nullable restore
#line 81 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
WriteAttributeValue("", 4973, ViewBag.qus.ProfileImageUs, 4973, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5001, "\"", 5007, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 50px;\" ><b style=\"font-size: 14px;\">");
#nullable restore
#line 81 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
                                                                                                                        Write(ViewBag.qus.Shoar);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
               
                </div>
                <div class=""ratings-container"">
                    <div class=""ratings-full"">
                        <span class=""ratings"" style=""width: 80%;""></span>
                        <span class=""tooltiptext tooltip-top""></span>
                    </div>
");
            WriteLiteral("                </div>\r\n                <hr class=\"product-divider\">\r\n\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 5562, "\"", 5570, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h5>توضیحات و حوزه فعالیت </h5>\r\n                </div>\r\n                <p style=\"text-align: justify ;\"> ");
#nullable restore
#line 96 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
                                             Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

            

           
                <div class=""row"">

                    <div class=""col-6"">
                       
                         <h5 class=""new-price"">قبول پروژه در شهر های   : </h5>
                   
                          <p>");
#nullable restore
#line 107 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
                        Write(Model.Citys);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    \r\n\r\n                \r\n\r\n                    \r\n          \r\n");
#nullable restore
#line 115 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
                if (@Model.TypeSend != null)
                {
                     

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <div class=\"col-6\">\r\n                        <h5 class=\"new-price\">نحوه ارسال محصول: </h5>\r\n                   \r\n                           <p>");
#nullable restore
#line 121 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
                         Write(Model.TypeSend);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
            WriteLiteral("                     <div class=\"col-6\">\r\n                        <h5 class=\"new-price\">نحوه تصفیه حساب(نقد یا چک و شرایط): </h5>\r\n                   \r\n                          <p>");
#nullable restore
#line 128 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
                        Write(Model.TypePay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"col-6\">\r\n                        <h5 class=\"new-price\">محل تسویه حساب: </h5>\r\n                   \r\n                           <p>");
#nullable restore
#line 134 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
                         Write(Model.LocationPay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 136 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"

                 }

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n</div>\r\n                    \r\n\r\n                   \r\n\r\n               \r\n\r\n\r\n\r\n\r\n\r\n                <hr class=\"product-divider\">\r\n\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 7057, "\"", 7065, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <h5 class=""new-price"">اطلاعات ارتباطی</h5>
                </div>

                <div class=""row"">

                    <div class=""col-6"">
                       
                         <h5 class=""new-price"">شماره تلفن ثابت : </h5>
                   
                           <p>");
#nullable restore
#line 162 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
                         Write(ViewBag.qus.Tel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-6\">\r\n                        <h5 class=\"new-price\">شماره تلفن  همراه: </h5>\r\n                   \r\n                           <p>");
#nullable restore
#line 167 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
                         Write(ViewBag.qus.PhoneUs);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>

                </div>

                 <div class=""row"">

                    <div class=""col-6"">
                       
                         <h5 class=""new-price"">آدرس  : </h5>
                   
                           <p>");
#nullable restore
#line 178 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
                         Write(ViewBag.qus.AddressUs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-6\">\r\n                        <h5 class=\"new-price\">آدرس سایت: </h5>\r\n                   \r\n                           <p>");
#nullable restore
#line 183 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Home\details.cshtml"
                         Write(ViewBag.qus.Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n     \r\n\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel.AdminViewModel.Page.MPages> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
