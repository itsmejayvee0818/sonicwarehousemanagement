#pragma checksum "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbe3c72b81986f832abe6a9a1e35e76a86de3d2c"
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
#line 2 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
using SonicWarehouseManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/purchaseorderlist")]
    public partial class HomePurchaseOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Purchase order</h2>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<a href=\"/addpurchaseorder\" class=\"btn btn-primary\">Create new purchase order</a>\r\n<hr>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-inline");
            __builder.AddMarkupContent(4, "<label class=\"sr-only\" for=\"search-ordernumber\">Search</label>\r\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control mb-2 mr-sm-2");
            __builder.AddAttribute(8, "placeholder", "Search article number");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                                searchartnum

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchartnum = __value, searchartnum));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "class", "btn btn-primary mr-sm-2 mb-2");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                                         Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n<hr>");
#nullable restore
#line 18 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
 if (polist == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "<p><em>Loading...</em></p>");
#nullable restore
#line 21 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "table");
            __builder.AddAttribute(20, "class", "table");
            __builder.AddMarkupContent(21, "<thead><tr><th>ID</th>\r\n                <th>Article document</th>\r\n                <th>Bill document</th></tr></thead>\r\n        ");
            __builder.OpenElement(22, "tbody");
#nullable restore
#line 33 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
             foreach (var po in polist)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "tr");
            __builder.OpenElement(24, "td");
            __builder.AddAttribute(25, "style", "font-size: small;");
            __builder.AddContent(26, 
#nullable restore
#line 36 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                   po.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddAttribute(29, "style", "font-size: small;");
            __builder.AddContent(30, 
#nullable restore
#line 37 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                   po.Article_Doc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "style", "font-size: small;");
            __builder.AddContent(34, 
#nullable restore
#line 38 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                   po.Bill_Doc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", "/editpurchaseorder/" + (
#nullable restore
#line 40 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                     po.Article_Doc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "class", "btn-sm btn-primary");
            __builder.AddContent(40, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.OpenComponent<SonicWarehouseManagement.Client.Shared.Pagination>(42);
            __builder.AddAttribute(43, "TotalPagesQuantity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                    totalPageQuantity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                                    currentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                                                         2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 46 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                                                                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 47 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
       
    PurchaseHeaders[] polist;

    private int totalPageQuantity;
    private int currentPage = 1;
    private string searchartnum = string.Empty;

    private HubConnection hubCon;

    protected override async Task OnInitializedAsync()
    {
        hubCon = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/PurchaseHeadersHub"))
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

    private async Task SelectedPage(int page)
    {
        currentPage = page;
        await LoadData(page);
    }

    private async Task Search()
    {
        currentPage = 1;
        await LoadData();
    }

    protected async Task LoadData(int page = 1, int quantityPerPage = 10)
    {
        var httpResponse = await Http.GetAsync($"api/PurchaseOrderHeadersIndex?page={page}&quantityPerPage={quantityPerPage}&article={searchartnum}");

        if (httpResponse.IsSuccessStatusCode)
        {
            totalPageQuantity = int.Parse(httpResponse.Headers.GetValues("pagesQuantity").FirstOrDefault());
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            polist = JsonSerializer.Deserialize<PurchaseHeaders[]>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            StateHasChanged();
        }
        else
        {
            //Error handler
        }
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
