#pragma checksum "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96b5f7aa7feff80cced42725e24c91de967c86c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Mobile_Views_shared__Layout), @"mvc.1.0.view", @"/Areas/Mobile/Views/shared/_Layout.cshtml")]
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
#nullable restore
#line 3 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 351 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96b5f7aa7feff80cced42725e24c91de967c86c1", @"/Areas/Mobile/Views/shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20036d9652529551c055619970abddeed186726", @"/Areas/Mobile/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Mobile_Views_shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("home/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            WriteLiteral("  \r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96b5f7aa7feff80cced42725e24c91de967c86c14726", async() => {
                WriteLiteral(@"
    <script >



</script>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1, viewport-fit=cover, shrink-to-fit=no"">
    <meta name=""description"" content=""Suha - Multipurpose Ecommerce Mobile HTML Template"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""theme-color"" content=""#100DD1"">
    <meta name=""apple-mobile-web-app-capable"" content=""yes"">
    <meta name=""apple-mobile-web-app-status-bar-style"" content=""black"">
    <!-- The above tags *must* come first in the head, any other head content must come *after* these tags-->
    <!-- Title-->
        <title>سامانه آنلاین انتخاب و مقایسه شرکت های غرفه ساز </title>

    <link rel=""preconnect"" href=""https://fonts.googleapis.com/"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com/"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&amp;di");
                WriteLiteral(@"splay=swap"" rel=""stylesheet"">
    <!-- Favicon-->
    <link rel=""icon"" href=""/assets/images/favicon.png"">
    <!-- Apple Touch Icon-->
    <link rel=""apple-touch-icon"" href=""img/icons/icon-96x96.png"">
    <link rel=""apple-touch-icon"" sizes=""152x152"" href=""img/icons/icon-152x152.png"">
    <link rel=""apple-touch-icon"" sizes=""167x167"" href=""img/icons/icon-167x167.png"">
    <link rel=""apple-touch-icon"" sizes=""180x180"" href=""img/icons/icon-180x180.png"">
    <!-- CSS Libraries-->
    <link rel=""stylesheet"" href=""css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""css/animate.css"">
    <link rel=""stylesheet"" href=""css/owl.carousel.min.css"">
    <link rel=""stylesheet"" href=""css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""css/lineicons.min.css"">
    <link rel=""stylesheet"" href=""css/magnific-popup.css"">
    <link rel=""stylesheet"" href=""/previewimg/styleimg.css"">
    <!-- Stylesheet-->
    <link rel=""stylesheet"" href=""style.css"">
    <!-- Web App Manifest-->
    <link rel=""manifest"" h");
                WriteLiteral(@"ref=""manifest.json"">
    <style>
      span{
        text-overflow: ellipsis;
        white-space: nowrap;
        overflow: hidden;
      }
      a{
        text-overflow: ellipsis;
        white-space: nowrap;
        overflow: hidden;
      }
    </style>

    <style>


/*the container must be positioned relative:*/
.autocomplete {
  position: relative;
  display: inline-block;
}




.autocomplete-items {
  position: absolute;
  border: 1px solid #d4d4d4;
  border-bottom: none;
  border-top: none;
  z-index: 99;
  /*position the autocomplete items to be the same width as the container:*/
  top: 100%;
  left: 0;
  right: 0;
  font-size: 10px !important;
}

.autocomplete-items div {
  padding: 10px;
  cursor: pointer;
  background-color: #fff; 
  border-bottom: 1px solid #d4d4d4; 
}

/*when hovering an item:*/
.autocomplete-items div:hover {
  background-color: #e9e9e9; 
}

.h5, h5 {
    font-size: 1rem !important;
}

/*when navigating through the items ");
                WriteLiteral("using the arrow keys:*/\r\n.autocomplete-active {\r\n  background-color: DodgerBlue !important; \r\n  color: #ffffff; \r\n}\r\n</style>\r\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96b5f7aa7feff80cced42725e24c91de967c86c19111", async() => {
                WriteLiteral(@"
    <!-- Preloader-->
    
    <!-- Header Area-->
    <div class=""header-area"" id=""headerArea"">
      <div class=""container h-100 d-flex align-items-center justify-content-between"">
        <!-- Logo Wrapper-->
        <div class=""logo-wrapper""><a href=""/""><img src=""/assets/images/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 3651, "\"", 3657, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"width: 75px !important;\"></a></div>\r\n        <!-- Search Form-->\r\n        <div class=\"top-search-form\">\r\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96b5f7aa7feff80cced42725e24c91de967c86c19961", async() => {
                    WriteLiteral("\r\n            <input class=\"form-control\" type=\"search\" placeholder=\"کلمه کلیدی خود را وارد کنید\" id=\"myInput\" autocomplete=\"off\" name=\"myinput\">\r\n            <button type=\"submit\"><i class=\"fa fa-search\"></i></button>\r\n          ");
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
        </div>
        <!-- Navbar Toggler-->
        <div class=""suha-navbar-toggler"" data-bs-toggle=""offcanvas"" data-bs-target=""#suhaOffcanvas"" aria-controls=""suhaOffcanvas""><span></span><span></span><span></span></div>
      </div>
    </div>
    <div class=""offcanvas offcanvas-start suha-offcanvas-wrap"" tabindex=""-1"" id=""suhaOffcanvas"" aria-labelledby=""suhaOffcanvasLabel"">
      <!-- Close button-->
      <button class=""btn-close btn-close-white text-reset"" type=""button"" data-bs-dismiss=""offcanvas"" aria-label=""Close""></button>
      <!-- Offcanvas body-->
      <div class=""offcanvas-body"">
        <!-- Sidenav Profile-->
        <div class=""sidenav-profile"">
          <div class=""user-profile""><img src=""/assets/images/logomobile.png""");
                BeginWriteAttribute("alt", " alt=\"", 4820, "\"", 4826, 0);
                EndWriteAttribute();
                WriteLiteral("></div>\r\n          <div class=\"user-info\">\r\n            <h6 class=\"user-name mb-1\">سامانه آنلاین اگزی</h6>\r\n");
                WriteLiteral("          </div>\r\n        </div>\r\n        <!-- Sidenav Nav-->\r\n        <ul class=\"sidenav-nav ps-0\">\r\n\r\n");
#nullable restore
#line 141 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml"
            if (User.Identity.IsAuthenticated)
             {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li><a href=\"profile/index\"><i class=\"lni lni-user\"></i> حساب کاربری شما</a></li>\r\n");
#nullable restore
#line 144 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml"

             }
             else
             {

#line default
#line hidden
#nullable disable
                WriteLiteral("                         <li><a href=\"login/login\"><i class=\"lni lni-user\"></i> ثبت نام | ورود</a></li>\r\n");
#nullable restore
#line 149 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml"



             }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"          <li><a href=""home/calenderlist""><i class=""lni lni-alarm lni-tada-effect""></i>تقویم نمایشگاهی <span class=""ms-3 badge badge-warning"">3</span></a></li>
          <li class=""suha-dropdown-menu""><a href=""#""><i class=""lni lni-list""></i>دسته بندی ها </a>
            <ul>
              <li><a href=""home/selectcat"">شرکت های غرفه سازی</a></li>
              <li><a href=""home/selectcat"">تامین کنندگان خدمات</a></li>
              <li><a href=""home/selectcat"">تامین کنندگان کالا</a></li>
              <li><a href=""home/selectcat"">تامین کنندگان نیروی انسانی </a></li>
              <li><a href=""home/selectcat"">تامین کنندگان ماشین الات </a></li>                       <li><a href=""flash-sale.html"">تامین کنندگان ماشین الات </a></li>
                            <li><a href=""home/selectcat"">   فری لنسرها </a></li>

            </ul>
          </li>
          <li><a href=""blog/category/1""><i class=""lni lni-empty-file""></i>مقالات</a></li>
                    <li><a href=""home/categoryshop""><i class=""lni lni-");
                WriteLiteral("shopify\"></i>فروشگاه</a></li>\r\n");
#nullable restore
#line 167 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml"
              if (User.Identity.IsAuthenticated)
             {

#line default
#line hidden
#nullable disable
                WriteLiteral("                         <li><a href=\"home/exit\"><i class=\"lni lni-exit\"></i>خروج</a></li>\r\n");
#nullable restore
#line 170 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml"

             }
          

#line default
#line hidden
#nullable disable
                WriteLiteral("        </ul>\r\n      </div>\r\n    </div>\r\n");
                WriteLiteral("\r\n    ");
#nullable restore
#line 178 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
                WriteLiteral(@" <!-- Internet Connection Status-->
    <div class=""internet-connection-status"" id=""internetStatus""></div>
    <!-- Footer Nav-->
   
    <!-- Footer Nav-->
    <div class=""footer-nav-area"" id=""footerNav"">
      <div class=""container h-100 px-0"">
        <div class=""suha-footer-nav h-100"">
          <ul class=""h-100 d-flex align-items-center justify-content-between ps-0"">
            <li class=""active""><a href=""/""><i class=""lni lni-home""></i>خانه</a></li>
            <li><a href=""home/selectcat""><i class=""lni lni-list""></i>دسته بندی ها</a></li>

");
#nullable restore
#line 193 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml"
              if (@HttpContextAccessor.HttpContext.Session.GetString("count") ==null)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                           <li><a href=\"#\"><i class=\"lni lni-shopping-basket\"></i>خرید</a></li>\r\n");
#nullable restore
#line 196 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml"
 
                                        }
                                        else{
                                           

#line default
#line hidden
#nullable disable
                WriteLiteral("                                             <li><a href=\"order/index\"><i class=\"lni lni-shopping-basket\"></i>(");
#nullable restore
#line 200 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml"
                                                                                                          Write(HttpContextAccessor.HttpContext.Session.GetString("count"));

#line default
#line hidden
#nullable disable
                WriteLiteral(")</a></li>                                      \r\n");
#nullable restore
#line 201 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml"

                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n           \r\n\r\n\r\n\r\n            <li><a href=\"home/calenderlist\"><i class=\"lni lni-calendar\"></i>تقویم</a></li>\r\n");
#nullable restore
#line 209 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                          <li><a href=\"profile/index\"><i class=\"lni lni-user\"></i>حساب کاربری</a></li>\r\n");
#nullable restore
#line 212 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml"

            }else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                              <li><a href=\"login/login\"><i class=\"lni lni-user\"></i>حساب کاربری</a></li>\r\n");
#nullable restore
#line 216 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml"
          
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"          </ul>
        </div>
      </div>
    </div>
    <!-- All JavaScript Files-->
    <script src=""js/bootstrap.bundle.min.js""></script>
    <script src=""js/jquery.min.js""></script>
    <script src=""js/waypoints.min.js""></script>
    <script src=""js/jquery.easing.min.js""></script>
    <script src=""js/owl.carousel.min.js""></script>
    <script src=""js/jquery.magnific-popup.min.js""></script>
    <script src=""js/jquery.counterup.min.js""></script>
    <script src=""js/jquery.countdown.min.js""></script>
    <script src=""js/jquery.passwordstrength.js""></script>
    <script src=""js/dark-mode-switch.js""></script>
    <script src=""js/no-internet.js""></script>
    <script src=""js/active.js""></script>
    <script src=""js/pwa.js""></script>
      <script src=""/previewimg/scriptimg.js""></script>
  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

</html>

<script>
function autocomplete(inp, arr) {
  /*the autocomplete function takes two arguments,
  the text field element and an array of possible autocompleted values:*/
  var currentFocus;
  /*execute a function when someone writes in the text field:*/
  inp.addEventListener(""input"", function(e) {
      var a, b, i, val = this.value;
      /*close any already open lists of autocompleted values*/
      closeAllLists();
      if (!val) { return false;}
      currentFocus = -1;
      /*create a DIV element that will contain the items (values):*/
      a = document.createElement(""DIV"");
      a.setAttribute(""id"", this.id + ""autocomplete-list"");
      a.setAttribute(""class"", ""autocomplete-items"");
      /*append the DIV element as a child of the autocomplete container:*/
      this.parentNode.appendChild(a);
      /*for each item in the array...*/
      for (i = 0; i < arr.length; i++) {
        /*check if the item starts with the same letters as the text field value:*/
        i");
            WriteLiteral(@"f (arr[i].substr(0, val.length).toUpperCase() == val.toUpperCase()) {
          /*create a DIV element for each matching element:*/
          b = document.createElement(""DIV"");
          /*make the matching letters bold:*/
          b.innerHTML = ""<strong>"" + arr[i].substr(0, val.length) + ""</strong>"";
          b.innerHTML += arr[i].substr(val.length);
          /*insert a input field that will hold the current array item's value:*/
          b.innerHTML += ""<input type='hidden' value='"" + arr[i] + ""'>"";
          /*execute a function when someone clicks on the item value (DIV element):*/
          b.addEventListener(""click"", function(e) {
              /*insert the value for the autocomplete text field:*/
              inp.value = this.getElementsByTagName(""input"")[0].value;
              /*close the list of autocompleted values,
              (or any other open lists of autocompleted values:*/
              closeAllLists();
          });
          a.appendChild(b);
        }
      }
  })");
            WriteLiteral(@";
  /*execute a function presses a key on the keyboard:*/
  inp.addEventListener(""keydown"", function(e) {
      var x = document.getElementById(this.id + ""autocomplete-list"");
      if (x) x = x.getElementsByTagName(""div"");
      if (e.keyCode == 40) {
        /*If the arrow DOWN key is pressed,
        increase the currentFocus variable:*/
        currentFocus++;
        /*and and make the current item more visible:*/
        addActive(x);
      } else if (e.keyCode == 38) { //up
        /*If the arrow UP key is pressed,
        decrease the currentFocus variable:*/
        currentFocus--;
        /*and and make the current item more visible:*/
        addActive(x);
      } else if (e.keyCode == 13) {
        /*If the ENTER key is pressed, prevent the form from being submitted,*/
        e.preventDefault();
        if (currentFocus > -1) {
          /*and simulate a click on the ""active"" item:*/
          if (x) x[currentFocus].click();
        }
      }
  });
  function addActive(x");
            WriteLiteral(@") {
    /*a function to classify an item as ""active"":*/
    if (!x) return false;
    /*start by removing the ""active"" class on all items:*/
    removeActive(x);
    if (currentFocus >= x.length) currentFocus = 0;
    if (currentFocus < 0) currentFocus = (x.length - 1);
    /*add class ""autocomplete-active"":*/
    x[currentFocus].classList.add(""autocomplete-active"");
  }
  function removeActive(x) {
    /*a function to remove the ""active"" class from all autocomplete items:*/
    for (var i = 0; i < x.length; i++) {
      x[i].classList.remove(""autocomplete-active"");
    }
  }
  function closeAllLists(elmnt) {
    /*close all autocomplete lists in the document,
    except the one passed as an argument:*/
    var x = document.getElementsByClassName(""autocomplete-items"");
    for (var i = 0; i < x.length; i++) {
      if (elmnt != x[i] && elmnt != inp) {
        x[i].parentNode.removeChild(x[i]);
      }
    }
  }
  /*execute a function when someone clicks in the document:*/
  document");
            WriteLiteral(".addEventListener(\"click\", function (e) {\r\n      closeAllLists(e.target);\r\n  });\r\n}\r\n\r\n\r\n \r\nvar countries =");
#nullable restore
#line 341 "c:\Users\apple\Desktop\cafe-danesh\pransa\Areas\Mobile\Views\shared\_Layout.cshtml"
          Write(Html.Raw(JsonConvert.SerializeObject(@menu.find)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";;
/*An array containing all the country names in the world:*/
/*var countries 


/*initiate the autocomplete function on the ""myInput"" element, and pass along the countries array as possible autocomplete values:*/
autocomplete(document.getElementById(""myInput""), countries);
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591