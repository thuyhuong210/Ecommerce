#pragma checksum "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\NhaCungCap\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d085b3d458023ed16f82301142868a335c0d506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_NhaCungCap_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/NhaCungCap/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/NhaCungCap/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_NhaCungCap_Delete))]
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
#line 1 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\_ViewImports.cshtml"
using ASP.NET_CORE_Final_2019;

#line default
#line hidden
#line 2 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\_ViewImports.cshtml"
using ASP.NET_CORE_Final_2019.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d085b3d458023ed16f82301142868a335c0d506", @"/Areas/Admin/Views/NhaCungCap/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"915fbd610d2c1df000eb1977dd8fac33625858ab", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_NhaCungCap_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP.NET_CORE_Final_2019.Models.Nhacungcap>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(153, 610, true);
            WriteLiteral(@"<div class=""main-panel"">

    <div class=""content"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h4 class=""card-title"">Bạn Muốn Xóa Nhà Cung Cấp Này ? </h4>
                    </div>
                    <div class=""card-body"">
                        <dl class=""row"">
                            <dt class=""col-sm-2"">
                                Tên
                            </dt>
                            <dd class=""col-sm-10"">
                                ");
            EndContext();
            BeginContext(764, 35, false);
#line 22 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Ten));

#line default
#line hidden
            EndContext();
            BeginContext(799, 247, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                               Địa Chỉ\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
            EndContext();
            BeginContext(1047, 38, false);
#line 28 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Diachi));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 254, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                Số Điện Thoại\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
            EndContext();
            BeginContext(1340, 35, false);
#line 34 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Sdt));

#line default
#line hidden
            EndContext();
            BeginContext(1375, 94, true);
            WriteLiteral("\r\n                            </dd>\r\n                        </dl>\r\n\r\n                        ");
            EndContext();
            BeginContext(1469, 286, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d085b3d458023ed16f82301142868a335c0d5067761", async() => {
                BeginContext(1495, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1525, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d085b3d458023ed16f82301142868a335c0d5068173", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 39 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1561, 123, true);
                WriteLiteral("\r\n                            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n                            ");
                EndContext();
                BeginContext(1684, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d085b3d458023ed16f82301142868a335c0d50610178", async() => {
                    BeginContext(1706, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1722, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1755, 110, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP.NET_CORE_Final_2019.Models.Nhacungcap> Html { get; private set; }
    }
}
#pragma warning restore 1591
