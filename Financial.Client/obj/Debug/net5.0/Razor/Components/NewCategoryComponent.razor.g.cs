#pragma checksum "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0721bd39280ce640f6d17d5733f6c914af812684"
// <auto-generated/>
#pragma warning disable 1591
namespace Financial.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 1 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
using Financial.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
using Financial.Shared.Domains;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
using Financial.Shared;

#line default
#line hidden
#nullable disable
    public partial class NewCategoryComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudCard>(0);
            __builder.AddAttribute(1, "Outlined", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCardHeader>(3);
                __builder2.AddAttribute(4, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(5);
                    __builder3.AddAttribute(6, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 10 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(8, "Add New Category");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n\n    \n        ");
                __builder2.OpenComponent<MudBlazor.MudCardContent>(10);
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
                    __builder3.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                             Category

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                                       HandleValidSubmit

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(17, "\n                ");
                        __builder4.OpenComponent<MudBlazor.MudCard>(18);
                        __builder4.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudCardContent>(20);
                            __builder5.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(22);
                                __builder6.AddAttribute(23, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(24, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                         12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.Financial.Client.Components.NewCategoryComponent.TypeInference.CreateMudTextField_0(__builder7, 26, 27, "Subject", 28, 
#nullable restore
#line 22 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                                                                                     InputType.Text

#line default
#line hidden
#nullable disable
                                    , 29, 
#nullable restore
#line 22 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                                                                                                            () => Category.CategoryName

#line default
#line hidden
#nullable disable
                                    , 30, 
#nullable restore
#line 22 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                                                                                                                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 31, 
#nullable restore
#line 22 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                                                                                                                                                                                Adornment.End

#line default
#line hidden
#nullable disable
                                    , 32, 
#nullable restore
#line 22 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                                                                                                                                                                                                               Icons.Material.Filled.Subject

#line default
#line hidden
#nullable disable
                                    , 33, 
#nullable restore
#line 22 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                                                                                                                                                                                                                                                              Color.Warning

#line default
#line hidden
#nullable disable
                                    , 34, 
#nullable restore
#line 22 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                                   Category.CategoryName

#line default
#line hidden
#nullable disable
                                    , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.CategoryName = __value, Category.CategoryName)));
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(36, "\n                    \n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(37);
                                __builder6.AddAttribute(38, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(39, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                         12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(40, "Class", "mt-5");
                                __builder6.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.Financial.Client.Components.NewCategoryComponent.TypeInference.CreateInputSelect_1(__builder7, 42, 43, "form-control mt-3", 44, 
#nullable restore
#line 26 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                                                             Category.CategoryType

#line default
#line hidden
#nullable disable
                                    , 45, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.CategoryType = __value, Category.CategoryType)), 46, () => Category.CategoryType, 47, (__builder8) => {
#nullable restore
#line 27 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                             foreach (var item in Enum.GetValues(typeof(TransactionType)))
                            {

#line default
#line hidden
#nullable disable
                                        __builder8.OpenElement(48, "option");
                                        __builder8.AddAttribute(49, "value", 
#nullable restore
#line 29 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                                item

#line default
#line hidden
#nullable disable
                                        );
                                        __builder8.AddContent(50, 
#nullable restore
#line 29 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                                       item

#line default
#line hidden
#nullable disable
                                        );
                                        __builder8.CloseElement();
#nullable restore
#line 30 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                            }

#line default
#line hidden
#nullable disable
                                    }
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(51, "\n                ");
                            __builder5.OpenComponent<MudBlazor.MudCardActions>(52);
                            __builder5.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudButton>(54);
                                __builder6.AddAttribute(55, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 35 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                           ButtonType.Submit

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(56, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 35 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                                                       Variant.Filled

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(57, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 35 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                                                                              Color.Success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(58, "EndIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
                                                                                                                       Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(60, "Add New");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Components/NewCategoryComponent.razor"
       

    public Category Category = new Category();

    [Parameter]
    public EventCallback OnSubmitAddNew { get; set; }

    

    protected async override Task OnInitializedAsync()
    {
        
    }

    private async Task HandleValidSubmit()
    {
        var responseMessage = await Http.PostAsJsonAsync("api/transaction/AddCategory", Category);
        if (responseMessage.IsSuccessStatusCode)
        {
            toastService.ShowSuccess("Add category succesfully!", "Success");
        }
        await OnSubmitAddNew.InvokeAsync(Category);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Financial.Client.Components.NewCategoryComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.InputType __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, global::MudBlazor.Variant __arg3, int __seq4, global::MudBlazor.Adornment __arg4, int __seq5, global::System.String __arg5, int __seq6, global::MudBlazor.Color __arg6, int __seq7, T __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg8)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "InputType", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Variant", __arg3);
        __builder.AddAttribute(__seq4, "Adornment", __arg4);
        __builder.AddAttribute(__seq5, "AdornmentIcon", __arg5);
        __builder.AddAttribute(__seq6, "AdornmentColor", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "ValueChanged", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
