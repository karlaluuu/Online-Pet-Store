#pragma checksum "K:\Karlaluuu-PC\Documents\Semester 6\API Engineering & Cloud Comp\Assignments\Project\Group Project\OnlinePetStoreDatabaseAPI\OnlinePetStoreInfoAPI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "229db5cc18c5b2be0dca0512591be9c9323c8e72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "K:\Karlaluuu-PC\Documents\Semester 6\API Engineering & Cloud Comp\Assignments\Project\Group Project\OnlinePetStoreDatabaseAPI\OnlinePetStoreInfoAPI\Views\_ViewImports.cshtml"
using OnlinePetStoreInfoAPI;

#line default
#line hidden
#line 2 "K:\Karlaluuu-PC\Documents\Semester 6\API Engineering & Cloud Comp\Assignments\Project\Group Project\OnlinePetStoreDatabaseAPI\OnlinePetStoreInfoAPI\Views\_ViewImports.cshtml"
using OnlinePetStoreInfoAPI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"229db5cc18c5b2be0dca0512591be9c9323c8e72", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"288f42c60cbdd2913a3a92f2eff5d2ff507577d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlinePetStoreInfoAPI.Models.PetStoreModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(64, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 2 "K:\Karlaluuu-PC\Documents\Semester 6\API Engineering & Cloud Comp\Assignments\Project\Group Project\OnlinePetStoreDatabaseAPI\OnlinePetStoreInfoAPI\Views\Home\Index.cshtml"
      
        ViewData["Title"] = "Home Page";
    

#line default
#line hidden
            BeginContext(121, 727, true);
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-4"">
            <h2>Welcome to Online Petstore</h2>
        </div>
        <div>
            <div id=""content"">
                <div id=""announcement"">
                    <center>
                        <p><marquee>Latest News: WEBSITE IS STILL UNDER MAINTENANCE!</marquee></p>
                    </center>
                </div>
            </div>
            <table class=""table table-condensed table-hover"">
                <tr class=""table-header"">
                    <th>StoreId</th>
                    <th>StoreName</th>
                    <th>StoreDescription</th>
                    <th>StoreAddress</th>
                    <th>Options</th>
");
            EndContext();
#line 25 "K:\Karlaluuu-PC\Documents\Semester 6\API Engineering & Cloud Comp\Assignments\Project\Group Project\OnlinePetStoreDatabaseAPI\OnlinePetStoreInfoAPI\Views\Home\Index.cshtml"
                 foreach(var item in Model)
                {

#line default
#line hidden
            BeginContext(912, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(959, 42, false);
#line 28 "K:\Karlaluuu-PC\Documents\Semester 6\API Engineering & Cloud Comp\Assignments\Project\Group Project\OnlinePetStoreDatabaseAPI\OnlinePetStoreInfoAPI\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StoreId));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1021, 44, false);
#line 29 "K:\Karlaluuu-PC\Documents\Semester 6\API Engineering & Cloud Comp\Assignments\Project\Group Project\OnlinePetStoreDatabaseAPI\OnlinePetStoreInfoAPI\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.StoreName));

#line default
#line hidden
            EndContext();
            BeginContext(1065, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1085, 51, false);
#line 30 "K:\Karlaluuu-PC\Documents\Semester 6\API Engineering & Cloud Comp\Assignments\Project\Group Project\OnlinePetStoreDatabaseAPI\OnlinePetStoreInfoAPI\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.StoreDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1156, 47, false);
#line 31 "K:\Karlaluuu-PC\Documents\Semester 6\API Engineering & Cloud Comp\Assignments\Project\Group Project\OnlinePetStoreDatabaseAPI\OnlinePetStoreInfoAPI\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.StoreAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1260, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6c5001c760144369edd9821c0f35c2c", async() => {
                BeginContext(1310, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "K:\Karlaluuu-PC\Documents\Semester 6\API Engineering & Cloud Comp\Assignments\Project\Group Project\OnlinePetStoreDatabaseAPI\OnlinePetStoreInfoAPI\Views\Home\Index.cshtml"
                                               WriteLiteral(item.StoreId);

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
            BeginContext(1318, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1346, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8f4940f9cd342e2bc5da16f7d58c237", async() => {
                BeginContext(1398, 6, true);
                WriteLiteral("Delete");
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
#line 34 "K:\Karlaluuu-PC\Documents\Semester 6\API Engineering & Cloud Comp\Assignments\Project\Group Project\OnlinePetStoreDatabaseAPI\OnlinePetStoreInfoAPI\Views\Home\Index.cshtml"
                                                 WriteLiteral(item.StoreId);

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
            BeginContext(1408, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 37 "K:\Karlaluuu-PC\Documents\Semester 6\API Engineering & Cloud Comp\Assignments\Project\Group Project\OnlinePetStoreDatabaseAPI\OnlinePetStoreInfoAPI\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1479, 56, true);
            WriteLiteral("            </table>\r\n            <button type=\"submit\">");
            EndContext();
            BeginContext(1535, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74108a69ea2743b8b80649be32f64917", async() => {
                BeginContext(1558, 11, true);
                WriteLiteral("Add a store");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(1573, 53, true);
            WriteLiteral("</button>\r\n            \r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlinePetStoreInfoAPI.Models.PetStoreModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
