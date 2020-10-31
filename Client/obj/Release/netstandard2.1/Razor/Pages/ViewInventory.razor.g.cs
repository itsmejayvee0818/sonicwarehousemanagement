#pragma checksum "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\ViewInventory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64f9a3b03ae0508e1bd5c0988d4594cc471c58e3"
// <auto-generated/>
#pragma warning disable 1591
namespace SonicWarehouseManagement.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using SonicWarehouseManagement.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using SonicWarehouseManagement.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\ViewInventory.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\ViewInventory.razor"
using SonicWarehouseManagement.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/viewinventory/{id}")]
    public partial class ViewInventory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Inventory</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Transaction Type: ");
            __builder.OpenElement(3, "b");
            __builder.AddContent(4, 
#nullable restore
#line 9 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\ViewInventory.razor"
                         inv.Transaction_Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Date: ");
            __builder.OpenElement(8, "b");
            __builder.AddContent(9, 
#nullable restore
#line 10 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\ViewInventory.razor"
             inv.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.AddMarkupContent(11, @"<table class=""table"">
    <thead>
        <tr>
            <th>Site</th>
            <th>Item Code</th>
            <th>Item Description</th>
            <th>Quantity</th>
            <th>Uom</th>
            <th>Posting Date</th>
            <th>Document Date</th>
        </tr>
    </thead>
    <tbody>

    </tbody>
</table>");
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\ViewInventory.razor"
       
    Inventory inv = new Inventory();
    Inventory[] inlist;

    private HubConnection hubCon;

    [Parameter]
    public string id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        inv     = await Http.GetJsonAsync<Inventory>("api/Inventories/" + id);

        hubCon = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/InventoryHub"))
            .Build();

        await hubCon.StartAsync();
    }

    public bool IsConnected =>
        hubCon.State == HubConnectionState.Connected;

    Task SendMessage() => hubCon.SendAsync("SendMessage");

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