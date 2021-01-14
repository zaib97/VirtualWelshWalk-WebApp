// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\VirtualMap.razor"
using DataAccess.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\VirtualMap.razor"
using VirtualWelshWalk.DataAccess.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\VirtualMap.razor"
using VirtualWelshWalk.DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Virtual Coastal Map")]
    public partial class VirtualMap : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\VirtualMap.razor"
 
    public People people { get; set; } = new People();
    public VirtualWalk virtualWalk { get; set; } = new VirtualWalk();
    CalculatePersonsPosition calculatePerson = new CalculatePersonsPosition();

    ElementReference mapElement;
    IJSObjectReference mapModule, mapInstance;

    #region elementIds
    string landID = "landID";
    #endregion

    string WalkName = "Welsh Coastal Walk";

    double stepToNextMilestone = 0;

    bool showEnterStepsModal = false;

    protected override async Task OnInitializedAsync()
    {
        people = await PeopleService.GetPeople();
        virtualWalk = await WalkService.GetVirtualWalk(WalkName, people.PeopleId);

        showEnterStepsModal = true;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {

            mapModule = await jsRunTime.InvokeAsync<IJSObjectReference>(
               "import", "./scripts/MapBox.js").AsTask();
            mapInstance = await mapModule.InvokeAsync<IJSObjectReference>(
                "initialize", mapElement).AsTask();

            if (virtualWalk != null && mapModule != null)
            {
                await UpdatePersonLocation();
            }

            StateHasChanged();
        }
    }

    async Task UpdatePersonLocation()
    {
        if (virtualWalk.TotalSteps >= 0)
        {
            await mapModule.InvokeVoidAsync("updatePersonIcon", calculatePerson.NewPosition(virtualWalk.TotalSteps)).AsTask();
            await mapModule.InvokeVoidAsync("LandMarksPassed", landID);
            stepToNextMilestone = Math.Round(await mapModule.InvokeAsync<double>("ApproximateStepsToNextMilestone"), 2);
        }
    }

    async Task Update()
    {
        showEnterStepsModal = false;
        await UpdatePersonLocation();
        await mapModule.InvokeVoidAsync("UpdateColourPath");
    }

    async ValueTask IAsyncDisposable.DisposeAsync()
    {
        if (mapInstance != null)
        {
            await mapInstance.DisposeAsync();
        }

        if (mapModule != null)
        {
            await mapModule.DisposeAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRunTime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleService PeopleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVirtualWalkService WalkService { get; set; }
    }
}
#pragma warning restore 1591
