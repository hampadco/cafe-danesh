#pragma checksum "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Login\verify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7ea4f283d3d8bbef32253912d4cdcbc3504eaa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_verify), @"mvc.1.0.view", @"/Views/Login/verify.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7ea4f283d3d8bbef32253912d4cdcbc3504eaa9", @"/Views/Login/verify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20036d9652529551c055619970abddeed186726", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_verify : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.AdminViewModel.Users.Vm_User>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/login/checkcode"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
            WriteLiteral(@"






<div class=""page-wrapper"">
  <!-- Start of Main -->
  <main class=""main login-page"" style=""margin-top: 60px;"">
    <!-- Start of Breadcrumb -->
 
    <!-- End of Breadcrumb -->
    
      <div class=""page-content mt-10"">
        <div class=""container row justify-content-center"" style=""padding-left: 0px !important;"">
         
          <div class=""login-popup col-12"" style=""background-color: white"">
            <div class=""tab tab-nav-boxed tab-nav-center tab-nav-underline"">
              <ul class=""nav nav-tabs text-uppercase"" role=""tablist"">
                <li class=""nav-item"">
                  <a href=""#sign-in"" class=""nav-link active"" style=""font-size: large"">ثبت کد تایید
                  </a>
                </li>
               
              </ul>
              <div class=""tab-content"">

             


     

                <div class=""tab-pane active"" id=""sign-in"">
                 
       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7ea4f283d3d8bbef32253912d4cdcbc3504eaa94898", async() => {
                WriteLiteral("\n\n");
#nullable restore
#line 41 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Login\verify.cshtml"
       if (@ViewBag.er != null)
      {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p style=\"color:red;padding: 10px\">");
#nullable restore
#line 43 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Login\verify.cshtml"
                                      Write(ViewBag.er);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 44 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Login\verify.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Login\verify.cshtml"
        if (TempData["mssg"] != null)
      {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p style=\"color:#cf1d369e;padding: 10px\" class=\"mt-3\">");
#nullable restore
#line 47 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Login\verify.cshtml"
                                                         Write(TempData["mssg"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 48 "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Login\verify.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                  <div class=""form-group"">
                    <input style=""
                          padding: 15px;
                          border: 1px solid rgb(207, 206, 206);
                          border-radius: 8px;
                        "" type=""number"" class=""form-control mt-5"" name=""Token""  
                      placeholder=""لطفا کد تایید ارسالی را وارد کنید "" autocomplete=""off"" required />

                      
                  </div>
                
                  

                <hr>
                   <button type=""submit"" class=""btn btn-primary mt-1 form-control""
                    style=""color:white;padding: 18px; border-radius: 8px; font-size: 25px;background-color: #FFCC01;"">ثبت 
                  </button>
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
            WriteLiteral(@"
                  <!-- <div class=""form-checkbox d-flex align-items-center justify-content-between"">
                                        <input type=""checkbox"" class=""custom-checkbox"" id=""remember1"" name=""remember1"" ="""">
                                        <label for=""remember1"">مرا به خاطر بسپار </label>
                                        <a href=""#"">فراموشی رمز عبور؟ </a>
                                    </div> -->
                 

                  
");
            WriteLiteral("\n                 \n                </div>\n\n\n");
            WriteLiteral("                \n\n\n\n\n              </div>\n            </div>\n            <br />\n            <br />\n            <br />\n          </div>\n        </div>\n      </div>\n    \n  </main>\n  <!-- End of Main -->\n</div>\n\n");
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
