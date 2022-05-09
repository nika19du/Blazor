// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
