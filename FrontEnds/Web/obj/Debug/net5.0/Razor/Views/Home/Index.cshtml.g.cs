#pragma checksum "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4f0ba2834394f88031f8a85fb8568cb5bc735b528c810a40799823af94737a45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\_ViewImports.cshtml"
using Web.Models.Catalog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4f0ba2834394f88031f8a85fb8568cb5bc735b528c810a40799823af94737a45", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f31f04c99af4fe7b7174149d1dbda7359b2f1f03c74457426397fdb003749e8e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CourseViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Kurslar</h2>\r\n<hr />\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\Home\Index.cshtml"
 if (Model.Any())

{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {
        count++;
        if (count == 1 || (count % 3 == 1))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\Home\Index.cshtml"
       Write(Html.Raw("<div class='row row-cols-1 row-cols-md-3 g-4 mb-2' >"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\Home\Index.cshtml"
                                                                             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col\">\r\n            <div class=\"card\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 433, "\"", 460, 1);
#nullable restore
#line 22 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 439, item.StockPictureUrl, 439, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 24 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\Home\Index.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 25 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\Home\Index.cshtml"
                                    Write(item.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h4 class=\"text-primary\">");
#nullable restore
#line 26 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\Home\Index.cshtml"
                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</h4>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f0ba2834394f88031f8a85fb8568cb5bc735b528c810a40799823af94737a457614", async() => {
                WriteLiteral("Detay");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\Home\Index.cshtml"
                                                                                           WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\Home\Index.cshtml"

        if (count % 3 == 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\Home\Index.cshtml"
       Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\Home\Index.cshtml"
                               
        }

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Umut.Sahinkaya\source\repos\UmutSahinkaya\Microservices\Microservices\FrontEnds\Web\Views\Home\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CourseViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
