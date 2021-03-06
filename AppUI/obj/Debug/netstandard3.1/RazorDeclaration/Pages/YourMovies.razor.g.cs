#pragma checksum "c:\git\AP98992\final_project\MovieSharing\AppUI\Pages\YourMovies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46cabacf49abed57e2eae9e6ff58c80197eb519e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AppUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "c:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using AppUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\git\AP98992\final_project\MovieSharing\AppUI\Pages\YourMovies.razor"
using SharedData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\git\AP98992\final_project\MovieSharing\AppUI\Pages\YourMovies.razor"
using Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\git\AP98992\final_project\MovieSharing\AppUI\Pages\YourMovies.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\git\AP98992\final_project\MovieSharing\AppUI\Pages\YourMovies.razor"
           [Microsoft.AspNetCore.Authorization.Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/you/movies")]
    public partial class YourMovies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 143 "c:\git\AP98992\final_project\MovieSharing\AppUI\Pages\YourMovies.razor"
      
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask {get;set;}
    private bool ShowPopup = false;
    private MovieDataModel MovieData {get;set;}
    private string PreviousTitle = "";
    private string PreviousImage = "";
    private bool ShowErrors;
    private string Error = "";
    private MovieDataModel[] AllYourMovies {get;set;} = {};
    protected override async Task OnInitializedAsync()
    {
        var auth = await authenticationStateTask;
        var username = auth.User.Identity.Name;
        movie = new Movie(Http);
        AllYourMovies = await movie.ShowingMovies(username);
        theFile = new Files(Http , fileReader);
    }

    private void ClosePopup()
    {
        ShowPopup = false;
        NavigationManager.NavigateTo("/you/movies",true);
    }

    private void OnDelete(string title)
    {
        movie.DeleteMovie(title);
        NavigationManager.NavigateTo("/you/movies",true);
    }
    private void OnEdit(MovieDataModel theMovie)
    {
        PreviousTitle = theMovie.Title;
        PreviousImage = theMovie.ImageUrl;
        MovieData = theMovie;
        ShowPopup = true;
    }

    private async void CheckSubmit() 
    {
        var response = await theFile.UploadFileAsync();
        if(response == null)
        {
            MovieData.ImageUrl = PreviousImage;
            SaveEdited();
        }
        else if(response.IsSuccessStatusCode)
        {
            string name = await response.Content.ReadAsStringAsync();
            MovieData.ImageUrl = "/covers/" + name;
            SaveEdited();
        }
        else
        {
            Error = await response.Content.ReadAsStringAsync();
            ShowErrors = true;
        }
    }

    private async void SaveEdited()
    {
        ShowPopup = false;
        await movie.EditMovie(PreviousTitle,MovieData);
        NavigationManager.NavigateTo("/you/movies" , true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Files theFile { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Movie movie { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Tewr.Blazor.FileReader.IFileReaderService fileReader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
