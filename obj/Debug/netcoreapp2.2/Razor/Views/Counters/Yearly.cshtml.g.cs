#pragma checksum "C:\Prog\printercounter\Views\Counters\Yearly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b99f6a82a96bae2d4eaec284fa8c2359797b6791"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Counters_Yearly), @"mvc.1.0.view", @"/Views/Counters/Yearly.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Counters/Yearly.cshtml", typeof(AspNetCore.Views_Counters_Yearly))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b99f6a82a96bae2d4eaec284fa8c2359797b6791", @"/Views/Counters/Yearly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df34cb6c556c6c14781a1361aba4a2e83537f839", @"/Views/_ViewImports.cshtml")]
    public class Views_Counters_Yearly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Printercounter.ViewModels.CountersYearlyReportsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Counters", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery-1.12.4.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chartinator.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Prog\printercounter\Views\Counters\Yearly.cshtml"
  
    ViewData["Title"] = "Yearly";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(156, 135, true);
            WriteLiteral("\r\n<h1>Yearly</h1>\r\n\r\n<div>\r\n    <h4>Yearly Report</h4>\r\n    <hr />\r\n\r\n</div>\r\n<div class=\"d-flex\">\r\n    <div class=\"mr-auto\">\r\n        ");
            EndContext();
            BeginContext(291, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b99f6a82a96bae2d4eaec284fa8c2359797b67915471", async() => {
                BeginContext(414, 12, true);
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Prog\printercounter\Views\Counters\Yearly.cshtml"
                                                            WriteLiteral(ViewBag.DetailsId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 17 "C:\Prog\printercounter\Views\Counters\Yearly.cshtml"
                                                                                                    WriteLiteral(ViewBag.dateList);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dateList"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dateList", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dateList"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(430, 38, true);
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n             ");
            EndContext();
            BeginContext(469, 100, false);
#line 20 "C:\Prog\printercounter\Views\Counters\Yearly.cshtml"
        Write(Html.DropDownList("Years", (IEnumerable<SelectListItem>)Model.Years, new {@class="form-control-sm"}));

#line default
#line hidden
            EndContext();
            BeginContext(569, 134, true);
            WriteLiteral("  \r\n          \r\n    </div>\r\n    &nbsp;\r\n   \r\n</div>\r\n<table class=\"table table-hover\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n");
            EndContext();
#line 29 "C:\Prog\printercounter\Views\Counters\Yearly.cshtml"
          foreach (var item in Model.Months)
            {

#line default
#line hidden
            BeginContext(764, 42, true);
            WriteLiteral("                <th>\r\n                    ");
            EndContext();
            BeginContext(807, 4, false);
#line 32 "C:\Prog\printercounter\Views\Counters\Yearly.cshtml"
               Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(811, 25, true);
            WriteLiteral("\r\n                </th>\r\n");
            EndContext();
#line 34 "C:\Prog\printercounter\Views\Counters\Yearly.cshtml"
                
            }

#line default
#line hidden
            BeginContext(869, 68, true);
            WriteLiteral("\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        \r\n        <tr>\r\n");
            EndContext();
#line 42 "C:\Prog\printercounter\Views\Counters\Yearly.cshtml"
             foreach (var item in Model.MonthsValue)
            {

#line default
#line hidden
            BeginContext(1006, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1049, 4, false);
#line 45 "C:\Prog\printercounter\Views\Counters\Yearly.cshtml"
               Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(1053, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 47 "C:\Prog\printercounter\Views\Counters\Yearly.cshtml"
                
            }

#line default
#line hidden
            BeginContext(1111, 121, true);
            WriteLiteral("        </tr>\r\n        \r\n    </tbody>\r\n</table>\r\n<br />\r\n<div id=\"columnChart\" class=\"columnChart chart col\"></div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1249, 239, true);
                WriteLiteral("\r\n    <!-- <script src=\"https://code.jquery.com/jquery-1.12.4.js\"></script>\r\n     <script src=\"https://code.jquery.com/ui/1.12.1/jquery-ui.js\"></script>\r\n     <script src=\"https://localhost:5001/js/chartinator.js\"></script>\r\n     -->\r\n    ");
                EndContext();
                BeginContext(1488, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b99f6a82a96bae2d4eaec284fa8c2359797b679111676", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1546, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1552, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b99f6a82a96bae2d4eaec284fa8c2359797b679112932", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1606, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1612, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b99f6a82a96bae2d4eaec284fa8c2359797b679114188", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1655, 1638, true);
                WriteLiteral(@"
    
    
    
    <script type=""text/javascript"">
        jQuery(function ($) {

              $(""#Years"").change(function(){
                 var year = $(""#Years"").val();
                 var url  = $(""a[href*='Monthly']"").attr(""href"");
                 var n = url.search(""year"");
                 var oldYear = url.slice(n+5,n+9)
                 
                $(""a[href*='Monthly']"")
                    .each(function()
                    { 
                        this.href = this.href.replace(oldYear,year);
                        
                    });

                 
                });      
            //  Column Chart Example
            var chart4 = $('#columnChart').chartinator({
                // Custom Options ------------------------------------------------------
                // note: This example uses js data arrays for data instead of HTML tables
                // Columns - The columns data-array
                columns: [
                    { label");
                WriteLiteral(@": 'Date', type: 'string' },
                    //   {label: '2013', type: 'number'},
                    //   {label: '2014', type: 'number'},
                    { label: 'Monthly paper consumption', type: 'number' }
                ],
                // Rows - The rows data-array
                // If colIndexes array has values the row data will be inserted into the columns
                // defined in the colindexes array. Otherwise the row data will be appended
                // to any existing row data extracted from an HTML table or Google Sheet
                
                rows: [
");
                EndContext();
#line 103 "C:\Prog\printercounter\Views\Counters\Yearly.cshtml"
                         foreach (var item in Model.MonthsValue)
                        {
                            
                            

#line default
#line hidden
#line 106 "C:\Prog\printercounter\Views\Counters\Yearly.cshtml"
                             if (item.Length == 0)
                            { 
                                

#line default
#line hidden
                BeginContext(3538, 83, true);
                WriteLiteral("\r\n                                [\'January\',0], \r\n                                ");
                EndContext();
#line 110 "C:\Prog\printercounter\Views\Counters\Yearly.cshtml"
                                       
                            }
                            else
                            {
                                

#line default
#line hidden
                BeginContext(3764, 45, true);
                WriteLiteral("\r\n                                [\'January\',");
                EndContext();
                BeginContext(3810, 4, false);
#line 115 "C:\Prog\printercounter\Views\Counters\Yearly.cshtml"
                                      Write(item);

#line default
#line hidden
                EndContext();
                BeginContext(3814, 36, true);
                WriteLiteral("],\r\n                                ");
                EndContext();
#line 116 "C:\Prog\printercounter\Views\Counters\Yearly.cshtml"
                                       
                            }

#line default
#line hidden
#line 117 "C:\Prog\printercounter\Views\Counters\Yearly.cshtml"
                             ;

                        }

#line default
#line hidden
                BeginContext(3920, 4112, true);
                WriteLiteral(@"                    //['Januar ', 512]
                ],
                // The class to apply to the table element
                tableClass: 'col-table',
                // Create Table - String
                // Create a basic HTML table or a Google Table Chart from chart data
                // Options: false, 'basic-table', 'table-chart'
                // Note: This table will replace an existing HTML table
                //createTable: 'basic-table',
                // The chart type - String
                // Derived from the Google Charts visualization class name
                // Default: 'BarChart'
                // Use TitleCase names. eg. BarChart, PieChart, ColumnChart, Calendar, GeoChart, Table.
                // See Google Charts Gallery for a complete list of Chart types
                // https://developers.google.com/chart/interactive/docs/gallery
                chartType: 'ColumnChart',
                // The data title
                // A title used to identify ");
                WriteLiteral(@"the set of data
                // Used as a caption when generating an HTML table
                dataTitle: 'Column Chart Data',
                // The chart aspect ratio custom option - width/height
                // Used to calculate the chart dimensions relative to the width or height
                // this is overridden if the Google Chart's height and width options have values
                // Suggested value: 1.25
                // Default: false - not used
                chartAspectRatio: 1.5,
                // Google Column Chart Options
                columnChart: {
                    // Width of chart in pixels - Number
                    // Default: automatic (unspecified)
                    width: null,
                    // Height of chart in pixels - Number
                    // Default: automatic (unspecified)
                    //height: 200,
                    chartArea: {
                        left: ""10%"",
                        top: 30,
              ");
                WriteLiteral(@"          width: ""90%"",
                        height: ""65%""
                    },
                    // The font size in pixels - Number
                    // Or use css selectors as keywords to assign font sizes from the page
                    // For example: 'body'
                    // Default: false - Use Google Charts defaults
                    //fontSize: 'body',
                    // The font family name - String
                    // Default: body font family
                    fontName: 'Roboto',
                    // Chart Title - String
                    // Default: Table caption.
                    //title: 'Column Chart',
                    titleTextStyle: {
                        // The font size in pixels - Number
                        // Or use css selectors as keywords to assign font sizes from the page
                        // For example: 'body'
                        // Default: false - Use Google Charts defaults
                        fontSize: ");
                WriteLiteral(@"'h4'
                    },
                    legend: {
                        // Legend position - String
                        // Options: bottom, top, left, right, in, none.
                        // Default: bottom
                        position: 'none'
                    },
                    // Array of colours
                    colors: ['#a82180', '#dd61b8', '#ff99e1'],
                    // Stack values within a bar or column chart - Boolean
                    // Default: false.
                    isStacked: false,
                    tooltip: {
                        // Shows tooltip with values on hover - String
                        // Options: focus, none.
                        // Default: focus
                        trigger: 'focus'
                    }
                },
                // Show table as well as chart - String
                // Options: 'show', 'hide', 'remove'
                showTable: 'show'
            });
        }
        );");
                WriteLiteral("\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Printercounter.ViewModels.CountersYearlyReportsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
