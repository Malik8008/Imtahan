#pragma checksum "C:\Users\examthree\source\repos\Imtahan\Imtahan\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ea8296bdf3710af4c94e97aa999abe2cdb7abf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea8296bdf3710af4c94e97aa999abe2cdb7abf1", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/SCSS/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/JS/style.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ea8296bdf3710af4c94e97aa999abe2cdb7abf14121", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Document</title>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"" integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8ea8296bdf3710af4c94e97aa999abe2cdb7abf15091", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ea8296bdf3710af4c94e97aa999abe2cdb7abf16974", async() => {
                WriteLiteral(@"
    <section id=""topheader"">
        <div class=""container"">
            <div class=""row d-flex justify-content-between"">
                <div class=""col-lg-6 d-flex right"">
                    <div class=""email d-flex justify-content-between"">
                        <div class=""emailIcon mt-1 "">
                            <i class=""fa-regular fa-envelope""></i>
                        </div>
                        <div class=""emailInfo ms-1"">
                            <a");
                BeginWriteAttribute("href", " href=\"", 1290, "\"", 1297, 0);
                EndWriteAttribute();
                WriteLiteral(@">contact@example.com</a>
                        </div>
                    </div>
                    <div class=""phone d-flex ms-3"">
                        <div class=""phoneIcon"">
                            <i class=""fa-solid fa-mobile-button""></i>
                        </div>
                        <div class=""phoneInfo ms-1"">
                            <p>+1 5589 55488 55</p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6 left mt-1"">
                    <ul>
                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1886, "\"", 1893, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"mx-2 fa-brands fa-twitter\"></i></a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1977, "\"", 1984, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"mx-2 fa-brands fa-facebook\"></i></a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 2069, "\"", 2076, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"mx-2 fa-brands fa-instagram\"></i></a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 2162, "\"", 2169, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""mx-2 fa-brands fa-linkedin""></i></a></li>
                    </ul>
                </div>
            </div>
        </div>
    </section>
    <header>
        <section id=""headerbottom"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-5"">
                        <div class=""logo"">
                            <h2>BizLand<span>.</span></h2>
                        </div>
                    </div>
                    <div class=""col-lg-7"">
                        <div class=""navbar"">
                            <ul class=""d-flex justify-content-end w-100"">
                                <li><a");
                BeginWriteAttribute("href", " href=\"", 2861, "\"", 2868, 0);
                EndWriteAttribute();
                WriteLiteral(">Home</a></li>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 2923, "\"", 2930, 0);
                EndWriteAttribute();
                WriteLiteral(">About</a></li>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 2986, "\"", 2993, 0);
                EndWriteAttribute();
                WriteLiteral(">Services</a></li>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 3052, "\"", 3059, 0);
                EndWriteAttribute();
                WriteLiteral(">Portfolio</a></li>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 3119, "\"", 3126, 0);
                EndWriteAttribute();
                WriteLiteral(">Team</a></li>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 3181, "\"", 3188, 0);
                EndWriteAttribute();
                WriteLiteral(">Drop Down</a></li>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 3248, "\"", 3255, 0);
                EndWriteAttribute();
                WriteLiteral(">Contact</a></li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </header>\r\n    ");
#nullable restore
#line 71 "C:\Users\examthree\source\repos\Imtahan\Imtahan\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <footer>
        <section id=""footertop"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-3"">
                        <h3>BizLand.</h3>
                        <ul>
                            <li>
                                A108 Adam Street
                                New York, NY 535022
                                United States
                            </li>
                            <li class=""mt-4"">Phone: +1 5589 55488 55</li>
                            <li>Email: info@example.com</li>
                        </ul>
                    </div>
                    <div class=""col-lg-3"">
                        <h3>Useful Links</h3>
                        <ul>
                            <li><i class=""fa-solid fa-angle-right""></i>Home</li>
                            <li><i class=""fa-solid fa-angle-right""></i>About Us</li>
                            <li><i class=""fa-solid fa-angle-right""></i>Services</");
                WriteLiteral(@"li>
                            <li><i class=""fa-solid fa-angle-right""></i>Terms of service</li>
                            <li><i class=""fa-solid fa-angle-right""></i>privacy policy</li>
                        </ul>
                    </div>
                    <div class=""col-lg-3"">
                        <h3>Our Services</h3>
                        <ul>
                            <li><i class=""fa-solid fa-angle-right""></i>Design</li>
                            <li><i class=""fa-solid fa-angle-right""></i>Web Development</li>
                            <li><i class=""fa-solid fa-angle-right""></i>Marketing</li>
                            <li><i class=""fa-solid fa-angle-right""></i>Terms of service</li>
                            <li><i class=""fa-solid fa-angle-right""></i>privacy policy</li>
                        </ul>
                    </div>
                    <div class=""col-lg-3"">
                        <h3>Our Social Networks</h3>
                        <p>Cras fermentum odio");
                WriteLiteral(" eu feugiat lide par naso tierra videa magna derita valies</p>\r\n                        <ul class=\"d-flex justify-content-evenly\">\r\n\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 5682, "\"", 5689, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-twitter\"></i></a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 5772, "\"", 5779, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"mx-2 fa-brands fa-facebook\"></i></a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 5868, "\"", 5875, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"mx-2 fa-brands fa-instagram\"></i></a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 5965, "\"", 5972, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""mx-2 fa-brands fa-linkedin""></i></a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </section>
        <section id=""footerend"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""copy d-flex justify-content-start"">
                            <p>© Copyright BizLand. All Rights Reserved</p>
                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <div class=""design d-flex justify-content-end"">
                            <p>Designed by <a");
                BeginWriteAttribute("href", " href=\"", 6672, "\"", 6679, 0);
                EndWriteAttribute();
                WriteLiteral(@">BootstrapMade</a></p>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </footer>




    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"" crossorigin=""anonymous""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ea8296bdf3710af4c94e97aa999abe2cdb7abf116386", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
