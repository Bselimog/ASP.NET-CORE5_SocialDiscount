#pragma checksum "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Areas\Admin\Views\Blog\BlogListExcel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d65ddddbe8afa95e10759f2ac5addaa4cd69880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_BlogListExcel), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/BlogListExcel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d65ddddbe8afa95e10759f2ac5addaa4cd69880", @"/Areas/Admin/Views/Blog/BlogListExcel.cshtml")]
    public class Areas_Admin_Views_Blog_BlogListExcel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Areas\Admin\Views\Blog\BlogListExcel.cshtml"
  
    ViewData["Title"] = "BlogListExcel";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Areas\Admin\Views\Blog\BlogListExcel.cshtml"
Write(localizer["BlogListesiExcel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n\r\n<a href=\"/Admin/Blog/ExportStaticExcelBlogList/\" class=\"btn btn-primary\">");
#nullable restore
#line 10 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Areas\Admin\Views\Blog\BlogListExcel.cshtml"
                                                                    Write(localizer["Excel Listesini İndir"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n\r\n");
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