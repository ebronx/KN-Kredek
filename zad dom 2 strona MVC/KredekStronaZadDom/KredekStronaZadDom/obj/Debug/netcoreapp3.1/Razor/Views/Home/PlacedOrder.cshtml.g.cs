#pragma checksum "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\Home\PlacedOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a457fb2c3354e3948635d8f9bffd196b7d1804e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PlacedOrder), @"mvc.1.0.view", @"/Views/Home/PlacedOrder.cshtml")]
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
#line 1 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\_ViewImports.cshtml"
using KredekStronaZadDom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\_ViewImports.cshtml"
using KredekStronaZadDom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a457fb2c3354e3948635d8f9bffd196b7d1804e4", @"/Views/Home/PlacedOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25686d9459d417990dabef8a32bc3319c475aef5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PlacedOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KredekStronaZadDom.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\Home\PlacedOrder.cshtml"
  
    ViewData["Title"] = "Twoje zamowienie";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kupione kursy</h1>\r\n<hr />\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\Home\PlacedOrder.cshtml"
       Write(Html.DisplayName("kurs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\Home\PlacedOrder.cshtml"
       Write(ViewBag.orderPizza.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\Home\PlacedOrder.cshtml"
       Write(Html.DisplayName("cena"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\Home\PlacedOrder.cshtml"
       Write(ViewBag.orderPizza.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\Home\PlacedOrder.cshtml"
       Write(Html.DisplayName("Imie"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\Home\PlacedOrder.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 30 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\Home\PlacedOrder.cshtml"
       Write(Html.DisplayName("Nazwisko"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\Home\PlacedOrder.cshtml"
       Write(Html.DisplayFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 36 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\Home\PlacedOrder.cshtml"
       Write(Html.DisplayName("Nr tel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 39 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\Home\PlacedOrder.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 42 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\Home\PlacedOrder.cshtml"
       Write(Html.DisplayName("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 45 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\Home\PlacedOrder.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 48 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\Home\PlacedOrder.cshtml"
       Write(Html.DisplayName("data zamowienie"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 51 "C:\Users\ebron\KN Kredek\zad dom 2 strona MVC\KredekStronaZadDom\KredekStronaZadDom\Views\Home\PlacedOrder.cshtml"
       Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a457fb2c3354e3948635d8f9bffd196b7d1804e48685", async() => {
                WriteLiteral("powrot");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KredekStronaZadDom.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
