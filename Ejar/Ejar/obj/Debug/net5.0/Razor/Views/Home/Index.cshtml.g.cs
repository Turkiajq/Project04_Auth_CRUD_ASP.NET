#pragma checksum "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb95cc4f5f3421e2a79525efce9cb9739a1610fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\_ViewImports.cshtml"
using Ejar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\_ViewImports.cshtml"
using Ejar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb95cc4f5f3421e2a79525efce9cb9739a1610fe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e2c1fe1cd059d1c6fcd18974b632d1c3226b8e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Car", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

    List<CarModel> Cars = (List<CarModel>)ViewBag.Cars;

    int count = 0;
    int count2 = 0;
    int role = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n<div class=\"row\">\r\n");
#nullable restore
#line 14 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
     foreach (var car in Cars)
    {

        count = 0;
        count2 = 0;



#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row card-group card\" style=\"max-width: 300px; margin-left: 70px; margin-bottom: 10px;\">\r\n\r\n\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb95cc4f5f3421e2a79525efce9cb9739a1610fe4822", async() => {
                WriteLiteral("\r\n                <div");
                BeginWriteAttribute("id", " id=\"", 510, "\"", 539, 2);
                WriteAttributeValue("", 515, "carouselIndicators-", 515, 19, true);
#nullable restore
#line 26 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
WriteAttributeValue("", 534, role, 534, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"carousel slide\" data-ride=\"carousel\">\r\n                    <ol class=\"carousel-indicators\">\r\n\r\n");
#nullable restore
#line 29 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
                         foreach (var img in car.Images)
                        {
                            if (count == 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li data-target=\"#carouselIndicators-");
#nullable restore
#line 33 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
                                                                Write(role);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-slide-to=\"");
#nullable restore
#line 33 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
                                                                                      Write(count);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"active\"></li>\r\n");
#nullable restore
#line 34 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li data-target=\"#carouselIndicators-");
#nullable restore
#line 37 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
                                                                Write(role);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-slide-to=\"");
#nullable restore
#line 37 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
                                                                                      Write(count);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"></li>\r\n");
#nullable restore
#line 38 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
                            }

                            count++;
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </ol>\r\n                    <div class=\"carousel-inner\" style=\"width: 100%\">\r\n\r\n");
#nullable restore
#line 45 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
                         foreach (var img in car.Images)
                        {
                            if (count2 == 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"carousel-item active\" style=\"width: 100%\">\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 1614, "\"", 1633, 1);
#nullable restore
#line 50 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
WriteAttributeValue("", 1620, img.ImageUrl, 1620, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"d-block w-100\" height=\"200\" style=\"width: 100%\" alt=\"...\">\r\n                                </div>\r\n");
#nullable restore
#line 52 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"carousel-item\">\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 1941, "\"", 1960, 1);
#nullable restore
#line 57 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
WriteAttributeValue("", 1947, img.ImageUrl, 1947, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"d-block w-100\" height=\"200\" style=\"width: 100%\" alt=\"...\">\r\n                                </div>\r\n");
#nullable restore
#line 59 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
                            }
                            count2++;
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                    <a class=\"carousel-control-prev\"");
                BeginWriteAttribute("href", " href=\"", 2246, "\"", 2278, 2);
                WriteAttributeValue("", 2253, "#carouselIndicators-", 2253, 20, true);
#nullable restore
#line 63 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
WriteAttributeValue("", 2273, role, 2273, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next""");
                BeginWriteAttribute("href", " href=\"", 2548, "\"", 2580, 2);
                WriteAttributeValue("", 2555, "#carouselIndicators-", 2555, 20, true);
#nullable restore
#line 67 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
WriteAttributeValue("", 2575, role, 2575, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>


                </div>
                <div class=""card-body"" style=""align-items: center; align-self: center"">
                    <center>

                        <h5 class=""card-title"">");
#nullable restore
#line 77 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
                                          Write(car.Manufacturer);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 77 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
                                                            Write(car.CarName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 77 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
                                                                         Write(car.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        <p><strong>");
#nullable restore
#line 78 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
                              Write(car.DayPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" SAR</strong> /day | <strong>");
#nullable restore
#line 78 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
                                                                        Write(car.HourPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" SAR</strong> /hour </p>\r\n\r\n                    </center>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"
                                                                     WriteLiteral(car.Id);

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
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 84 "C:\Users\Turki\Desktop\Tuwaiq\Dotnet\Project04_Auth_CRUD_ASP.NET\Ejar\Ejar\Views\Home\Index.cshtml"

        role++;

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
