#pragma checksum "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66f2d03c6acc77c3eee378b56a69e2bab962d268"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\_Imports.razor"
using BlazorCRUD.Client;

#line default
#line hidden
#line 7 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\_Imports.razor"
using BlazorCRUD.Client.Shared;

#line default
#line hidden
#line 8 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\_Imports.razor"
using BlazorCRUD.Shared.Models;

#line default
#line hidden
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>BlazorCRUD</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 3 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#line 8 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 8 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "patient");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Patient\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 34 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591