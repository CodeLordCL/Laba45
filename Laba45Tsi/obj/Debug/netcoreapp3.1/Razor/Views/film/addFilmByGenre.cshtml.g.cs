#pragma checksum "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\addFilmByGenre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93b578bdb683e59fced948eddc25625c5a540f19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_film_addFilmByGenre), @"mvc.1.0.view", @"/Views/film/addFilmByGenre.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93b578bdb683e59fced948eddc25625c5a540f19", @"/Views/film/addFilmByGenre.cshtml")]
    public class Views_film_addFilmByGenre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Laba45Tsi.Managers.filmManager.filmCreatOrUpdateRequest>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\addFilmByGenre.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93b578bdb683e59fced948eddc25625c5a540f192987", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>AddClient</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93b578bdb683e59fced948eddc25625c5a540f194050", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\addFilmByGenre.cshtml"
     using (Html.BeginForm("addByGenre", "film", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <label>Жанр : ");
#nullable restore
#line 16 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\addFilmByGenre.cshtml"
                 Write(ViewBag.genre.genreName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 393, "\"", 418, 1);
#nullable restore
#line 17 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\addFilmByGenre.cshtml"
WriteAttributeValue("", 401, ViewBag.genre.id, 401, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"genreId\">\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 465, "\"", 497, 1);
#nullable restore
#line 18 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\addFilmByGenre.cshtml"
WriteAttributeValue("", 473, ViewBag.genre.genreName, 473, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"genreName\"><br /><br />\r\n");
                WriteLiteral("        <label>Название фильма : </label>\r\n        <input type=\"text\" id=\"filmName\" name=\"filmName\" /><br /><br />\r\n        <label>Фамилия и имя режисера : </label>\r\n        <input type=\"text\" id=\"producerName\" name=\"producerName\">\r\n");
                WriteLiteral("        <input type=\"submit\" value=\"Содать\">\r\n");
#nullable restore
#line 26 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\addFilmByGenre.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <a");
                BeginWriteAttribute("href", " href=\"", 826, "\"", 872, 2);
                WriteAttributeValue("", 833, "/film/showFilmByGenre/", 833, 22, true);
#nullable restore
#line 27 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\addFilmByGenre.cshtml"
WriteAttributeValue("", 855, ViewBag.genre.id, 855, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Вернуться</a>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Laba45Tsi.Managers.filmManager.filmCreatOrUpdateRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591
