#pragma checksum "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15ff6713e51774f10ea20a8cb94989678bd46d2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_WriterAdd), @"mvc.1.0.view", @"/Views/Writer/WriterAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15ff6713e51774f10ea20a8cb94989678bd46d2b", @"/Views/Writer/WriterAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4b429c079bc72702172a168de5d0da3eaf50236", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_WriterAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNetCoreCamp.Models.AddProfileImage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterAdd.cshtml"
  
    ViewData["Title"] = "WriterAdd";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15ff6713e51774f10ea20a8cb94989678bd46d2b4707", async() => {
                WriteLiteral("\r\n    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterAdd.cshtml"
                                  Write(localizer["Yazar Profil Bilgileri Düzenleme"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                <br />\r\n                ");
#nullable restore
#line 14 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterAdd.cshtml"
           Write(Html.HiddenFor(x => x.WriterID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"forms-sample\">\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">");
#nullable restore
#line 17 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterAdd.cshtml"
                                                  Write(localizer["Adınız!"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        ");
#nullable restore
#line 18 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterAdd.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputEmail3\">");
#nullable restore
#line 21 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterAdd.cshtml"
                                                   Write(localizer["Mail Adresiniz!"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        ");
#nullable restore
#line 22 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterAdd.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterMail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputPassword4\">");
#nullable restore
#line 25 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterAdd.cshtml"
                                                      Write(localizer["Şifreniz!"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        ");
#nullable restore
#line 26 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterAdd.cshtml"
                   Write(Html.PasswordFor(x => x.WriterPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                    <label>");
#nullable restore
#line 31 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterAdd.cshtml"
                      Write(localizer["GÖRSELİNİZ!"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        <input type=\"file\" name=\"WriterImage\" />\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleTextarea1\">");
#nullable restore
#line 35 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterAdd.cshtml"
                                                 Write(localizer["Hakkınızda!"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        ");
#nullable restore
#line 36 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterAdd.cshtml"
                   Write(Html.TextAreaFor(x => x.WriterAbout, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <button type=\"submit\" class=\"btn btn-gradient-primary mr-2\">");
#nullable restore
#line 38 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterAdd.cshtml"
                                                                           Write(localizer["Kaydet"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                    <button class=\"btn btn-light\">");
#nullable restore
#line 39 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterAdd.cshtml"
                                             Write(localizer["İptal"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNetCoreCamp.Models.AddProfileImage> Html { get; private set; }
    }
}
#pragma warning restore 1591
