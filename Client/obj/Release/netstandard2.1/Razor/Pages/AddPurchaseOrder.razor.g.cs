#pragma checksum "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\AddPurchaseOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8a3b9fca739a46385398755becb1a4b3c56aca3"
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
#line 2 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\AddPurchaseOrder.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\AddPurchaseOrder.razor"
using SonicWarehouseManagement.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addpurchaseorder")]
    public partial class AddPurchaseOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Add new purchase order</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label for=\"site\" class=\"control-label\">Site</label>\r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "form", "site");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\AddPurchaseOrder.razor"
                                                                po.Site

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => po.Site = __value, po.Site));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<label for=\"postingdate\" class=\"control-label\">Posting date</label>\r\n                ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "form", "postingdate");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\AddPurchaseOrder.razor"
                                                                       po.Posting_Date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => po.Posting_Date = __value, po.Posting_Date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.AddMarkupContent(34, "<label for=\"docdate\" class=\"control-label\">Document date</label>\r\n                ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "form", "docdate");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\AddPurchaseOrder.razor"
                                                                   po.Document_Date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => po.Document_Date = __value, po.Document_Date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.AddMarkupContent(45, "<label for=\"artdoc\" class=\"control-label\">Article document</label>\r\n                ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "form", "artdoc");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\AddPurchaseOrder.razor"
                                                                  po.Article_Doc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => po.Article_Doc = __value, po.Article_Doc));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-group");
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.AddMarkupContent(56, "<label for=\"billdoc\" class=\"control-label\">Bill Document</label>\r\n                ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "form", "billdoc");
            __builder.AddAttribute(59, "class", "form-control");
            __builder.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\AddPurchaseOrder.razor"
                                                                   po.Bill_Doc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => po.Bill_Doc = __value, po.Bill_Doc));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-group");
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.AddMarkupContent(67, "<label for=\"itemcode\" class=\"control-label\">Item code</label>\r\n                ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "form", "itemcode");
            __builder.AddAttribute(70, "class", "form-control");
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\AddPurchaseOrder.razor"
                                                                    po.Item_Code

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => po.Item_Code = __value, po.Item_Code));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "form-group");
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.AddMarkupContent(78, "<label for=\"itemdesc\" class=\"control-label\">Item description</label>\r\n                ");
            __builder.OpenElement(79, "input");
            __builder.AddAttribute(80, "form", "itemdesc");
            __builder.AddAttribute(81, "class", "form-control");
            __builder.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\AddPurchaseOrder.razor"
                                                                    po.Item_Desc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => po.Item_Desc = __value, po.Item_Desc));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "form-group");
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.AddMarkupContent(89, "<label for=\"qty\" class=\"control-label\">Quantity</label>\r\n                ");
            __builder.OpenElement(90, "input");
            __builder.AddAttribute(91, "form", "qty");
            __builder.AddAttribute(92, "class", "form-control");
            __builder.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\AddPurchaseOrder.razor"
                                                               po.Quantity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => po.Quantity = __value, po.Quantity));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "row");
            __builder.AddMarkupContent(101, "\r\n        ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "col-md-4");
            __builder.AddMarkupContent(104, "\r\n            ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "form-group");
            __builder.AddMarkupContent(107, "\r\n                ");
            __builder.OpenElement(108, "input");
            __builder.AddAttribute(109, "type", "button");
            __builder.AddAttribute(110, "class", "btn btn-success");
            __builder.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\AddPurchaseOrder.razor"
                                                                        addpurchaseorder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(112, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                ");
            __builder.OpenElement(114, "input");
            __builder.AddAttribute(115, "type", "button");
            __builder.AddAttribute(116, "class", "btn btn-danger");
            __builder.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\AddPurchaseOrder.razor"
                                                                       cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\AddPurchaseOrder.razor"
       
    PurchaseOrder po = new PurchaseOrder();

    private HubConnection hubCon;

    protected override async Task OnInitializedAsync()
    {
        hubCon = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/PurchaseOrderManualHub"))
            .Build();

        await hubCon.StartAsync();
    }

    public bool IsConnected =>
        hubCon.State == HubConnectionState.Connected;

    public async Task addpurchaseorder()
    {
        await Http.PostJsonAsync("api/PurchaseOrdersManual", po);
        if (IsConnected) await SendMessage();
        NavigationManager.NavigateTo("purchaseorderlist");
    }

    Task SendMessage() => hubCon.SendAsync("SendMessage");

    void cancel()
    {
        NavigationManager.NavigateTo("purchaseorderlist");
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
