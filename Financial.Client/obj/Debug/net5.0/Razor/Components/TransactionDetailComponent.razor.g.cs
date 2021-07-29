#pragma checksum "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b98a2db4a3d4a116987395a4a64522644a3e45c"
// <auto-generated/>
#pragma warning disable 1591
namespace Financial.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/_Imports.razor"
using Financial.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/_Imports.razor"
using Financial.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/_Imports.razor"
using Financial.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
using Financial.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
using Financial.Client.Pages;

#line default
#line hidden
#nullable disable
    public partial class TransactionDetailComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
 if (categoryModels != null) {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
                     TransactionUpdateModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
                                                             HandleValidUpdate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "mb-3");
                __builder2.AddMarkupContent(8, "<label for=\"date\" class=\"form-label\">Date</label>\n            ");
                __Blazor.Financial.Client.Components.TransactionDetailComponent.TypeInference.CreateInputDate_0(__builder2, 9, 10, "date", 11, "form-control", 12, "date", 13, 
#nullable restore
#line 11 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
                                                                     TransactionUpdateModel.Date

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => TransactionUpdateModel.Date = __value, TransactionUpdateModel.Date)), 15, () => TransactionUpdateModel.Date);
                __builder2.AddMarkupContent(16, "\n            ");
                __Blazor.Financial.Client.Components.TransactionDetailComponent.TypeInference.CreateValidationMessage_1(__builder2, 17, 18, 
#nullable restore
#line 12 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
                                    () => TransactionUpdateModel.Date

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "mb-3");
                __builder2.AddMarkupContent(22, "<label for=\"subject\" class=\"form-label\">Subject</label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "type", "text");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "id", "subject");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
                                                                     TransactionUpdateModel.Subject

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => TransactionUpdateModel.Subject = __value, TransactionUpdateModel.Subject))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => TransactionUpdateModel.Subject));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\n            ");
                __Blazor.Financial.Client.Components.TransactionDetailComponent.TypeInference.CreateValidationMessage_2(__builder2, 31, 32, 
#nullable restore
#line 17 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
                                    () => TransactionUpdateModel.Subject

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\n        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "mb-3");
                __builder2.AddMarkupContent(36, "<label for=\"amount\" class=\"form-label\">Amount</label>\n            ");
                __Blazor.Financial.Client.Components.TransactionDetailComponent.TypeInference.CreateInputNumber_3(__builder2, 37, 38, "number", 39, "form-control", 40, "amount", 41, 
#nullable restore
#line 21 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
                                                                         TransactionUpdateModel.Amount

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => TransactionUpdateModel.Amount = __value, TransactionUpdateModel.Amount)), 43, () => TransactionUpdateModel.Amount);
                __builder2.AddMarkupContent(44, "\n            ");
                __Blazor.Financial.Client.Components.TransactionDetailComponent.TypeInference.CreateValidationMessage_4(__builder2, 45, 46, 
#nullable restore
#line 22 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
                                    () => TransactionUpdateModel.Amount

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\n        ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "mb-3");
                __builder2.AddMarkupContent(50, "<label class=\"form-label\" for=\"category\">Category</label>\n            ");
                __Blazor.Financial.Client.Components.TransactionDetailComponent.TypeInference.CreateInputSelect_5(__builder2, 51, 52, "form-control", 53, "category", 54, 
#nullable restore
#line 26 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
                                                                         TransactionUpdateModel.CategoryId

#line default
#line hidden
#nullable disable
                , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => TransactionUpdateModel.CategoryId = __value, TransactionUpdateModel.CategoryId)), 56, () => TransactionUpdateModel.CategoryId, 57, (__builder3) => {
#nullable restore
#line 27 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
                 foreach (var category in categoryModels)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(58, "option");
                    __builder3.AddAttribute(59, "value", 
#nullable restore
#line 29 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
                                    category.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(60, 
#nullable restore
#line 29 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
                                                  category.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 30 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
                }

#line default
#line hidden
#nullable disable
                    __Blazor.Financial.Client.Components.TransactionDetailComponent.TypeInference.CreateValidationMessage_6(__builder3, 61, 62, 
#nullable restore
#line 31 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
                                        () => TransactionUpdateModel.CategoryId

#line default
#line hidden
#nullable disable
                    );
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\n        ");
                __builder2.AddMarkupContent(64, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\n    ");
                __builder2.OpenElement(65, "button");
                __builder2.AddAttribute(66, "type", "button");
                __builder2.AddAttribute(67, "class", "btn btn-warning");
                __builder2.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
                                                            () => NavigationManager.NavigateTo("/transactions")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(69, "Back");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 38 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/TransactionDetailComponent.razor"
       
    [Parameter]
    public TransactionUpdateModel TransactionUpdateModel { get; set; }

    private TransactionUpdateModel TransactionToUpdate;
    private List<CategoryModel> categoryModels;
    public EventCallback OnEditSubmit { get; set; }
    protected async override Task OnInitializedAsync()
    {
        categoryModels = await Http.GetFromJsonAsync<List<CategoryModel>>("api/transaction/getcategories");
    }

    private async Task HandleValidUpdate()
    {
        TransactionToUpdate = TransactionUpdateModel;
        var response = await Http.PutAsJsonAsync($"api/transaction/updatetransaction/?id={TransactionToUpdate.Id}", TransactionToUpdate);
        if (response.IsSuccessStatusCode)
        {
            ToastService.ShowSuccess("Update successfully!","Success");
            TransactionToUpdate = null;
        } else
        {
            ToastService.ShowError("Something wrong! Please try again","Error");
        }

        await OnEditSubmit.InvokeAsync(TransactionUpdateModel);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Financial.Client.Components.TransactionDetailComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "type", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
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
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "type", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591