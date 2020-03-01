#pragma checksum "F:\Projects\personal\Budget\Sesh\Pages\ClassificationView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f2a3f06930eae73b21b1caf039c2c8e66ef8b16"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "F:\Projects\personal\Budget\Sesh\Pages\ClassificationView.razor"
using Sesh.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Projects\personal\Budget\Sesh\Pages\ClassificationView.razor"
using SeshDB.Data.Sesh;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/classificationview")]
    public partial class ClassificationView : OwningComponentBase<TransactionService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "F:\Projects\personal\Budget\Sesh\Pages\ClassificationView.razor"
       
    //AuthenticationState is available as a CascadingParameter

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    List<Classifications> classifications;

    protected override async Task OnInitializedAsync()
    {
        // Get the current user
        var user = (await authenticationStateTask).User;
        // Get the budgeted items for the current user
        // We access BudgetServices using @Service
        classifications = await @Service.GetClassificationsAsync(user.Identity.Name);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
