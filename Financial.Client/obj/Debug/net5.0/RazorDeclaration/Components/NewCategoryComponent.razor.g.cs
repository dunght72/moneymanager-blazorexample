// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
