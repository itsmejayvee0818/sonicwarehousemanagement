#pragma checksum "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15d03df4a37b63153a9d6f5656e62031901a8e5d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editsalesorder/{id}")]
    public partial class EditSalesOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Sales order</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Order number: ");
            __builder.OpenElement(3, "b");
            __builder.AddContent(4, 
#nullable restore
#line 9 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                     solist.Order_Number

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Order type: ");
            __builder.AddContent(8, 
#nullable restore
#line 10 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                solist.Order_Type_Desc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "p");
            __builder.AddContent(11, "Date: ");
            __builder.AddContent(12, 
#nullable restore
#line 11 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
          solist.SO_Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n<hr>\r\n");
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table");
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.AddMarkupContent(17, "<thead>\r\n        <tr>\r\n            <th>Item number</th>\r\n            <th>Item description</th>\r\n            <th>Cases</th>\r\n            <th>Pieces</th>\r\n            <th>Free CS</th>\r\n            <th>Free PC</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(18, "tbody");
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 25 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
         if(sod == null)
        {

        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
             foreach(var items in sod)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "style", "font-size: small;");
            __builder.AddContent(25, 
#nullable restore
#line 34 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                   items.Material_N

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "style", "font-size: small;");
            __builder.AddContent(29, 
#nullable restore
#line 35 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                   items.Article_Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddAttribute(32, "style", "font-size: small;");
            __builder.AddContent(33, 
#nullable restore
#line 36 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                   items.Cases

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "style", "font-size: small;");
            __builder.AddContent(37, 
#nullable restore
#line 37 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                   items.Pieces

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "td");
            __builder.AddAttribute(40, "style", "font-size: small;");
            __builder.AddContent(41, 
#nullable restore
#line 38 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                   items.Free_Cases

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "td");
            __builder.AddAttribute(44, "style", "font-size: small;");
            __builder.AddContent(45, 
#nullable restore
#line 39 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                   items.Free_Piece

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 41 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n<hr>\r\n");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "container");
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "row");
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.AddMarkupContent(57, "<div class=\"text-left col-md-12\">\r\n            <h6><b>Insert Sales Order Details:</b></h6>\r\n        </div>\r\n        <hr>\r\n        ");
            __builder.OpenElement(58, "form");
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "row");
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "col-md-4");
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "form-group");
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.AddMarkupContent(69, "<label for=\"mn\" class=\"control-label\">Material Number</label>\r\n                        ");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "form", "mn");
            __builder.AddAttribute(72, "class", "form-control");
            __builder.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                                      sodlist.Material_N

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sodlist.Material_N = __value, sodlist.Material_N));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "col-md-4");
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "form-group");
            __builder.AddMarkupContent(83, "\r\n                        ");
            __builder.AddMarkupContent(84, "<label for=\"ad\" class=\"control-label\">Article Description</label>\r\n                        ");
            __builder.OpenElement(85, "input");
            __builder.AddAttribute(86, "form", "ad");
            __builder.AddAttribute(87, "class", "form-control");
            __builder.AddAttribute(88, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                                      sodlist.Article_Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sodlist.Article_Description = __value, sodlist.Article_Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "col-md-4");
            __builder.AddMarkupContent(95, "\r\n                    ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "form-group");
            __builder.AddMarkupContent(98, "\r\n                        ");
            __builder.AddMarkupContent(99, "<label for=\"ps\" class=\"control-label\">Pack Size</label>\r\n                        ");
            __builder.OpenElement(100, "input");
            __builder.AddAttribute(101, "form", "ps");
            __builder.AddAttribute(102, "class", "form-control");
            __builder.AddAttribute(103, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                                      sodlist.Pack_Size

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sodlist.Pack_Size = __value, sodlist.Pack_Size));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "col-md-4");
            __builder.AddMarkupContent(110, "\r\n                    ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "form-group");
            __builder.AddMarkupContent(113, "\r\n                        ");
            __builder.AddMarkupContent(114, "<label for=\"cs\" class=\"control-label\">Cases</label>\r\n                        ");
            __builder.OpenElement(115, "input");
            __builder.AddAttribute(116, "form", "cs");
            __builder.AddAttribute(117, "class", "form-control");
            __builder.AddAttribute(118, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                                      sodlist.Cases

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(119, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sodlist.Cases = __value, sodlist.Cases));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "col-md-4");
            __builder.AddMarkupContent(125, "\r\n                    ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "form-group");
            __builder.AddMarkupContent(128, "\r\n                        ");
            __builder.AddMarkupContent(129, "<label for=\"pc\" class=\"control-label\">Pieces</label>\r\n                        ");
            __builder.OpenElement(130, "input");
            __builder.AddAttribute(131, "form", "pc");
            __builder.AddAttribute(132, "class", "form-control");
            __builder.AddAttribute(133, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 81 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                                      sodlist.Pieces

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(134, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sodlist.Pieces = __value, sodlist.Pieces));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                ");
            __builder.OpenElement(138, "div");
            __builder.AddAttribute(139, "class", "col-md-4");
            __builder.AddMarkupContent(140, "\r\n                    ");
            __builder.OpenElement(141, "div");
            __builder.AddAttribute(142, "class", "form-group");
            __builder.AddMarkupContent(143, "\r\n                        ");
            __builder.AddMarkupContent(144, "<label for=\"fcs\" class=\"control-label\">Free Cases</label>\r\n                        ");
            __builder.OpenElement(145, "input");
            __builder.AddAttribute(146, "form", "fcs");
            __builder.AddAttribute(147, "class", "form-control");
            __builder.AddAttribute(148, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 87 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                                       sodlist.Free_Cases

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(149, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sodlist.Free_Cases = __value, sodlist.Free_Cases));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                ");
            __builder.OpenElement(153, "div");
            __builder.AddAttribute(154, "class", "col-md-4");
            __builder.AddMarkupContent(155, "\r\n                    ");
            __builder.OpenElement(156, "div");
            __builder.AddAttribute(157, "class", "form-group");
            __builder.AddMarkupContent(158, "\r\n                        ");
            __builder.AddMarkupContent(159, "<label for=\"fp\" class=\"control-label\">Free Piece</label>\r\n                        ");
            __builder.OpenElement(160, "input");
            __builder.AddAttribute(161, "form", "fp");
            __builder.AddAttribute(162, "class", "form-control");
            __builder.AddAttribute(163, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                                      sodlist.Free_Piece

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(164, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sodlist.Free_Piece = __value, sodlist.Free_Piece));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n                ");
            __builder.OpenElement(168, "div");
            __builder.AddAttribute(169, "class", "col-md-4");
            __builder.AddMarkupContent(170, "\r\n                    ");
            __builder.OpenElement(171, "div");
            __builder.AddAttribute(172, "class", "form-group");
            __builder.AddMarkupContent(173, "\r\n                        ");
            __builder.AddMarkupContent(174, "<label for=\"dqcs\" class=\"control-label\">Delivery Qty CS</label>\r\n                        ");
            __builder.OpenElement(175, "input");
            __builder.AddAttribute(176, "form", "dqcs");
            __builder.AddAttribute(177, "class", "form-control");
            __builder.AddAttribute(178, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 99 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                                        sodlist.Delivery_Qty_CS

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(179, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sodlist.Delivery_Qty_CS = __value, sodlist.Delivery_Qty_CS));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n                ");
            __builder.OpenElement(183, "div");
            __builder.AddAttribute(184, "class", "col-md-4");
            __builder.AddMarkupContent(185, "\r\n                    ");
            __builder.OpenElement(186, "div");
            __builder.AddAttribute(187, "class", "form-group");
            __builder.AddMarkupContent(188, "\r\n                        ");
            __builder.AddMarkupContent(189, "<label for=\"dqpc\" class=\"control-label\">Delivery Qty PC</label>\r\n                        ");
            __builder.OpenElement(190, "input");
            __builder.AddAttribute(191, "form", "dqpc");
            __builder.AddAttribute(192, "class", "form-control");
            __builder.AddAttribute(193, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 105 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                                        sodlist.Delivery_Qty_PC

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(194, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sodlist.Delivery_Qty_PC = __value, sodlist.Delivery_Qty_PC));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(195, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(197, "\r\n                ");
            __builder.OpenElement(198, "div");
            __builder.AddAttribute(199, "class", "col-md-4");
            __builder.AddMarkupContent(200, "\r\n                    ");
            __builder.OpenElement(201, "div");
            __builder.AddAttribute(202, "class", "form-group");
            __builder.AddMarkupContent(203, "\r\n                        ");
            __builder.AddMarkupContent(204, "<label for=\"sv\" class=\"control-label\">Sales_Value</label>\r\n                        ");
            __builder.OpenElement(205, "input");
            __builder.AddAttribute(206, "form", "sv");
            __builder.AddAttribute(207, "class", "form-control");
            __builder.AddAttribute(208, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 111 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                                      sodlist.Sales_Value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(209, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sodlist.Sales_Value = __value, sodlist.Sales_Value));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(210, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(211, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(212, "\r\n                ");
            __builder.OpenElement(213, "div");
            __builder.AddAttribute(214, "class", "col-md-4");
            __builder.AddMarkupContent(215, "\r\n                    ");
            __builder.OpenElement(216, "div");
            __builder.AddAttribute(217, "class", "form-group");
            __builder.AddMarkupContent(218, "\r\n                        ");
            __builder.AddMarkupContent(219, "<label for=\"vv\" class=\"control-label\">VAT Value</label>\r\n                        ");
            __builder.OpenElement(220, "input");
            __builder.AddAttribute(221, "form", "vv");
            __builder.AddAttribute(222, "class", "form-control");
            __builder.AddAttribute(223, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 117 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                                      sodlist.VAT_Value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(224, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sodlist.VAT_Value = __value, sodlist.VAT_Value));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(225, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(226, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(227, "\r\n                ");
            __builder.OpenElement(228, "div");
            __builder.AddAttribute(229, "class", "col-md-4");
            __builder.AddMarkupContent(230, "\r\n                    ");
            __builder.OpenElement(231, "div");
            __builder.AddAttribute(232, "class", "form-group");
            __builder.AddMarkupContent(233, "\r\n                        ");
            __builder.AddMarkupContent(234, "<label for=\"ns\" class=\"control-label\">Net Sales</label>\r\n                        ");
            __builder.OpenElement(235, "input");
            __builder.AddAttribute(236, "form", "ns");
            __builder.AddAttribute(237, "class", "form-control");
            __builder.AddAttribute(238, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 123 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                                      sodlist.Net_Sales

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(239, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sodlist.Net_Sales = __value, sodlist.Net_Sales));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(240, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(241, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(242, "\r\n                ");
            __builder.OpenElement(243, "div");
            __builder.AddAttribute(244, "class", "col-md-4");
            __builder.AddMarkupContent(245, "\r\n                    ");
            __builder.OpenElement(246, "div");
            __builder.AddAttribute(247, "class", "form-group");
            __builder.AddMarkupContent(248, "\r\n                        ");
            __builder.AddMarkupContent(249, "<label for=\"in\" class=\"control-label\">Item Number</label>\r\n                        ");
            __builder.OpenElement(250, "input");
            __builder.AddAttribute(251, "form", "in");
            __builder.AddAttribute(252, "class", "form-control");
            __builder.AddAttribute(253, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 129 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                                      sodlist.Item_Number

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(254, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sodlist.Item_Number = __value, sodlist.Item_Number));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(255, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(256, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(257, "\r\n                ");
            __builder.OpenElement(258, "div");
            __builder.AddAttribute(259, "class", "col-md-4");
            __builder.AddMarkupContent(260, "\r\n                    ");
            __builder.OpenElement(261, "div");
            __builder.AddAttribute(262, "class", "form-group");
            __builder.AddMarkupContent(263, "\r\n                        ");
            __builder.AddMarkupContent(264, "<label for=\"cspc\" class=\"control-label\">Cases Pieces</label>\r\n                        ");
            __builder.OpenElement(265, "input");
            __builder.AddAttribute(266, "form", "cspc");
            __builder.AddAttribute(267, "class", "form-control");
            __builder.AddAttribute(268, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 135 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                                        sodlist.Cases_Pieces

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(269, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sodlist.Cases_Pieces = __value, sodlist.Cases_Pieces));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(270, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(271, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(272, "\r\n                ");
            __builder.OpenElement(273, "div");
            __builder.AddAttribute(274, "class", "col-md-4");
            __builder.AddMarkupContent(275, "\r\n                    ");
            __builder.OpenElement(276, "div");
            __builder.AddAttribute(277, "class", "form-group");
            __builder.AddMarkupContent(278, "\r\n                        ");
            __builder.AddMarkupContent(279, "<label for=\"fcspc\" class=\"control-label\">Free CS PC</label>\r\n                        ");
            __builder.OpenElement(280, "input");
            __builder.AddAttribute(281, "form", "fcspc");
            __builder.AddAttribute(282, "class", "form-control");
            __builder.AddAttribute(283, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 141 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                                         sodlist.Free_CS_PS

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(284, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sodlist.Free_CS_PS = __value, sodlist.Free_CS_PS));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(285, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(286, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(287, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(288, "\r\n            ");
            __builder.OpenElement(289, "div");
            __builder.AddAttribute(290, "class", "text-center");
            __builder.AddMarkupContent(291, "\r\n                ");
            __builder.OpenElement(292, "input");
            __builder.AddAttribute(293, "type", "button");
            __builder.AddAttribute(294, "class", "btn btn-success");
            __builder.AddAttribute(295, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 146 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
                                                                        updatesalesorder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(296, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(297, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(298, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(299, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(300, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 152 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditSalesOrder.razor"
       
    SalesOrderHeaders solist = new SalesOrderHeaders();
    SalesOrderDetails sodlist = new SalesOrderDetails();
    SalesOrderDetails[] sod;

    private HubConnection hubCon;

    [Parameter]
    public string id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        solist = await Http.GetJsonAsync<SalesOrderHeaders>("api/SalesOrderHeadersIndex/" + id);
        sod = await Http.GetJsonAsync<SalesOrderDetails[]>("api/SalesOrderDetailsIndex/" + id);

        hubCon = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/SalesOrderHub"))
            .Build();

        await hubCon.StartAsync();
    }

    public bool IsConnected =>
        hubCon.State == HubConnectionState.Connected;

    public async Task updatesalesorder()
    {
        await Http.PostJsonAsync("api/SalesOrderDetailsIndex/" + id, sodlist);

        var addHeaderItems = new InventoryHeader { Ref_ID = id, Item_Code = sodlist.Material_N, Ref_Type = "Sales Order"};
        await Http.PostJsonAsync("api/InventoryHeadersIndex", addHeaderItems);

        if(sodlist.Cases.Equals(""))
        {
            var addDetailItems = new InventoryDetails { Header_Ref = id, Quantity = Int32.Parse(sodlist.Pieces), Uom = "PC", Transaction_Type = "Sales Order" };
            await Http.PostJsonAsync("api/InventoryDetailsIndex", addDetailItems);

        }
        if(sodlist.Pieces.Equals(""))
        {
            var addDetailItems = new InventoryDetails { Header_Ref = id, Quantity = Int32.Parse(sodlist.Cases), Uom = "CS", Transaction_Type = "Sales Order" };
            await Http.PostJsonAsync("api/InventoryDetailsIndex", addDetailItems);
        }
        if (IsConnected) await SendMessage();
        NavigationManager.NavigateTo("salesorderlist");
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
