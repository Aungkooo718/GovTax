#pragma checksum "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3a96ffbc41a45243f5499089deda5e6ab6a329a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaxPayers_Details), @"mvc.1.0.view", @"/Views/TaxPayers/Details.cshtml")]
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
#nullable restore
#line 1 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\_ViewImports.cshtml"
using GovernmentTaxPrj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\_ViewImports.cshtml"
using GovernmentTaxPrj.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3a96ffbc41a45243f5499089deda5e6ab6a329a", @"/Views/TaxPayers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cedae53dbc8e389024b6221f6a8e85e1562963cf", @"/Views/_ViewImports.cshtml")]
    public class Views_TaxPayers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GovernmentTaxPrj.Models.TaxPayer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""content-header"">
    <h1>Details</h1>
</section>
<section class=""content"">
    <div class=""box box-default"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Detail of TaxPayer</h3>
        </div> 
        <div class=""box-body"">
            <div>
                <h4>TaxPayer</h4>
                <hr />
                <dl class=""row"">
                    <dt class=""col-sm-2"">
                        ");
#nullable restore
#line 20 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 23 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 26 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.TinNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 29 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml"
                   Write(Html.DisplayFor(model => model.TinNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 32 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 35 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 38 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nrc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 41 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Nrc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 44 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.TaxType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 47 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml"
                   Write(Html.DisplayFor(model => model.TaxType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 50 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Township));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 53 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Township.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </dd>
                </dl>
            </div>
            <div class=""row"">
                <div>
                <h3>အခွန်ဆောင်ထားသောစာရင်း</h3>
                    <table class=""table-bordered"" style=""width:350px; height:auto;border-width:thick;"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th>No</th>
                                <th>TaxPayer Name</th>
                                <th>Income Type</th>
                                <th>Amount</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>");
#nullable restore
#line 72 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 73 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml"
                               Write(Model.TaxType);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                <td>120000</td>
                            </tr>
                        </tbody>
                    </table>
                </div>&nbsp;&nbsp;
                <div>
                    <h3>အသုံးပြုထားသောစာရင်း</h3>
                    <table class=""table-bordered"" style=""width:350px; height:auto;border-width:thick"">
                        <thead>
                            <tr>
                                <th>No</th>
                                <th>UsedCar</th>
                                <th>TaxAmount</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>2Yrs</td>
                                <td>12000</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <div>
    ");
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3a96ffbc41a45243f5499089deda5e6ab6a329a11944", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 100 "D:\entity framework\GovernmentTaxPrj\GovernmentTaxPrj\Views\TaxPayers\Details.cshtml"
                                                                            WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3a96ffbc41a45243f5499089deda5e6ab6a329a14237", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GovernmentTaxPrj.Models.TaxPayer> Html { get; private set; }
    }
}
#pragma warning restore 1591
