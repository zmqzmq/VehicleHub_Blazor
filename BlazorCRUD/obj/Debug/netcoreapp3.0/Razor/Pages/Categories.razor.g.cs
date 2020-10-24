#pragma checksum "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb321433ffd173661525a2c873be7f99ce13568d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using BlazorCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\_Imports.razor"
using BlazorCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
using BlazorCRUD.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
using BlazorCRUD.Contracts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Categories")]
    public partial class Categories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.AddMarkupContent(1, "<style>\r\n    .sort-th {\r\n        cursor: pointer;\r\n    }\r\n\r\n    .fa {\r\n        float: right;\r\n    }\r\n</style>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "width", "100%");
            __builder.AddAttribute(4, "border", "0");
            __builder.AddMarkupContent(5, "\r\n\r\n    ");
            __builder.OpenElement(6, "tr");
            __builder.AddAttribute(7, "valign", "top");
            __builder.AddMarkupContent(8, "\r\n\r\n        ");
            __builder.OpenElement(9, "td");
            __builder.AddAttribute(10, "height", "100%");
            __builder.AddAttribute(11, "width", "60%");
            __builder.AddMarkupContent(12, "\r\n\r\n            ");
            __builder.AddMarkupContent(13, "<h1>\r\n                Categories\r\n            </h1>\r\n\r\n            ");
            __builder.OpenElement(14, "div");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "class", "btn btn-primary");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                     () => AddCategory()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n            <br>\r\n\r\n");
#nullable restore
#line 39 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
             if (categoryViewModelList == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "                ");
            __builder.AddMarkupContent(23, "<p><em>Loading...</em></p> ");
#nullable restore
#line 41 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                           }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "                ");
            __builder.OpenElement(25, "table");
            __builder.AddAttribute(26, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "thead");
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "tr");
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "th");
            __builder.AddAttribute(33, "class", "sort-th");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                            () => SortTable("ID")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "\r\n                                ID\r\n                                ");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "class", "fa" + " " + (
#nullable restore
#line 49 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                  SetSortIcon("ID")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                            ");
            __builder.OpenElement(40, "th");
            __builder.AddAttribute(41, "class", "sort-th");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                            () => SortTable("Name")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(43, "\r\n                                Name\r\n                                ");
            __builder.OpenElement(44, "span");
            __builder.AddAttribute(45, "class", "fa" + " " + (
#nullable restore
#line 53 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                  SetSortIcon("Name")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                            ");
            __builder.OpenElement(48, "th");
            __builder.AddAttribute(49, "class", "sort-th");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                            () => SortTable("WeightMin")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(51, "\r\n                                WeightMin\r\n                                ");
            __builder.OpenElement(52, "span");
            __builder.AddAttribute(53, "class", "fa" + " " + (
#nullable restore
#line 57 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                  SetSortIcon("WeightMin")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                            ");
            __builder.OpenElement(56, "th");
            __builder.AddAttribute(57, "class", "sort-th");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                            () => SortTable("WeightMax")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(59, "\r\n                                WeightMax\r\n                                ");
            __builder.OpenElement(60, "span");
            __builder.AddAttribute(61, "class", "fa" + " " + (
#nullable restore
#line 61 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                  SetSortIcon("WeightMax")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                            ");
            __builder.AddMarkupContent(64, "<th>Icon</th>\r\n                            ");
            __builder.AddMarkupContent(65, "<th>Action</th>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "tbody");
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 68 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                         foreach (var categoryViewModel in categoryViewModelList)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                            ");
            __builder.OpenElement(71, "tr");
            __builder.AddMarkupContent(72, "\r\n                                ");
            __builder.OpenElement(73, "td");
            __builder.AddContent(74, 
#nullable restore
#line 71 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                     categoryViewModel.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                                ");
            __builder.OpenElement(76, "td");
            __builder.AddContent(77, 
#nullable restore
#line 72 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                     categoryViewModel.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                                ");
            __builder.OpenElement(79, "td");
            __builder.AddContent(80, 
#nullable restore
#line 73 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                     categoryViewModel.WeightMin

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                                ");
            __builder.OpenElement(82, "td");
            __builder.AddContent(83, 
#nullable restore
#line 74 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                     categoryViewModel.WeightMax

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                                ");
            __builder.OpenElement(85, "td");
            __builder.OpenElement(86, "img");
            __builder.AddAttribute(87, "src", 
#nullable restore
#line 75 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                               categoryViewModel.IconPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(88, "width", "20");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                                ");
            __builder.OpenElement(90, "td");
            __builder.AddMarkupContent(91, "\r\n                                    ");
            __builder.OpenElement(92, "a");
            __builder.AddAttribute(93, "class", "btn btn-primary");
            __builder.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                                         () => EditCategory(categoryViewModel)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(95, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 78 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                     if (categoryViewModel.WeightEditable)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "                                        ");
            __builder.OpenElement(98, "button");
            __builder.AddAttribute(99, "class", "btn btn-danger");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                                                 () => DeleteCategory(categoryViewModel.ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(101, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n");
#nullable restore
#line 81 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "                                        ");
            __builder.OpenElement(104, "button");
            __builder.AddAttribute(105, "class", "btn btn-danger");
            __builder.AddAttribute(106, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                                                 () => DeleteCategory(categoryViewModel.ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "disabled", true);
            __builder.AddContent(108, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
#nullable restore
#line 85 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n");
#nullable restore
#line 88 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(113, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n");
#nullable restore
#line 93 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(116, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n\r\n        <td width=\"10%\" height=\"100%\"></td>\r\n\r\n        ");
            __builder.OpenElement(118, "td");
            __builder.AddAttribute(119, "width", "30%");
            __builder.AddAttribute(120, "height", "100%");
            __builder.AddMarkupContent(121, "\r\n\r\n\r\n");
#nullable restore
#line 102 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
             if (selectedCategoryViewModel != null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(122, "            ");
            __builder.OpenElement(123, "div");
            __builder.AddMarkupContent(124, "\r\n                <br> <br> <br>\r\n\r\n                ");
            __builder.OpenElement(125, "h4");
            __builder.AddContent(126, 
#nullable restore
#line 107 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                     editMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(128);
            __builder.AddAttribute(129, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 109 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                  selectedCategoryViewModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(130, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 109 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                                             HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(131, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(132, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(133);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(134, "\r\n\r\n                    <br>\r\n                    ");
                __builder2.AddMarkupContent(135, "<label class=\"control-label\" for=\"Name\">Name</label>\r\n                    ");
                __builder2.OpenElement(136, "input");
                __builder2.AddAttribute(137, "class", "form-control");
                __builder2.AddAttribute(138, "id", "Name");
                __builder2.AddAttribute(139, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 114 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                                        selectedCategoryViewModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(140, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedCategoryViewModel.Name = __value, selectedCategoryViewModel.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n                    ");
                __Blazor.BlazorCRUD.Pages.Categories.TypeInference.CreateValidationMessage_0(__builder2, 142, 143, 
#nullable restore
#line 115 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                              () => selectedCategoryViewModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(144, "\r\n\r\n");
#nullable restore
#line 117 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                     if (selectedCategoryViewModel.WeightEditable)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(145, "                        <br>\r\n                        ");
                __builder2.AddMarkupContent(146, "<label class=\"control-label\" for=\"WeightMin\">WeightMin</label>\r\n                        ");
                __builder2.OpenElement(147, "input");
                __builder2.AddAttribute(148, "class", "form-control");
                __builder2.AddAttribute(149, "id", "WeightMin");
                __builder2.AddAttribute(150, "type", "number");
                __builder2.AddAttribute(151, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 121 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                                                               selectedCategoryViewModel.WeightMin

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(152, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedCategoryViewModel.WeightMin = __value, selectedCategoryViewModel.WeightMin, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(153, "\r\n                        ");
                __Blazor.BlazorCRUD.Pages.Categories.TypeInference.CreateValidationMessage_1(__builder2, 154, 155, 
#nullable restore
#line 122 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                  () => selectedCategoryViewModel.WeightMin

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(156, "\r\n");
                __builder2.AddMarkupContent(157, "                        <br>\r\n                        ");
                __builder2.AddMarkupContent(158, "<label class=\"control-label\" for=\"WeightMax\">WeightMax</label>\r\n                        ");
                __builder2.OpenElement(159, "input");
                __builder2.AddAttribute(160, "class", "form-control");
                __builder2.AddAttribute(161, "id", "WeightMax");
                __builder2.AddAttribute(162, "type", "number");
                __builder2.AddAttribute(163, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 126 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                                                               selectedCategoryViewModel.WeightMax

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(164, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedCategoryViewModel.WeightMax = __value, selectedCategoryViewModel.WeightMax, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(165, "\r\n                        ");
                __Blazor.BlazorCRUD.Pages.Categories.TypeInference.CreateValidationMessage_2(__builder2, 166, 167, 
#nullable restore
#line 127 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                  () => selectedCategoryViewModel.WeightMax

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(168, "\r\n                        ");
                __builder2.OpenElement(169, "p");
                __builder2.AddAttribute(170, "style", "color:red");
                __builder2.AddContent(171, 
#nullable restore
#line 128 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                              weightRangeValidateResult

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(172, "\r\n");
#nullable restore
#line 129 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(173, "\r\n                    <br>\r\n                    ");
                __builder2.AddMarkupContent(174, "<label class=\"control-label\">IconPath</label>\r\n                    ");
                __builder2.OpenElement(175, "select");
                __builder2.AddAttribute(176, "class", "form-control");
                __builder2.AddAttribute(177, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 133 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                         selectedCategoryViewModel.IconPath

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(178, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedCategoryViewModel.IconPath = __value, selectedCategoryViewModel.IconPath));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(179, "\r\n");
#nullable restore
#line 134 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                         foreach (var path in iconPaths)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(180, "                            ");
                __builder2.OpenElement(181, "option");
                __builder2.AddAttribute(182, "value", 
#nullable restore
#line 136 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                            path

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(183, 
#nullable restore
#line 136 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                   path

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(184, "\r\n");
#nullable restore
#line 137 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(185, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(186, "\r\n\r\n                    <br>\r\n                    ");
                __builder2.AddMarkupContent(187, "<button class=\"btn btn-primary\" type=\"submit\">Save</button>\r\n                    ");
                __builder2.OpenElement(188, "button");
                __builder2.AddAttribute(189, "class", "btn btn-danger");
                __builder2.AddAttribute(190, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 143 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
                                                             () => Cancel()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(191, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(192, "\r\n\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(193, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n");
#nullable restore
#line 148 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(195, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(197, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 158 "D:\zmq\GitHub\VehicleHub_Blazor\BlazorCRUD\Pages\Categories.razor"
       
    List<CategoryViewModel> categoryViewModelList;
    CategoryViewModel selectedCategoryViewModel;
    List<Category> categoryList;
    string[] iconPaths;
    string editMessage;
    string weightRangeValidateResult;
    
    private async Task ResetUI()
    {
        categoryList = await categoriesManager.ListAll();
        categoryViewModelList = GetCategoryViewModelList(categoryList);
        selectedCategoryViewModel = null;
        editMessage = string.Empty;
        weightRangeValidateResult = string.Empty;
    }

    protected override async Task OnInitializedAsync()
    {
        iconPaths = await categoriesManager.GetIconPaths();
        await ResetUI();
    }

    protected async Task DeleteCategory(int id)
    {
        await categoriesManager.Delete(id);
        categoryList = await categoriesManager.ListAll();
        categoryViewModelList = GetCategoryViewModelList(categoryList);

    }

    protected async Task UpdateCategory(CategoryViewModel categoryViewModel)
    {
        Category category = new Category
        {
            ID = categoryViewModel.ID,
            Name = categoryViewModel.Name,
            WeightMin = categoryViewModel.WeightMin,
            WeightMax = categoryViewModel.WeightMax,
            IconPath = categoryViewModel.IconPath,
        };
        if (category.ID > 0)
        {
            await categoriesManager.Update(category);
        }
        else
        {
            await categoriesManager.Create(category);
        }
        await ResetUI();
    }

    protected void AddCategory()
    {
        selectedCategoryViewModel = new CategoryViewModel
        {
            IconPath = iconPaths.Length > 0 ? iconPaths[0] : string.Empty,
            WeightEditable = true
        };
        editMessage = "New Category";
        weightRangeValidateResult = string.Empty;
    }

    protected void EditCategory(CategoryViewModel categoryViewModel)
    {
        selectedCategoryViewModel = categoryViewModel;
        editMessage = string.Concat("Categorgy Id = ", categoryViewModel.ID);
        weightRangeValidateResult = string.Empty;
    }

    protected async Task Cancel()
    {
        await ResetUI();
    }

    protected async void HandleValidSubmit()
    {
        if (selectedCategoryViewModel != null)
        {
            //validate WeightMin and WeightMax
            weightRangeValidateResult = await categoriesManager.ValidateCategoryWeightRange(new Category
            {
                ID = selectedCategoryViewModel.ID,
                Name = selectedCategoryViewModel.Name,
                WeightMin = selectedCategoryViewModel.WeightMin,
                WeightMax = selectedCategoryViewModel.WeightMax,
                IconPath = selectedCategoryViewModel.IconPath,
            }, categoryList);

            if (weightRangeValidateResult == string.Empty)
            {
                await UpdateCategory(selectedCategoryViewModel);
            }
        }
    }

    private bool isSortedAscending;
    private string activeSortColumn;

    private void SortTable(string columnName)
    {
        if (columnName != activeSortColumn)
        {
            categoryViewModelList = categoryViewModelList.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
            isSortedAscending = true;
            activeSortColumn = columnName;

        }
        else
        {
            if (isSortedAscending)
            {
                categoryViewModelList = categoryViewModelList.OrderByDescending(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
            }
            else
            {
                categoryViewModelList = categoryViewModelList.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
            }

            isSortedAscending = !isSortedAscending;
        }
    }

    private string SetSortIcon(string columnName)
    {
        if (activeSortColumn != columnName)
        {
            return string.Empty;
        }
        if (isSortedAscending)
        {
            return "fa-sort-up";
        }
        else
        {
            return "fa-sort-down";
        }
    }

    private List<CategoryViewModel> GetCategoryViewModelList(List<Category> CategoryList)
    {
        List<CategoryViewModel> CategoryViewModelList = new List<CategoryViewModel>();
        foreach (var category in CategoryList)
        {
            CategoryViewModelList.Add(new CategoryViewModel
            {
                ID = category.ID,
                Name = category.Name,
                WeightMin = category.WeightMin,
                WeightMax = category.WeightMax,
                IconPath = category.IconPath,

                WeightEditable = category.WeightMin == categoryList.Min(c => c.WeightMin) || category.WeightMax == categoryList.Max(c => c.WeightMax)
            });
        }
        return CategoryViewModelList;
    }

    protected class CategoryViewModel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Name max length is 250.")]
        public string Name { get; set; }

        [Required]
        [Range(0, 99999, ErrorMessage = "WeightMin must be between 0 and 99999.")]
        public int WeightMin { get; set; }

        [Required]
        [Range(0, 99999, ErrorMessage = "WeightMax must be between 0 and 99999.")]
        public int WeightMax { get; set; }
        public string IconPath { get; set; }

        public bool WeightEditable { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoriesManager categoriesManager { get; set; }
    }
}
namespace __Blazor.BlazorCRUD.Pages.Categories
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
