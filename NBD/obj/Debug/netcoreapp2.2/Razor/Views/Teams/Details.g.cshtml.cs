#pragma checksum "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f33662573b3acb7084dff71d7c1ed9b4e7d1d958"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teams_Details), @"mvc.1.0.view", @"/Views/Teams/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teams/Details.cshtml", typeof(AspNetCore.Views_Teams_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f33662573b3acb7084dff71d7c1ed9b4e7d1d958", @"/Views/Teams/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877786879ad765db0577617c19ecaf8320d35743", @"/Views/_ViewImports.cshtml")]
    public class Views_Teams_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NBD.Models.Team>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(69, 37, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>");
            EndContext();
            BeginContext(107, 40, false);
#line 10 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
   Write(Html.DisplayFor(model => model.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(147, 84, true);
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(232, 38, false);
#line 14 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(270, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(332, 34, false);
#line 17 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
       Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(366, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(427, 41, false);
#line 20 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phase));

#line default
#line hidden
            EndContext();
            BeginContext(468, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(530, 37, false);
#line 23 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phase));

#line default
#line hidden
            EndContext();
            BeginContext(567, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(628, 44, false);
#line 26 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(672, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(734, 40, false);
#line 29 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
       Write(Html.DisplayFor(model => model.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(774, 49, true);
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n");
            EndContext();
#line 32 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
              
                int empCount = Model.TeamEmployees.Count;
                if (empCount > 0)
                {
                    string firstEmployee = Model.TeamEmployees.FirstOrDefault().Employee.FullName;
                    if (empCount > 1)
                    {
                        string empList = "";
                        var c = Model.TeamEmployees.ToList();
                        for (int i = 1; i < empCount; i++)
                        {
                            empList += c[i].Employee.FullName + " <br />";
                        }

#line default
#line hidden
            BeginContext(1413, 72, true);
            WriteLiteral("                        <a class=\"\" role=\"button\" data-toggle=\"collapse\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1485, "\"", 1518, 2);
            WriteAttributeValue("", 1492, "#collapseCamper", 1492, 15, true);
#line 45 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
WriteAttributeValue("", 1507, Model.ID, 1507, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1519, 22, true);
            WriteLiteral(" aria-expanded=\"false\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1541, "\"", 1582, 2);
            WriteAttributeValue("", 1557, "collapseCamper", 1557, 14, true);
#line 45 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
WriteAttributeValue("", 1571, Model.ID, 1571, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1583, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(1615, 13, false);
#line 46 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
                       Write(firstEmployee);

#line default
#line hidden
            EndContext();
            BeginContext(1628, 35, true);
            WriteLiteral("... <span class=\"badge badge-info\">");
            EndContext();
            BeginContext(1664, 8, false);
#line 46 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
                                                                        Write(empCount);

#line default
#line hidden
            EndContext();
            BeginContext(1672, 84, true);
            WriteLiteral("</span>\r\n                        </a>\r\n                        <div class=\"collapse\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1756, "\"", 1786, 2);
            WriteAttributeValue("", 1761, "collapseCamper", 1761, 14, true);
#line 48 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
WriteAttributeValue("", 1775, Model.ID, 1775, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1787, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(1819, 17, false);
#line 49 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
                       Write(Html.Raw(empList));

#line default
#line hidden
            EndContext();
            BeginContext(1836, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
#line 51 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(1967, 13, false);
#line 54 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
                   Write(firstEmployee);

#line default
#line hidden
            EndContext();
#line 54 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
                                      
                    }
                }
            

#line default
#line hidden
            BeginContext(2039, 45, true);
            WriteLiteral("        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2084, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f33662573b3acb7084dff71d7c1ed9b4e7d1d95812179", async() => {
                BeginContext(2152, 4, true);
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
#line 62 "C:\Users\Administrator\Documents\GitHub\New_NBD\NBD\Views\Teams\Details.cshtml"
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
            BeginContext(2160, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2168, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f33662573b3acb7084dff71d7c1ed9b4e7d1d95814605", async() => {
                BeginContext(2213, 12, true);
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
            BeginContext(2229, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NBD.Models.Team> Html { get; private set; }
    }
}
#pragma warning restore 1591
