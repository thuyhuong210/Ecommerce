#pragma checksum "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\KhachHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a958d4ac4fe36e095dfdc924d19ed895beb809d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_KhachHang_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/KhachHang/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/KhachHang/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_KhachHang_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a958d4ac4fe36e095dfdc924d19ed895beb809d9", @"/Areas/Admin/Views/KhachHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"915fbd610d2c1df000eb1977dd8fac33625858ab", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_KhachHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASP.NET_CORE_Final_2019.Models.Khachhang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "KhachHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportCSV", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportXlsx", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:red"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\KhachHang\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 7 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\KhachHang\Index.cshtml"
   
    VEGEFOOD_DBContext db = new VEGEFOOD_DBContext();

#line default
#line hidden
            BeginContext(227, 345, true);
            WriteLiteral(@"<div class=""main-panel"">
    <div class=""content"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h4 class=""card-title"" style=""background-image:url('/images/p9.jpg')"">Danh Sách Khách Hàng</h4>
                        ");
            EndContext();
            BeginContext(572, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a958d4ac4fe36e095dfdc924d19ed895beb809d96365", async() => {
                BeginContext(625, 52, true);
                WriteLiteral("Export CSV  <span><i class=\"fa fa-file\"></i> </span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(681, 33, true);
            WriteLiteral(" Hoặc\r\n\r\n                        ");
            EndContext();
            BeginContext(714, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a958d4ac4fe36e095dfdc924d19ed895beb809d98024", async() => {
                BeginContext(786, 60, true);
                WriteLiteral("Export Excel <span><i class=\"fa fa-file-excel-o\"></span></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(850, 1059, true);
            WriteLiteral(@"
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead class="" text-primary"">
                                    <tr>
                                        <th>
                                            Email Khách Hàng
                                        </th>
                                        <th>
                                            Tên
                                        </th>
                                        <th>
                                            Số Điện Thoại
                                        </th>
                                        <th>
                                            Địa Chỉ
                                        </th>
                                        <th></th>
                                    </tr>
                                </thead>
      ");
            WriteLiteral("                          <tbody>\r\n");
            EndContext();
#line 42 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\KhachHang\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(2014, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2147, 10, false);
#line 46 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\KhachHang\Index.cshtml"
                                       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2157, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2297, 38, false);
#line 49 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\KhachHang\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Ten));

#line default
#line hidden
            EndContext();
            BeginContext(2335, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2475, 38, false);
#line 52 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\KhachHang\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Sdt));

#line default
#line hidden
            EndContext();
            BeginContext(2513, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2653, 41, false);
#line 55 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\KhachHang\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(2694, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2833, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a958d4ac4fe36e095dfdc924d19ed895beb809d913678", async() => {
                BeginContext(2884, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Email", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\KhachHang\Index.cshtml"
                                                                      WriteLiteral(item.Email);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2892, 3, true);
            WriteLiteral(" \r\n");
            EndContext();
#line 59 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\KhachHang\Index.cshtml"
                                             if (db.Donhang.Where(p=>p.EmailKhachHang==item.Email)==null)
                                            {
                                           

#line default
#line hidden
            BeginContext(3094, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(3138, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a958d4ac4fe36e095dfdc924d19ed895beb809d916633", async() => {
                BeginContext(3191, 8, true);
                WriteLiteral("| Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Email", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\KhachHang\Index.cshtml"
                                                                        WriteLiteral(item.Email);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3203, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 63 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\KhachHang\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(3252, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 67 "C:\Users\lethi\OneDrive\Máy tính\tmdt\Ecommerce\ASP.NET_CORE_Final_2019\ASP.NET_CORE_Final_2019\Areas\Admin\Views\KhachHang\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3383, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(3868, 222, true);
            WriteLiteral("\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASP.NET_CORE_Final_2019.Models.Khachhang>> Html { get; private set; }
    }
}
#pragma warning restore 1591