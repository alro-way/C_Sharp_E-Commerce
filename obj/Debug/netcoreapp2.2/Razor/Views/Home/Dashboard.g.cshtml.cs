#pragma checksum "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e87e7bc84da93f864514edb95233390550443662"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\_ViewImports.cshtml"
using C_Sharp_ECommerce;

#line default
#line hidden
#line 1 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
using C_Sharp_ECommerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e87e7bc84da93f864514edb95233390550443662", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3b3bc7851711012c7f1161d879ea0628ec3d718", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("customer/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Customers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 57, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        ");
            EndContext();
            BeginContext(108, 419, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87e7bc84da93f864514edb952333905504436625525", async() => {
                BeginContext(153, 367, true);
                WriteLiteral(@"
            <div class=""form-group"">
                <label name=""Name"">Search Product by Name:</label>
                <input type=""text"" class=""form-control"" name=""Name"">
                <span class=""valid"" name=""Name""></span>
            </div>
            
            <button type=""submit"" class=""btn btn-info"">Search</button>
            <br>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(527, 347, true);
            WriteLiteral(@"
        <br>
        <br>
    </div>
        
    <div class=""col-sm-8"">
        <div class=""row"">
            <div class=""col-sm-3"">.col-sm-3</div>
            <div class=""col-sm-3"">.col-sm-3</div>
            <div class=""col-sm-3"">.col-sm-3</div>
            <div class=""col-sm-3"">.col-sm-3</div>
            <br>
            <br>
");
            EndContext();
#line 28 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
             foreach(var prod in ViewBag.LastProducts)
            {

#line default
#line hidden
            BeginContext(945, 114, true);
            WriteLiteral("                <br>\r\n                <div class=\"col-sm-3\">\r\n                    <img width=\"80%\" class=\"prodImg\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1059, "\"", 1074, 1);
#line 32 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1065, prod.Img, 1065, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1075, "\"", 1124, 6);
            WriteAttributeValue("", 1081, "Here", 1081, 4, true);
            WriteAttributeValue(" ", 1085, "should", 1086, 7, true);
            WriteAttributeValue(" ", 1092, "be", 1093, 3, true);
            WriteAttributeValue(" ", 1095, "picture", 1096, 8, true);
            WriteAttributeValue(" ", 1103, "of", 1104, 3, true);
#line 32 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
WriteAttributeValue(" ", 1106, prod.ProductName, 1107, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1125, 25, true);
            WriteLiteral(">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1150, "\"", 1181, 2);
            WriteAttributeValue("", 1157, "/product/", 1157, 9, true);
#line 33 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1166, prod.ProductId, 1166, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1182, 31, true);
            WriteLiteral(">\r\n                        <h6>");
            EndContext();
            BeginContext(1214, 16, false);
#line 34 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
                       Write(prod.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1230, 57, true);
            WriteLiteral("</h6>\r\n                    </a>\r\n                    <p>(");
            EndContext();
            BeginContext(1288, 10, false);
#line 36 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
                   Write(prod.Quant);

#line default
#line hidden
            EndContext();
            BeginContext(1298, 58, true);
            WriteLiteral(" left)</p>\r\n                </div>\r\n                <br>\r\n");
            EndContext();
#line 39 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
            }

#line default
#line hidden
            BeginContext(1371, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1383, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87e7bc84da93f864514edb9523339055044366211285", async() => {
                BeginContext(1430, 21, true);
                WriteLiteral("Show more Products...");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
            BeginContext(1455, 125, true);
            WriteLiteral("\r\n            <br>\r\n            <br>\r\n        </div>\r\n\r\n        <div >\r\n            <h4>Recent Orders</h4>\r\n            <p>\r\n");
            EndContext();
#line 48 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
             foreach(var order in ViewBag.LastOrders)
            {

#line default
#line hidden
            BeginContext(1650, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(1670, 16, false);
#line 50 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
              Write(order.Buyer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1686, 11, true);
            WriteLiteral(" purchased ");
            EndContext();
            BeginContext(1698, 19, false);
#line 50 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
                                          Write(order.OrderQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(1717, 4, true);
            WriteLiteral(" of ");
            EndContext();
            BeginContext(1722, 26, false);
#line 50 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
                                                                  Write(order.Purchase.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1748, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(1752, 49, false);
#line 50 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
                                                                                                Write((@DateTime.Now - @order.CreatedAt).ToString("%m"));

#line default
#line hidden
            EndContext();
            BeginContext(1802, 19, true);
            WriteLiteral(" minutes ago)</p>\r\n");
            EndContext();
#line 51 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
            }

#line default
#line hidden
            BeginContext(1836, 30, true);
            WriteLiteral("            </p>\r\n            ");
            EndContext();
            BeginContext(1866, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87e7bc84da93f864514edb9523339055044366215409", async() => {
                BeginContext(1911, 18, true);
                WriteLiteral("Show all Orders...");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1933, 125, true);
            WriteLiteral("\r\n            <br>\r\n            <br>\r\n        </div>\r\n\r\n        <div >\r\n            <h4>New Customers</h4>\r\n            <p>\r\n");
            EndContext();
#line 61 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
             foreach(var cust in ViewBag.LastCustomers)
            {

#line default
#line hidden
            BeginContext(2130, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(2150, 9, false);
#line 63 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
              Write(cust.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2159, 19, true);
            WriteLiteral(" joined the store (");
            EndContext();
            BeginContext(2180, 48, false);
#line 63 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
                                            Write((@DateTime.Now - @cust.CreatedAt).ToString("%m"));

#line default
#line hidden
            EndContext();
            BeginContext(2229, 19, true);
            WriteLiteral(" minutes ago)</p>\r\n");
            EndContext();
#line 64 "D:\ALEX_and_SASHA\07 Training\Coding Dojo\c#_stack\C_Sharp_Assignments\C_Sharp_ECommerce\Views\Home\Dashboard.cshtml"
            }

#line default
#line hidden
            BeginContext(2263, 30, true);
            WriteLiteral("            </p>\r\n            ");
            EndContext();
            BeginContext(2293, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87e7bc84da93f864514edb9523339055044366218638", async() => {
                BeginContext(2341, 21, true);
                WriteLiteral("Show all Customers...");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2366, 86, true);
            WriteLiteral("\r\n            <br>\r\n            <br>\r\n        </div>\r\n\r\n        \r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
