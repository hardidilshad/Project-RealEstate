#pragma checksum "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fd0c88fb224fe7c537dd1df0e872eb6d454c682"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Properties_Details), @"mvc.1.0.view", @"/Views/Properties/Details.cshtml")]
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
#line 1 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\_ViewImports.cshtml"
using H_EstateAgency2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\_ViewImports.cshtml"
using H_EstateAgency2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd0c88fb224fe7c537dd1df0e872eb6d454c682", @"/Views/Properties/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8e985bccd174d8f46d08badd1ea30c60ddb91c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Properties_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<H_EstateAgency2.Models.Property>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Property</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PropertyType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.PropertyType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PropertyTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.PropertyTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PropertyCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.PropertyCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PropertyAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.PropertyAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PropertyArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.PropertyArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PropertyPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.PropertyPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PropertyYearOfBuilt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.PropertyYearOfBuilt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PropertyComBuilt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.PropertyComBuilt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PublishingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.PublishingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.isAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.isAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 83 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
         foreach (var item in Model.pictures)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4\">\r\n                <div class=\"card\" style=\"width: 25rem; \">\r\n                    <img style=\"width: 25rem; height:25rem\"");
            BeginWriteAttribute("src", " src=\"", 2815, "\"", 2900, 1);
#nullable restore
#line 87 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
WriteAttributeValue("", 2821, String.Format("data:image/png;base64,{0}", Convert.ToBase64String(item.photo)), 2821, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 92 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    \r\n\r\n\r\n\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fd0c88fb224fe7c537dd1df0e872eb6d454c68213624", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\Users\Ahmed Safaa\Source\Repos\hardidilshad\Project-RealEstate\H_EstateAgency2\Views\Properties\Details.cshtml"
                           WriteLiteral(Model.PropertyId);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fd0c88fb224fe7c537dd1df0e872eb6d454c68215810", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<H_EstateAgency2.Models.Property> Html { get; private set; }
    }
}
#pragma warning restore 1591
