#pragma checksum "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\producer\showProducer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54191ed4e8fa0342fbb17504b9aa9b6ad7d47ff4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_producer_showProducer), @"mvc.1.0.view", @"/Views/producer/showProducer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54191ed4e8fa0342fbb17504b9aa9b6ad7d47ff4", @"/Views/producer/showProducer.cshtml")]
    public class Views_producer_showProducer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Laba45Tsi.Storage.Entity.producerEntity>>
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
#line 2 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\producer\showProducer.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54191ed4e8fa0342fbb17504b9aa9b6ad7d47ff42996", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Режисёры</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54191ed4e8fa0342fbb17504b9aa9b6ad7d47ff44058", async() => {
                WriteLiteral("\r\n    <div>\r\n        <h1>Режисёры</h1>\r\n");
#nullable restore
#line 16 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\producer\showProducer.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label>Фамилия и имя режисера : </label>");
#nullable restore
#line 18 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\producer\showProducer.cshtml"
                                               Write(item.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 401, "\"", 441, 2);
                WriteAttributeValue("", 408, "/producer/updateProducer/", 408, 25, true);
#nullable restore
#line 19 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\producer\showProducer.cshtml"
WriteAttributeValue("", 433, item.id, 433, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Редактировать режисёра</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 485, "\"", 525, 2);
                WriteAttributeValue("", 492, "/film/showFilmByProducer/", 492, 25, true);
#nullable restore
#line 20 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\producer\showProducer.cshtml"
WriteAttributeValue("", 517, item.id, 517, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Показать фильмы</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 562, "\"", 592, 2);
                WriteAttributeValue("", 569, "/producer/dell/", 569, 15, true);
#nullable restore
#line 21 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\producer\showProducer.cshtml"
WriteAttributeValue("", 584, item.id, 584, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Удалить</a>\r\n            <br />\r\n");
#nullable restore
#line 23 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\producer\showProducer.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\producer\showProducer.cshtml"
         using (Html.BeginForm("addProducer", "producer"))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div><input type=\"submit\" value=\"Добавить режисера\"></div>\r\n");
#nullable restore
#line 27 "C:\Users\Sergey\source\repos\Laba45Tsi\Laba45Tsi\Views\producer\showProducer.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <a href=\"/genre/showGenre\">Список жанров</a>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Laba45Tsi.Storage.Entity.producerEntity>> Html { get; private set; }
    }
}
#pragma warning restore 1591