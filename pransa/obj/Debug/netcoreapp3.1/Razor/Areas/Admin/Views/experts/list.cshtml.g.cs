#pragma checksum "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\experts\list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c7854cc1fe72c81ded28a4146c561b0e4131aef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_experts_list), @"mvc.1.0.view", @"/Areas/Admin/Views/experts/list.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c7854cc1fe72c81ded28a4146c561b0e4131aef", @"/Areas/Admin/Views/experts/list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20036d9652529551c055619970abddeed186726", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_experts_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 60px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n    <!-- BEGIN: Content-->\n<section id=\"data-list-view\" class=\"data-list-view-header\">\n");
#nullable restore
#line 5 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\experts\list.cshtml"
   if (ViewBag.er != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"alert alert-success\">");
#nullable restore
#line 7 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\experts\list.cshtml"
                          Write(ViewBag.er);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 8 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\experts\list.cshtml"
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
          <th> نام کارشناس </th>
          <th> کد کارشناس </th>
          <th> تصویر کارشناس </th>
          <th> آدرس </th>
           <th>  زبان</th>
          <th> عملیات</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 25 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\experts\list.cshtml"
 if (ViewBag.list != null)
{
  int i=1;
     foreach (var item in ViewBag.list)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <tr>\n          <td></td>\n          <td class=\"product-category\"> ");
#nullable restore
#line 32 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\experts\list.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td class=\"product-name\">");
#nullable restore
#line 33 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\experts\list.cshtml"
                              Write(item.NameEx);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"product-category\">");
#nullable restore
#line 34 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\experts\list.cshtml"
                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n\n           <td class=\"product-category\">  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8c7854cc1fe72c81ded28a4146c561b0e4131aef6301", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 917, "~/fileupload/", 917, 13, true);
#nullable restore
#line 36 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\experts\list.cshtml"
AddHtmlAttributeValue("", 930, item.ImageEx, 930, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  </td>\n            <td class=\"product-category\">");
#nullable restore
#line 37 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\experts\list.cshtml"
                                    Write(item.address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td class=\"product-category\">");
#nullable restore
#line 38 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\experts\list.cshtml"
                                                Write(item.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n           <td class=\"product-action\">\n             <div class=\"col-lg-3 col-md-3 mb-1\">\n                <div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">\n                 \n                  <a");
            BeginWriteAttribute("href", " href=\"", 1302, "\"", 1336, 2);
            WriteAttributeValue("", 1309, "/admin/experts/del/", 1309, 19, true);
#nullable restore
#line 43 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\experts\list.cshtml"
WriteAttributeValue("", 1328, item.Id, 1328, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-danger btn-sm\" onclick=\"return confirm(\'آیا از حذف رکورد مورد نظر مطمن هستید؟\')\">حذف</a>\n                 \n                </div>\n              </div>\n          </td>\n        </tr>\n");
#nullable restore
#line 49 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Admin\Views\experts\list.cshtml"
 i++;
     }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("      \n\n      \n\n\n      </tbody>\n    </table>\n  </div>\n  <!-- DataTable ends -->\n\n  <!-- add new sidebar starts -->\n \n  <!-- add new sidebar ends -->\n</section>\n<!-- Data list view end -->\n");
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