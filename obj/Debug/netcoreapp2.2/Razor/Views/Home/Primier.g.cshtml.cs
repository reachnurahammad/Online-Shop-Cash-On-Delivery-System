#pragma checksum "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Primier.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af0d81c9ce7a5a014ce80a09efb45900e2ff9658"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Primier), @"mvc.1.0.view", @"/Views/Home/Primier.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Primier.cshtml", typeof(AspNetCore.Views_Home_Primier))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af0d81c9ce7a5a014ce80a09efb45900e2ff9658", @"/Views/Home/Primier.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b938626c1cb27b4184c87d029e4bd0625527155", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Primier : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Test.Models.Primier>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PrimierAddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Primier.cshtml"
  
    ViewData["Title"] = "Primier";

#line default
#line hidden
            BeginContext(86, 58, true);
            WriteLiteral("<div class=\"offset-5\">\r\n    <h1>Primier</h1>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(2463, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2495, 19, true);
            WriteLiteral("<div class=\"row\">\r\n");
            EndContext();
#line 80 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Primier.cshtml"
     foreach (var item in Model)
    {

        

#line default
#line hidden
            BeginContext(2628, 232, true);
            WriteLiteral("        <div class=\"col-md-2\" style=\"margin-top:10px; margin-bottom:95px; margin-left:2%;\">\r\n            <div style=\"height: 180px; width: 150px; background-color:#ffffff ; margin-top: 30px; \">\r\n           \r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2860, "\"", 2881, 1);
#line 88 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Primier.cshtml"
WriteAttributeValue("", 2866, item.ImageFile, 2866, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2882, 309, true);
            WriteLiteral(@" alt=""Product Image"" style=""height: 180px; width: 270px; border: 1px solid #64696d; border-bottom:none;"" />
           
                <div style=""background-color: white; width:270px; border: 1px solid #64696d; border-top:none;"">
                    <div class=""offset-1 "">
                        <h6> ");
            EndContext();
            BeginContext(3192, 12, false);
#line 92 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Primier.cshtml"
                        Write(item.Details);

#line default
#line hidden
            EndContext();
            BeginContext(3204, 42, true);
            WriteLiteral("</h6>\r\n                        <p1>Price: ");
            EndContext();
            BeginContext(3247, 10, false);
#line 93 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Primier.cshtml"
                              Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3257, 7, true);
            WriteLiteral("</p1>\r\n");
            EndContext();
            BeginContext(3307, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3331, 407, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af0d81c9ce7a5a014ce80a09efb45900e2ff96586922", async() => {
                BeginContext(3401, 61, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"pid\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3462, "\"", 3478, 1);
#line 96 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Primier.cshtml"
WriteAttributeValue("", 3470, item.Id, 3470, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3479, 252, true);
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
            BeginContext(3738, 96, true);
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 104 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Primier.cshtml"
    }

#line default
#line hidden
            BeginContext(3841, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Test.Models.Primier>> Html { get; private set; }
    }
}
#pragma warning restore 1591
