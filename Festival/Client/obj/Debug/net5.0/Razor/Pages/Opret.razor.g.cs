#pragma checksum "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Opret.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f875bc48e4a253819277b4bcb6a74ec9626de53"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/opret")]
    public partial class Opret : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "html");
            __builder.OpenElement(1, "body");
            __builder.AddMarkupContent(2, "<img src=\"swag.png\" width=\"124\" height=\"124\" style=\"float:right\">\n\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "login");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "id", "navn");
            __builder.AddAttribute(8, "class", "login");
            __builder.AddAttribute(9, "name", "navn");
            __builder.AddAttribute(10, "placeholder", "navn");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Opret.razor"
                                                                                         navn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => navn = __value, navn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n        ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "id", "email");
            __builder.AddAttribute(17, "class", "login");
            __builder.AddAttribute(18, "name", "email");
            __builder.AddAttribute(19, "placeholder", "email");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Opret.razor"
                                                                                            email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n        ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "text");
            __builder.AddAttribute(25, "id", "tlf");
            __builder.AddAttribute(26, "class", "login");
            __builder.AddAttribute(27, "name", "telefonnummer");
            __builder.AddAttribute(28, "placeholder", "telefonnummer");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Opret.razor"
                                                                                                          tlf

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tlf = __value, tlf));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n        ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "id", "password");
            __builder.AddAttribute(35, "class", "login");
            __builder.AddAttribute(36, "name", "password");
            __builder.AddAttribute(37, "placeholder", "password");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Opret.razor"
                                                                                                     password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n        ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "text");
            __builder.AddAttribute(43, "id", "adgangsID");
            __builder.AddAttribute(44, "class", "login");
            __builder.AddAttribute(45, "name", "adgangsID");
            __builder.AddAttribute(46, "placeholder", "adgangsID");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Opret.razor"
                                                                                                        adgangsID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adgangsID = __value, adgangsID));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n        ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "type", "submit");
            __builder.AddAttribute(52, "class", "registrering");
            __builder.AddAttribute(53, "value", "Opret bruger");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Opret.razor"
                                                                                 opretbruger

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Opret.razor"
      
    private string email;
    private string password;
    private string navn;
    private string tlf;
    private string adgangsID;


    private int adgang = 0;

    public async Task opretbruger()
    {

        adgang = await Http.GetFromJsonAsync<int>($"opretbruger/{email}/{password}");

        if (adgang == 1)
        {
            nav.NavigateTo("/vagtplan");
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
