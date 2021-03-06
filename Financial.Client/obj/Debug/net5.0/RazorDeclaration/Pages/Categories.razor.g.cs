// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Financial.Client.Pages
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
#line 2 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Pages/Categories.razor"
using Financial.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Pages/Categories.razor"
using Financial.Shared.Domains;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Categories")]
    public partial class Categories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "/Volumes/Data/Code/DotNetCore/BlazorTutorial/MoneyManager/Financial.Client/Pages/Categories.razor"
       
    private List<Category> categoriesList;
    public bool DeleteDialogOpen { get; set; }
    private Category categoryToDelete;

    protected async override Task OnInitializedAsync()
    {
        await LoadData();
    }

    protected async Task LoadData()
    {
        categoriesList = await Http.GetFromJsonAsync<List<Category>>("api/transaction/GetCategories");
        StateHasChanged();
    }

    private async Task OnDeleteDialogClose(bool accepted)
    {
        if (accepted)
        {
            await Http.DeleteAsync($"api/transaction/RemoveCategory/{categoryToDelete.Id}");
            await LoadData();
            categoryToDelete = null;
        }
        DeleteDialogOpen = false;
    }

    private void OpenDeleteDialog(Category category)
    {
        categoryToDelete = category;
        DeleteDialogOpen = true;
        StateHasChanged();
    }

    protected async void Refresh()
    {
        await LoadData();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
