#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Skill\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "df0fed4e37475b85844df3cf2977ca3181a96782e5734aac8ff8b4a6805f68ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Skill_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Skill/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"df0fed4e37475b85844df3cf2977ca3181a96782e5734aac8ff8b4a6805f68ae", @"/Areas/Admin/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5eb060aecd846ceb4dbabfb1c6906820ed26f2d3e7c07cd1ec9987716624c438", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concreate.Skill>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Skill\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<Table class=\"table table-bordred\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Name</th>\r\n        <th>Değer</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Skill\Index.cshtml"
     foreach(var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Skill\Index.cshtml"
           Write(x.SkillID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Skill\Index.cshtml"
           Write(x.SkillName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Skill\Index.cshtml"
           Write(x.SkillValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a hred=\"#\"");
            BeginWriteAttribute("href", " href=\"", 521, "\"", 563, 2);
            WriteAttributeValue("", 528, "/Admin/Skill/DeleteSkill/", 528, 25, true);
#nullable restore
#line 23 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Skill\Index.cshtml"
WriteAttributeValue("", 553, x.SkillID, 553, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a>\r\n            </td>\r\n            <td>\r\n                <a hred=\"#\"");
            BeginWriteAttribute("href", " href=\"", 669, "\"", 712, 2);
            WriteAttributeValue("", 676, "/Admin/Skill/UppdateSkill/", 676, 26, true);
#nullable restore
#line 26 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Skill\Index.cshtml"
WriteAttributeValue("", 702, x.SkillID, 702, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Güncelle</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Skill\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</Table>\r\n\r\n<a style=\"margin-top:20px; margin-bottom:20px\" href=\"/Admin/Skill/AddSkill\" class=\"btn btn-outline-primary\">Ekle</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concreate.Skill>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
