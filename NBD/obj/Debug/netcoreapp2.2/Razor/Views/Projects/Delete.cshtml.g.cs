#pragma checksum "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2525b1fd38b4cfed00fdd2cdfa547622435e0027"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Delete), @"mvc.1.0.view", @"/Views/Projects/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Delete.cshtml", typeof(AspNetCore.Views_Projects_Delete))]
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
#line 1 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\_ViewImports.cshtml"
using NBD;

#line default
#line hidden
#line 2 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\_ViewImports.cshtml"
using NBD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2525b1fd38b4cfed00fdd2cdfa547622435e0027", @"/Views/Projects/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877786879ad765db0577617c19ecaf8320d35743", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NBD.Models.Project>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(71, 177, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Project</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(249, 40, false);
#line 15 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(289, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(353, 36, false);
#line 18 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(389, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(452, 44, false);
#line 21 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjSite));

#line default
#line hidden
            EndContext();
            BeginContext(496, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(560, 40, false);
#line 24 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProjSite));

#line default
#line hidden
            EndContext();
            BeginContext(600, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(663, 47, false);
#line 27 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjBidDate));

#line default
#line hidden
            EndContext();
            BeginContext(710, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(774, 43, false);
#line 30 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProjBidDate));

#line default
#line hidden
            EndContext();
            BeginContext(817, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(880, 48, false);
#line 33 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EstStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(928, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(992, 44, false);
#line 36 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EstStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1099, 46, false);
#line 39 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EstEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1145, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1209, 42, false);
#line 42 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EstEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1251, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1314, 45, false);
#line 45 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1423, 41, false);
#line 48 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1464, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1527, 43, false);
#line 51 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1570, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1634, 39, false);
#line 54 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1673, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1736, 45, false);
#line 57 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ActAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1781, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1845, 41, false);
#line 60 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ActAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1886, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1949, 45, false);
#line 63 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EstAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1994, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2058, 41, false);
#line 66 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EstAmount));

#line default
#line hidden
            EndContext();
            BeginContext(2099, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2162, 50, false);
#line 69 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ClientApproval));

#line default
#line hidden
            EndContext();
            BeginContext(2212, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2276, 46, false);
#line 72 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ClientApproval));

#line default
#line hidden
            EndContext();
            BeginContext(2322, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2385, 49, false);
#line 75 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AdminApproval));

#line default
#line hidden
            EndContext();
            BeginContext(2434, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2498, 45, false);
#line 78 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AdminApproval));

#line default
#line hidden
            EndContext();
            BeginContext(2543, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2606, 52, false);
#line 81 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjCurrentPhase));

#line default
#line hidden
            EndContext();
            BeginContext(2658, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2722, 48, false);
#line 84 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProjCurrentPhase));

#line default
#line hidden
            EndContext();
            BeginContext(2770, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2833, 49, false);
#line 87 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjIsFlagged));

#line default
#line hidden
            EndContext();
            BeginContext(2882, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2946, 45, false);
#line 90 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProjIsFlagged));

#line default
#line hidden
            EndContext();
            BeginContext(2991, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3054, 42, false);
#line 93 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client));

#line default
#line hidden
            EndContext();
            BeginContext(3096, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3160, 46, false);
#line 96 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.Address));

#line default
#line hidden
            EndContext();
            BeginContext(3206, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3250, 228, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2525b1fd38b4cfed00fdd2cdfa547622435e002717232", async() => {
                BeginContext(3276, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3286, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2525b1fd38b4cfed00fdd2cdfa547622435e002717625", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 101 "C:\Users\Dhrumil Dave\Documents\GitHub\New_NBD\NBD\Views\Projects\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

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
                BeginContext(3322, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(3405, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2525b1fd38b4cfed00fdd2cdfa547622435e002719532", async() => {
                    BeginContext(3449, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3465, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3478, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NBD.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
