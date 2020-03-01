#pragma checksum "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4f4535eb92f768492940991b2a3aa47b324fad2"
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
#line 3 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
using Sesh.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
using SeshDB.Data.Sesh;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transactionview")]
    public partial class TransactionView : OwningComponentBase<TransactionService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 125 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
       

    //AuthenticationState is available as a CascadingParameter
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    [Parameter]
    public string TransactionDate { get; set; } = "";
    List<Transactions> transactions;
    Dictionary<int, string> accountDict;
    Dictionary<int, string> payeeDict;
    Dictionary<int, string> catDict;

    protected override async Task OnInitializedAsync()
    {
        // Get the current user
        var user = (await authenticationStateTask).User;
        // Get the Transactions for the current user
        transactions = await @Service.GetTransactionsAsync(user.Identity.Name);
        // Get a Dictionary of User Accounts
        accountDict = await @Service.GetAccountKeyValuesAsync(user.Identity.Name);
        // Get a Dictionary of Payees
        payeeDict = await @Service.GetPayeeKeyValuesAsync(user.Identity.Name);
        // Get a Dictionary of Categories
        catDict = await @Service.GetCatKeyValuesAsync(user.Identity.Name);
    }

    Transactions objTransaction = new Transactions();
    bool ShowPopup = false;
    void ClosePopup()
    {
        ShowPopup = false;
    }
    void AddNewTransaction()
    {
        objTransaction = new Transactions();
        // Set Id to 0 so we know it is a new record
        objTransaction.TransactionId = 0;
        ShowPopup = true;
    }
    async Task SaveTransaction()
    {
        ShowPopup = false;
        var user = (await authenticationStateTask).User;
        DateTime properDate = new DateTime();
        // New transaction will have Id set to 0
        if (DateTime.TryParse(TransactionDate, out properDate))
        {

            objTransaction.TransactionDate = properDate;

            if (objTransaction.TransactionId == 0)
            {
                //create new transaction
                Transactions objNewTransaction = new Transactions();
                objNewTransaction.AccountId = objTransaction.AccountId;
                objNewTransaction.TransactionDate = objTransaction.TransactionDate;
                objNewTransaction.PayeeId = objTransaction.PayeeId;
                objNewTransaction.ItemId = objTransaction.ItemId;
                objNewTransaction.Memo = objTransaction.Memo;
                objNewTransaction.DebitAmount = objTransaction.DebitAmount;
                objNewTransaction.CreditAmount = objTransaction.CreditAmount;
                objNewTransaction.UserName = user.Identity.Name;

                var result = @Service.CreateTransactionAsync(objNewTransaction);
            }
            else
            {
                var result = @Service.UpdateTransactionAsync(objTransaction);
            }
            transactions = await @Service.GetTransactionsAsync(user.Identity.Name);
        }
    }

    void EditTransaction(Transactions transaction)
    {
        // set the selected forecast as the current forecast
        objTransaction = transaction;
        ShowPopup = true;
    }

    async Task DeleteTransaction()
    {
        //Close the popup
        ShowPopup = false;
        // Get the current user
        var user = (await authenticationStateTask).User;
        // Delete the transaction
        var result = @Service.DeleteTransactionAsync(objTransaction);
        // Refresh transactions
        await @Service.GetTransactionsAsync(user.Identity.Name); 
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
