#pragma checksum "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d52d0635c77770eac04e3ccf96d7e386c16766e5"
// <auto-generated/>
#pragma warning disable 1591
namespace Festival.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/_Imports.razor"
using Festival.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/_Imports.razor"
using Festival.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Login.razor"
using Festival.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "wrapper fadeInDown");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "id", "formContent");
            __builder.AddMarkupContent(4, "\r\n        Tabs Titles\r\n        Icon\r\n        ");
            __builder.AddMarkupContent(5, "<div class=\"fadeIn first\"><img src=\"http://danielzawadzki.com/codepen/01/icon.svg\" id=\"icon\" alt=\"User Icon\"></div>\r\n\r\n        Login Form\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Login.razor"
                         logger

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Login.razor"
                                                logincheck

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(10, "input");
                __builder2.AddAttribute(11, "type", "text");
                __builder2.AddAttribute(12, "id", "login");
                __builder2.AddAttribute(13, "class", "fadeIn second");
                __builder2.AddAttribute(14, "name", "login");
                __builder2.AddAttribute(15, "placeholder", "login");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Login.razor"
                                                                                          email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenElement(19, "input");
                __builder2.AddAttribute(20, "type", "text");
                __builder2.AddAttribute(21, "id", "password");
                __builder2.AddAttribute(22, "class", "fadeIn third");
                __builder2.AddAttribute(23, "name", "login");
                __builder2.AddAttribute(24, "placeholder", "password");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Login.razor"
                                                                                            password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            <input type=\"submit\" class=\"fadeIn fourth\" value=\"Log In\">");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n\r\n        Remind Password\r\n        ");
            __builder.AddMarkupContent(29, "<div id=\"formFooter\"><a class=\"underlineHover\" href=\"#\">Forgot Password?</a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "}\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Login.razor"
      

    Login logger = new Login();
    public int niveau = 0;

    string message;

    protected string email { get; set; } = "";

    protected string password { get; set; } = "";

    private async void logincheck()
    {
        niveau = await Http.GetFromJsonAsync<int>($"{email}/{password}");
        if (niveau == 1)
        {
            nav.NavigateTo("/vagtplan");
        }
        if(niveau == 2)
        {
            nav.NavigateTo("/fetchdata");
        }
        else
        {
            message = "Email eller password er forkert.";
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
    }
}
#pragma warning restore 1591
