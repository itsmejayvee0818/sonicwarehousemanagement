#pragma checksum "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ca23f1ef4e2aad709bc9685d48ee1136e5e0414"
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
#line 2 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
using SonicWarehouseManagement.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addsalesorder")]
    public partial class AddSalesOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Add new sales order</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-2");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"routeno\" class=\"control-label\">Route number</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "form", "routeno");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                   solist.Route_No

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => solist.Route_No = __value, solist.Route_No));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-md-2");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group");
            __builder.AddMarkupContent(19, "<label for=\"ordertype\" class=\"control-label\">Order type</label>\r\n                ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "form", "ordertype");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                     solist.Order_Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => solist.Order_Type = __value, solist.Order_Type));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-md-2");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group");
            __builder.AddMarkupContent(30, "<label for=\"orderno\" class=\"control-label\">Order number</label>\r\n                ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "form", "orderno");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                   solist.Order_Number

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => solist.Order_Number = __value, solist.Order_Number));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-md-2");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group");
            __builder.AddMarkupContent(41, "<label for=\"sodate\" class=\"control-label\">Sales order date</label>\r\n                ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "form", "sodate");
            __builder.AddAttribute(44, "class", "form-control");
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                  date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => date = __value, date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-md-2");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group");
            __builder.AddMarkupContent(52, "<label for=\"outletcode\" class=\"control-label\">Outlet code</label>\r\n                ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "form", "outletcode");
            __builder.AddAttribute(55, "class", "form-control");
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                      solist.Outlet_Code

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => solist.Outlet_Code = __value, solist.Outlet_Code));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-md-2");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "form-group");
            __builder.AddMarkupContent(63, "<label for=\"outletname\" class=\"control-label\">Outlet name</label>\r\n                ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "form", "outletname");
            __builder.AddAttribute(66, "class", "form-control");
            __builder.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                      solist.Outlet_Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => solist.Outlet_Name = __value, solist.Outlet_Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "col-md-2");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "form-group");
            __builder.AddMarkupContent(74, "<label for=\"status\" class=\"control-label\">Status</label>\r\n                ");
            __builder.OpenElement(75, "input");
            __builder.AddAttribute(76, "form", "status");
            __builder.AddAttribute(77, "class", "form-control");
            __builder.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                  solist.Status

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => solist.Status = __value, solist.Status));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "col-md-2");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "form-group");
            __builder.AddMarkupContent(85, "<label for=\"deliveryno\" class=\"control-label\">Delivery number</label>\r\n                ");
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "form", "deliveryno");
            __builder.AddAttribute(88, "class", "form-control");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                      solist.Delivery_N

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => solist.Delivery_N = __value, solist.Delivery_N));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "col-md-2");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "form-group");
            __builder.AddMarkupContent(96, "<label for=\"routetype\" class=\"control-label\">Route type</label>\r\n                ");
            __builder.OpenElement(97, "input");
            __builder.AddAttribute(98, "form", "routetype");
            __builder.AddAttribute(99, "class", "form-control");
            __builder.AddAttribute(100, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                     solist.Route_Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => solist.Route_Type = __value, solist.Route_Type));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n        ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "col-md-2");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "form-group");
            __builder.AddMarkupContent(107, "<label for=\"salesmanname\" class=\"control-label\">Salesman name</label>\r\n                ");
            __builder.OpenElement(108, "input");
            __builder.AddAttribute(109, "form", "salesmanname");
            __builder.AddAttribute(110, "class", "form-control");
            __builder.AddAttribute(111, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                        solist.Salesman_Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(112, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => solist.Salesman_Name = __value, solist.Salesman_Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n        ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "col-md-2");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "form-group");
            __builder.AddMarkupContent(118, "<label for=\"termsofpayment\" class=\"control-label\">Terms of payment</label>\r\n                ");
            __builder.OpenElement(119, "input");
            __builder.AddAttribute(120, "form", "termsofpayment");
            __builder.AddAttribute(121, "class", "form-control");
            __builder.AddAttribute(122, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                          solist.Terms_of_payment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(123, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => solist.Terms_of_payment = __value, solist.Terms_of_payment));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n        ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "col-md-2");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "form-group");
            __builder.AddMarkupContent(129, "<label for=\"dfqcs\" class=\"control-label\">Delivery free qty cs</label>\r\n                ");
            __builder.OpenElement(130, "input");
            __builder.AddAttribute(131, "form", "dfqcs");
            __builder.AddAttribute(132, "class", "form-control");
            __builder.AddAttribute(133, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 80 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                 solist.Delivery_Free_Qty_CS

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(134, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => solist.Delivery_Free_Qty_CS = __value, solist.Delivery_Free_Qty_CS));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n        ");
            __builder.OpenElement(136, "div");
            __builder.AddAttribute(137, "class", "col-md-2");
            __builder.OpenElement(138, "div");
            __builder.AddAttribute(139, "class", "form-group");
            __builder.AddMarkupContent(140, "<label for=\"turnoverval\" class=\"control-label\">Turnover value</label>\r\n                ");
            __builder.OpenElement(141, "input");
            __builder.AddAttribute(142, "form", "turnoverval");
            __builder.AddAttribute(143, "class", "form-control");
            __builder.AddAttribute(144, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 86 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                       solist.Turnover_Value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(145, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => solist.Turnover_Value = __value, solist.Turnover_Value));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n        ");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "col-md-2");
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "class", "form-group");
            __builder.AddMarkupContent(151, "<label for=\"dfqpc\" class=\"control-label\">Delivery free qty pc</label>\r\n                ");
            __builder.OpenElement(152, "input");
            __builder.AddAttribute(153, "form", "dfqpc");
            __builder.AddAttribute(154, "class", "form-control");
            __builder.AddAttribute(155, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 92 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                 solist.Delivery_Free_Qty_PC

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(156, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => solist.Delivery_Free_Qty_PC = __value, solist.Delivery_Free_Qty_PC));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n        ");
            __builder.OpenElement(158, "div");
            __builder.AddAttribute(159, "class", "col-md-2");
            __builder.OpenElement(160, "div");
            __builder.AddAttribute(161, "class", "form-group");
            __builder.AddMarkupContent(162, "<label for=\"doccat\" class=\"control-label\">Document category</label>\r\n                ");
            __builder.OpenElement(163, "input");
            __builder.AddAttribute(164, "form", "doccat");
            __builder.AddAttribute(165, "class", "form-control");
            __builder.AddAttribute(166, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 98 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                  solist.Document_Category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(167, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => solist.Document_Category = __value, solist.Document_Category));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n        ");
            __builder.OpenElement(169, "div");
            __builder.AddAttribute(170, "class", "col-md-2");
            __builder.OpenElement(171, "div");
            __builder.AddAttribute(172, "class", "form-group");
            __builder.AddMarkupContent(173, "<label for=\"salesman\" class=\"control-label\">Salesman</label>\r\n                ");
            __builder.OpenElement(174, "input");
            __builder.AddAttribute(175, "form", "salesman");
            __builder.AddAttribute(176, "class", "form-control");
            __builder.AddAttribute(177, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 104 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                    solist.Salesman

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(178, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => solist.Salesman = __value, solist.Salesman));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n        ");
            __builder.OpenElement(180, "div");
            __builder.AddAttribute(181, "class", "col-md-2");
            __builder.OpenElement(182, "div");
            __builder.AddAttribute(183, "class", "form-group");
            __builder.AddMarkupContent(184, "<label for=\"ordertypedesc\" class=\"control-label\">Order type description</label>\r\n                ");
            __builder.OpenElement(185, "input");
            __builder.AddAttribute(186, "form", "ordertypedesc");
            __builder.AddAttribute(187, "class", "form-control");
            __builder.AddAttribute(188, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 110 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                         solist.Order_Type_Desc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(189, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => solist.Order_Type_Desc = __value, solist.Order_Type_Desc));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n        ");
            __builder.OpenElement(191, "div");
            __builder.AddAttribute(192, "class", "col-md-4");
            __builder.OpenElement(193, "div");
            __builder.AddAttribute(194, "class", "form-group");
            __builder.OpenElement(195, "input");
            __builder.AddAttribute(196, "type", "button");
            __builder.AddAttribute(197, "class", "btn btn-success");
            __builder.AddAttribute(198, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 115 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                        addsalesorder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(199, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\r\n                ");
            __builder.OpenElement(201, "input");
            __builder.AddAttribute(202, "type", "button");
            __builder.AddAttribute(203, "class", "btn btn-danger");
            __builder.AddAttribute(204, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 116 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
                                                                       cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(205, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\AddSalesOrder.razor"
       
    SalesOrder solist = new SalesOrder();

    public string date { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");

    private HubConnection hubCon;

    protected override async Task OnInitializedAsync()
    {
        hubCon = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/SalesOrderHub"))
            .Build();

        await hubCon.StartAsync();
    }

    public bool IsConnected =>
            hubCon.State == HubConnectionState.Connected;

    public async Task addsalesorder()
    {
        var addSOHeader = new SalesOrderHeaders { Route_Type = solist.Route_Type, Salesman_Name = solist.Salesman_Name, Terms_of_payment = solist.Terms_of_payment, Delivery_Free_Qty_CS = solist.Delivery_Free_Qty_CS, Turnover_Value = solist.Turnover_Value, Delivery_Free_Qty_PC = solist.Delivery_Free_Qty_PC, Document_Category = solist.Document_Category, Salesman = solist.Salesman, Order_Type = solist.Order_Type, Route_No = solist.Route_No, Order_Type_Desc = solist.Order_Type_Desc, Order_Number = solist.Order_Number, SO_Date = solist.SO_Date, Outlet_Code = solist.Outlet_Code, Outlet_Name = solist.Outlet_Name, Status = solist.Status, Delivery_N = solist.Delivery_N };
        await Http.PostJsonAsync("api/SalesOrderHeadersIndex", addSOHeader);

        if (IsConnected) await SendMessage();
        NavigationManager.NavigateTo("editsalesorder/" + solist.Order_Number);
    }

    Task SendMessage() => hubCon.SendAsync("SendMessage");

    void cancel()
    {
        NavigationManager.NavigateTo("salesorderlist");
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
