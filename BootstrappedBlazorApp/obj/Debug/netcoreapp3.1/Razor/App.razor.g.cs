#pragma checksum "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db9b6d068c2674409919ef3761d640d01b1f69b5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Core.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Transition.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Script.DomHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Form;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Input;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Typography;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Progress;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Transition;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Button;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Icon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Paper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Avatar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Badge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Selection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Toolbar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.AppBar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Divider;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Grid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Table;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Baseline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Card;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Hidden;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.List;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Script;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Drawer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Dialog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Popover;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Tab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\_Imports.razor"
using Skclusive.Material.Container;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Skclusive.Material.Component.MaterialScripts>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<Skclusive.Material.Component.MaterialStyles>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n\r\n");
            __builder.OpenComponent<Skclusive.Material.Theme.ThemeProvider>(4);
            __builder.AddAttribute(5, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Skclusive.Core.Component.Theme>(
#nullable restore
#line 6 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\App.razor"
                       Theme.Light

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(7);
            __builder.AddAttribute(8, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 8 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(11);
                __builder2.AddAttribute(12, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 10 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 10 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n    ");
            }
            ));
            __builder.AddAttribute(15, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(17);
                __builder2.AddAttribute(18, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 13 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(20, "\r\n            ");
                    __builder3.AddMarkupContent(21, "<p>Sorry, there\'s nothing at this address.</p>\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
