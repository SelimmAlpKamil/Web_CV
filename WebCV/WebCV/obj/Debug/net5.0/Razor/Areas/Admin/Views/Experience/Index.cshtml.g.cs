#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Experience\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "171c83716c18e9b4b13be11874ddd773130955e0483eb216ac7de8baffcaf040"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Experience_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Experience/Index.cshtml")]
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
#line 1 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\_ViewImports.cshtml"
using WebCV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\_ViewImports.cshtml"
using WebCV.Areas.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"171c83716c18e9b4b13be11874ddd773130955e0483eb216ac7de8baffcaf040", @"/Areas/Admin/Views/Experience/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5eb060aecd846ceb4dbabfb1c6906820ed26f2d3e7c07cd1ec9987716624c438", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Experience_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concreate.Experience>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Experience\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<Table class=\"table table-bordred\">\r\n    <tr>\r\n        <th>Resim</th>\r\n        <th>Id</th>\r\n        <th>Başlık</th>\r\n        <th>Tarih</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Experience\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 442, "\"", 469, 1);
#nullable restore
#line 21 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Experience\Index.cshtml"
WriteAttributeValue("", 448, x.ExperienceImageURL, 448, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50px\" width=\"50px\" />\r\n            </td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Experience\Index.cshtml"
           Write(x.ExperienceId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Experience\Index.cshtml"
           Write(x.ExperienceTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Experience\Index.cshtml"
           Write(x.ExperienceDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", "  href=\"", 676, "\"", 734, 2);
            WriteAttributeValue("", 684, "/Admin/Experience/DeleteExperience/", 684, 35, true);
#nullable restore
#line 27 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Experience\Index.cshtml"
WriteAttributeValue("", 719, x.ExperienceId, 719, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 831, "\"", 889, 2);
            WriteAttributeValue("", 838, "/Admin/Experience/UppdateExperience/", 838, 36, true);
#nullable restore
#line 30 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Experience\Index.cshtml"
WriteAttributeValue("", 874, x.ExperienceId, 874, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Güncelle</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Experience\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</Table>\r\n\r\n<a style=\"margin-top:20px; margin-bottom:20px\" href=\"/Admin/Experience/AddExperience\" class=\"btn btn-outline-primary\">Ekle</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concreate.Experience>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
