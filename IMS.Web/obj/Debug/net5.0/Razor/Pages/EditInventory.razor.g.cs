#pragma checksum "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\Pages\EditInventory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8ba677d6acc15f36f46b3d060613a9a233c507a"
// <auto-generated/>
#pragma warning disable 1591
namespace IMS.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\_Imports.razor"
using IMS.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\_Imports.razor"
using IMS.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\_Imports.razor"
using IMS.UseCases;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\_Imports.razor"
using IMS.CoreBusiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\_Imports.razor"
using IMS.UseCases.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\_Imports.razor"
using IMS.Web.Controls;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editinventory/{invId:int}")]
    public partial class EditInventory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Inventory</h3>");
#nullable restore
#line 9 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\Pages\EditInventory.razor"
 if (this.inventory != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\Pages\EditInventory.razor"
                     inventory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\Pages\EditInventory.razor"
                                               OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "<label for=\"name\">Iventory Name</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "name");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\Pages\EditInventory.razor"
                                              inventory.InventoryName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => inventory.InventoryName = __value, inventory.InventoryName))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => inventory.InventoryName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label for=\"qty\">Quantity</label>\r\n            ");
                __Blazor.IMS.Web.Pages.EditInventory.TypeInference.CreateInputNumber_0(__builder2, 22, 23, "qty", 24, "form-control", 25, 
#nullable restore
#line 21 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\Pages\EditInventory.razor"
                                               inventory.Quantity

#line default
#line hidden
#nullable disable
                , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => inventory.Quantity = __value, inventory.Quantity)), 27, () => inventory.Quantity);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "<label for=\"price\">Iventory Name</label>\r\n            ");
                __Blazor.IMS.Web.Pages.EditInventory.TypeInference.CreateInputNumber_1(__builder2, 32, 33, "price", 34, "form-control", 35, 
#nullable restore
#line 25 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\Pages\EditInventory.razor"
                                                 inventory.Price

#line default
#line hidden
#nullable disable
                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => inventory.Price = __value, inventory.Price)), 37, () => inventory.Price);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\r\n        ");
                __builder2.AddMarkupContent(39, "<button type=\"submit\" class=\"btn btn-primary\">Save</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 30 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\Pages\EditInventory.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\Pages\EditInventory.razor"
       
    [Parameter]
    public int InvId { get; set; }
    public Inventory? inventory { get; set; }


    protected override async Task OnInitializedAsync()//public   async Task OnInitializedAsync()
    {
        this.inventory = await ViewInventoryByIdUseCase.ExecuteAsync(InvId);
    }

    public async Task OnValidSubmit()
    {
        if (this.inventory != null)
        {
            await EditInventoryUseCase.ExecuteAsync(this.inventory);
            NavigationManager.NavigateTo("/inventories");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEditInventoryUseCase EditInventoryUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IViewInventoryByIdUseCase ViewInventoryByIdUseCase { get; set; }
    }
}
namespace __Blazor.IMS.Web.Pages.EditInventory
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591