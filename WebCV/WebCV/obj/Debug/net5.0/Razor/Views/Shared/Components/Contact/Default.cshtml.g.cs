#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\Shared\Components\Contact\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "873c78a39d09b2457eda617856b2387c60c42d98d7a022e3fdba15673c95f52a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Contact_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Contact/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"873c78a39d09b2457eda617856b2387c60c42d98d7a022e3fdba15673c95f52a", @"/Views/Shared/Components/Contact/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fe569253b3a1b9847886bb2a8901e640a4da463c5661d1a0b271fb8a57c15568", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Contact_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""section px-2 px-lg-4 pb-4 pt-5 mb-5"" id=""contact"">
    <div class=""container-narrow"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">İletişim</h2>
        </div>
        <div class=""row"">

            ");
#nullable restore
#line 13 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\Shared\Components\Contact\Default.cshtml"
       Write(await Component.InvokeAsync("ContactSend"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 15 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\Shared\Components\Contact\Default.cshtml"
       Write(await Component.InvokeAsync("ContactUs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            \r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
