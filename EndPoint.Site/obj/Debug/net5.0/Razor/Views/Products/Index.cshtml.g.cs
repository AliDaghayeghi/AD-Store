#pragma checksum "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b70f38e455ca6acb0ff11b4830a74809d4da15d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#nullable restore
#line 1 "P:\Projects\ADStore\EndPoint.Site\Views\_ViewImports.cshtml"
using EndPoint.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\Projects\ADStore\EndPoint.Site\Views\_ViewImports.cshtml"
using EndPoint.Site.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
using ADStore.Application.Services.Products.Queries.GetProductForSite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b70f38e455ca6acb0ff11b4830a74809d4da15d0", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87685c89e84078b3e134b89a928accf3d0f04a39", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultProductForSiteDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("tab"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-controls", new global::Microsoft.AspNetCore.Html.HtmlString("Most-visited"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-selected", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-controls", new global::Microsoft.AspNetCore.Html.HtmlString("Bestselling"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-selected", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-controls", new global::Microsoft.AspNetCore.Html.HtmlString("Most-Popular"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-controls", new global::Microsoft.AspNetCore.Html.HtmlString("newest"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-controls", new global::Microsoft.AspNetCore.Html.HtmlString("cheapest"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-controls", new global::Microsoft.AspNetCore.Html.HtmlString("most-expensive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("show-first-numbered-page", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("show-last-numbered-page", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("query-string-key-page-no", "Page", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("query-string-key-page-size", "PageSize", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_18 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("gap-size", new global::Microsoft.AspNetCore.Html.HtmlString("2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::LazZiya.TagHelpers.PagingTagHelper __LazZiya_TagHelpers_PagingTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    int pageNumber = 1;
    int pageSize = 20;
    int.TryParse(Context.Request.Query["page"], out pageNumber);
    int.TryParse(Context.Request.Query["pageSize"], out pageSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 col-md-12 col-xs-12 pl"">
    <div class=""shop-archive-content mt-3 d-block"">
        <div class=""archive-header"">
            <h2 class=""archive-header-title"">آرشیو محصولات</h2>
            <div class=""sort-tabs mt-0 d-inline-block pr"">
                <h4>مرتب&zwnj;سازی بر اساس :</h4>
            </div>
            <div class=""nav-sort-tabs-res"">
                <ul class=""nav sort-tabs-options"" id=""myTab"" role=""tablist"">
                    <li class=""nav-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70f38e455ca6acb0ff11b4830a74809d4da15d010980", async() => {
                WriteLiteral("پربازدیدترین");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 977, "~/products?Searchkey=", 977, 21, true);
#nullable restore
#line 23 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 998, Context.Request.Query["SearchKey"], 998, 35, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1033, "&CatId=", 1033, 7, true);
#nullable restore
#line 23 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 1040, Context.Request.Query["CatId"], 1040, 31, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1071, "&ordering=MostVisited", 1071, 21, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70f38e455ca6acb0ff11b4830a74809d4da15d013344", async() => {
                WriteLiteral("پرفروش&zwnj;ترین&zwnj;");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1295, "~/products?Searchkey=", 1295, 21, true);
#nullable restore
#line 26 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 1316, Context.Request.Query["SearchKey"], 1316, 35, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1351, "&CatId=", 1351, 7, true);
#nullable restore
#line 26 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 1358, Context.Request.Query["CatId"], 1358, 31, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1389, "&ordering=Bestselling", 1389, 21, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70f38e455ca6acb0ff11b4830a74809d4da15d015722", async() => {
                WriteLiteral("محبوب&zwnj;ترین");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1623, "~/products?Searchkey=", 1623, 21, true);
#nullable restore
#line 29 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 1644, Context.Request.Query["SearchKey"], 1644, 35, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1679, "&CatId=", 1679, 7, true);
#nullable restore
#line 29 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 1686, Context.Request.Query["CatId"], 1686, 31, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1717, "&ordering=Most-Popular", 1717, 22, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70f38e455ca6acb0ff11b4830a74809d4da15d018094", async() => {
                WriteLiteral("جدیدترین");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1946, "~/products?Searchkey=", 1946, 21, true);
#nullable restore
#line 32 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 1967, Context.Request.Query["SearchKey"], 1967, 35, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2002, "&CatId=", 2002, 7, true);
#nullable restore
#line 32 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 2009, Context.Request.Query["CatId"], 2009, 31, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2040, "&ordering=newest", 2040, 16, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70f38e455ca6acb0ff11b4830a74809d4da15d020453", async() => {
                WriteLiteral("ارزان&zwnj;ترین");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2251, "~/products?Searchkey=", 2251, 21, true);
#nullable restore
#line 35 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 2272, Context.Request.Query["SearchKey"], 2272, 35, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2307, "&CatId=", 2307, 7, true);
#nullable restore
#line 35 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 2314, Context.Request.Query["CatId"], 2314, 31, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2345, "&ordering=cheapest", 2345, 18, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70f38e455ca6acb0ff11b4830a74809d4da15d022821", async() => {
                WriteLiteral("گران&zwnj;ترین");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2566, "~/products?Searchkey=", 2566, 21, true);
#nullable restore
#line 38 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 2587, Context.Request.Query["SearchKey"], 2587, 35, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2622, "&CatId=", 2622, 7, true);
#nullable restore
#line 38 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 2629, Context.Request.Query["CatId"], 2629, 31, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2660, "&ordering=most-expensive", 2660, 24, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>
                </ul>
            </div>
        </div>
        <div class=""product-items"">
            <div class=""tab-content"" id=""myTabContent"">



                <div class=""tab-pane fade show active"" id=""Most-visited"" role=""tabpanel"" aria-labelledby=""Most-visited-tab"">
                    <div class=""row"">
");
#nullable restore
#line 50 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
                         foreach (var item in Model.Products)
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-lg-3 col-md-3 col-xs-12 order-1 d-block mb-3"">
                                <section class=""product-box product product-type-simple"">
                                    <div class=""thumb"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70f38e455ca6acb0ff11b4830a74809d4da15d026016", async() => {
                WriteLiteral("\r\n\r\n                                            <div class=\"product-rate\">\r\n\r\n");
#nullable restore
#line 61 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
                                                 for (int i = 1; i <= item.Star; i++)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <i class=\"fa fa-star active\"></i>\r\n");
#nullable restore
#line 64 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
                                                 for (int i = 1; i <= (5 - item.Star); i++)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <i class=\"fa fa-star\"></i>\r\n");
#nullable restore
#line 68 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </div>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b70f38e455ca6acb0ff11b4830a74809d4da15d027690", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4308, "~/", 4308, 2, true);
#nullable restore
#line 70 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 4310, item.ImageSrc, 4310, 14, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3504, "~/products/detail/", 3504, 18, true);
#nullable restore
#line 57 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 3522, item.Id, 3522, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"title\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70f38e455ca6acb0ff11b4830a74809d4da15d030916", async() => {
                WriteLiteral("  ");
#nullable restore
#line 74 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
                                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4524, "~/products/detail/", 4524, 18, true);
#nullable restore
#line 74 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 4542, item.Id, 4542, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"price\">\r\n                                        <span class=\"amount\">\r\n                                            ");
#nullable restore
#line 78 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
                                       Write(item.Price.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <span>تومان</span>\r\n                                        </span>\r\n                                    </div>\r\n                                </section>\r\n                            </div>\r\n");
#nullable restore
#line 84 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"pagination-product\">\r\n            <nav aria-label=\"Page navigation example\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("paging", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70f38e455ca6acb0ff11b4830a74809d4da15d033807", async() => {
                WriteLiteral("\r\n                ");
            }
            );
            __LazZiya_TagHelpers_PagingTagHelper = CreateTagHelper<global::LazZiya.TagHelpers.PagingTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_TagHelpers_PagingTagHelper);
#nullable restore
#line 93 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.TotalRecords = Model.TotalRow;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("total-records", __LazZiya_TagHelpers_PagingTagHelper.TotalRecords, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 94 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.PageNo = pageNumber==0?1:pageNumber;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-no", __LazZiya_TagHelpers_PagingTagHelper.PageNo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 95 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.PageSize = pageSize==0?20:pageNumber;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __LazZiya_TagHelpers_PagingTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 96 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowPrevNext = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-prev-next", __LazZiya_TagHelpers_PagingTagHelper.ShowPrevNext, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 97 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowTotalPages = false;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-total-pages", __LazZiya_TagHelpers_PagingTagHelper.ShowTotalPages, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 98 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowTotalRecords = false;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-total-records", __LazZiya_TagHelpers_PagingTagHelper.ShowTotalRecords, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 99 "P:\Projects\ADStore\EndPoint.Site\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowPageSizeNav = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-page-size-nav", __LazZiya_TagHelpers_PagingTagHelper.ShowPageSizeNav, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            __LazZiya_TagHelpers_PagingTagHelper.QueryStringKeyPageNo = (string)__tagHelperAttribute_16.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
            __LazZiya_TagHelpers_PagingTagHelper.QueryStringKeyPageSize = (string)__tagHelperAttribute_17.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_17);
            BeginWriteTagHelperAttribute();
            WriteLiteral("@");
            WriteLiteral("(Request.QueryString.Value)");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("query-string-value", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_18);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </nav>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultProductForSiteDto> Html { get; private set; }
    }
}
#pragma warning restore 1591