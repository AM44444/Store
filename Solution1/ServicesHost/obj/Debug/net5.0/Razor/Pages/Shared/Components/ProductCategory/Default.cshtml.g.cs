#pragma checksum "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Pages\Shared\Components\ProductCategory\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e981154dc4f88716a030cffd236c68063da2f40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServicesHost.Pages.Shared.Components.ProductCategory.Pages_Shared_Components_ProductCategory_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/ProductCategory/Default.cshtml")]
namespace ServicesHost.Pages.Shared.Components.ProductCategory
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
#line 1 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Pages\_ViewImports.cshtml"
using ServicesHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e981154dc4f88716a030cffd236c68063da2f40", @"/Pages/Shared/Components/ProductCategory/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b0d6fb725f7721dd7f2ce8071bf40915ede4770", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_ProductCategory_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_TennisQuery.Contract.ProductCategoryModel.ProductCategoryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ProductCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""category-area section-space"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <!--=======  category wrapper  =======-->
                <div class=""category-wrapper"">
                    <div class=""row row-10 masonry-category-layout"">
");
#nullable restore
#line 9 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Pages\Shared\Components\ProductCategory\Default.cshtml"
                         foreach (var ProductCategory in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-lg-4 col-sm-6 grid-item"">
                                <!--=======  single category item  =======-->
                                <div class=""single-category-item"">
                                    <div class=""single-category-item__image"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e981154dc4f88716a030cffd236c68063da2f404501", async() => {
                WriteLiteral("\r\n                                            <img");
                BeginWriteAttribute("src", " src=\"", 941, "\"", 971, 1);
#nullable restore
#line 16 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Pages\Shared\Components\ProductCategory\Default.cshtml"
WriteAttributeValue("", 947, ProductCategory.Picture, 947, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 972, "\"", 1005, 1);
#nullable restore
#line 16 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Pages\Shared\Components\ProductCategory\Default.cshtml"
WriteAttributeValue("", 978, ProductCategory.PictureAlt, 978, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", "title=\"", 1006, "\"", 1042, 1);
#nullable restore
#line 16 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Pages\Shared\Components\ProductCategory\Default.cshtml"
WriteAttributeValue("", 1013, ProductCategory.PictureTitle, 1013, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Pages\Shared\Components\ProductCategory\Default.cshtml"
                                                                         WriteLiteral(ProductCategory.Slug);

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
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"single-category-item__content\">\r\n                                        <h3 class=\"title\">");
#nullable restore
#line 20 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Pages\Shared\Components\ProductCategory\Default.cshtml"
                                                     Write(ProductCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e981154dc4f88716a030cffd236c68063da2f408590", async() => {
                WriteLiteral("\r\n                                            <i class=\"ion-android-arrow-dropleft-circle\"></i> همین حالا بخرید\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Pages\Shared\Components\ProductCategory\Default.cshtml"
                                                                          WriteLiteral(ProductCategory.Slug);

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
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <!--=======  End of single category item  =======-->\r\n                            </div>\r\n");
#nullable restore
#line 28 "D:\Users\mashadservice\source\repos\RAZOR\Solution1\ServicesHost\Pages\Shared\Components\ProductCategory\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n\r\n                    </div>\r\n                </div>\r\n                <!--=======  End of category wrapper  =======-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_TennisQuery.Contract.ProductCategoryModel.ProductCategoryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
