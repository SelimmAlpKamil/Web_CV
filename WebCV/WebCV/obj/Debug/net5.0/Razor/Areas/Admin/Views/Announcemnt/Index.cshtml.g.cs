#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Announcemnt\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7316c7c83fdd15c621a0c6b31425b8416d9ec293aa0b45d4f6bad87fe7104016"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Announcemnt_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Announcemnt/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7316c7c83fdd15c621a0c6b31425b8416d9ec293aa0b45d4f6bad87fe7104016", @"/Areas/Admin/Views/Announcemnt/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5eb060aecd846ceb4dbabfb1c6906820ed26f2d3e7c07cd1ec9987716624c438", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Announcemnt_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concreate.Announcement>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Announcemnt\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 13 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Announcemnt\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Başlık</th>\r\n            <th>İçerik</th>\r\n            <th>Sil</th>\r\n            <th>Güncelle</th>\r\n        </tr>\r\n");
#nullable restore
#line 23 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Announcemnt\Index.cshtml"
         foreach (var x in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Announcemnt\Index.cshtml"
               Write(x.AnnouncementId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Announcemnt\Index.cshtml"
               Write(x.AnnouncementTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Announcemnt\Index.cshtml"
               Write(x.AnnouncementSubject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 690, "\"", 752, 2);
            WriteAttributeValue("", 697, "/Admin/Announcemnt/DeleteAnnouncement/", 697, 38, true);
#nullable restore
#line 32 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Announcemnt\Index.cshtml"
WriteAttributeValue("", 735, x.AnnouncementId, 735, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a>\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 861, "\"", 922, 2);
            WriteAttributeValue("", 868, "/Admin/Announcemnt/UpdateAnnouncemnt/", 868, 37, true);
#nullable restore
#line 35 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Announcemnt\Index.cshtml"
WriteAttributeValue("", 905, x.AnnouncementId, 905, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Güncelle</a>\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Announcemnt\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 41 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Announcemnt\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Gösterilcek bir duyuru yok</h2>\r\n");
#nullable restore
#line 45 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Announcemnt\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a href=\"/Admin/Announcemnt/AddAnnouncement\" class=\"btn btn-outline-primary\">Ekle</a>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concreate.Announcement>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
