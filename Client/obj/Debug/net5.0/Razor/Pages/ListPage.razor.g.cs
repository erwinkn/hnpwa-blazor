#pragma checksum "/home/erwin/Documents/Code/hnpwa-blazor/Client/Pages/ListPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "585061ed4a56437def1a791eeed1f35ca1450758"
// <auto-generated/>
#pragma warning disable 1591
namespace Hnpwa.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/erwin/Documents/Code/hnpwa-blazor/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/erwin/Documents/Code/hnpwa-blazor/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/erwin/Documents/Code/hnpwa-blazor/Client/_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/erwin/Documents/Code/hnpwa-blazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/erwin/Documents/Code/hnpwa-blazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/erwin/Documents/Code/hnpwa-blazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/erwin/Documents/Code/hnpwa-blazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/erwin/Documents/Code/hnpwa-blazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/erwin/Documents/Code/hnpwa-blazor/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/erwin/Documents/Code/hnpwa-blazor/Client/_Imports.razor"
using Hnpwa.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/erwin/Documents/Code/hnpwa-blazor/Client/_Imports.razor"
using Hnpwa.Client.Layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/erwin/Documents/Code/hnpwa-blazor/Client/_Imports.razor"
using Hnpwa.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/erwin/Documents/Code/hnpwa-blazor/Client/_Imports.razor"
using Hnpwa.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{Category}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{Category}/{Page:int}")]
    public partial class ListPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Pages/ListPage.razor"
 if(Stories != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mx-auto");
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "href", "/" + (
#nullable restore
#line 10 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Pages/ListPage.razor"
                   Category

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 10 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Pages/ListPage.razor"
                              Page-1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "class", 
#nullable restore
#line 10 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Pages/ListPage.razor"
                                              prevStyling

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\n            Prev\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "span");
            __builder.AddAttribute(8, "class", "px-4");
            __builder.AddContent(9, 
#nullable restore
#line 14 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Pages/ListPage.razor"
              Page ?? 1

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, " / 10\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n        ");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", "/" + (
#nullable restore
#line 16 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Pages/ListPage.razor"
                   Category

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 16 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Pages/ListPage.razor"
                              Page+1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "class", 
#nullable restore
#line 16 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Pages/ListPage.razor"
                                              nextStyling

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\n            Next\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Pages/ListPage.razor"
    int counter = 1 + 30 * ((int)Page! - 1);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "ul");
            __builder.AddAttribute(17, "class", "list-disc");
#nullable restore
#line 22 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Pages/ListPage.razor"
         foreach(IStory story in Stories)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "flex mt-8");
            __builder.OpenComponent<Hnpwa.Client.Components.StoryTitle>(20);
            __builder.AddAttribute(21, "Story", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Hnpwa.Shared.IStory>(
#nullable restore
#line 25 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Pages/ListPage.razor"
                                    story

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "Number", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 25 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Pages/ListPage.razor"
                                                    counter

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 27 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Pages/ListPage.razor"
            counter++;
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 30 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Pages/ListPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
