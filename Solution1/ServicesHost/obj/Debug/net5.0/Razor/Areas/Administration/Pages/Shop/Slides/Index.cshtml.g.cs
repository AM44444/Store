#pragma checksum "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd1cebbcdee0cb897840654614273eb1d1dd43f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServicesHost.Areas.Administration.Pages.Shop.Slides.Areas_Administration_Pages_Shop_Slides_Index), @"mvc.1.0.razor-page", @"/Areas/Administration/Pages/Shop/Slides/Index.cshtml")]
namespace ServicesHost.Areas.Administration.Pages.Shop.Slides
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd1cebbcdee0cb897840654614273eb1d1dd43f2", @"/Areas/Administration/Pages/Shop/Slides/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"372c0f9084d3dbaa8e37960b6674c3eea49940e3", @"/Areas/Administration/Pages/_ViewImports.cshtml")]
    public class Areas_Administration_Pages_Shop_Slides_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-custom waves-effect waves-light m-b-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-custom waves-effect waves-light m-b-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Restore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminTheme/assets/datatables/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminTheme/assets/datatables/dataTables.bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
  
    Layout = "Shared/_AdminLayout";
    ViewData["title"] = "مدیریت اسلایدها";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n        <h4 class=\"page-title pull-right\">");
#nullable restore
#line 12 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
                                     Write(ViewData["title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p class=\"pull-left\">\r\n            <a class=\"btn btn-success btn-lg\"");
            BeginWriteAttribute("href", " href=\"", 366, "\"", 413, 2);
            WriteAttributeValue("", 373, "#showmodal=", 373, 11, true);
#nullable restore
#line 14 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
WriteAttributeValue("", 384, Url.Page("./Index","Create"), 384, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">ایجاد اسلاید جدید</a>
        </p>
    </div>
</div>



<div class=""row"" id=""ProductCategoriesDiv"">
    <div class=""col-md-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">لیست اسلایدها</h3>
            </div>
            <div class=""panel-body"">
                <div class=""row"">
                    <div class=""col-md-12 col-sm-12 col-xs-12"">
                        <table id=""datatable"" class=""table table-striped table-bordered"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>عکس</th>
                                    <th>سرتیر</th>
                                    <th>عنوان</th>
                                    <th>وضعیت</th>
                                    <th>تاریخ تولید</th>
                                    <th>عملیات</th>
                                </tr>
              ");
            WriteLiteral("              </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 43 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
                                 foreach (var item in Model.Slides)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 46 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 1798, "\"", 1817, 1);
#nullable restore
#line 48 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
WriteAttributeValue("", 1804, item.Picture, 1804, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 70px; height: 70px\" />\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 50 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
                                       Write(item.Heading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 51 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                       \r\n                                        <td class=\"text-center\">\r\n");
#nullable restore
#line 54 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
                                             if (!item.IsRemoved)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <i class=\"fa fa-check fa-3x text-success\"></i>\r\n");
#nullable restore
#line 57 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <i class=\"fa fa-remove fa-3x text-danger\"></i>\r\n");
#nullable restore
#line 61 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>");
#nullable restore
#line 63 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
                                       Write(item.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <a class=\"btn btn-warning btn-custom waves-effect waves-light m-b-5\"");
            BeginWriteAttribute("href", "\r\n                                               href=\"", 2908, "\"", 3020, 2);
            WriteAttributeValue("", 2963, "#showmodal=", 2963, 11, true);
#nullable restore
#line 66 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
WriteAttributeValue("", 2974, Url.Page("./Index","Edit", new {id= item.Id}), 2974, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <i class=\"fa fa-edit\"></i> ویرایش\r\n                                            </a>\r\n");
#nullable restore
#line 69 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
                                             if (!item.IsRemoved)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd1cebbcdee0cb897840654614273eb1d1dd43f212937", async() => {
                WriteLiteral("\r\n                                                   حذف\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
                                                     WriteLiteral(item.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 75 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"

                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd1cebbcdee0cb897840654614273eb1d1dd43f215953", async() => {
                WriteLiteral("\r\n                                                   فعال سازی\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
                                                                                                                                                                     WriteLiteral(item.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 82 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 86 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Areas\Administration\Pages\Shop\Slides\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd1cebbcdee0cb897840654614273eb1d1dd43f219598", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd1cebbcdee0cb897840654614273eb1d1dd43f220698", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\'#datatable\').dataTable();\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServicesHost.Areas.Administration.Pages.Shop.Slides.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServicesHost.Areas.Administration.Pages.Shop.Slides.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServicesHost.Areas.Administration.Pages.Shop.Slides.IndexModel>)PageContext?.ViewData;
        public ServicesHost.Areas.Administration.Pages.Shop.Slides.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
