#pragma checksum "D:\AgileFoodOrder\OrderFoodLast\Areas\Admin\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab2ef4f83fd010f23641420dd94f4df5cc6f7c08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Order/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Order_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab2ef4f83fd010f23641420dd94f4df5cc6f7c08", @"/Areas/Admin/Views/Order/Index.cshtml")]
    public class Areas_Admin_Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\AgileFoodOrder\OrderFoodLast\Areas\Admin\Views\Order\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(59, 36, false);
#line 9 "D:\AgileFoodOrder\OrderFoodLast\Areas\Admin\Views\Order\Index.cshtml"
Write(await Html.PartialAsync("_MyHeader"));

#line default
#line hidden
            EndContext();
            BeginContext(95, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(97, 381, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab2ef4f83fd010f23641420dd94f4df5cc6f7c083389", async() => {
                BeginContext(103, 37, true);
                WriteLiteral("\r\n    <div class=\"wrapper\">\r\n        ");
                EndContext();
                BeginContext(141, 33, false);
#line 12 "D:\AgileFoodOrder\OrderFoodLast\Areas\Admin\Views\Order\Index.cshtml"
   Write(await Html.PartialAsync("_MyNav"));

#line default
#line hidden
                EndContext();
                BeginContext(174, 47, true);
                WriteLiteral("\r\n        <div class=\"container\">\r\n            ");
                EndContext();
                BeginContext(222, 33, false);
#line 14 "D:\AgileFoodOrder\OrderFoodLast\Areas\Admin\Views\Order\Index.cshtml"
       Write(await Html.PartialAsync("_MyBar"));

#line default
#line hidden
                EndContext();
                BeginContext(255, 32, true);
                WriteLiteral("\r\n\r\n            <!-- detail-->\r\n");
                EndContext();
                BeginContext(341, 47, true);
                WriteLiteral("            <!-- end detail -->\r\n\r\n            ");
                EndContext();
                BeginContext(389, 36, false);
#line 20 "D:\AgileFoodOrder\OrderFoodLast\Areas\Admin\Views\Order\Index.cshtml"
       Write(await Html.PartialAsync("ListOrder"));

#line default
#line hidden
                EndContext();
                BeginContext(425, 46, true);
                WriteLiteral("\r\n        </div>\r\n        \r\n    </div>\r\n    \r\n");
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
            BeginContext(478, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(481, 36, false);
#line 26 "D:\AgileFoodOrder\OrderFoodLast\Areas\Admin\Views\Order\Index.cshtml"
Write(await Html.PartialAsync("_MyFooter"));

#line default
#line hidden
            EndContext();
            BeginContext(517, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
