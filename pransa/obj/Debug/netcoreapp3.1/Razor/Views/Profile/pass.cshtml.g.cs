#pragma checksum "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\pass.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8338535e40e0c223f703e96a64a7a5e0656a051"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_pass), @"mvc.1.0.view", @"/Views/Profile/pass.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8338535e40e0c223f703e96a64a7a5e0656a051", @"/Views/Profile/pass.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20036d9652529551c055619970abddeed186726", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Profile_pass : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.AdminViewModel.Users.Vm_User>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/profile/pass"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!-- Start of Main -->\n\n<style>\n    p.t {\n        font-size: 18px;\n        text-align: center;\n        margin-top: 5px;\n\n    }\n\n   \n\n\n    div.col-md-3 {\n");
            WriteLiteral(@"padding: 10px;
        margin: 0px;
        margin-bottom: 15px
    }

    p.text-uppercase {
        font-size: large;
    }
</style>
<main class=""main"">
    <!-- Start of Page Header -->



            <h2 class=""form-control  text-center mt-5"" style=""background-color: lightblue;margin-top: 40px;"">

                

                تغییر رمز عبور

            </h2>
        


    <!-- End of Page Header -->

    <!-- Start of Breadcrumb -->

    <!-- End of Breadcrumb -->

    <!-- Start of PageContent -->
    <div class=""page-content pt-2"">
        <div class=""container card"">



            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8338535e40e0c223f703e96a64a7a5e0656a0514714", async() => {
                WriteLiteral("\n\n                <div class=\"row justify-content-center\" style=\" border:1px solid gray; \n                                    border-radius: 15px;\">\n\n\n\n");
#nullable restore
#line 60 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\pass.cshtml"
                     if (TempData["msg"] != null)

                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p style=\"color:green;text-align: center;padding: 20px;font-size: 18px;\">");
#nullable restore
#line 63 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\pass.cshtml"
                                                                                            Write(TempData["msg"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 64 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\pass.cshtml"


                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
#nullable restore
#line 68 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\pass.cshtml"
                     if (TempData["msge"] != null)

                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p style=\"color: red;text-align: center;padding: 20px;font-size: 18px;\">");
#nullable restore
#line 71 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\pass.cshtml"
                                                                                           Write(TempData["msge"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 72 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\pass.cshtml"


                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"






                    <div class=""col-12 text-center mb-4"">


                        <div class=""container"">
                            <div class=""row"">
                                <p class=""t""> ورود رمز عبور جدید </p>
                                <input type=""password"" class=""form-control t"" placeholder=""رمز عبور جدید""
                                    name=""PasswordUs"" required>
                            </div>
                        </div>
                    </div>

                    <div class=""col-12 text-center mb-4"">


                        <div class=""container"">
                            <div class=""row"">
                                <p class=""t""> تکرار رمز عبور جدید </p>
                                <input type=""password"" class=""form-control t"" placeholder=""تکرار رمز عبور"" name=""repass""
                                    required>
                            </div>
                        </div>
                    </div>






                    <div class=""row ju");
                WriteLiteral(@"stify-content-center mt-5"">

                        <button class=""btn btn-success 12"" style=""font-size: 15px;"" type=""submit"">ذخیره</button>
                        <button class=""btn btn-danger col-12 mt-1"" style=""font-size: 15px;""
                            type=""reset"">انصراف</button>
<br><br>
                    </div>








                </div>

            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n\n\n\n        </div>\n    </div>\n\n    <!-- End of PageContent -->\n</main>\n<!-- End of Main -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModels.AdminViewModel.Users.Vm_User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
