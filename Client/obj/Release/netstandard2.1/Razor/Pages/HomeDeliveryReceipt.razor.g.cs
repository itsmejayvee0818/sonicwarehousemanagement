#pragma checksum "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "873dcf7a1783f11861f80073bb6cc228a9c1a39f"
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
#line 2 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
using SonicWarehouseManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/deliveryreceiptlist")]
    public partial class HomeDeliveryReceipt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Delivery Receipt</h2>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<a href=\"/adddeliveryreceipt\" class=\"btn btn-primary\">Create new delivery receipt</a>\r\n<hr>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-inline");
            __builder.AddMarkupContent(4, "<label class=\"sr-only\" for=\"search-ordernumber\">Search</label>\r\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control mb-2 mr-sm-2");
            __builder.AddAttribute(8, "placeholder", "Search delivery number");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
                                                                searchdelivery

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchdelivery = __value, searchdelivery));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "class", "btn btn-primary mr-sm-2 mb-2");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
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
#line 18 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
 if (drlist == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "<p><em>Loading...</em></p>");
#nullable restore
#line 21 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "table");
            __builder.AddAttribute(20, "class", "table");
            __builder.AddMarkupContent(21, "<thead><tr><th style=\"font-size: small;\">ID</th>\r\n                <th style=\"font-size: small;\">Delivery Receipt No</th>\r\n                <th style=\"font-size: small;\">Delivery Due Date</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(22, "tbody");
#nullable restore
#line 34 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
             foreach (var dr in drlist)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "tr");
            __builder.OpenElement(24, "td");
            __builder.AddAttribute(25, "style", "font-size: small;");
            __builder.AddContent(26, 
#nullable restore
#line 37 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
                                                   dr.ID

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
#line 38 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
                                                   dr.Delivery_Receipt_No

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
#line 39 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
                                                   dr.Delivery_Due_Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "style", "font-size: small;");
            __builder.AddAttribute(39, "href", "/editdeliveryreceipt/" + (
#nullable restore
#line 41 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
                                                                                 dr.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "btn-sm btn-primary");
            __builder.AddContent(41, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "style", "font-size: small;");
            __builder.AddAttribute(45, "href", "/deletedeliveryreceipt/" + (
#nullable restore
#line 42 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
                                                                                   dr.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "class", "btn-sm btn-danger");
            __builder.AddContent(47, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.OpenComponent<SonicWarehouseManagement.Client.Shared.Pagination>(49);
            __builder.AddAttribute(50, "TotalPagesQuantity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 48 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
                                    totalPageQuantity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 48 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
                                                                    currentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 48 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
                                                                                         2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 48 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
                                                                                                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 49 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeDeliveryReceipt.razor"
       
    DeliveryReceipt[] drlist;

    private int totalPageQuantity;
    private int currentPage = 1;
    private string searchdelivery = string.Empty;

    private HubConnection hubCon;

    protected override async Task OnInitializedAsync()
    {
        hubCon = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/DeliveryReceiptHub"))
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
        var httpResponse = await Http.GetAsync($"api/DeliveryReceipts?page={page}&quantityPerPage={quantityPerPage}&delivery={searchdelivery}");

        if (httpResponse.IsSuccessStatusCode)
        {
            totalPageQuantity = int.Parse(httpResponse.Headers.GetValues("pagesQuantity").FirstOrDefault());
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            drlist = JsonSerializer.Deserialize<DeliveryReceipt[]>(responseString,
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
