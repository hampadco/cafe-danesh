#pragma checksum "c:\Users\apple\Desktop\cafe-danesh\pransa\Views\Profile\listnotvertify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be2749c987a3ebc2b383f86c22f0c30b63681385"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_listnotvertify), @"mvc.1.0.view", @"/Views/Profile/listnotvertify.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be2749c987a3ebc2b383f86c22f0c30b63681385", @"/Views/Profile/listnotvertify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20036d9652529551c055619970abddeed186726", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Profile_listnotvertify : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Start of Main -->
<style>
    table{
        width: 100%;
        
    }
    td{
        border:1px solid black;
        text-align: center;
    }
    tr:nth-child(even)
    {
       background-color: gray;
       color:white
    }
     th{
           text-align: center;
           
       }

</style>
<main class=""main"">
    <!-- Start of Page Header -->
    
            <h2 class=""form-contrl  text-center"" style=""background-color: lightblue; margin-top: 60px;padding: 10px;"">

                لیست صفحات در انتظار تایید 
            </h2>
       
    <!-- End of Page Header -->

    <!-- Start of Breadcrumb -->

    <!-- End of Breadcrumb -->

    <!-- Start of PageContent -->
    <div class=""page-content pt-2"" >
        <div class=""container card"" >
");
            WriteLiteral(@"
            <div class=""row justify-content-center p-2""  >


               


                                      <p  class=""alert alert-danger text-center"" style=""padding: 25px;"">هیچ آیتمی فعلا وجود   وجود ندارد </p>



                      
                    


             

               


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
