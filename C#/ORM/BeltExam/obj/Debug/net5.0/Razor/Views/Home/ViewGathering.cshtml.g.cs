#pragma checksum "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/Home/ViewGathering.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efc1b6606c5583384d05394437b75b3bbed4ca92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewGathering), @"mvc.1.0.view", @"/Views/Home/ViewGathering.cshtml")]
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
#line 1 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/_ViewImports.cshtml"
using BeltExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/_ViewImports.cshtml"
using BeltExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efc1b6606c5583384d05394437b75b3bbed4ca92", @"/Views/Home/ViewGathering.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84119000702c45f5036e3e300b27d647b6aca13", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewGathering : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<header>\n    <nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3\">\n        <div class=\"container\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efc1b6606c5583384d05394437b75b3bbed4ca925139", async() => {
                WriteLiteral("Dojo Activity Center");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                    aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""navbar-collapse collapse d-sm-inline-flex justify-content-between"">
                <ul class=""navbar-nav flex-grow-1"">
                    <li class=""nav-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efc1b6606c5583384d05394437b75b3bbed4ca927310", async() => {
                WriteLiteral("Dashboard");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </li>\n                    <li class=\"nav-item\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efc1b6606c5583384d05394437b75b3bbed4ca929030", async() => {
                WriteLiteral("Log Out");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </li>\n                </ul>\n            </div>\n        </div>\n    </nav>\n</header>\n\n<div class=\"canvas-view\">\n    <header class=\"view-header\">\n        <h2>");
#nullable restore
#line 25 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/Home/ViewGathering.cshtml"
       Write(ViewBag.OneGathering.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n");
#nullable restore
#line 26 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/Home/ViewGathering.cshtml"
          
        if(ViewBag.OneGathering.Creator.UserId == ViewBag.User.UserId){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><a");
            BeginWriteAttribute("href", " href=\"", 1381, "\"", 1439, 3);
            WriteAttributeValue("", 1388, "/gathering/", 1388, 11, true);
#nullable restore
#line 28 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/Home/ViewGathering.cshtml"
WriteAttributeValue("", 1399, ViewBag.OneGathering.GatheringId, 1399, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1432, "/delete", 1432, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn form-btn btn-lg btn-danger\">Delete</a></td>\n");
#nullable restore
#line 29 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/Home/ViewGathering.cshtml"
        }
        else if(ViewBag.OneGathering.Creator.UserId != ViewBag.User.UserId){
            var RSVP = false;
            foreach(var user in ViewBag.OneGathering.Attendees){
                if(user.UserId == ViewBag.User.UserId){
                    RSVP = true;
                }
            }
            if(RSVP == true){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td><a");
            BeginWriteAttribute("href", " href=\"", 1851, "\"", 1910, 3);
            WriteAttributeValue("", 1858, "/attendance/", 1858, 12, true);
#nullable restore
#line 38 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/Home/ViewGathering.cshtml"
WriteAttributeValue("", 1870, ViewBag.OneGathering.GatheringId, 1870, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1903, "/delete", 1903, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn form-btn btn-lg btn-danger\">Leave</a></td>\n");
#nullable restore
#line 39 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/Home/ViewGathering.cshtml"
            }
            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td><a");
            BeginWriteAttribute("href", " href=\"", 2020, "\"", 2079, 3);
            WriteAttributeValue("", 2027, "/attendance/", 2027, 12, true);
#nullable restore
#line 41 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/Home/ViewGathering.cshtml"
WriteAttributeValue("", 2039, ViewBag.OneGathering.GatheringId, 2039, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2072, "/submit", 2072, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn form-btn btn-lg btn-success\">Join</a></td>\n");
#nullable restore
#line 42 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/Home/ViewGathering.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    </header>\n    <h4>Event Coordinator: ");
#nullable restore
#line 46 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/Home/ViewGathering.cshtml"
                      Write(ViewBag.OneGathering.Creator.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    <h4>Date and Time: ");
#nullable restore
#line 47 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/Home/ViewGathering.cshtml"
                  Write(ViewBag.OneGathering.Date.ToString("MM dd yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" at ");
#nullable restore
#line 47 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/Home/ViewGathering.cshtml"
                                                                       Write(ViewBag.OneGathering.Time.ToString("h:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    <h4>Description: </h4>\n    <p>");
#nullable restore
#line 49 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/Home/ViewGathering.cshtml"
  Write(ViewBag.OneGathering.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <h4>Participants: </h4>\n    <ul>\n");
#nullable restore
#line 52 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/Home/ViewGathering.cshtml"
         foreach (var RSVP in ViewBag.OneGathering.Attendees)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 54 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/Home/ViewGathering.cshtml"
           Write(RSVP.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 55 "/Users/davidstorer/Documents/code/Coding Dojo/C#/ORM/BeltExam/Views/Home/ViewGathering.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n</div>");
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
