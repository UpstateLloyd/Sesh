#pragma checksum "F:\Projects\personal\Budget\Sesh\Pages\BudgetView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d3f11900db33588ea45fd3a9935ea30ed001ca5"
// <auto-generated/>
#pragma warning disable 1591
namespace Sesh.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Projects\personal\Budget\Sesh\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\personal\Budget\Sesh\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projects\personal\Budget\Sesh\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Projects\personal\Budget\Sesh\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Projects\personal\Budget\Sesh\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Projects\personal\Budget\Sesh\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Projects\personal\Budget\Sesh\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Projects\personal\Budget\Sesh\_Imports.razor"
using Sesh;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Projects\personal\Budget\Sesh\_Imports.razor"
using Sesh.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Projects\personal\Budget\Sesh\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projects\personal\Budget\Sesh\Pages\BudgetView.razor"
using Sesh.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Projects\personal\Budget\Sesh\Pages\BudgetView.razor"
using SeshDB.Data.Sesh;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/budgetview")]
    public partial class BudgetView : OwningComponentBase<TransactionService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#nullable restore
#line 19 "F:\Projects\personal\Budget\Sesh\Pages\BudgetView.razor"
 if (budgetedItems == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 22 "F:\Projects\personal\Budget\Sesh\Pages\BudgetView.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Amount</th>\r\n                <th>Name</th>\r\n                <th>CurrentBalance</th>\r\n                <th>Class Id</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 35 "F:\Projects\personal\Budget\Sesh\Pages\BudgetView.razor"
             foreach (var budgetedItem in budgetedItems)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 38 "F:\Projects\personal\Budget\Sesh\Pages\BudgetView.razor"
                         budgetedItem.BudgetedAmount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 39 "F:\Projects\personal\Budget\Sesh\Pages\BudgetView.razor"
                         budgetedItem.BudgetItemName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 40 "F:\Projects\personal\Budget\Sesh\Pages\BudgetView.razor"
                         budgetedItem.CurrentBalance

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 41 "F:\Projects\personal\Budget\Sesh\Pages\BudgetView.razor"
                         budgetedItem.ClassId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 43 "F:\Projects\personal\Budget\Sesh\Pages\BudgetView.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 46 "F:\Projects\personal\Budget\Sesh\Pages\BudgetView.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "F:\Projects\personal\Budget\Sesh\Pages\BudgetView.razor"
       
    //AuthenticationState is available as a CascadingParameter

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    List<Categories> budgetedItems;

    protected override async Task OnInitializedAsync()
    {
        // Get the current user
        var user = (await authenticationStateTask).User;
        // Get the budgeted items for the current user
        // We access BudgetServices using @Service
        budgetedItems = await @Service.GetCategoriesAsync(user.Identity.Name);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
