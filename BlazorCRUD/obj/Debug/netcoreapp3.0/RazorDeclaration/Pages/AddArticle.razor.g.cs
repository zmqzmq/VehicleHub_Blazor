#pragma checksum "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\AddArticle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88a5f5b30071c537a519ac9cc7c38d530c91f59b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCRUD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using BlazorCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using BlazorCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\AddArticle.razor"
using BlazorCRUD.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\AddArticle.razor"
using BlazorCRUD.Contracts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addArticle")]
    public partial class AddArticle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\AddArticle.razor"
       

    Article article = new Article();

    protected async Task CreateArticle()
    {
        await articleManager.Create(article);
        navigationManager.NavigateTo("/articlelist");
    }

    void cancel()
    {
        navigationManager.NavigateTo("/articlelist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArticleManager articleManager { get; set; }
    }
}
#pragma warning restore 1591
