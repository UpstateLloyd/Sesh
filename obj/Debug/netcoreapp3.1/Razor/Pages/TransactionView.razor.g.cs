#pragma checksum "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4f4535eb92f768492940991b2a3aa47b324fad2"
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
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#nullable restore
#line 18 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
 if (transactions == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 21 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
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
            __builder.AddMarkupContent(8, @"<thead>
            <tr>
                <th>Account</th>
                <th>Transaction Date</th>
                <th>Payee</th>
                <th>Item</th>
                <th>Memo</th>
                <th>Debit Amount</th>
                <th>Credit Amount</th>
                <th></th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 38 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
             foreach (var transaction in transactions)
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
#line 41 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                         accountDict.GetValueOrDefault(transaction.AccountId)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "                    \r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 42 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                         transaction.TransactionDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 43 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                         payeeDict.GetValueOrDefault(transaction.PayeeId)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 44 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                         catDict.GetValueOrDefault(transaction.ItemId)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 45 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                         transaction.Memo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 46 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                         transaction.DebitAmount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 47 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                         transaction.CreditAmount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-primary");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                                                  (() => EditTransaction(transaction))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 52 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 55 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "\r\n");
            __builder.OpenElement(48, "p");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "class", "btn btn-primary");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                             AddNewTransaction

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, "Add New Transaction");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n");
#nullable restore
#line 59 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
 if (ShowPopup)

{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(54, "    \r\n    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "modal");
            __builder.AddAttribute(57, "tabindex", "-1");
            __builder.AddAttribute(58, "style", "display:block");
            __builder.AddAttribute(59, "role", "dialog");
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "modal-dialog");
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "modal-content");
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "modal-header");
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.AddMarkupContent(70, "<h3 class=\"modal-title\">Edit Forecast</h3>\r\n                    \r\n                    ");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "type", "button");
            __builder.AddAttribute(73, "class", "close");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                      ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(75, "\r\n                        ");
            __builder.AddMarkupContent(76, "<span aria-hidden=\"true\">X</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                \r\n                ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "modal-body");
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.OpenElement(82, "select");
            __builder.AddAttribute(83, "class", "form-control");
            __builder.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                                              objTransaction.AccountId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objTransaction.AccountId = __value, objTransaction.AccountId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 77 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                         foreach (KeyValuePair<int, string> entry in accountDict)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "                            ");
            __builder.OpenElement(88, "option");
            __builder.AddAttribute(89, "value", 
#nullable restore
#line 79 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                            entry.Key

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(90, 
#nullable restore
#line 79 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                                        entry.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 80 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"

                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                    ");
            __builder.OpenElement(94, "input");
            __builder.AddAttribute(95, "class", "form-control");
            __builder.AddAttribute(96, "type", "text");
            __builder.AddAttribute(97, "placeholder", 
#nullable restore
#line 83 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                                                          objTransaction.TransactionDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(98, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                                                                                                                     TransactionDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TransactionDate = __value, TransactionDate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "                  \r\n                    ");
            __builder.OpenElement(101, "select");
            __builder.AddAttribute(102, "class", "form-control");
            __builder.AddAttribute(103, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 84 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                                              objTransaction.PayeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objTransaction.PayeeId = __value, objTransaction.PayeeId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(105, "\r\n");
#nullable restore
#line 85 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                         foreach (KeyValuePair<int, string> entry in payeeDict)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(106, "                            ");
            __builder.OpenElement(107, "option");
            __builder.AddAttribute(108, "value", 
#nullable restore
#line 87 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                            entry.Key

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(109, 
#nullable restore
#line 87 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                                        entry.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n");
#nullable restore
#line 88 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(111, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                    ");
            __builder.OpenElement(113, "select");
            __builder.AddAttribute(114, "class", "form-control");
            __builder.AddAttribute(115, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 90 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                                              objTransaction.ItemId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(116, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objTransaction.ItemId = __value, objTransaction.ItemId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(117, "\r\n");
#nullable restore
#line 91 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                         foreach (KeyValuePair<int, string> entry in catDict)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(118, "                            ");
            __builder.OpenElement(119, "option");
            __builder.AddAttribute(120, "value", 
#nullable restore
#line 93 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                            entry.Key

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(121, 
#nullable restore
#line 93 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                                        entry.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
#nullable restore
#line 94 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(123, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                    ");
            __builder.OpenElement(125, "input");
            __builder.AddAttribute(126, "class", "form-control");
            __builder.AddAttribute(127, "type", "text");
            __builder.AddAttribute(128, "placeholder", "Memo");
            __builder.AddAttribute(129, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 98 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                  objTransaction.Memo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(130, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objTransaction.Memo = __value, objTransaction.Memo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                    ");
            __builder.OpenElement(132, "input");
            __builder.AddAttribute(133, "class", "form-control");
            __builder.AddAttribute(134, "type", "text");
            __builder.AddAttribute(135, "placeholder", "Debit Amount");
            __builder.AddAttribute(136, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 101 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                  objTransaction.DebitAmount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(137, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objTransaction.DebitAmount = __value, objTransaction.DebitAmount));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                    ");
            __builder.OpenElement(139, "input");
            __builder.AddAttribute(140, "class", "form-control");
            __builder.AddAttribute(141, "type", "text");
            __builder.AddAttribute(142, "placeholder", "Credit Amount");
            __builder.AddAttribute(143, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 104 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                  objTransaction.CreditAmount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(144, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objTransaction.CreditAmount = __value, objTransaction.CreditAmount));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                    <br>\r\n                    \r\n                    ");
            __builder.OpenElement(146, "button");
            __builder.AddAttribute(147, "class", "btn btn-primary");
            __builder.AddAttribute(148, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                      SaveTransaction

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(149, "\r\n                        Save\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                    \r\n");
#nullable restore
#line 112 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                     if  (objTransaction.TransactionId > 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(151, "                        \r\n                        ");
            __builder.OpenElement(152, "button");
            __builder.AddAttribute(153, "class", "btn btn-primary");
            __builder.AddAttribute(154, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 115 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                                                                  DeleteTransaction

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(155, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n");
#nullable restore
#line 116 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(157, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n");
#nullable restore
#line 121 "F:\Projects\personal\Budget\Sesh\Pages\TransactionView.razor"

}

#line default
#line hidden
#nullable disable
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
