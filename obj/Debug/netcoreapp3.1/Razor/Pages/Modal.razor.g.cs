#pragma checksum "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ad09ed0ee703b25ddd0f7f977baef06e314610"
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
#line 1 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
using Sesh.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
using SeshDB.Data.Sesh;

#line default
#line hidden
#nullable disable
    public partial class Modal : OwningComponentBase<TransactionService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                                             AddNewTransaction

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Add New Transaction");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
#nullable restore
#line 10 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
 if (ShowPopup)

{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "    \r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal");
            __builder.AddAttribute(9, "tabindex", "-1");
            __builder.AddAttribute(10, "style", "display:block");
            __builder.AddAttribute(11, "role", "dialog");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-dialog");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "modal-content");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "modal-header");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.AddMarkupContent(22, "<h3 class=\"modal-title\">Edit Forecast</h3>\r\n                    \r\n                    ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "class", "close");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                                      ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.AddMarkupContent(28, "<span aria-hidden=\"true\">X</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                \r\n                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "modal-body");
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "select");
            __builder.AddAttribute(35, "class", "form-control");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                                                              objTransaction.AccountId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objTransaction.AccountId = __value, objTransaction.AccountId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 28 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                         foreach (KeyValuePair<int, string> entry in accountDict)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "                            ");
            __builder.OpenElement(40, "option");
            __builder.AddAttribute(41, "value", 
#nullable restore
#line 30 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                                            entry.Key

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(42, 
#nullable restore
#line 30 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                                                        entry.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 31 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"

                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "select");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                                                              objTransaction.PayeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objTransaction.PayeeId = __value, objTransaction.PayeeId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 35 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                         foreach (KeyValuePair<int, string> entry in payeeDict)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                            ");
            __builder.OpenElement(52, "option");
            __builder.AddAttribute(53, "value", 
#nullable restore
#line 37 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                                            entry.Key

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(54, 
#nullable restore
#line 37 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                                                        entry.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 38 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "select");
            __builder.AddAttribute(59, "class", "form-control");
            __builder.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                                                              objTransaction.ItemId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objTransaction.ItemId = __value, objTransaction.ItemId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 41 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                         foreach (KeyValuePair<int, string> entry in catDict)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "                            ");
            __builder.OpenElement(64, "option");
            __builder.AddAttribute(65, "value", 
#nullable restore
#line 43 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                                            entry.Key

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(66, 
#nullable restore
#line 43 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                                                        entry.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 44 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "class", "form-control");
            __builder.AddAttribute(72, "type", "text");
            __builder.AddAttribute(73, "placeholder", "Memo");
            __builder.AddAttribute(74, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                                  objTransaction.Memo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objTransaction.Memo = __value, objTransaction.Memo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "input");
            __builder.AddAttribute(78, "class", "form-control");
            __builder.AddAttribute(79, "type", "text");
            __builder.AddAttribute(80, "placeholder", "Debit Amount");
            __builder.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                                  objTransaction.DebitAmount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objTransaction.DebitAmount = __value, objTransaction.DebitAmount));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.OpenElement(84, "input");
            __builder.AddAttribute(85, "class", "form-control");
            __builder.AddAttribute(86, "type", "text");
            __builder.AddAttribute(87, "placeholder", "Credit Amount");
            __builder.AddAttribute(88, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                                  objTransaction.CreditAmount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objTransaction.CreditAmount = __value, objTransaction.CreditAmount));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                    <br>\r\n                    \r\n                    ");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "class", "btn btn-primary");
            __builder.AddAttribute(93, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                                          SaveTransaction

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(94, "\r\n                        Save\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 65 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
       
    // TODO See if context can be passed when this component is called
    [Parameter]
    public EventCallback<string> ComponentDataUpdated { get; set; }
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    Dictionary<int, string> accountDict;
    Dictionary<int, string> payeeDict;
    Dictionary<int, string> catDict;

    protected override async Task OnInitializedAsync()
    {
        // Get the current user
        var user = (await authenticationStateTask).User;
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
        // New transaction will have Id set to 0
        if (objTransaction.TransactionId == 0)
        {
            //create new transaction
            Transactions objNewTransaction = new Transactions();
            objNewTransaction.AccountId = objTransaction.AccountId;
            objNewTransaction.TransactionDate = System.DateTime.Now;
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
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "F:\Projects\personal\Budget\Sesh\Pages\Modal.razor"
                                                      
        }
        InvokeCallBack();
    }

    async Task InvokeCallBack()
    {
        await ComponentDataUpdated.InvokeAsync("");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
