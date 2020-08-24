#pragma checksum "C:\git\AP98992\final_project\MovieSharing\AppUI\Pages\LogIn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77c8913786f185f6d2c8f0ed1fbeaa894575877a"
// <auto-generated/>
#pragma warning disable 1591
namespace AppUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using AppUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\git\AP98992\final_project\MovieSharing\AppUI\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\AP98992\final_project\MovieSharing\AppUI\Pages\LogIn.razor"
using SharedData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class LogIn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "topnav");
            __builder.AddAttribute(2, "id", "myTopnav");
            __builder.AddMarkupContent(3, "\r\n  ");
            __builder.AddMarkupContent(4, "<a href=\"/\">Home</a>\r\n  ");
            __builder.AddMarkupContent(5, "<a href=\"/movies\">Movies</a>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.AddMarkupContent(9, "<a href=\"/you/movies\">Your Movies</a>\r\n        ");
                __builder2.AddMarkupContent(10, "<a href=\"/you/add\">Add Movie</a>\r\n        ");
                __builder2.AddMarkupContent(11, "<a href=\"/logout\">Log out</a>\r\n        ");
            }
            ));
            __builder.AddAttribute(12, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.AddMarkupContent(14, "<a href=\"/register\">Sign up</a>\r\n        ");
                __builder2.AddMarkupContent(15, "<a href=\"/login\" class=\"active\">Log in</a>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n\r\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "container");
            __builder.AddAttribute(20, "style", "width: 35%; padding:10px;");
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card");
            __builder.AddMarkupContent(24, "\r\n      ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "card-body");
            __builder.AddAttribute(27, "style", "margin: 20px 20px;");
            __builder.AddMarkupContent(28, "\r\n          ");
            __builder.AddMarkupContent(29, "<h5 class=\"card-title\" style=\"margin-bottom: 20px;\">Please enter username and password:</h5>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(30);
            __builder.AddAttribute(31, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 27 "C:\git\AP98992\final_project\MovieSharing\AppUI\Pages\LogIn.razor"
                             loginModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 27 "C:\git\AP98992\final_project\MovieSharing\AppUI\Pages\LogIn.razor"
                                                        HandleLogin

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(35);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(37);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n");
#nullable restore
#line 30 "C:\git\AP98992\final_project\MovieSharing\AppUI\Pages\LogIn.razor"
                 if (ShowErrors)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(39, "                    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "alert alert-danger");
                __builder2.AddAttribute(42, "role", "alert");
                __builder2.AddMarkupContent(43, "\r\n                        ");
                __builder2.OpenElement(44, "p");
                __builder2.AddAttribute(45, "style", "margin-bottom: 1px;");
                __builder2.AddContent(46, 
#nullable restore
#line 33 "C:\git\AP98992\final_project\MovieSharing\AppUI\Pages\LogIn.razor"
                                                        Error

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n");
#nullable restore
#line 35 "C:\git\AP98992\final_project\MovieSharing\AppUI\Pages\LogIn.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(49, "                ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group row");
                __builder2.AddMarkupContent(52, "\r\n                    ");
                __builder2.AddMarkupContent(53, "<label for=\"username\" class=\"col-25\">Username</label>\r\n                    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "col-75");
                __builder2.AddMarkupContent(56, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(57);
                __builder2.AddAttribute(58, "Id", "text");
                __builder2.AddAttribute(59, "Class", "form-control");
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\git\AP98992\final_project\MovieSharing\AppUI\Pages\LogIn.razor"
                                                                               loginModel.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginModel.Username = __value, loginModel.Username))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginModel.Username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __Blazor.AppUI.Pages.LogIn.TypeInference.CreateValidationMessage_0(__builder2, 64, 65, 
#nullable restore
#line 40 "C:\git\AP98992\final_project\MovieSharing\AppUI\Pages\LogIn.razor"
                                                  () => loginModel.Username

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(66, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group row");
                __builder2.AddMarkupContent(71, "\r\n                    ");
                __builder2.AddMarkupContent(72, "<label for=\"password\" class=\"col-25\">Password</label>\r\n                    ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "col-75");
                __builder2.AddMarkupContent(75, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(76);
                __builder2.AddAttribute(77, "Id", "password");
                __builder2.AddAttribute(78, "type", "password");
                __builder2.AddAttribute(79, "Class", "form-control");
                __builder2.AddAttribute(80, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\git\AP98992\final_project\MovieSharing\AppUI\Pages\LogIn.razor"
                                                                                                   loginModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginModel.Password = __value, loginModel.Password))));
                __builder2.AddAttribute(82, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginModel.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n                        ");
                __Blazor.AppUI.Pages.LogIn.TypeInference.CreateValidationMessage_1(__builder2, 84, 85, 
#nullable restore
#line 47 "C:\git\AP98992\final_project\MovieSharing\AppUI\Pages\LogIn.razor"
                                                  () => loginModel.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(86, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                ");
                __builder2.AddMarkupContent(89, "<button type=\"submit\" class=\"btn btn-primary\" style=\"float: right;\"> Submit </button>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(90, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\git\AP98992\final_project\MovieSharing\AppUI\Pages\LogIn.razor"
       

    private LoginModel loginModel = new LoginModel();
    private bool ShowErrors;
    private string Error = "";

    private async Task HandleLogin()
    {
        ShowErrors = false;

        var result = await AuthService.Login(loginModel);

        if (result.Successful)
        {
            NavigationManager.NavigateTo("/");
        }
        else
        {
            Error = result.Error;
            ShowErrors = true;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
    }
}
namespace __Blazor.AppUI.Pages.LogIn
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591