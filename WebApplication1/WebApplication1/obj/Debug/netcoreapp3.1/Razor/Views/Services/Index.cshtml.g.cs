#pragma checksum "C:\Users\SONY\Desktop\4-5-23\WebApplication1\WebApplication1\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dff838b0eb3b79473756d843699afc717c074f37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
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
#line 1 "C:\Users\SONY\Desktop\4-5-23\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SONY\Desktop\4-5-23\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SONY\Desktop\4-5-23\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff838b0eb3b79473756d843699afc717c074f37", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1653c4935ed204a0ba7941e3c8dbbf94c531f33", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- ======= Services Section ======= -->\r\n<main>\r\n    <section id=\"services\" class=\"services\">\r\n        <div class=\"container\">\r\n\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\SONY\Desktop\4-5-23\WebApplication1\WebApplication1\Views\Services\Index.cshtml"
                 foreach (var srv in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch\">\r\n                        <div class=\"icon-box\">\r\n                            <div class=\"icon\"><i");
            BeginWriteAttribute("class", " class=\"", 425, "\"", 442, 1);
#nullable restore
#line 12 "C:\Users\SONY\Desktop\4-5-23\WebApplication1\WebApplication1\Views\Services\Index.cshtml"
WriteAttributeValue("", 433, srv.Icon, 433, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></div>\r\n                            <h4><a");
            BeginWriteAttribute("href", " href=\"", 490, "\"", 497, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "C:\Users\SONY\Desktop\4-5-23\WebApplication1\WebApplication1\Views\Services\Index.cshtml"
                                      Write(srv.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                            <p>");
#nullable restore
#line 14 "C:\Users\SONY\Desktop\4-5-23\WebApplication1\WebApplication1\Views\Services\Index.cshtml"
                          Write(srv.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 17 "C:\Users\SONY\Desktop\4-5-23\WebApplication1\WebApplication1\Views\Services\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n    </section><!-- End Services Section -->\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
