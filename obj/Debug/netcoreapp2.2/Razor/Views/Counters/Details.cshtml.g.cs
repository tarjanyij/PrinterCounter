#pragma checksum "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0307aae72c0947fbcc9c56df9e152c650c2e8527"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Counters_Details), @"mvc.1.0.view", @"/Views/Counters/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Counters/Details.cshtml", typeof(AspNetCore.Views_Counters_Details))]
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
#line 1 "D:\MyPrograms\Printercounter\Views\_ViewImports.cshtml"
using Printercounter;

#line default
#line hidden
#line 2 "D:\MyPrograms\Printercounter\Views\_ViewImports.cshtml"
using Printercounter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0307aae72c0947fbcc9c56df9e152c650c2e8527", @"/Views/Counters/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df34cb6c556c6c14781a1361aba4a2e83537f839", @"/Views/_ViewImports.cshtml")]
    public class Views_Counters_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Printercounter.Models.Counter>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Montly", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 138, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Counter</h4>\r\n    <hr />\r\n    \r\n\r\n\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(282, 68, false);
#line 18 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstOrDefault().Printer.PrinterName));

#line default
#line hidden
            EndContext();
            BeginContext(350, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(412, 69, false);
#line 21 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstOrDefault().Printer.PrinterModel));

#line default
#line hidden
            EndContext();
            BeginContext(481, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(544, 71, false);
#line 24 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstOrDefault().Printer.PrinterBarcode));

#line default
#line hidden
            EndContext();
            BeginContext(615, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(679, 57, false);
#line 27 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
       Write(Html.DisplayFor(model => model.First().Printer.PrinterIP));

#line default
#line hidden
            EndContext();
            BeginContext(736, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(799, 57, false);
#line 30 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
       Write(Html.DisplayFor(model => model.First().Printer.PrinterSN));

#line default
#line hidden
            EndContext();
            BeginContext(856, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(920, 63, false);
#line 33 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
       Write(Html.DisplayFor(model => model.First().Printer.PrinterLocation));

#line default
#line hidden
            EndContext();
            BeginContext(983, 56, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n    </dl>\r\n   \r\n</div>\r\n<div>\r\n\r\n    ");
            EndContext();
            BeginContext(1039, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0307aae72c0947fbcc9c56df9e152c650c2e85276774", async() => {
                BeginContext(1061, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1077, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1083, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0307aae72c0947fbcc9c56df9e152c650c2e85278157", async() => {
                BeginContext(1146, 13, true);
                WriteLiteral("Montly report");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
                             WriteLiteral(Model.First().PrinterID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1163, 108, true);
            WriteLiteral("\r\n</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1272, 48, false);
#line 49 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Date_Counter));

#line default
#line hidden
            EndContext();
            BeginContext(1320, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1376, 48, false);
#line 52 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.PaperCounter));

#line default
#line hidden
            EndContext();
            BeginContext(1424, 81, true);
            WriteLiteral("\r\n            </th>\r\n                        \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1506, 57, false);
#line 56 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.DailyPaperConsumption));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1619, 46, false);
#line 59 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.TonerLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1665, 79, true);
            WriteLiteral("\r\n            </th>\r\n            \r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 66 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1793, 50, true);
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1844, 47, false);
#line 71 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date_Counter));

#line default
#line hidden
            EndContext();
            BeginContext(1891, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1947, 47, false);
#line 74 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.PaperCounter));

#line default
#line hidden
            EndContext();
            BeginContext(1994, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2050, 56, false);
#line 77 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.DailyPaperConsumption));

#line default
#line hidden
            EndContext();
            BeginContext(2106, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2162, 45, false);
#line 80 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.TonerLevel));

#line default
#line hidden
            EndContext();
            BeginContext(2207, 61, true);
            WriteLiteral("\r\n            </td>\r\n                       \r\n        </tr>\r\n");
            EndContext();
#line 84 "D:\MyPrograms\Printercounter\Views\Counters\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(2279, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Printercounter.Models.Counter>> Html { get; private set; }
    }
}
#pragma warning restore 1591