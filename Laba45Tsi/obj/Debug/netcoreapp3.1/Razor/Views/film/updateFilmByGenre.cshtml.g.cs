#pragma checksum "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\updateFilmByGenre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84c99b5ef324138cda5013d61b0ce33ac6a1c1c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_film_updateFilmByGenre), @"mvc.1.0.view", @"/Views/film/updateFilmByGenre.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84c99b5ef324138cda5013d61b0ce33ac6a1c1c0", @"/Views/film/updateFilmByGenre.cshtml")]
    public class Views_film_updateFilmByGenre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Laba45Tsi.Storage.Entity.filmEntity>
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
#line 2 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\updateFilmByGenre.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84c99b5ef324138cda5013d61b0ce33ac6a1c1c02985", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84c99b5ef324138cda5013d61b0ce33ac6a1c1c04048", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\updateFilmByGenre.cshtml"
     using (Html.BeginForm("updateByGenre", "film", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <label>Жанр : ");
#nullable restore
#line 16 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\updateFilmByGenre.cshtml"
                 Write(Model.genreName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 368, "\"", 390, 1);
#nullable restore
#line 17 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\updateFilmByGenre.cshtml"
WriteAttributeValue("", 376, Model.genreId, 376, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"genreId\">\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 437, "\"", 461, 1);
#nullable restore
#line 18 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\updateFilmByGenre.cshtml"
WriteAttributeValue("", 445, Model.genreName, 445, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"genreName\">\r\n");
                WriteLiteral("        <label>Название фильма : </label>\r\n        <input type=\"text\" id=\"filmName\" name=\"filmName\"");
                BeginWriteAttribute("value", " value=\"", 583, "\"", 606, 1);
#nullable restore
#line 21 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\updateFilmByGenre.cshtml"
WriteAttributeValue("", 591, Model.filmName, 591, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br /><br />\r\n");
                WriteLiteral("        <label>Фамилия и имя режисера : </label>\r\n        <input type=\"text\" id=\"producerName\" name=\"producerName\"");
                BeginWriteAttribute("value", " value=\"", 742, "\"", 769, 1);
#nullable restore
#line 25 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\updateFilmByGenre.cshtml"
WriteAttributeValue("", 750, Model.producerName, 750, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><br />\r\n        <input type=\"submit\" value=\"Обновить\">\r\n        <input type=\"hidden\" name=\"id\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 873, "\"", 890, 1);
#nullable restore
#line 27 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\updateFilmByGenre.cshtml"
WriteAttributeValue("", 881, Model.id, 881, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 28 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\updateFilmByGenre.cshtml"

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("<a");
                BeginWriteAttribute("href", " href=\"", 905, "\"", 948, 2);
                WriteAttributeValue("", 912, "/film/showFilmByGenre/", 912, 22, true);
#nullable restore
#line 30 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\film\updateFilmByGenre.cshtml"
WriteAttributeValue("", 934, Model.genreId, 934, 14, false);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Laba45Tsi.Storage.Entity.filmEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591