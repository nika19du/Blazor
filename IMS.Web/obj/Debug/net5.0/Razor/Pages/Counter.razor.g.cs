#pragma checksum "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53ea763386b2f3084fcbf79f860b238b3e678af8"
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
#line 2 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\Pages\Counter.razor"
using IMS.Web.Controls;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n<br>\r\n\r\n");
            __builder.OpenComponent<IMS.Web.Controls.ViewInventoriesComponent>(10);
            __builder.AddAttribute(11, "OnSearchInventories", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.List<IMS.CoreBusiness.Inventory>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.List<IMS.CoreBusiness.Inventory>>(this, 
#nullable restore
#line 11 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\Pages\Counter.razor"
                                               OnSearchInventories

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Nika\source\repos\Blazor\IMS\IMS.Web\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

 // //  let's test the component 
    private void OnSearchInventories(List<IMS.CoreBusiness.Inventory> inventories)
    {
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IViewInventoriesByNameUseCase ViewInventoriesByNameUseCase { get; set; }
    }
}
#pragma warning restore 1591