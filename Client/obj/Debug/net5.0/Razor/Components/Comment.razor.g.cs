#pragma checksum "/home/erwin/Documents/Code/hnpwa-blazor/Client/Components/Comment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5db23b69650bae0cac93a3bb4bad489660bd9ab"
// <auto-generated/>
#pragma warning disable 1591
namespace Hnpwa.Client.Components
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
    public partial class Comment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mt-4");
            __builder.OpenElement(2, "span");
            __builder.AddAttribute(3, "class", "text-indigo-700 hover:underline");
            __builder.AddContent(4, 
#nullable restore
#line 3 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Components/Comment.razor"
         Item.User

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n    ");
            __builder.OpenElement(6, "span");
            __builder.AddContent(7, 
#nullable restore
#line 6 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Components/Comment.razor"
         Item.TimeAgo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n    ");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "class", "cursor-pointer");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Components/Comment.razor"
                                        Toggle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "\n        [");
            __builder.AddContent(13, 
#nullable restore
#line 9 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Components/Comment.razor"
          toggleIndicator

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "]\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 12 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Components/Comment.razor"
 if(show)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "max-w-prose comment mt-3");
            __builder.AddContent(17, 
#nullable restore
#line 15 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Components/Comment.razor"
          (MarkupString)Item.Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "ml-8");
#nullable restore
#line 18 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Components/Comment.razor"
         foreach(IComment kid in Item.Comments)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Hnpwa.Client.Components.Comment>(21);
            __builder.AddAttribute(22, "Item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Hnpwa.Shared.IComment>(
#nullable restore
#line 20 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Components/Comment.razor"
                            kid

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 21 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Components/Comment.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 23 "/home/erwin/Documents/Code/hnpwa-blazor/Client/Components/Comment.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591