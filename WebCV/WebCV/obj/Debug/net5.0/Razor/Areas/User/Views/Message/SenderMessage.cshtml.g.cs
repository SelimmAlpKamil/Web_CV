#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Message\SenderMessage.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f8ca812ac8009da3886eb13aafd952d040c79b2a906f0ef7ef86807777b66630"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Message_SenderMessage), @"mvc.1.0.view", @"/Areas/User/Views/Message/SenderMessage.cshtml")]
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
#line 1 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\_ViewImports.cshtml"
using WebCV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\_ViewImports.cshtml"
using WebCV.Areas.User;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f8ca812ac8009da3886eb13aafd952d040c79b2a906f0ef7ef86807777b66630", @"/Areas/User/Views/Message/SenderMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3a190b191209e9a91bc520db64fc61403b6c74fc5e919ac9dfbfc37965251116", @"/Areas/User/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_User_Views_Message_SenderMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concreate.Message>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Message\SenderMessage.cshtml"
  
    ViewData["Title"] = "SenderMessage";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Message\SenderMessage.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table-bordered\" style=\"margin:20px\">\r\n        <tr>\r\n            <td>Id</td>\r\n            <td>Gönderilen</td>\r\n            <td>Başlık</td>\r\n            <td>Tarih</td>\r\n            <td>Sil</td>\r\n            <td>Detay</td>\r\n        </tr>\r\n");
#nullable restore
#line 19 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Message\SenderMessage.cshtml"
         foreach (var x in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Message\SenderMessage.cshtml"
               Write(x.MessageId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Message\SenderMessage.cshtml"
               Write(x.Recever);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Message\SenderMessage.cshtml"
               Write(x.MessageSubject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Message\SenderMessage.cshtml"
               Write(x.MessageDateTime.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 733, "\"", 786, 2);
            WriteAttributeValue("", 740, "/User/Message/DeleteMessageSender/", 740, 34, true);
#nullable restore
#line 27 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Message\SenderMessage.cshtml"
WriteAttributeValue("", 774, x.MessageId, 774, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a>\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 895, "\"", 942, 2);
            WriteAttributeValue("", 902, "/User/Message/MessageDetail/", 902, 28, true);
#nullable restore
#line 30 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Message\SenderMessage.cshtml"
WriteAttributeValue("", 930, x.MessageId, 930, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Detay</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Message\SenderMessage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 35 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Message\SenderMessage.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Gönderilen Mesaj Yoktur</h2>\r\n");
#nullable restore
#line 39 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Message\SenderMessage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a href=\"/User/Message/AddMessage\" class=\"btn btn-outline-info\">Mesaj Gönder</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concreate.Message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
