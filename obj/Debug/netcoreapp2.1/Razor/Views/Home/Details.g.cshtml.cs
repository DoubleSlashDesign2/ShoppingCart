#pragma checksum "D:\Studies\5th Semester\Internet Technologies\assignment2\Proj2\ShoppingCart\ShoppingCart\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a5252d688a6936f076cd69d0511ce32bac687fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "D:\Studies\5th Semester\Internet Technologies\assignment2\Proj2\ShoppingCart\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart;

#line default
#line hidden
#line 2 "D:\Studies\5th Semester\Internet Technologies\assignment2\Proj2\ShoppingCart\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a5252d688a6936f076cd69d0511ce32bac687fc", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65a8198b297c3ea7f3bc4f7f8cdac67c148a265", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart.Models.Cateogary>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "View", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 5 "D:\Studies\5th Semester\Internet Technologies\assignment2\Proj2\ShoppingCart\ShoppingCart\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 7, true);
            WriteLiteral("\r\n<h2> ");
            EndContext();
            BeginContext(95, 37, false);
#line 9 "D:\Studies\5th Semester\Internet Technologies\assignment2\Proj2\ShoppingCart\ShoppingCart\Views\Home\Details.cshtml"
Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(132, 47, true);
            WriteLiteral("</h2>\r\n\r\n<table class=\"table\">\r\n\r\n    <tbody>\r\n");
            EndContext();
#line 14 "D:\Studies\5th Semester\Internet Technologies\assignment2\Proj2\ShoppingCart\ShoppingCart\Views\Home\Details.cshtml"
         foreach (var item in Model.Products)
        {

#line default
#line hidden
            BeginContext(237, 65, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <h4> ");
            EndContext();
            BeginContext(303, 40, false);
#line 18 "D:\Studies\5th Semester\Internet Technologies\assignment2\Proj2\ShoppingCart\ShoppingCart\Views\Home\Details.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(343, 76, true);
            WriteLiteral("</h4>\r\n                </td>\r\n                <td>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 419, "\"", 471, 1);
#line 21 "D:\Studies\5th Semester\Internet Technologies\assignment2\Proj2\ShoppingCart\ShoppingCart\Views\Home\Details.cshtml"
WriteAttributeValue(" ", 425, Html.DisplayFor(modelItem => item.Imagepath), 426, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(472, 95, true);
            WriteLiteral(" height=\"200\" width=\"150\" />\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(567, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd0a726bef134091a4cbcae90436fcce", async() => {
                BeginContext(619, 12, true);
                WriteLiteral("View Product");
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
#line 24 "D:\Studies\5th Semester\Internet Technologies\assignment2\Proj2\ShoppingCart\ShoppingCart\Views\Home\Details.cshtml"
                                           WriteLiteral(item.ProductID);

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
            BeginContext(635, 48, true);
            WriteLiteral("\r\n\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 29 "D:\Studies\5th Semester\Internet Technologies\assignment2\Proj2\ShoppingCart\ShoppingCart\Views\Home\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(694, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart.Models.Cateogary> Html { get; private set; }
    }
}
#pragma warning restore 1591