#pragma checksum "E:\dotnetlab\OrderFoodLast\OrderFoodLast\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d99673892517a87af4363de0a0ba1b0f610eda6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
#line 1 "E:\dotnetlab\OrderFoodLast\OrderFoodLast\Views\_ViewImports.cshtml"
using OrderFoodLast;

#line default
#line hidden
#line 2 "E:\dotnetlab\OrderFoodLast\OrderFoodLast\Views\_ViewImports.cshtml"
using OrderFoodLast.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d99673892517a87af4363de0a0ba1b0f610eda6", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f11a11eb09feb1fffe737ceef46d12b533a5beb2", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 28, true);
            WriteLiteral("<!-- header-area-start -->\r\n");
            EndContext();
            BeginContext(29, 36, false);
#line 2 "E:\dotnetlab\OrderFoodLast\OrderFoodLast\Views\Cart\Index.cshtml"
Write(await Html.PartialAsync("_MyHeader"));

#line default
#line hidden
            EndContext();
            BeginContext(65, 61, true);
            WriteLiteral("\r\n<!-- header-area-end -->\r\n<!-- breadcrumbs-area-start -->\r\n");
            EndContext();
            BeginContext(127, 39, false);
#line 5 "E:\dotnetlab\OrderFoodLast\OrderFoodLast\Views\Cart\Index.cshtml"
Write(await Html.PartialAsync("_Breadcrumbs"));

#line default
#line hidden
            EndContext();
            BeginContext(166, 421, true);
            WriteLiteral(@"
<!-- breadcrumbs-area-end -->
<!-- entry-header-area-start -->
<div class=""entry-header-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""entry-header-title"">
                    <h2>Cart</h2>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- entry-header-area-end -->
<!-- cart-main-area-start -->
");
            EndContext();
            BeginContext(588, 37, false);
#line 21 "E:\dotnetlab\OrderFoodLast\OrderFoodLast\Views\Cart\Index.cshtml"
Write(await Html.PartialAsync("CartDetail"));

#line default
#line hidden
            EndContext();
            BeginContext(625, 29, true);
            WriteLiteral("\r\n<!-- cart-main-area-end -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
