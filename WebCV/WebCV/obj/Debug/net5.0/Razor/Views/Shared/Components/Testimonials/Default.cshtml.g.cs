#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\Shared\Components\Testimonials\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "12da22b61ddd4f8738c2c68416d9f82a1e2d92d4ef9f9e32e39cdaf701bb8a71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Testimonials_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Testimonials/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\_ViewImports.cshtml"
using WebCV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\_ViewImports.cshtml"
using WebCV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"12da22b61ddd4f8738c2c68416d9f82a1e2d92d4ef9f9e32e39cdaf701bb8a71", @"/Views/Shared/Components/Testimonials/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fe569253b3a1b9847886bb2a8901e640a4da463c5661d1a0b271fb8a57c15568", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Testimonials_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concreate.Testimonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<div class=\"section px-3 px-lg-4 pt-5\" id=\"testimonials\">\r\n    <div class=\"container-narrow\">\r\n        <div class=\"text-center mb-5\">\r\n            <h2 class=\"marker marker-center\">Referanslarım</h2>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 18 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\Shared\Components\Testimonials\Default.cshtml"
             foreach(var x in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 mb-5\" data-aos=\"fade-right\" data-aos-delay=\"100\">\r\n                    <div class=\"d-flex ms-md-3\"><span><i class=\"fas fa-2x fa-quote-left\"></i></span><span class=\"m-2\">");
#nullable restore
#line 21 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\Shared\Components\Testimonials\Default.cshtml"
                                                                                                                 Write(x.TestimonialComment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                    <div class=\"d-flex justify-content-end align-items-end\">\r\n                        <div class=\"text-end me-2\">\r\n                            <div class=\"fw-bolder\">");
#nullable restore
#line 24 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\Shared\Components\Testimonials\Default.cshtml"
                                              Write(x.TestimonialName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"text-small\">");
#nullable restore
#line 25 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\Shared\Components\Testimonials\Default.cshtml"
                                               Write(x.TestimonialCompany);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div><img class=\"me-md-3 rounded\"");
            BeginWriteAttribute("src", " src=\"", 1076, "\"", 1104, 1);
#nullable restore
#line 26 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\Shared\Components\Testimonials\Default.cshtml"
WriteAttributeValue("", 1082, x.TestimonialImageURL, 1082, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"96\" height=\"96\" alt=\"client 1\" />\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 29 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\Shared\Components\Testimonials\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concreate.Testimonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
