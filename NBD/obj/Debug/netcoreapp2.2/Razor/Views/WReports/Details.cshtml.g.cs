#pragma checksum "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\WReports\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b02a1d3fb17e734bd4a28374a1e526563c5cbab7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WReports_Details), @"mvc.1.0.view", @"/Views/WReports/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WReports/Details.cshtml", typeof(AspNetCore.Views_WReports_Details))]
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
#line 1 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\_ViewImports.cshtml"
using NBD;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\_ViewImports.cshtml"
using NBD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b02a1d3fb17e734bd4a28374a1e526563c5cbab7", @"/Views/WReports/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877786879ad765db0577617c19ecaf8320d35743", @"/Views/_ViewImports.cshtml")]
    public class Views_WReports_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NBD.Models.WReport>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\WReports\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(72, 141, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Worker Report</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n\r\n        <dt class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(214, 40, false);
#line 16 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\WReports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.date));

#line default
#line hidden
            EndContext();
            BeginContext(254, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-5\">\r\n            ");
            EndContext();
            BeginContext(317, 36, false);
#line 19 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\WReports\Details.cshtml"
       Write(Html.DisplayFor(model => model.date));

#line default
#line hidden
            EndContext();
            BeginContext(353, 63, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(417, 40, false);
#line 22 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\WReports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hour));

#line default
#line hidden
            EndContext();
            BeginContext(457, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-5\">\r\n            ");
            EndContext();
            BeginContext(520, 36, false);
#line 25 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\WReports\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hour));

#line default
#line hidden
            EndContext();
            BeginContext(556, 63, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(620, 40, false);
#line 28 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\WReports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(660, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-5\">\r\n            ");
            EndContext();
            BeginContext(723, 36, false);
#line 31 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\WReports\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(759, 63, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(823, 44, false);
#line 34 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\WReports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee));

#line default
#line hidden
            EndContext();
            BeginContext(867, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-5\">\r\n            ");
            EndContext();
            BeginContext(930, 49, false);
#line 37 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\WReports\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(979, 63, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1043, 40, false);
#line 40 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\WReports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Task));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-5\">\r\n            ");
            EndContext();
            BeginContext(1146, 48, false);
#line 43 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\WReports\Details.cshtml"
       Write(Html.DisplayFor(model => model.Task.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 63, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1258, 43, false);
#line 46 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\WReports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project));

#line default
#line hidden
            EndContext();
            BeginContext(1301, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-5\">\r\n            ");
            EndContext();
            BeginContext(1364, 44, false);
#line 49 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\WReports\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1408, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1456, 68, false);
#line 54 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\WReports\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1532, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b02a1d3fb17e734bd4a28374a1e526563c5cbab79394", async() => {
                BeginContext(1554, 12, true);
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
            BeginContext(1570, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NBD.Models.WReport> Html { get; private set; }
    }
}
#pragma warning restore 1591
