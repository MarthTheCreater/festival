#pragma checksum "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2c6be61147683b3e0e8f2fe8f6e719ad1fa498a"
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
#line 2 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/FetchData.razor"
using Festival.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vagtplan")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Vagtplan</h1>");
#nullable restore
#line 7 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/FetchData.razor"
 if (vagterne == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 10 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Mandag</th>\n                <th>Tirsdag</th>\n                <th>Onsdag</th>\n                <th>Torsdag</th>\n                <th>Fredag</th>\n                <th>Lørdag</th>\n                <th>Søndag</th></tr></thead>\n        ");
            __builder.OpenElement(5, "tbody");
            __builder.OpenElement(6, "tr");
#nullable restore
#line 30 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/FetchData.razor"
                 foreach (var vagter in vagterne)
                {
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "td");
            __builder.AddAttribute(8, "style", "padding: 10px; border: 3px solid ");
            __builder.AddMarkupContent(9, "<p>Starttid:</p>\n                    ");
            __builder.AddContent(10, 
#nullable restore
#line 35 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/FetchData.razor"
                     vagter.starttidspunkt

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "<br>\n                    <br>\n\n                    ");
            __builder.AddMarkupContent(12, "<p>Sluttid:</p>\n                    ");
            __builder.AddContent(13, 
#nullable restore
#line 39 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/FetchData.razor"
                     vagter.sluttidspunkt

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "<br>\n                    <br>\n\n                    ");
            __builder.AddMarkupContent(15, "<p>Arbejdsopgave:</p>\n                    ");
            __builder.AddContent(16, 
#nullable restore
#line 43 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/FetchData.razor"
                     vagter.beskrivelse

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "<br>\n                    <br>\n\n                    ");
            __builder.AddMarkupContent(18, "<p>Antal frivillige:</p>\n                    ");
            __builder.AddContent(19, 
#nullable restore
#line 47 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/FetchData.razor"
                     vagter.kap

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "<br>");
            __builder.CloseElement();
#nullable restore
#line 49 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/FetchData.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/FetchData.razor"
       
    public Bruger[] brugere;
    public Vagter[] vagterne;
    public Dage[] dagene;
    public Frivillige[] defrivillige;
    public Koordinator[] koordinators;
    public Hold[] holdene;

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/FetchData.razor"
       

protected override async Task OnInitializedAsync()
{
    vagterne = await Http.GetFromJsonAsync<Vagter[]>("Vagter");
}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
