#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7f1768e96095a4ca3d1038070f7a49d6e24b46a78c795a119559e5bbcd3d4c6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminLayoutPartial__AdminSideBar), @"mvc.1.0.view", @"/Views/AdminLayoutPartial/_AdminSideBar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7f1768e96095a4ca3d1038070f7a49d6e24b46a78c795a119559e5bbcd3d4c6a", @"/Views/AdminLayoutPartial/_AdminSideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fe569253b3a1b9847886bb2a8901e640a4da463c5661d1a0b271fb8a57c15568", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminLayoutPartial__AdminSideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<nav class=""sidenav navbar navbar-vertical  fixed-left  navbar-expand-xs navbar-light bg-white"" id=""sidenav-main"">
    <div class=""scrollbar-inner"">


        <div class=""navbar-inner"">
            <!-- Collapse -->
            <div class=""collapse navbar-collapse"" id=""sidenav-collapse-main"">
                <!-- Nav items -->
                <ul class=""navbar-nav"">
                    

");
#nullable restore
#line 16 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                     if(TempData["dashboardActive"] == "active"){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""/Admin/Dashborad/Index"">
                                <i class=""ni ni-tv-2 text-primary""></i>
                                <span class=""nav-link-text"">Dashboard</span>
                            </a>
                        </li>
");
#nullable restore
#line 23 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link "" href=""/Admin/Dashborad/Index"">
                                <i class=""ni ni-tv-2 text-primary""></i>
                                <span class=""nav-link-text"">Dashboard</span>
                            </a>
                        </li>
");
#nullable restore
#line 31 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                     if (TempData["SenderActive"] == "active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""/Admin/Message/SenderMessage"">
                                <i class=""ni ni-bag-17 text-primary""></i>
                                <span class=""nav-link-text"">Gönderilen Mesajlar</span>
                            </a>
                        </li>
");
#nullable restore
#line 41 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link "" href=""/Admin/Message/SenderMessage"">
                                <i class=""ni ni-bag-17 text-primary""></i>
                                <span class=""nav-link-text"">Gönderilen Mesajlar</span>
                            </a>
                        </li>
");
#nullable restore
#line 50 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                     if (TempData["RecevirActive"] == "active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link active "" href=""/Admin/Message/RecevirMessage"">
                                <i class=""ni ni-bag-17 text-red""></i>
                                <span class=""nav-link-text"">Gelen Mesaj</span>
                            </a>
                        </li>
");
#nullable restore
#line 61 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link "" href=""/Admin/Message/RecevirMessage"">
                                <i class=""ni ni-bag-17 text-red""></i>
                                <span class=""nav-link-text"">Gelen Mesaj</span>
                            </a>
                        </li>
");
#nullable restore
#line 70 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 72 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                     if (TempData["socialMediaActive"] == "active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link active "" href=""/Admin/SocialMedia/Index"">
                                <i class=""ni ni-air-baloon text-green""></i>
                                <span class=""nav-link-text"">Sosyal Medya</span>
                            </a>
                        </li>
");
#nullable restore
#line 80 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link "" href=""/Admin/SocialMedia/Index"">
                                <i class=""ni ni-air-baloon text-green""></i>
                                <span class=""nav-link-text"">Sosyal Medya</span>
                            </a>
                        </li>
");
#nullable restore
#line 89 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 91 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                     if (TempData["featureActive"] == "active")
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""/Admin/Feature/Index"">
                                <i class=""ni ni-planet text-orange""></i>
                                <span class=""nav-link-text"">Öne Çıkanlar</span>
                            </a>
                        </li>
");
#nullable restore
#line 100 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Admin/Feature/Index"">
                                <i class=""ni ni-planet text-orange""></i>
                                <span class=""nav-link-text"">Öne Çıkanlar</span>
                            </a>
                        </li>
");
#nullable restore
#line 108 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 110 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                     if (TempData["aboutActive"] == "active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""/Admin/About/Index"">
                                <i class=""ni ni-pin-3 text-primary""></i>
                                <span class=""nav-link-text"">Hakkımızda</span>
                            </a>
                        </li>
");
#nullable restore
#line 118 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Admin/About/Index"">
                                <i class=""ni ni-pin-3 text-primary""></i>
                                <span class=""nav-link-text"">Hakkımızda</span>
                            </a>
                        </li>
");
#nullable restore
#line 126 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                     if (TempData["serviceActive"] == "active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""/Admin/Services/Index"">
                                <i class=""ni ni-single-02 text-yellow""></i>
                                <span class=""nav-link-text"">Hizmetler</span>
                            </a>
                        </li>
");
#nullable restore
#line 136 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Admin/Services/Index"">
                                <i class=""ni ni-single-02 text-yellow""></i>
                                <span class=""nav-link-text"">Hizmetler</span>
                            </a>
                        </li>
");
#nullable restore
#line 144 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                     if (TempData["skillActive"] == "active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""/Admin/Skill/Index"">
                                <i class=""ni ni-bullet-list-67 text-red""></i>
                                <span class=""nav-link-text"">Yetenekler</span>
                            </a>
                        </li>
");
#nullable restore
#line 153 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link "" href=""/Admin/Skill/Index"">
                                <i class=""ni ni-bullet-list-67 text-red""></i>
                                <span class=""nav-link-text"">Yetenekler</span>
                            </a>
                        </li>
");
#nullable restore
#line 162 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                     if (TempData["portfolioActive"] == "active"){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""/Admin/Portfolio/Index"">
                                <i class=""ni ni-key-25 text-info""></i>
                                <span class=""nav-link-text"">Projeler</span>
                            </a>
                        </li>
");
#nullable restore
#line 170 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Admin/Portfolio/Index"">
                                <i class=""ni ni-key-25 text-info""></i>
                                <span class=""nav-link-text"">Projeler</span>
                            </a>
                        </li>
");
#nullable restore
#line 178 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 179 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                     if (TempData["experienceActive"] == "active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""/Admin/Experience/Index"">
                                <i class=""ni ni-badge text-yellow""></i>
                                <span class=""nav-link-text"">Deneyim</span>
                            </a>
                        </li>
");
#nullable restore
#line 187 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Admin/Experience/Index"">
                                <i class=""ni ni-badge text-yellow""></i>
                                <span class=""nav-link-text"">Deneyim</span>
                            </a>
                        </li>
");
#nullable restore
#line 196 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 197 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                     if (TempData["studentActive"] == "active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""/Admin/Student/Index"">
                                <i class=""ni ni-archive-2 text-blue""></i>
                                <span class=""nav-link-text"">Eğitim</span>
                            </a>
                        </li>
");
#nullable restore
#line 205 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Admin/Student/Index"">
                                <i class=""ni ni-archive-2 text-blue""></i>
                                <span class=""nav-link-text"">Eğitim</span>
                            </a>
                        </li>
");
#nullable restore
#line 213 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 214 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                     if (TempData["testimonialActive"] == "active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""/Admin/Testimonial/Index"">
                                <i class=""ni ni-user-run text-brown""></i>
                                <span class=""nav-link-text"">Referanslar</span>
                            </a>
                        </li>
");
#nullable restore
#line 222 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link "" href=""/Admin/Testimonial/Index"">
                                <i class=""ni ni-user-run text-brown""></i>
                                <span class=""nav-link-text"">Referanslar</span>
                            </a>
                        </li>
");
#nullable restore
#line 230 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 231 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                     if (TempData["contactActive"] == "active")
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""/Admin/Contact/Index"">
                                <i class=""ni ni-world-2 text-orange""></i>
                                <span class=""nav-link-text"">Gelen İletişim Mesajları</span>
                            </a>
                        </li>
");
#nullable restore
#line 240 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Admin/Contact/Index"">
                                <i class=""ni ni-world-2 text-orange""></i>
                                <span class=""nav-link-text"">Gelen İletişim Mesajları</span>
                            </a>
                        </li>
");
#nullable restore
#line 248 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 249 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                     if (TempData["roleActive"] == "active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""/Admin/Role/Index"">
                                <i class=""ni ni-world text-green""></i>
                                <span class=""nav-link-text"">Role İşlemleri</span>
                            </a>
                        </li>
");
#nullable restore
#line 257 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Admin/Role/Index"">
                                <i class=""ni ni-world text-green""></i>
                                <span class=""nav-link-text"">Role İşlemleri</span>
                            </a>
                        </li>
");
#nullable restore
#line 265 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 266 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                     if (TempData["announcemntActive"] == "active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""/Admin/Announcemnt/Index"">
                                <i class=""ni ni-app text-blue""></i>
                                <span class=""nav-link-text"">Duyuru</span>
                            </a>
                        </li>
");
#nullable restore
#line 274 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Admin/Announcemnt/Index"">
                                <i class=""ni ni-app text-blue""></i>
                                <span class=""nav-link-text"">Duyuru</span>
                            </a>
                        </li>
");
#nullable restore
#line 283 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 285 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                     if (TempData["profileActive"] == "active"){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li class=""nav-item"">
                            <a class=""nav-link active"" href=""/Admin/Profile/Index"">
                            <i class=""ni ni-settings text-pink""></i>
                            <span class=""nav-link-text"">Ayarlar</span>
                        </a>
                    </li>
");
#nullable restore
#line 292 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Admin/Profile/Index"">
                                <i class=""ni ni-settings text-pink""></i>
                                <span class=""nav-link-text"">Ayarlar</span>
                            </a>
                        </li>
");
#nullable restore
#line 299 "C:\Users\selim\OneDrive\Masaüstü\C#\WebCV\WebCV\Views\AdminLayoutPartial\_AdminSideBar.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Admin/Login/SingOut"">
                            <i class=""ni ni-fat-remove text-purple""></i>
                            <span class=""nav-link-text"">Çıkış</span>
                        </a>
                    </li>
                </ul>

            </div>
        </div>
    </div>
</nav>
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
