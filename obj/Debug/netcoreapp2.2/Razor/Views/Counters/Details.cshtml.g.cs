#pragma checksum "C:\Prog\printercounter\Views\Counters\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebf76b21d4a27130d07a87aca718ea3b5b3608ac"
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
#line 1 "C:\Prog\printercounter\Views\_ViewImports.cshtml"
using Printercounter;

#line default
#line hidden
#line 2 "C:\Prog\printercounter\Views\_ViewImports.cshtml"
using Printercounter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebf76b21d4a27130d07a87aca718ea3b5b3608ac", @"/Views/Counters/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df34cb6c556c6c14781a1361aba4a2e83537f839", @"/Views/_ViewImports.cshtml")]
    public class Views_Counters_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Printercounter.Models.Counter>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Counters", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Monthly", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Yearly", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 138, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Counter</h4>\r\n    <hr />\r\n    \r\n\r\n\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(282, 68, false);
#line 18 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstOrDefault().Printer.PrinterName));

#line default
#line hidden
            EndContext();
            BeginContext(350, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(412, 69, false);
#line 21 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstOrDefault().Printer.PrinterModel));

#line default
#line hidden
            EndContext();
            BeginContext(481, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(544, 71, false);
#line 24 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstOrDefault().Printer.PrinterBarcode));

#line default
#line hidden
            EndContext();
            BeginContext(615, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(679, 57, false);
#line 27 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
       Write(Html.DisplayFor(model => model.First().Printer.PrinterIP));

#line default
#line hidden
            EndContext();
            BeginContext(736, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(799, 57, false);
#line 30 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
       Write(Html.DisplayFor(model => model.First().Printer.PrinterSN));

#line default
#line hidden
            EndContext();
            BeginContext(856, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(920, 63, false);
#line 33 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
       Write(Html.DisplayFor(model => model.First().Printer.PrinterLocation));

#line default
#line hidden
            EndContext();
            BeginContext(983, 56, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n    </dl>\r\n   \r\n</div>\r\n<div>\r\n\r\n    ");
            EndContext();
            BeginContext(1039, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebf76b21d4a27130d07a87aca718ea3b5b3608ac7324", async() => {
                BeginContext(1126, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-dateList", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
                                                            WriteLiteral(ViewBag.dateList);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dateList"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dateList", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dateList"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1142, 12, true);
            WriteLiteral("&nbsp;\r\n    ");
            EndContext();
            BeginContext(1154, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebf76b21d4a27130d07a87aca718ea3b5b3608ac9903", async() => {
                BeginContext(1218, 14, true);
                WriteLiteral("Monthly report");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
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
            BeginContext(1236, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1242, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebf76b21d4a27130d07a87aca718ea3b5b3608ac12224", async() => {
                BeginContext(1305, 13, true);
                WriteLiteral("Yearly report");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
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
            BeginContext(1322, 139, true);
            WriteLiteral("\r\n</div>\r\n<table class=\"table table-hover\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1462, 48, false);
#line 50 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Date_Counter));

#line default
#line hidden
            EndContext();
            BeginContext(1510, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1566, 48, false);
#line 53 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.PaperCounter));

#line default
#line hidden
            EndContext();
            BeginContext(1614, 81, true);
            WriteLiteral("\r\n            </th>\r\n                        \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1696, 57, false);
#line 57 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.DailyPaperConsumption));

#line default
#line hidden
            EndContext();
            BeginContext(1753, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1809, 46, false);
#line 60 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.TonerLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1855, 79, true);
            WriteLiteral("\r\n            </th>\r\n            \r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 67 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1983, 50, true);
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2034, 47, false);
#line 72 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date_Counter));

#line default
#line hidden
            EndContext();
            BeginContext(2081, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2137, 47, false);
#line 75 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.PaperCounter));

#line default
#line hidden
            EndContext();
            BeginContext(2184, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2240, 56, false);
#line 78 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.DailyPaperConsumption));

#line default
#line hidden
            EndContext();
            BeginContext(2296, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2352, 45, false);
#line 81 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.TonerLevel));

#line default
#line hidden
            EndContext();
            BeginContext(2397, 61, true);
            WriteLiteral("\r\n            </td>\r\n                       \r\n        </tr>\r\n");
            EndContext();
#line 85 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(2469, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
#line 89 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
  
    var prevDisabled = !ViewBag.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !ViewBag.HasNextPage ? "disabled" : "";
    var pervPage = 1;
    if (ViewBag.pageNumber > 1)
    {
        pervPage = ViewBag.pageNumber - 1;
    }
   
    if (ViewBag.pageNumber == null )
    {
        ViewBag.pageNumber = 1;
    }

    var nextPage = ViewBag.pageNumber + 1;

#line default
#line hidden
            BeginContext(2884, 77, true);
            WriteLiteral("    <ul class=\"pagination pagination-sm justify-content-center\">\r\n        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2961, "\"", 2992, 2);
            WriteAttributeValue("", 2969, "page-item", 2969, 9, true);
#line 106 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
WriteAttributeValue(" ", 2978, prevDisabled, 2979, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2993, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(2996, 128, false);
#line 106 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
                                        Write(Html.ActionLink("Previous","Details","Counters", new {datelist=ViewBag.datelist,pageNumber=pervPage},new {@class = "page-link"}));

#line default
#line hidden
            EndContext();
            BeginContext(3124, 198, true);
            WriteLiteral("</li>\r\n        <!--<li class=\"page-item\"><a class=\"page-link\" href=\"#\">1</a></li>\r\n        <li class=\"page-item\"><a class=\"page-link\" asp-controller=\"Counters\" asp-action=\"index\" asp-route-datelist=");
            EndContext();
            BeginContext(3323, 16, false);
#line 108 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
                                                                                                              Write(ViewBag.dateList);

#line default
#line hidden
            EndContext();
            BeginContext(3339, 124, true);
            WriteLiteral(" asp-route-pageNumber=\"2\">2</a></li>\r\n        <li class=\"page-item\"><a class=\"page-link\" href=\"#\">3</a></li>-->\r\n        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3463, "\"", 3494, 2);
            WriteAttributeValue("", 3471, "page-item", 3471, 9, true);
#line 110 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
WriteAttributeValue(" ", 3480, nextDisabled, 3481, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3495, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3497, 125, false);
#line 110 "C:\Prog\printercounter\Views\Counters\Details.cshtml"
                                       Write(Html.ActionLink("Next", "Details","Counters", new {datelist=ViewBag.datelist,pageNumber=nextPage},new {@class = "page-link"}));

#line default
#line hidden
            EndContext();
            BeginContext(3622, 21, true);
            WriteLiteral("</li>\r\n    </ul>\r\n   ");
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
