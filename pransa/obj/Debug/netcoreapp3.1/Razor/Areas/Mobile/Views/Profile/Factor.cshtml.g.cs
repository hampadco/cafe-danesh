#pragma checksum "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Profile\Factor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a74d364b9aadd53b2ec997f190ea497e16a1b75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Mobile_Views_Profile_Factor), @"mvc.1.0.view", @"/Areas/Mobile/Views/Profile/Factor.cshtml")]
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
#line 2 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Profile\Factor.cshtml"
using Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Profile\Factor.cshtml"
using pransa.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Profile\Factor.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a74d364b9aadd53b2ec997f190ea497e16a1b75", @"/Areas/Mobile/Views/Profile/Factor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20036d9652529551c055619970abddeed186726", @"/Areas/Mobile/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Mobile_Views_Profile_Factor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.Area.Questions.Vm_Questions>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"                           



                    <style>
    table{
        width: 100%;
        
    }
    td{
        border:1px solid black;
        text-align: center;
        padding: 10px;
        white-space: nowrap;
    }
    tr:nth-child(odd)
    {
       background-color: #80808096;
       color:black;
       font-size: 16px;
       
    }
     th{
           text-align: center;
           white-space: nowrap;
           padding: 10px;
           
           
       }

</style>
<main class=""main"">
    <!-- Start of Page Header -->
       <h2 class=""form-control  text-center mt-5"" style=""background-color: lightblue;margin-top: 40px;"">

              
                لیست و وضعیت سفارشات
            </h2>

            <p class=""mt-3 mb-3 text-center alert alert-primary p-2"">برای دیدن بقیه جدول اسکرول کنید </p>
        
    <!-- End of Page Header -->

    <!-- Start of Breadcrumb -->

    <!-- End of Breadcrumb -->

    <!-- Start of PageContent -->
    <div class=""page-content pt-2"" >
        <div ");
            WriteLiteral("class=\"card p-1\" >\n");
            WriteLiteral(@"
            <div class=""row justify-content-center""  id=""cat"">


                <div class=""col-12 mb-4"">


                    <div class=""container justify-content-center"">
                        <div class=""row"" style=""overflow: auto;"">
                          

                          <table>

                              <tr>
                                  <th>ردیف</th>
                                  <th>شناسه پیگیری</th>
                                  <th>مبلغ (تومان)</th>
                                  <th>تاریخ</th>
                                  <th>وضعیت</th>
                                  
                              </tr>

");
#nullable restore
#line 79 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Profile\Factor.cshtml"
                                
                                  int i=1;

                             

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Profile\Factor.cshtml"
                              if(ViewBag.order != null)
                             {

                             
                              

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Profile\Factor.cshtml"
                               foreach (var item in @ViewBag.order)
                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   <tr>\n                                  <td>");
#nullable restore
#line 89 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Profile\Factor.cshtml"
                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                  <td class=\"product-name\">");
#nullable restore
#line 90 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Profile\Factor.cshtml"
                                                      Write(item.RFactor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                <td class=\"product-category\">");
#nullable restore
#line 91 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Profile\Factor.cshtml"
                                                                                                        Write(item.Pay);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                                                                <td class=\"product-category\">");
#nullable restore
#line 92 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Profile\Factor.cshtml"
                                                                                                        Write(item.Date_Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                <td class=\"product-category\">\n");
#nullable restore
#line 94 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Profile\Factor.cshtml"
                                                                                     if (@item.State == "OK")
                                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                                        <p>در انتظار ارسال مدیر</p>\n");
#nullable restore
#line 97 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Profile\Factor.cshtml"
                                                                                    }
                                                                                    else
                                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                                        <p>ارسال شده</p>\n");
#nullable restore
#line 101 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Profile\Factor.cshtml"
                                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                                </td>\n                                                                                 \n                              </tr>\n");
#nullable restore
#line 105 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Profile\Factor.cshtml"
                                   i++;
                              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\Profile\Factor.cshtml"
                               
                              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                             

                             
                            


                          </table>





                      
                        </div>
                    </div>
                    

                </div>


             

               


            </div>


            </div>
    </div>
            

          

                


                

               


            


           









        

    <!-- End of PageContent -->
</main>
<!-- End of Main -->
<script>

    function show()
    {
        document.getElementById('des').style.display='';

    }
     function hide()
    {
        document.getElementById('des').style.display='none';
        
    }






</script>");
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