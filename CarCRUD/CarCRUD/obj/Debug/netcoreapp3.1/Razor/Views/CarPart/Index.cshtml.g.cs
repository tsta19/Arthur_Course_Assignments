#pragma checksum "C:\Users\Jakubko\Desktop\GitHub Repositories\Arthur_Course_Assignments\CarCRUD\CarCRUD\Views\CarPart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9dcb7a6f56f4cda06836b9dfe34dfb2fa8c66e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarPart_Index), @"mvc.1.0.view", @"/Views/CarPart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9dcb7a6f56f4cda06836b9dfe34dfb2fa8c66e3", @"/Views/CarPart/Index.cshtml")]
    public class Views_CarPart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CarCRUD.Models.CarPart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/scripts/Index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/styles/Index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("background"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9dcb7a6f56f4cda06836b9dfe34dfb2fa8c66e34706", async() => {
                WriteLiteral("\r\n    <title>table</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9dcb7a6f56f4cda06836b9dfe34dfb2fa8c66e34996", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css""
          integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk""
          crossorigin=""anonymous"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e9dcb7a6f56f4cda06836b9dfe34dfb2fa8c66e36437", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9dcb7a6f56f4cda06836b9dfe34dfb2fa8c66e38407", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-lg navbar-dark bg-dark"">
        <div class=""container-navbar"">
            <a class=""navbar-brand"" href=""#"">Navbar w/ text</a>
            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarText"" aria-controls=""navbarText"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarText"">
                <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" aria-current=""page"" href=""#"">Home</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Features</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Pricing</a>
                    </li>
               ");
                WriteLiteral(@" </ul>
                <span class=""navbar-text"">
                    Navbar text with an inline element
                </span>
            </div>
        </div>
    </nav>
    <div class=""container-fluid mt-2"">
        <div class=""row justify-content-center"">
<<<<<<< Updated upstream
            <div class=""col-12"">
                <div class=""row navbar"">
                    <div class=""col-1"">
                        <a href=""#""><i class=""fa fa-fw fa-search""></i> Search</a>
                    </div>
                    <div class=""col-1"">
                        <a href=""#""><i class=""fa fa-fw fa-search""></i> Search</a>
                    </div>
                    <div class=""col-6"">
                        <a href=""#""><i class=""fa fa-fw fa-search""></i> Search</a>
                    </div>
                </div>
=======
            <div class=""col-11"">

>>>>>>> Stashed changes
                <div class=""row tableRow"">
                    <div class=""col-1"">
                ");
                WriteLiteral(@"        <span> ID </span>
                    </div>
                    <div class=""col-6"">
                        <span> Name </span>
                    </div>
                    <div class=""col-2"">
                        <span> Price </span>
                    </div>
                    <div class=""col-2"">
                        <span> Actions </span>
                    </div>

                </div>
");
#nullable restore
#line 72 "C:\Users\Jakubko\Desktop\GitHub Repositories\Arthur_Course_Assignments\CarCRUD\CarCRUD\Views\CarPart\Index.cshtml"
                  
                    foreach (var carPart in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"row tableRow\">\r\n                            <div class=\"col-1\">\r\n                                <span>");
#nullable restore
#line 77 "C:\Users\Jakubko\Desktop\GitHub Repositories\Arthur_Course_Assignments\CarCRUD\CarCRUD\Views\CarPart\Index.cshtml"
                                 Write(carPart.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"col-6\">\r\n                                <span>");
#nullable restore
#line 80 "C:\Users\Jakubko\Desktop\GitHub Repositories\Arthur_Course_Assignments\CarCRUD\CarCRUD\Views\CarPart\Index.cshtml"
                                 Write(carPart.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"col-2\">\r\n                                <span>");
#nullable restore
#line 83 "C:\Users\Jakubko\Desktop\GitHub Repositories\Arthur_Course_Assignments\CarCRUD\CarCRUD\Views\CarPart\Index.cshtml"
                                 Write(carPart.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                            </div>
                            <div class=""col-2"">
                                <button type=""button"" class=""btn btn-primary"">Edit</button>
                                <button type=""button"" class=""btn btn-danger"">Delete</button>
                            </div>
                        </div>
");
#nullable restore
#line 90 "C:\Users\Jakubko\Desktop\GitHub Repositories\Arthur_Course_Assignments\CarCRUD\CarCRUD\Views\CarPart\Index.cshtml"
                    }

                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CarCRUD.Models.CarPart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
