#pragma checksum "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd8e5c65448b17c2911249cd9187c563b82fb3b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Baik), @"mvc.1.0.view", @"/Views/Admin/Baik.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Baik.cshtml", typeof(AspNetCore.Views_Admin_Baik))]
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
#line 1 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\_ViewImports.cshtml"
using Test;

#line default
#line hidden
#line 2 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\_ViewImports.cshtml"
using Test.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd8e5c65448b17c2911249cd9187c563b82fb3b7", @"/Views/Admin/Baik.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b938626c1cb27b4184c87d029e4bd0625527155", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Baik : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Test.Models.Baik>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DesktopUpload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LaptopUpload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BaikUpload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditDesktop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsDesktop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteDesktop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
  
    ViewData["Title"] = "Baik";

#line default
#line hidden
            BeginContext(80, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
            BeginContext(119, 226, true);
            WriteLiteral("<div class=\"card4\" style=\"width: 20rem; margin-top: -2%;\">\r\n    <div class=\"card-body\" style=\"background-color: black;\">\r\n        <h3 class=\"card-title text-center\" style=\"color:white;\">QUICK.COM</h3>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(345, 383, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd8e5c65448b17c2911249cd9187c563b82fb3b78519", async() => {
                BeginContext(406, 315, true);
                WriteLiteral(@"
            <div class=""input-group"">
                <input type=""search"" class=""form-control rounded"" name=""usertext"" placeholder=""Search"" aria-label=""Search"" aria-describedby=""search-addon"" />
                <button type=""submit"" class=""btn btn-outline-primary"">Search</button>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(728, 68, true);
            WriteLiteral("\r\n        <br />\r\n        <div class=\"list-group\">\r\n\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 796, "\"", 840, 1);
#line 22 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
WriteAttributeValue("", 803, Url.Action("CustomerOrders","Admin"), 803, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(841, 60, true);
            WriteLiteral(" class=\"list-group-item\">Customer Orders</a>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 901, "\"", 942, 1);
#line 23 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
WriteAttributeValue("", 908, Url.Action("HomeProduct","Admin"), 908, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(943, 55, true);
            WriteLiteral(" class=\"list-group-item\">Home-product</a>\r\n            ");
            EndContext();
            BeginContext(998, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd8e5c65448b17c2911249cd9187c563b82fb3b711912", async() => {
                BeginContext(1045, 51, true);
                WriteLiteral("Home product<i class=\"fas fa-plus-square ml-4\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1100, 16, true);
            WriteLiteral("\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1116, "\"", 1153, 1);
#line 25 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
WriteAttributeValue("", 1123, Url.Action("desktop","Admin"), 1123, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1154, 50, true);
            WriteLiteral(" class=\"list-group-item\">desktop</a>\r\n            ");
            EndContext();
            BeginContext(1204, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd8e5c65448b17c2911249cd9187c563b82fb3b713892", async() => {
                BeginContext(1258, 52, true);
                WriteLiteral("DesktopUpload<i class=\"fas fa-plus-square ml-3\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1314, 16, true);
            WriteLiteral("\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1330, "\"", 1367, 1);
#line 27 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
WriteAttributeValue("", 1337, Url.Action("Laptops","Admin"), 1337, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1368, 50, true);
            WriteLiteral(" class=\"list-group-item\">Laptops</a>\r\n            ");
            EndContext();
            BeginContext(1418, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd8e5c65448b17c2911249cd9187c563b82fb3b715873", async() => {
                BeginContext(1471, 51, true);
                WriteLiteral("LaptopUpload<i class=\"fas fa-plus-square ml-4\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1526, 16, true);
            WriteLiteral("\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1542, "\"", 1576, 1);
#line 29 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
WriteAttributeValue("", 1549, Url.Action("Baik","Admin"), 1549, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1577, 53, true);
            WriteLiteral(" class=\"list-group-item\">Motor-Baik</a>\r\n            ");
            EndContext();
            BeginContext(1630, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd8e5c65448b17c2911249cd9187c563b82fb3b717853", async() => {
                BeginContext(1681, 49, true);
                WriteLiteral("BaikUpload<i class=\"fas fa-plus-square ml-5\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1734, 16, true);
            WriteLiteral("\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1750, "\"", 1788, 1);
#line 31 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
WriteAttributeValue("", 1757, Url.Action("manswatch","Home"), 1757, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1789, 55, true);
            WriteLiteral(" class=\"list-group-item\">mens-watch</a>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1844, "\"", 1883, 1);
#line 32 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
WriteAttributeValue("", 1851, Url.Action("smartphone","Home"), 1851, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1884, 56, true);
            WriteLiteral(" class=\"list-group-item\">smart-phone</a>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1940, "\"", 1976, 1);
#line 33 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
WriteAttributeValue("", 1947, Url.Action("smarttv","Home"), 1947, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1977, 53, true);
            WriteLiteral(" class=\"list-group-item\">smart-tv</a>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2030, "\"", 2071, 1);
#line 34 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
WriteAttributeValue("", 2037, Url.Action("Refrigerator","Home"), 2037, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2072, 79, true);
            WriteLiteral(" class=\"list-group-item\">Refrigerator</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(2234, 185, true);
            WriteLiteral("\r\n<table class=\"table table-bordered table-sm \" style=\"margin-top: -52.7%;margin-left:21%;width: 79%;\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2420, 41, false);
#line 45 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
           Write(Html.DisplayNameFor(model => model.BranD));

#line default
#line hidden
            EndContext();
            BeginContext(2461, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2517, 43, false);
#line 48 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
           Write(Html.DisplayNameFor(model => model.Details));

#line default
#line hidden
            EndContext();
            BeginContext(2560, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2616, 41, false);
#line 51 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2657, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2713, 44, false);
#line 54 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2757, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2813, 41, false);
#line 57 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(2854, 94, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>Action</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 64 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2997, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3058, 40, false);
#line 68 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
               Write(Html.DisplayFor(modelItem => item.BranD));

#line default
#line hidden
            EndContext();
            BeginContext(3098, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3166, 42, false);
#line 71 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
               Write(Html.DisplayFor(modelItem => item.Details));

#line default
#line hidden
            EndContext();
            BeginContext(3208, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3276, 40, false);
#line 74 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3316, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3384, 43, false);
#line 77 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(3427, 71, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3498, "\"", 3519, 1);
#line 80 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
WriteAttributeValue("", 3504, item.ImageFile, 3504, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3520, 127, true);
            WriteLiteral(" alt=\"Product Image\" style=\"height: 50px; width: 60px;\" />\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3647, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd8e5c65448b17c2911249cd9187c563b82fb3b726248", async() => {
                BeginContext(3720, 27, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3751, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3773, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd8e5c65448b17c2911249cd9187c563b82fb3b728710", async() => {
                BeginContext(3852, 34, true);
                WriteLiteral("<i class=\"fas fa-info-circle\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3890, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3912, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd8e5c65448b17c2911249cd9187c563b82fb3b731185", async() => {
                BeginContext(3989, 32, true);
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 86 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
                                                    WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4025, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 89 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Admin\Baik.cshtml"
        }

#line default
#line hidden
            BeginContext(4080, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Test.Models.Baik>> Html { get; private set; }
    }
}
#pragma warning restore 1591
