#pragma checksum "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Efood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b575f5fd973066e4d9d067c8b310a6cee51d7061"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Efood), @"mvc.1.0.view", @"/Views/Home/Efood.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Efood.cshtml", typeof(AspNetCore.Views_Home_Efood))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b575f5fd973066e4d9d067c8b310a6cee51d7061", @"/Views/Home/Efood.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b938626c1cb27b4184c87d029e4bd0625527155", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Efood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Test.Models.Efood>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EfoodAddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Efood.cshtml"
  
    ViewData["Title"] = "Efood";

#line default
#line hidden
            BeginContext(82, 54, true);
            WriteLiteral("\r\n<div class=\"offset-5\">\r\n    <h1>Efood</h1>\r\n</div>\r\n");
            EndContext();
            BeginContext(2563, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(2595, 19, true);
            WriteLiteral("<div class=\"row\">\r\n");
            EndContext();
#line 83 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Efood.cshtml"
     foreach (var item in Model)
    {

        

#line default
#line hidden
            BeginContext(2728, 223, true);
            WriteLiteral("        <div class=\"col-md-2\" style=\"margin-top:10px; margin-bottom:95px; margin-left:2%;\">\r\n            <div style=\"height: 180px; width: 150px; background-color:#ffffff ; margin-top: 30px; \">\r\n  \r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2951, "\"", 2972, 1);
#line 91 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Efood.cshtml"
WriteAttributeValue("", 2957, item.ImageFile, 2957, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2973, 309, true);
            WriteLiteral(@" alt=""Product Image"" style=""height: 180px; width: 270px; border: 1px solid #64696d; border-bottom:none;"" />
           
                <div style=""background-color: white; width:270px; border: 1px solid #64696d; border-top:none;"">
                    <div class=""offset-1 "">
                        <h6> ");
            EndContext();
            BeginContext(3283, 12, false);
#line 95 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Efood.cshtml"
                        Write(item.Details);

#line default
#line hidden
            EndContext();
            BeginContext(3295, 42, true);
            WriteLiteral("</h6>\r\n                        <p1>Price: ");
            EndContext();
            BeginContext(3338, 10, false);
#line 96 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Efood.cshtml"
                              Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3348, 7, true);
            WriteLiteral("</p1>\r\n");
            EndContext();
            BeginContext(3398, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3422, 405, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b575f5fd973066e4d9d067c8b310a6cee51d70616881", async() => {
                BeginContext(3490, 61, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"pid\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3551, "\"", 3567, 1);
#line 99 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Efood.cshtml"
WriteAttributeValue("", 3559, item.Id, 3559, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3568, 252, true);
                WriteLiteral(" />\r\n                            <input type=\"number\" name=\"qty\" value=\"1\" class=\"form-control\" style=\"width:60px;\" />\r\n                            <button class=\"btn btn-primary btn-sm ml-1\" type=\"submit\">Add To Cart</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            BeginContext(3827, 96, true);
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 107 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Efood.cshtml"
    }

#line default
#line hidden
            BeginContext(3930, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Test.Models.Efood>> Html { get; private set; }
    }
}
#pragma warning restore 1591