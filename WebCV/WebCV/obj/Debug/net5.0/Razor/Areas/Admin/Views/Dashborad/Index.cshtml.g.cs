#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Dashborad\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "af36adf0e233bcfeb5c3246b55a982c4b99e841f60c99a4e70ee320b3eacdc53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashborad_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashborad/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"af36adf0e233bcfeb5c3246b55a982c4b99e841f60c99a4e70ee320b3eacdc53", @"/Areas/Admin/Views/Dashborad/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5eb060aecd846ceb4dbabfb1c6906820ed26f2d3e7c07cd1ec9987716624c438", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Dashborad_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Dashborad\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

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

            <div class=""col-xl-3 col-md-6"">
                <div class=""card card-stats"">
                    <!-- Card body -->
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <h5 class=""card-title text-uppercase text-muted mb-0"">Okunmamış Gelen iletişim mesaj sayısı Sayısı</h5>
                                <span class=""h2 font-weight-bold mb-0"">");
#nullable restore
#line 23 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Dashborad\Index.cshtml"
                                                                  Write(ViewBag.activeMessageCount);

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

            <div class=""col-xl-3 col-md-6"">
                <div class=""card card-stats"">
                    <!-- Card body -->
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <h5 class=""card-title text-uppercase text-muted mb-0"">Okunmuş Gelen iletişim mesaj Sayısı</h5>
                                <span class=""h2 font-weight-bold mb-0"">");
#nullable restore
#line 42 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Dashborad\Index.cshtml"
                                                                  Write(ViewBag.pasifMessageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                            <div class=""col-auto"">
                                <div class=""icon icon-shape bg-gradient-info text-white rounded-circle shadow"">
                                    <i class=""ni ni-planet""></i>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>

            <div class=""col-xl-3 col-md-6"">
                <div class=""card card-stats"">
                    <!-- Card body -->
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <h5 class=""card-title text-uppercase text-muted mb-0"">Proje Sayısı</h5>
                                <span class=""h2 font-weight-bold mb-0"">");
#nullable restore
#line 62 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Dashborad\Index.cshtml"
                                                                  Write(ViewBag.projeCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                            <div class=""col-auto"">
                                <div class=""icon icon-shape bg-gradient-orange text-white rounded-circle shadow"">
                                    <i class=""ni ni-chart-pie-35""></i>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
            <div class=""col-xl-3 col-md-6"">
                <div class=""card card-stats"">
                    <!-- Card body -->
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <h5 class=""card-title text-uppercase text-muted mb-0"">Referans Sayısı</h5>
                                <span class=""h2 font-weight-bold mb-0"">");
#nullable restore
#line 81 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Dashborad\Index.cshtml"
                                                                  Write(ViewBag.testimoniolCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                            <div class=""col-auto"">
                                <div class=""icon icon-shape bg-gradient-green text-white rounded-circle shadow"">
                                    <i class=""ni ni-money-coins""></i>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>

            <div class=""col-xl-3 col-md-6"">
                <div class=""card card-stats"">
                    <!-- Card body -->
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <h5 class=""card-title text-uppercase text-muted mb-0"">Yetenek Sayısı</h5>
                                <span class=""h2 font-weight-bold mb-0"">");
#nullable restore
#line 101 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Dashborad\Index.cshtml"
                                                                  Write(ViewBag.skilCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                            <div class=""col-auto"">
                                <div class=""icon icon-shape bg-gradient-info text-white rounded-circle shadow"">
                                    <i class=""ni ni-chart-bar-32""></i>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>

            <div class=""col-xl-3 col-md-6"">
                <div class=""card card-stats"">
                    <!-- Card body -->
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <h5 class=""card-title text-uppercase text-muted mb-0"">Deneyim Sayısı</h5>
                                <span class=""h2 font-weight-bold mb-0"">");
#nullable restore
#line 121 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Dashborad\Index.cshtml"
                                                                  Write(ViewBag.experienceCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                            <div class=""col-auto"">
                                <div class=""icon icon-shape bg-red text-white rounded-circle shadow"">
                                    <i class=""ni ni-shop""></i>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>

            <div class=""col-xl-3 col-md-6"">
                <div class=""card card-stats"">
                    <!-- Card body -->
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <h5 class=""card-title text-uppercase text-muted mb-0"">Okul Sayısı</h5>
                                <span class=""h2 font-weight-bold mb-0"">");
#nullable restore
#line 141 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Dashborad\Index.cshtml"
                                                                  Write(ViewBag.studentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                            <div class=""col-auto"">
                                <div class=""icon icon-shape bg-blue text-white rounded-circle shadow"">
                                    <i class=""ni ni-bus-front-12""></i>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>

            <div class=""col-xl-3 col-md-6"">
                <div class=""card card-stats"">
                    <!-- Card body -->
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <h5 class=""card-title text-uppercase text-muted mb-0"">Dal Sayısı</h5>
                                <span class=""h2 font-weight-bold mb-0"">");
#nullable restore
#line 161 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Dashborad\Index.cshtml"
                                                                  Write(ViewBag.serviceCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                            <div class=""col-auto"">
                                <div class=""icon icon-shape bg-green text-white rounded-circle shadow"">
                                    <i class=""ni ni-app""></i>
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
#nullable restore
#line 178 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Dashborad\Index.cshtml"
Write(await Component.InvokeAsync("AdminAddToDoList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 180 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Areas\Admin\Views\Dashborad\Index.cshtml"
Write(await Component.InvokeAsync("AdminToDoList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
