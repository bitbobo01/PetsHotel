#pragma checksum "D:\PetsHotel\PetsHotel\PetsHotel\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2235fbd90b0b609f9752ff6baab5af2becacb86a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "D:\PetsHotel\PetsHotel\PetsHotel\Views\_ViewImports.cshtml"
using PetsHotel;

#line default
#line hidden
#line 2 "D:\PetsHotel\PetsHotel\PetsHotel\Views\_ViewImports.cshtml"
using PetsHotel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2235fbd90b0b609f9752ff6baab5af2becacb86a", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76d2fd4f19543d7a4e4a53b915612e86cd4d6d19", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 878, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2235fbd90b0b609f9752ff6baab5af2becacb86a3303", async() => {
                BeginContext(31, 865, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>Portfolio Template</title>

    <!-- mobile responsive meta -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">

    <!-- ** Plugins Needed for the Project ** -->
    <!-- Bootstrap -->
    <link rel=""stylesheet"" href=""plugins/bootstrap/bootstrap.min.css"">
    <!-- slick slider -->
    <link rel=""stylesheet"" href=""plugins/slick/slick.css"">
    <!-- themefy-icon -->
    <link rel=""stylesheet"" href=""plugins/themify-icons/themify-icons.css"">

    <!-- Main Stylesheet -->
    <link href=""css/style.css"" rel=""stylesheet"">

    <!--Favicon-->
    <link rel=""shortcut icon"" href=""images/favicon.ico"" type=""image/x-icon"">
    <link rel=""icon"" href=""images/favicon.ico"" type=""image/x-icon"">

");
                EndContext();
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
            EndContext();
            BeginContext(903, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(907, 3512, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2235fbd90b0b609f9752ff6baab5af2becacb86a5390", async() => {
                BeginContext(913, 1460, true);
                WriteLiteral(@"
    <header class=""navigation fixed-top"">
        <nav class=""navbar navbar-expand-lg navbar-dark"">
            <a class=""navbar-brand font-tertiary h3"" href=""index.html""><img src=""images/logo.png"" alt=""Myself""></a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navigation""
                    aria-controls=""navigation"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>

            <div class=""collapse navbar-collapse text-center"" id=""navigation"">
                <ul class=""navbar-nav ml-auto"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""trang-chu"">Home</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""thong-tin"">about</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href");
                WriteLiteral(@"=""blog.html"">Blog</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""portfolio.html"">Portfolio</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""contact.html"">Contact</a>
                    </li>
                </ul>
            </div>
        </nav>
    </header>

            ");
                EndContext();
                BeginContext(2374, 12, false);
#line 59 "D:\PetsHotel\PetsHotel\PetsHotel\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2386, 10, true);
                WriteLiteral("\r\n    \r\n\r\n");
                EndContext();
                BeginContext(2640, 1728, true);
                WriteLiteral(@"    <footer class=""bg-dark footer-section"">
        <div class=""section"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <h5 class=""text-light"">Email</h5>
                        <p class=""text-white paragraph-lg font-secondary"">steve.fruits@email.com</p>
                    </div>
                    <div class=""col-md-4"">
                        <h5 class=""text-light"">Phone</h5>
                        <p class=""text-white paragraph-lg font-secondary"">+880 2544 658 256</p>
                    </div>
                    <div class=""col-md-4"">
                        <h5 class=""text-light"">Address</h5>
                        <p class=""text-white paragraph-lg font-secondary"">125/A, CA Commercial Area, California, USA</p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""border-top text-center border-dark py-5"">
            <p class=""mb-0 text-light");
                WriteLiteral(@""">
                Copyright ©
                <script>
                    var CurrentYear = new Date().getFullYear()
                    document.write(CurrentYear)
                </script> a theme by <a href=""themefisher.com"">themefisher.com</a>
            </p>
        </div>
    </footer>
        
    <script src=""plugins/jQuery/jquery.min.js""></script>
    <!-- Bootstrap JS -->
    <script src=""plugins/bootstrap/bootstrap.min.js""></script>
    <!-- slick slider -->
    <script src=""plugins/slick/slick.min.js""></script>
    <!-- filter -->
    <script src=""plugins/shuffle/shuffle.min.js""></script>

    <!-- Main Script -->
    <script src=""js/script.js""></script>

    ");
                EndContext();
                BeginContext(4369, 41, false);
#line 108 "D:\PetsHotel\PetsHotel\PetsHotel\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(4410, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(4419, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
