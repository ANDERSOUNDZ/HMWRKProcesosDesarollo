#pragma checksum "C:\Users\User\source\repos\SpecFlowProject\CalculadoraWeb\Views\Home\calculadora.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a93d4ebd888c99f5be06b233d05f601c92c4f70f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_calculadora), @"mvc.1.0.view", @"/Views/Home/calculadora.cshtml")]
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
#line 1 "C:\Users\User\source\repos\SpecFlowProject\CalculadoraWeb\Views\_ViewImports.cshtml"
using CalculadoraWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\SpecFlowProject\CalculadoraWeb\Views\_ViewImports.cshtml"
using CalculadoraWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a93d4ebd888c99f5be06b233d05f601c92c4f70f", @"/Views/Home/calculadora.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"171faa4044442e697b8f48f3156c54b0f3c08753", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_calculadora : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Resultado</h1>\r\n\r\n<input type=\"text\" name=\"esperado\"");
            BeginWriteAttribute("value", " value=\"", 56, "\"", 78, 1);
#nullable restore
#line 3 "C:\Users\User\source\repos\SpecFlowProject\CalculadoraWeb\Views\Home\calculadora.cshtml"
WriteAttributeValue("", 64, ViewBag.Sumar, 64, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
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
