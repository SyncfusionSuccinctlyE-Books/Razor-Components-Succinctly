#pragma checksum "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\Shared\SurveyPrompt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "910c2948edbad1ad1924b991c4d6d4416fcbd344"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Shared
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
    public partial class SurveyPrompt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddMarkupContent(3, "\r\n    <span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\r\n    ");
            __builder.OpenElement(4, "strong");
            __builder.AddContent(5, 
#nullable restore
#line 3 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\Shared\SurveyPrompt.razor"
             Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.AddMarkupContent(7, "<span class=\"text-nowrap\">\r\n        Please take our\r\n        <a target=\"_blank\" class=\"font-weight-bold\" href=\"https://go.microsoft.com/fwlink/?linkid=2112271\">brief survey</a>\r\n    </span>\r\n    and tell us what you think.\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Projects\Projects\Syncfusion\Razor Components Succinctly\demo\BlazorApp\Shared\SurveyPrompt.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string Title { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
