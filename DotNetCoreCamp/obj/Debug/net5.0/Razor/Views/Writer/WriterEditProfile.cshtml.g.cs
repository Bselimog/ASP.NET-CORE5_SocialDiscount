#pragma checksum "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1647df0804add662b792dfa15f2c69044b49d08d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_WriterEditProfile), @"mvc.1.0.view", @"/Views/Writer/WriterEditProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1647df0804add662b792dfa15f2c69044b49d08d", @"/Views/Writer/WriterEditProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4b429c079bc72702172a168de5d0da3eaf50236", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_WriterEditProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
  
    ViewData["Title"] = "WriterEditProfile";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
 using (Html.BeginForm("WriterEditProfile", "Writer", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
                                  Write(localizer["Yazar Profil Bilgileri Düzenleme"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <br />\r\n                ");
#nullable restore
#line 15 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
           Write(Html.HiddenFor(x => x.WriterID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1647df0804add662b792dfa15f2c69044b49d08d5290", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">");
#nullable restore
#line 18 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
                                                  Write(localizer["Adınız!"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        ");
#nullable restore
#line 19 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputEmail3\"> ");
#nullable restore
#line 22 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
                                                    Write(localizer["Mail Adresiniz!"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        ");
#nullable restore
#line 23 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterMail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputPassword4\">\r\n                            ");
#nullable restore
#line 27 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
                       Write(localizer["Şifreniz!"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </label>\r\n                        ");
#nullable restore
#line 29 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
                   Write(Html.PasswordFor(x => x.WriterPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 31 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
                   Write(Html.ValidationMessageFor(x => x.WriterPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputPassword2 mb-2\">\r\n                            ");
#nullable restore
#line 35 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
                       Write(localizer["Parolanızı Tekrar Giriniz"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </label>\r\n                        <input type=\"password\" name=\"PasswordAgain\" class=\"form-control\" id=\"password2\"");
                BeginWriteAttribute("placeholder", " placeholder=", 1888, "", 1940, 1);
#nullable restore
#line 37 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
WriteAttributeValue("", 1901, localizer["Şifrenizi Tekrar Giriniz" ], 1901, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 1940, "\"", 1951, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>\r\n                            ");
#nullable restore
#line 41 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
                       Write(localizer["GÖRSELİNİZ!"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </label>
                        <input type=""file"" name=""img[]"" class=""file-upload-default"">
                        <div class=""input-group col-xs-12"">
                            <input type=""text"" class=""form-control file-upload-info"" disabled");
                BeginWriteAttribute("placeholder", " placeholder=", 2393, "", 2443, 1);
#nullable restore
#line 45 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
WriteAttributeValue("", 2406, localizer["Resminizi Yükleyiniz..."], 2406, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <span class=\"input-group-append\">\r\n                                <button class=\"file-upload-browse btn btn-gradient-primary\" type=\"button\">");
#nullable restore
#line 47 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
                                                                                                     Write(localizer["Resim Seç"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                            </span>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleTextarea1\">\r\n                            ");
#nullable restore
#line 53 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
                       Write(localizer["Hakkınızda!"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </label>\r\n                        ");
#nullable restore
#line 55 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
                   Write(Html.TextAreaFor(x => x.WriterAbout, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    \r\n                    <button type=\"submit\" class=\"btn btn-gradient-primary mr-2\">\r\n                        ");
#nullable restore
#line 59 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
                   Write(localizer["Güncelle"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </button>\r\n                    <button class=\"btn btn-light\">");
#nullable restore
#line 61 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
                                             Write(localizer["İptal"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 66 "C:\Users\Melike Selimoğlu\Desktop\tıbbi istatistik\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Writer\WriterEditProfile.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; }
    }
}
#pragma warning restore 1591
