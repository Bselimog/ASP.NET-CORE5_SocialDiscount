#pragma checksum "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Areas\Admin\Views\Shared\_Culture.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cba75dfccbdd733bc275ac39c08a01ed8729054c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Culture), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Culture.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba75dfccbdd733bc275ac39c08a01ed8729054c", @"/Areas/Admin/Views/Shared/_Culture.cshtml")]
    public class Areas_Admin_Views_Shared__Culture : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Areas\Admin\Views\Shared\_Culture.cshtml"
  
    var culture = Context.Features.Get<Microsoft.AspNetCore.Localization.IRequestCultureFeature>();
    var cultureList = localizationOptions.Value.SupportedUICultures.Select(x => new SelectListItem { Value = x.Name, Text = x.Name }).ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <form asp-action=\"CultureManagement\" asp-controller=\"Login\" method=\"post\">\r\n        <select name=\"culture\"");
            BeginWriteAttribute("asp-for", " asp-for=\"", 570, "\"", 618, 1);
#nullable restore
#line 11 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Areas\Admin\Views\Shared\_Culture.cshtml"
WriteAttributeValue("", 580, culture.RequestCulture.UICulture.Name, 580, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-items", " asp-items=\"", 619, "\"", 643, 1);
#nullable restore
#line 11 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Areas\Admin\Views\Shared\_Culture.cshtml"
WriteAttributeValue("", 631, cultureList, 631, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("    onchange=\"this.form.submit();\"></select>\r\n    </form>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.RequestLocalizationOptions> localizationOptions { get; private set; }
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
