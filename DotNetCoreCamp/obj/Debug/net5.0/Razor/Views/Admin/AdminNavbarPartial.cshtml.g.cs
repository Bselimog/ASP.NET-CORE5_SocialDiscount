#pragma checksum "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Admin\AdminNavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddb1b896382f3f40af9b9d392063f7aa5aed7a0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminNavbarPartial), @"mvc.1.0.view", @"/Views/Admin/AdminNavbarPartial.cshtml")]
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
#line 1 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\_ViewImports.cshtml"
using DotNetCoreCamp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\_ViewImports.cshtml"
using DotNetCoreCamp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddb1b896382f3f40af9b9d392063f7aa5aed7a0a", @"/Views/Admin/AdminNavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4b429c079bc72702172a168de5d0da3eaf50236", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminNavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/inspinia-gh-pages/img/a6.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<nav class=\"navbar-default navbar-static-side\" role=\"navigation\">\r\n    <div class=\"sidebar-collapse\">\r\n        <ul class=\"nav metismenu\" id=\"side-menu\">\r\n            <li class=\"nav-header\">\r\n                ");
#nullable restore
#line 7 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Admin\AdminNavbarPartial.cshtml"
           Write(await Html.PartialAsync("~/Views/Shared/_Culture.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"dropdown profile-element\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ddb1b896382f3f40af9b9d392063f7aa5aed7a0a5017", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <a data-toggle=""dropdown"" class=""dropdown-toggle"" href=""#"">
                        <span class=""block m-t-xs font-bold"">Beyza Selimoğlu</span>

                        <span class=""text-muted text-xs block""> <b class=""caret""></b></span>
                    </a>
                    <ul class=""dropdown-menu animated fadeInRight m-t-xs"">


                        <li><a class=""dropdown-item"" href=""/Login/IndexAdmin/"">");
#nullable restore
#line 18 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Admin\AdminNavbarPartial.cshtml"
                                                                          Write(localizer["Çıkış Yap"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>

                    </ul>

                </div>

                <div class=""logo-element"">
                    IN+
                </div>
            </li>

            </li>

            <li>
                <a href=""/Admin/Widget""><i class=""fa fa-bar-chart-o""></i> <span class=""nav-label"">");
#nullable restore
#line 32 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Admin\AdminNavbarPartial.cshtml"
                                                                                             Write(localizer["SocialDiscount Takip"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><span class=\"fa arrow\"></span></a>\r\n\r\n            </li>\r\n            <li>\r\n                <a href=\"#\">\r\n                    <i class=\"fa fa-bar-chart-o\"></i> <span class=\"nav-label\">\r\n                        ");
#nullable restore
#line 38 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Admin\AdminNavbarPartial.cshtml"
                   Write(localizer["Bloglar"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span><span class=\"fa arrow\"></span>\r\n                </a>\r\n                <ul class=\"nav nav-second-level collapse\">\r\n                    <li><a href=\"/Admin/Blog/BlogListExcel\">");
#nullable restore
#line 42 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Admin\AdminNavbarPartial.cshtml"
                                                       Write(localizer["BLog Listesi"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                    <li><a href=\"/Admin/Blog/BlogTitleListExcel\">");
#nullable restore
#line 43 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Admin\AdminNavbarPartial.cshtml"
                                                            Write(localizer["Blog Başlık Listesi"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\r\n                </ul>\r\n            </li>\r\n\r\n            <li>\r\n                <a href=\"#\">\r\n                    <i class=\"fa fa-bar-chart-o\"></i> <span class=\"nav-label\">\r\n                        ");
#nullable restore
#line 51 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Admin\AdminNavbarPartial.cshtml"
                   Write(localizer["Kategoriler"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span><span class=\"fa arrow\"></span>\r\n                </a>\r\n                <ul class=\"nav nav-second-level collapse\">\r\n                    <li><a href=\"/Admin/Category/Index\">");
#nullable restore
#line 55 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Admin\AdminNavbarPartial.cshtml"
                                                   Write(localizer["Kategori Durumu"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                    <li><a href=\"/Admin/Category/AddCategory\">");
#nullable restore
#line 56 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Admin\AdminNavbarPartial.cshtml"
                                                         Write(localizer["Kategori Ekle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\r\n                </ul>\r\n            </li>\r\n\r\n            <li>\r\n                <a href=\"#\">\r\n                    <i class=\"fa fa-bar-chart-o\"></i> <span class=\"nav-label\">\r\n                        ");
#nullable restore
#line 64 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Admin\AdminNavbarPartial.cshtml"
                   Write(localizer["Durum"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span><span class=\"fa arrow\"></span>\r\n                </a>\r\n                <ul class=\"nav nav-second-level collapse\">\r\n                    <li><a href=\"/Admin/Chart/Index\">");
#nullable restore
#line 68 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Admin\AdminNavbarPartial.cshtml"
                                                Write(localizer["Google Charts"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                  \r\n\r\n                </ul>\r\n            </li>\r\n\r\n\r\n\r\n        </ul>\r\n    </div>\r\n</nav>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591