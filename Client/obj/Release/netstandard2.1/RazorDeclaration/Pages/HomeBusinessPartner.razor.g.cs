#pragma checksum "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeBusinessPartner.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8572887186d8e5320a8e816875e3da02f52e5d1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SonicWarehouseManagement.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using SonicWarehouseManagement.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using SonicWarehouseManagement.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeBusinessPartner.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeBusinessPartner.razor"
using SonicWarehouseManagement.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/businesspartnerlist")]
    public partial class HomeBusinessPartner : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeBusinessPartner.razor"
       
    BusinessPartner[] bplist;

    private HubConnection hubCon;

    protected override async Task OnInitializedAsync()
    {
        hubCon = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/BusinessPartnerHub"))
            .Build();

        hubCon.On("ReceiveMessage", () =>
        {
            CallLoadData();
            StateHasChanged();
        });

        await hubCon.StartAsync();
        await LoadData();
    }

    private void CallLoadData()
    {
        Task.Run(async () =>
        {
            await LoadData();
        });
    }

    protected async Task LoadData()
    {
        bplist = await Http.GetJsonAsync<BusinessPartner[]>("api/BusinessPartners");
        StateHasChanged();
    }

    public void Dispose()
    {
        _ = hubCon.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
