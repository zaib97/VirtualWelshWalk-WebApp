#pragma checksum "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\VirtualMap.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96cbddd024474d682b58115017b26f05118524bd"
// <auto-generated/>
#pragma warning disable 1591
namespace VirtualWelshWalk.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\_Imports.razor"
using VirtualWelshWalk;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\_Imports.razor"
using VirtualWelshWalk.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Virtual Welsh Map")]
    public partial class VirtualMap : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"https://api.mapbox.com/mapbox-gl-js/v2.0.0/mapbox-gl.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>VirtualMap</h3>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "id", "map");
            __builder.AddAttribute(4, "style", "position:fixed; width: 50%; height: 50%;");
            __builder.AddElementReferenceCapture(5, (__value) => {
#nullable restore
#line 8 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\VirtualMap.razor"
           mapElement = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\VirtualMap.razor"
 
    ElementReference mapElement;
    IJSObjectReference mapModule;
    IJSObjectReference mapInstance;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            mapModule = await jsRunTime.InvokeAsync<IJSObjectReference>(
                "import", "./scripts/MapBox.js");
            mapInstance = await mapModule.InvokeAsync<IJSObjectReference>(
                "initialize", mapElement);

            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRunTime { get; set; }
    }
}
#pragma warning restore 1591
