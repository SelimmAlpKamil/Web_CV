#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Dashborad\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9f0de7e98cdb933b602a3bc79d9ada489936b9a5ae87f17e3a7357f0d727d071"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Dashborad_Index), @"mvc.1.0.view", @"/Areas/User/Views/Dashborad/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9f0de7e98cdb933b602a3bc79d9ada489936b9a5ae87f17e3a7357f0d727d071", @"/Areas/User/Views/Dashborad/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3a190b191209e9a91bc520db64fc61403b6c74fc5e919ac9dfbfc37965251116", @"/Areas/User/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_User_Views_Dashborad_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Dashborad\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""header-body"">
        <div class=""row align-items-center py-4"">
        </div>
        <!-- Card stats -->
        <div class=""row"">

            <div class=""col-xl-12 col-md-24"">
                <div class=""card card-stats"">
                    <!-- Card body -->
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <h5 class=""card-title text-uppercase text-muted mb-0"">Hoş geldin</h5>
                                <span class=""h2 font-weight-bold mb-0"">");
#nullable restore
#line 21 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Dashborad\Index.cshtml"
                                                                  Write(ViewBag.userName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                            <div class=""col-auto"">
                                <div class=""icon icon-shape bg-gradient-red text-white rounded-circle shadow"">
                                    <i class=""ni ni-active-40""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-xl-12 col-md-24"">
                <div class=""card card-stats"">
                    <!-- Card body -->
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <h5 class=""card-title text-uppercase text-muted mb-0"">Hava Durumu</h5>
                                <span class=""h2 font-weight-bold mb-0"">");
#nullable restore
#line 40 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Dashborad\Index.cshtml"
                                                                  Write(ViewBag.wether);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" °</span>
                            </div>
                            <div class=""col-auto"">
                                <div class=""icon icon-shape bg-gradient-blue text-white rounded-circle shadow"">
                                    <i class=""ni ni-active-40""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>




            <div class=""col-xl-12 col-md-24"">
                <div class=""card card-stats"">
                    <!-- Card body -->
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <h5 class=""card-title text-uppercase text-muted mb-0"">Duyuru Sayısı</h5>
                                <span class=""h2 font-weight-bold mb-0"">");
#nullable restore
#line 62 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\User\Views\Dashborad\Index.cshtml"
                                                                  Write(ViewBag.AnnouncementCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                            <div class=""col-auto"">
                                <div class=""icon icon-shape bg-gradient-blue text-white rounded-circle shadow"">
                                    <i class=""ni ni-planet""></i>
                                  
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>

        </div>
    </div>
</div>

");
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
