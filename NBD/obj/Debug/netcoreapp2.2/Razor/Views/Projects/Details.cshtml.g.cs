#pragma checksum "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ad410efe69366f36f9391c39154ba78aedf936c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Details), @"mvc.1.0.view", @"/Views/Projects/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Details.cshtml", typeof(AspNetCore.Views_Projects_Details))]
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
#line 1 "C:\Users\Administrator\Downloads\NBD\Views\_ViewImports.cshtml"
using NBD;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Downloads\NBD\Views\_ViewImports.cshtml"
using NBD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad410efe69366f36f9391c39154ba78aedf936c", @"/Views/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877786879ad765db0577617c19ecaf8320d35743", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NBD.Models.Project>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
  
    ViewData["Title"] = "Project Details";

#line default
#line hidden
            BeginContext(80, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(109, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad410efe69366f36f9391c39154ba78aedf936c5035", async() => {
                BeginContext(115, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
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
            BeginContext(211, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(213, 3831, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad410efe69366f36f9391c39154ba78aedf936c6313", async() => {
                BeginContext(219, 134, true);
                WriteLiteral("\r\n\r\n    <div>\r\n        <h4>Project</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
                EndContext();
                BeginContext(354, 40, false);
#line 21 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(394, 73, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
                EndContext();
                BeginContext(468, 36, false);
#line 24 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(504, 74, true);
                WriteLiteral("\r\n            </dd>\r\n\r\n            <dt class=\"col-sm-2\">\r\n                ");
                EndContext();
                BeginContext(579, 45, false);
#line 28 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
                EndContext();
                BeginContext(624, 73, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
                EndContext();
                BeginContext(698, 41, false);
#line 31 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
           Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
                EndContext();
                BeginContext(739, 72, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
                EndContext();
                BeginContext(812, 43, false);
#line 34 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
                EndContext();
                BeginContext(855, 73, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
                EndContext();
                BeginContext(929, 39, false);
#line 37 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
           Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
                EndContext();
                BeginContext(968, 74, true);
                WriteLiteral("\r\n            </dd>\r\n\r\n            <dt class=\"col-sm-2\">\r\n                ");
                EndContext();
                BeginContext(1043, 42, false);
#line 41 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
                EndContext();
                BeginContext(1085, 73, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
                EndContext();
                BeginContext(1159, 38, false);
#line 44 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
           Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
                EndContext();
                BeginContext(1197, 72, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
                EndContext();
                BeginContext(1270, 47, false);
#line 47 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ProdBidSite));

#line default
#line hidden
                EndContext();
                BeginContext(1317, 73, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
                EndContext();
                BeginContext(1391, 43, false);
#line 50 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
           Write(Html.DisplayFor(model => model.ProdBidSite));

#line default
#line hidden
                EndContext();
                BeginContext(1434, 184, true);
                WriteLiteral("\r\n            </dd>\r\n\r\n        </dl>\r\n      <h4>Project Bid Details:</h4>\r\n            <hr />\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
                EndContext();
                BeginContext(1619, 48, false);
#line 58 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.EstStartDate));

#line default
#line hidden
                EndContext();
                BeginContext(1667, 85, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
                EndContext();
                BeginContext(1753, 44, false);
#line 61 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(model => model.EstStartDate));

#line default
#line hidden
                EndContext();
                BeginContext(1797, 84, true);
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
                EndContext();
                BeginContext(1882, 46, false);
#line 64 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.EstEndDate));

#line default
#line hidden
                EndContext();
                BeginContext(1928, 85, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
                EndContext();
                BeginContext(2014, 42, false);
#line 67 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(model => model.EstEndDate));

#line default
#line hidden
                EndContext();
                BeginContext(2056, 86, true);
                WriteLiteral("\r\n                </dd>\r\n\r\n                <dt class=\"col-sm-2\">\r\n                    ");
                EndContext();
                BeginContext(2143, 45, false);
#line 71 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.BidAmount));

#line default
#line hidden
                EndContext();
                BeginContext(2188, 85, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
                EndContext();
                BeginContext(2274, 41, false);
#line 74 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(model => model.BidAmount));

#line default
#line hidden
                EndContext();
                BeginContext(2315, 84, true);
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
                EndContext();
                BeginContext(2400, 50, false);
#line 77 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ClientApproval));

#line default
#line hidden
                EndContext();
                BeginContext(2450, 85, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
                EndContext();
                BeginContext(2536, 46, false);
#line 80 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(model => model.ClientApproval));

#line default
#line hidden
                EndContext();
                BeginContext(2582, 84, true);
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
                EndContext();
                BeginContext(2667, 49, false);
#line 83 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.AdminApproval));

#line default
#line hidden
                EndContext();
                BeginContext(2716, 85, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
                EndContext();
                BeginContext(2802, 45, false);
#line 86 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(model => model.AdminApproval));

#line default
#line hidden
                EndContext();
                BeginContext(2847, 84, true);
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
                EndContext();
                BeginContext(2932, 42, false);
#line 89 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Client));

#line default
#line hidden
                EndContext();
                BeginContext(2974, 85, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
                EndContext();
                BeginContext(3060, 50, false);
#line 92 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(model => model.Client.CompanyName));

#line default
#line hidden
                EndContext();
                BeginContext(3110, 202, true);
                WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n            \r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(3313, 54, false);
#line 100 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.ProjectInventories));

#line default
#line hidden
                EndContext();
                BeginContext(3367, 111, true);
                WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
                EndContext();
#line 105 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
                     foreach (var item in Model.ProjectInventories)
                    {

#line default
#line hidden
                BeginContext(3570, 96, true);
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(3667, 49, false);
#line 109 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Inventory.Name));

#line default
#line hidden
                EndContext();
                BeginContext(3716, 76, true);
                WriteLiteral("\r\n\r\n\r\n\r\n                            </td>\r\n\r\n                        </tr>\r\n");
                EndContext();
#line 116 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
                    }

#line default
#line hidden
                BeginContext(3815, 69, true);
                WriteLiteral("                </tbody>\r\n\r\n            </table>\r\n</div>\r\n<div>\r\n    ");
                EndContext();
                BeginContext(3884, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad410efe69366f36f9391c39154ba78aedf936c18863", async() => {
                    BeginContext(3952, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 122 "C:\Users\Administrator\Downloads\NBD\Views\Projects\Details.cshtml"
                                                 WriteLiteral(Model.ID);

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
                BeginContext(3960, 7, true);
                WriteLiteral(" \r\n    ");
                EndContext();
                BeginContext(3967, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad410efe69366f36f9391c39154ba78aedf936c21401", async() => {
                    BeginContext(4011, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4027, 10, true);
                WriteLiteral("\r\n</div>\r\n");
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
            BeginContext(4044, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NBD.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
