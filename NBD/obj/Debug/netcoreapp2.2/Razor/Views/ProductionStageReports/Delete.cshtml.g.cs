#pragma checksum "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82838e68e1daf701b44f3fec7ff7f119ac811da3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductionStageReports_Delete), @"mvc.1.0.view", @"/Views/ProductionStageReports/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductionStageReports/Delete.cshtml", typeof(AspNetCore.Views_ProductionStageReports_Delete))]
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
#line 1 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\_ViewImports.cshtml"
using NBD;

#line default
#line hidden
#line 2 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\_ViewImports.cshtml"
using NBD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82838e68e1daf701b44f3fec7ff7f119ac811da3", @"/Views/ProductionStageReports/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877786879ad765db0577617c19ecaf8320d35743", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductionStageReports_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NBD.Models.ProductionStageReport>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(85, 191, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>ProductionStageReport</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(277, 39, false);
#line 15 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bid));

#line default
#line hidden
            EndContext();
            BeginContext(316, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(380, 35, false);
#line 18 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bid));

#line default
#line hidden
            EndContext();
            BeginContext(415, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(478, 47, false);
#line 21 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EstProdPlan));

#line default
#line hidden
            EndContext();
            BeginContext(525, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(589, 43, false);
#line 24 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EstProdPlan));

#line default
#line hidden
            EndContext();
            BeginContext(632, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(695, 51, false);
#line 27 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalCosttoDate));

#line default
#line hidden
            EndContext();
            BeginContext(746, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(810, 47, false);
#line 30 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalCosttoDate));

#line default
#line hidden
            EndContext();
            BeginContext(857, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(920, 45, false);
#line 33 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ActualMtl));

#line default
#line hidden
            EndContext();
            BeginContext(965, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1029, 41, false);
#line 36 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ActualMtl));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1133, 55, false);
#line 39 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EstimatedDesingCost));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1252, 51, false);
#line 42 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EstimatedDesingCost));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1366, 48, false);
#line 45 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ActuLaborPro));

#line default
#line hidden
            EndContext();
            BeginContext(1414, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1478, 44, false);
#line 48 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ActuLaborPro));

#line default
#line hidden
            EndContext();
            BeginContext(1522, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1585, 52, false);
#line 51 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EstLaborProdCost));

#line default
#line hidden
            EndContext();
            BeginContext(1637, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1701, 48, false);
#line 54 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EstLaborProdCost));

#line default
#line hidden
            EndContext();
            BeginContext(1749, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1812, 55, false);
#line 57 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ActuLaborDesingCost));

#line default
#line hidden
            EndContext();
            BeginContext(1867, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1931, 51, false);
#line 60 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ActuLaborDesingCost));

#line default
#line hidden
            EndContext();
            BeginContext(1982, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2045, 54, false);
#line 63 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EstLaborDesingCost));

#line default
#line hidden
            EndContext();
            BeginContext(2099, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2163, 50, false);
#line 66 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EstLaborDesingCost));

#line default
#line hidden
            EndContext();
            BeginContext(2213, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2276, 43, false);
#line 69 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Project));

#line default
#line hidden
            EndContext();
            BeginContext(2319, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2383, 44, false);
#line 72 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Project.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2427, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2471, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82838e68e1daf701b44f3fec7ff7f119ac811da313893", async() => {
                BeginContext(2497, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2507, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "82838e68e1daf701b44f3fec7ff7f119ac811da314286", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "C:\Users\Weird.Scar\Documents\GitHub\New_NBD\NBD\Views\ProductionStageReports\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2543, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2626, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82838e68e1daf701b44f3fec7ff7f119ac811da316204", async() => {
                    BeginContext(2648, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2664, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2677, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NBD.Models.ProductionStageReport> Html { get; private set; }
    }
}
#pragma warning restore 1591
