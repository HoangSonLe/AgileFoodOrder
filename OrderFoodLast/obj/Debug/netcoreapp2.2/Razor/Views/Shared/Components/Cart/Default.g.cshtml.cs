#pragma checksum "E:\dotnetlab\OrderFoodLast\OrderFoodLast\Views\Shared\Components\Cart\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa45345b1ef7a688aa58c19a6b0fa2f5cea69421"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Cart_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Cart/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Cart/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Cart_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa45345b1ef7a688aa58c19a6b0fa2f5cea69421", @"/Views/Shared/Components/Cart/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f11a11eb09feb1fffe737ceef46d12b533a5beb2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Cart_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1843, true);
            WriteLiteral(@"<div class=""my-cart"">
    <ul>
        <li>
            <a href=""#""><i class=""fa fa-shopping-cart""></i>My Cart</a>
            <span>2</span>
            <div class=""mini-cart-sub"">
                <div class=""cart-product"">
                    <div class=""single-cart"">
                        <div class=""cart-img"">
                            <a href=""#""><img src=""img/product/1.jpg"" alt=""book"" /></a>
                        </div>
                        <div class=""cart-info"">
                            <h5><a href=""#"">Joust Duffle Bag</a></h5>
                            <p>1 x £60.000000000000000</p>
                        </div>
                        <div class=""cart-icon"">
                            <a href=""#""><i class=""fa fa-remove""></i></a>
                        </div>
                    </div>
                    <div class=""single-cart"">
                        <div class=""cart-img"">
                            <a href=""#""><img src=""img/product/3.jpg"" alt=""book"" /></a>");
            WriteLiteral(@"
                        </div>
                        <div class=""cart-info"">
                            <h5><a href=""#"">Chaz Kangeroo Hoodie</a></h5>
                            <p>1 x £52.00</p>
                        </div>
                        <div class=""cart-icon"">
                            <a href=""#""><i class=""fa fa-remove""></i></a>
                        </div>
                    </div>
                </div>
                <div class=""cart-totals"">
                    <h5>Total <span>£12.00</span></h5>
                </div>
                <div class=""cart-bottom"">
                    <a class=""view-cart"" href=""cart.html"">view cart</a>
                    <a href=""checkout.html"">Check out</a>
                </div>
            </div>
        </li>
    </ul>
</div>
");
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
