#pragma checksum "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/LoginTab.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19fb9e35a6f18cc604e7c38904deb3468f62be11"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginComponent2
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/_Imports.razor"
using LoginExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/_Imports.razor"
using LoginExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/LoginTab.razor"
using LoginExample.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/LoginTab.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/LoginTab.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/LoginTab.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/LoginTab.razor"
using LoginExample.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class LoginTab : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "p-3 mb-2 bg-light text-dark text-center card");
                __builder2.AddMarkupContent(4, "<h3>Adult database login</h3>\n            ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-group");
                __builder2.OpenElement(7, "input");
                __builder2.AddAttribute(8, "class", "form-control");
                __builder2.AddAttribute(9, "type", "text");
                __builder2.AddAttribute(10, "placeholder", "Username");
                __builder2.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/LoginTab.razor"
                                                                                            username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "type", "password");
                __builder2.AddAttribute(19, "placeholder", "Password");
                __builder2.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/LoginTab.razor"
                                                                                                password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "style", "color:red");
                __builder2.AddContent(25, 
#nullable restore
#line 27 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/LoginTab.razor"
                                    errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n\n            ");
                __builder2.OpenElement(27, "a");
                __builder2.AddAttribute(28, "class", "btn btn-primary");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/LoginTab.razor"
                                                 PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(30, "<em class=\"text-light\">Login</em>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(31, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(32, "<h1>Succes!</h1>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/LoginTab.razor"
       
private string username;
private string password;
private string errorMessage;

public async Task PerformLogin() {
    errorMessage = "";
    try {
    //HttpClient client = new HttpClient();

        //string tmpString = "https://localhost:5005/UserLogin?userName=" + username.ToString() + "&password=" + password.ToString();
        //HttpResponseMessage responseMessage = await client.GetAsync(tmpString);
        //Console.WriteLine(responseMessage.IsSuccessStatusCode);
        //Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
        
        //User user = JsonSerializer.Deserialize<User>  (responseMessage.Content.ReadAsStringAsync().Result, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        
        ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username,password);
        
        //Console.WriteLine(user.UserName + user.Password + user.City);
        
        username = "";
        password = "";
    } catch (Exception e)
    {
        errorMessage = e.Message;
    }

    /*try
    {
        https://localhost:5005/UserLogin?userName=Troels&password=123456
        
        HttpClient client = new HttpClient();
        HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:5005/Adult");

        if (!responseMessage.IsSuccessStatusCode)
        {
            throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
        }

        string result = await responseMessage.Content.ReadAsStringAsync();

        List<Adult> adults2 = JsonSerializer.Deserialize<List < Adult >>  (result, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        
        Console.WriteLine("Done fetching");
        return adults2;
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }*/
}

public async Task PerformLogout() {
errorMessage = "";
username = "";
password = "";
try {
((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
NavigationManager.NavigateTo("/");
} catch (Exception e) { }
}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
