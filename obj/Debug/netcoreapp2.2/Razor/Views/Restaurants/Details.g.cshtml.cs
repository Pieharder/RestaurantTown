#pragma checksum "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Restaurants/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "230e8795514e3275b99b57a7e13333bbebeb1cc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Details), @"mvc.1.0.view", @"/Views/Restaurants/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Details.cshtml", typeof(AspNetCore.Views_Restaurants_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"230e8795514e3275b99b57a7e13333bbebeb1cc8", @"/Views/Restaurants/Details.cshtml")]
    public class Views_Restaurants_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RestaurantTown.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Restaurants/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(68, 34, true);
            WriteLiteral("\n<h2>Item Details</h2>\n<hr />\n<h3>");
            EndContext();
            BeginContext(103, 40, false);
#line 9 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Restaurants/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(143, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(146, 36, false);
#line 9 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Restaurants/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(182, 9, true);
            WriteLiteral("</h3>\n<p>");
            EndContext();
            BeginContext(192, 40, false);
#line 10 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Restaurants/Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(232, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(241, 75, false);
#line 11 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Restaurants/Details.cshtml"
Write(Html.ActionLink("Edit Restaurant", "Edit", new { id = Model.RestaurantId }));

#line default
#line hidden
            EndContext();
            BeginContext(316, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(325, 79, false);
#line 12 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Restaurants/Details.cshtml"
Write(Html.ActionLink("Delete Restaurant", "Delete", new { id = Model.RestaurantId }));

#line default
#line hidden
            EndContext();
            BeginContext(404, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantTown.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591