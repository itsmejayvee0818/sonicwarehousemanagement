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
#line 2 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
using SonicWarehouseManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editsalesorder/{id}")]
    public partial class EditSalesOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
       

    ArticleMaster artmas = new ArticleMaster();
    SalesOrderHeaders solist = new SalesOrderHeaders();
    Discount disc = new Discount();
    BusinessPartner bp = new BusinessPartner();
    SalesOrderDetails[] sod;

    private HubConnection hubCon;

    public int cases { get; set; } = 0;
    public int pieces { get; set; } = 0;
    public int free_cases { get; set; } = 0;
    public int free_pieces { get; set; } = 0;
    public string searchitemnum { get; set; }
    public decimal cs { get; set; }
    public decimal pc { get; set; }
    public decimal size { get; set; }
    public decimal amount { get; set; }
    public decimal sales { get; set; }
    public decimal vat { get; set; }
    public decimal net { get; set; }
    public decimal discount { get; set; }
    public decimal discountAmount { get; set; }

    [Parameter]
    public string id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        solist = await Http.GetJsonAsync<SalesOrderHeaders>("api/SalesOrderHeadersIndex/" + id);
        sod = await Http.GetJsonAsync<SalesOrderDetails[]>("api/SalesOrderDetailsIndex/" + solist.ID);
        disc = await Http.GetJsonAsync<Discount>("api/Discounts/" + solist.Outlet_Code);
        bp = await Http.GetJsonAsync<BusinessPartner>("api/BusinessPartners/getbp/" + solist.Outlet_Code);

        hubCon = new HubConnectionBuilder()
        .WithUrl(NavigationManager.ToAbsoluteUri("/SalesOrderDetailsHub"))
        .Build();

        await hubCon.StartAsync();
    }

    public bool IsConnected =>
        hubCon.State == HubConnectionState.Connected;

    private async Task Search()
    {
        artmas = await Http.GetJsonAsync<ArticleMaster>("api/ArticleMasters/" + searchitemnum);
        this.StateHasChanged();
    }

    void cancel()
    {
        NavigationManager.NavigateTo("salesorderlist");
    }

    private async Task SaveDetails()
    {
        discountAmount = disc.Discount_Amount / 100;
        cs = Convert.ToDecimal(cases);
        pc = Convert.ToDecimal(pieces);
        size = Convert.ToDecimal(artmas.Unit_Conversion2);
        amount = Convert.ToDecimal(artmas.Secondary_Price_CS);
        sales = (cs * amount) + ((amount / size) * pc);
        discount = ((cs * amount) * discountAmount) + (((amount / size) * pc) * discountAmount);
        vat = ((cs * amount) * Convert.ToDecimal(0.12)) + (((amount / size) * pc) * Convert.ToDecimal(0.12));
        net = (sales + vat) - discount;

        var salesOrderDetails = new SalesOrderDetails { Header_ID = solist.ID, Material_N = artmas.Article_Code, Article_Description = artmas.Article_Description, Pack_Size = artmas.Unit_Conversion2, Cases = Convert.ToString(cases), Pieces = Convert.ToString(pieces), Free_Cases = Convert.ToString(free_cases), Free_Piece = Convert.ToString(free_pieces), Delivery_Qty_CS = Convert.ToString(cases), Delivery_Qty_PC = Convert.ToString(pieces), Sales_Value = sales, VAT_Value = vat, Net_Sales = net, Cases_Pieces = cases+"/"+ pieces, Free_CS_PS = free_cases+"/"+free_pieces };
        await Http.PostJsonAsync("api/SalesOrderDetailsIndex", salesOrderDetails);

        var InsertInventoryHeaders = new InventoryHeader { Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()), Item_Code = artmas.Article_Code, Ref_ID = "Sales Order" };
        await Http.PostJsonAsync("api/InventoryHeaderIndex/" + artmas.Article_Code, InsertInventoryHeaders);

        if(cases == 0)
        {
            var InsertInventory = new Inventory { Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()), Item_Code = artmas.Article_Code, Quantity = -pieces, Transaction_Type = "Sales Order", Uom = "PC", Warehouse = bp.Delivering_Site, Location = bp.Delivering_Site_Description };
            await Http.PostJsonAsync("api/Inventory", InsertInventory);

            var InsertInventoryDetails = new InventoryDetails { Header_Ref = artmas.Article_Code, Quantity = -pieces, Transaction_Type = "Sales Order", Uom = "PC", Warehouse = bp.Delivering_Site, Location = bp.Delivering_Site_Description };
            await Http.PostJsonAsync("api/InventoryDetailsManual", InsertInventoryDetails);
        }
        else
        {
            var InsertInventory = new Inventory { Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()), Item_Code = artmas.Article_Code, Quantity = -cases, Transaction_Type = "Sales Order", Uom = "CS", Warehouse = bp.Delivering_Site, Location = bp.Delivering_Site_Description };
            await Http.PostJsonAsync("api/Inventory", InsertInventory);

            var InsertInventoryDetails = new InventoryDetails { Header_Ref = artmas.Article_Code, Quantity = -cases, Transaction_Type = "Sales Order", Uom = "CS", Warehouse = bp.Delivering_Site, Location = bp.Delivering_Site_Description };
            await Http.PostJsonAsync("api/InventoryDetailsManual", InsertInventoryDetails);
        }


        if (IsConnected) await SendMessage();
        this.StateHasChanged();
        NavigationManager.NavigateTo("refresh/" + solist.Order_Number);
    }

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
