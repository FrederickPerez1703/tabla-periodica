#pragma checksum "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90771161d107fd79acf2deb6951e0cd656f62bbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tablas_Index), @"mvc.1.0.view", @"/Views/Tablas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tablas/Index.cshtml", typeof(AspNetCore.Views_Tablas_Index))]
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
#line 1 "C:\Users\FrederickPz\source\repos\Tarea\Views\_ViewImports.cshtml"
using Tarea;

#line default
#line hidden
#line 2 "C:\Users\FrederickPz\source\repos\Tarea\Views\_ViewImports.cshtml"
using Tarea.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90771161d107fd79acf2deb6951e0cd656f62bbf", @"/Views/Tablas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611d629ae4ac2be94d5d4b39a9c924fb46ed0d6d", @"/Views/_ViewImports.cshtml")]
    public class Views_Tablas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/estilo.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90771161d107fd79acf2deb6951e0cd656f62bbf4405", async() => {
                BeginContext(64, 91, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n    ");
                EndContext();
                BeginContext(155, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "90771161d107fd79acf2deb6951e0cd656f62bbf4883", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(204, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(213, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(215, 2613, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90771161d107fd79acf2deb6951e0cd656f62bbf7012", async() => {
                BeginContext(221, 77, true);
                WriteLiteral("\r\n\r\n    <div class=\"main\">\r\n        <h2 class=\"titulo\">Tabla periodica</h2>\r\n");
                EndContext();
#line 18 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int j = 0; j < 7; j++)
        {



#line default
#line hidden
                BeginContext(351, 32, true);
                WriteLiteral("            <div class=\"grupo1\">");
                EndContext();
                BeginContext(385, 29, false);
#line 22 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                            Write(((String[])ViewBag.grupo1)[j]);

#line default
#line hidden
                EndContext();
                BeginContext(415, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 23 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"

        }

#line default
#line hidden
                BeginContext(436, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 25 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int i = 0; i < 6; i++)
        {

#line default
#line hidden
                BeginContext(485, 33, true);
                WriteLiteral("            <div class=\"grupo2\"> ");
                EndContext();
                BeginContext(520, 29, false);
#line 27 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                             Write(((String[])ViewBag.grupo2)[i]);

#line default
#line hidden
                EndContext();
                BeginContext(550, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 28 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(569, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 29 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int p = 0; p < 4; p++)
        {

#line default
#line hidden
                BeginContext(618, 32, true);
                WriteLiteral("            <div class=\"grupo3\">");
                EndContext();
                BeginContext(652, 29, false);
#line 31 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                            Write(((String[])ViewBag.grupo3)[p]);

#line default
#line hidden
                EndContext();
                BeginContext(682, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 32 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"

        }

#line default
#line hidden
                BeginContext(703, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 34 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int a = 0; a < 4; a++)
        {

#line default
#line hidden
                BeginContext(752, 33, true);
                WriteLiteral("            <div class=\"grupoA3\">");
                EndContext();
                BeginContext(787, 29, false);
#line 36 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                             Write(((String[])ViewBag.grupoA)[a]);

#line default
#line hidden
                EndContext();
                BeginContext(817, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 37 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(836, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 38 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int b = 0; b < 4; b++)
        {

#line default
#line hidden
                BeginContext(885, 32, true);
                WriteLiteral("            <div class=\"grupoB\">");
                EndContext();
                BeginContext(919, 29, false);
#line 40 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                            Write(((String[])ViewBag.grupoB)[b]);

#line default
#line hidden
                EndContext();
                BeginContext(949, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 41 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(968, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 42 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int w = 0; w < 4; w++)
        {

#line default
#line hidden
                BeginContext(1017, 32, true);
                WriteLiteral("            <div class=\"grupoC\">");
                EndContext();
                BeginContext(1051, 29, false);
#line 44 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                            Write(((String[])ViewBag.grupod)[w]);

#line default
#line hidden
                EndContext();
                BeginContext(1081, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 45 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1100, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 46 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int s = 0; s < 4; s++)
        {

#line default
#line hidden
                BeginContext(1149, 33, true);
                WriteLiteral("            <div class=\"grupoC1\">");
                EndContext();
                BeginContext(1184, 29, false);
#line 48 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                             Write(((String[])ViewBag.grupoC)[s]);

#line default
#line hidden
                EndContext();
                BeginContext(1214, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 49 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1233, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 51 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int v = 0; v < 4; v++)
        {

#line default
#line hidden
                BeginContext(1284, 33, true);
                WriteLiteral("            <div class=\"grupoC2\">");
                EndContext();
                BeginContext(1319, 29, false);
#line 53 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                             Write(((String[])ViewBag.grupoF)[v]);

#line default
#line hidden
                EndContext();
                BeginContext(1349, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 54 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1368, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 55 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int q = 0; q < 4; q++)
        {

#line default
#line hidden
                BeginContext(1417, 33, true);
                WriteLiteral("            <div class=\"grupoC3\">");
                EndContext();
                BeginContext(1452, 25, false);
#line 57 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                             Write(((String[])ViewBag.vs)[q]);

#line default
#line hidden
                EndContext();
                BeginContext(1478, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 58 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1497, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 59 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int t = 0; t < 4; t++)
        {

#line default
#line hidden
                BeginContext(1546, 33, true);
                WriteLiteral("            <div class=\"grupoC4\">");
                EndContext();
                BeginContext(1581, 26, false);
#line 61 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                             Write(((String[])ViewBag.vs1)[t]);

#line default
#line hidden
                EndContext();
                BeginContext(1608, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 62 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1627, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 63 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int z = 0; z < 4; z++)
        {

#line default
#line hidden
                BeginContext(1676, 33, true);
                WriteLiteral("            <div class=\"grupoC5\">");
                EndContext();
                BeginContext(1711, 26, false);
#line 65 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                             Write(((String[])ViewBag.vs2)[z]);

#line default
#line hidden
                EndContext();
                BeginContext(1738, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 66 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1757, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 67 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int n = 0; n < 6; n++)
        {

#line default
#line hidden
                BeginContext(1806, 33, true);
                WriteLiteral("            <div class=\"grupoC6\">");
                EndContext();
                BeginContext(1841, 26, false);
#line 69 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                             Write(((String[])ViewBag.vs3)[n]);

#line default
#line hidden
                EndContext();
                BeginContext(1868, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 70 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1887, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 71 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int l = 0; l < 6; l++)
        {

#line default
#line hidden
                BeginContext(1936, 33, true);
                WriteLiteral("            <div class=\"grupoC7\">");
                EndContext();
                BeginContext(1971, 26, false);
#line 73 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                             Write(((String[])ViewBag.vs4)[l]);

#line default
#line hidden
                EndContext();
                BeginContext(1998, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 74 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(2017, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 75 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int c = 0; c < 6; c++)
        {

#line default
#line hidden
                BeginContext(2066, 33, true);
                WriteLiteral("            <div class=\"grupoC8\">");
                EndContext();
                BeginContext(2101, 26, false);
#line 77 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                             Write(((String[])ViewBag.vs5)[c]);

#line default
#line hidden
                EndContext();
                BeginContext(2128, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 78 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(2147, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 79 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int h = 0; h < 6; h++)
        {

#line default
#line hidden
                BeginContext(2196, 33, true);
                WriteLiteral("            <div class=\"grupoC9\">");
                EndContext();
                BeginContext(2231, 26, false);
#line 81 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                             Write(((String[])ViewBag.vs6)[h]);

#line default
#line hidden
                EndContext();
                BeginContext(2258, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 82 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(2277, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 83 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int k = 0; k < 6; k++)
        {

#line default
#line hidden
                BeginContext(2326, 34, true);
                WriteLiteral("            <div class=\"grupoC10\">");
                EndContext();
                BeginContext(2362, 26, false);
#line 85 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                              Write(((String[])ViewBag.vs7)[k]);

#line default
#line hidden
                EndContext();
                BeginContext(2389, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 86 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(2408, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 87 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int w = 0; w < 7; w++)
        {

#line default
#line hidden
                BeginContext(2457, 34, true);
                WriteLiteral("            <div class=\"grupoC11\">");
                EndContext();
                BeginContext(2493, 26, false);
#line 89 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                              Write(((String[])ViewBag.vs8)[w]);

#line default
#line hidden
                EndContext();
                BeginContext(2520, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 90 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(2539, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 92 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int e = 0; e < 14; e++)
        {

#line default
#line hidden
                BeginContext(2591, 32, true);
                WriteLiteral("            <div class=\"extra1\">");
                EndContext();
                BeginContext(2625, 29, false);
#line 94 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                            Write(((String[])ViewBag.Estra1)[e]);

#line default
#line hidden
                EndContext();
                BeginContext(2655, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 95 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(2674, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 96 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
         for (int x = 0; x < 14; x++)
        {

#line default
#line hidden
                BeginContext(2724, 32, true);
                WriteLiteral("            <div class=\"extra2\">");
                EndContext();
                BeginContext(2758, 29, false);
#line 98 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
                            Write(((String[])ViewBag.Estra2)[x]);

#line default
#line hidden
                EndContext();
                BeginContext(2788, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 99 "C:\Users\FrederickPz\source\repos\Tarea\Views\Tablas\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(2807, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2828, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
