#pragma checksum "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18d307828c9d12c2fc95a13d1d5a91defc67e7cc"
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
#line 1 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Index.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Index.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-xl-6");
            __builder.AddMarkupContent(4, "<h3 style=\"margin-top: 1rem\">Login with register</h3>\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(5);
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.Festival.Client.Pages.Index.TypeInference.CreateRadzenTemplateForm_0(__builder2, 7, 8, 
#nullable restore
#line 10 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Index.razor"
                                       "LoginWithRegister"

#line default
#line hidden
#nullable disable
                , 9, (context) => (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLogin>(10);
                    __builder3.AddAttribute(11, "AllowResetPassword", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Index.razor"
                                                 false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Login", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoginArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoginArgs>(this, 
#nullable restore
#line 12 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Index.razor"
                                     args => OnLogin(args, "Login with register")

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(13, "Register", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 13 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Index.razor"
                                        args => OnRegister("Login with register")

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(14, "Style", "margin-bottom: 20px;");
                    __builder3.CloseComponent();
                }
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Index.razor"
       

    string textBox1 = "admin";
    string textBox2 = "admin";

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Users/martinjensen/Documents/ITA/ITA 2. semester/Festival/Festival/Client/Pages/Index.razor"
       


    private void show(string text)
    {
    }

    private void DisplayMessageBoxText()
    {
        show("");
    }

    void OnLogin(LoginArgs args, string name)
    {
        string userName = "admin";
        string password = "admin";

        if((textBox1 == userName) && (textBox2 == password))
        {
            DisplayMessageBoxText();
        }

    }

    void OnRegister(string name)
    {
    }

    void OnResetPassword(string value, string name)
    {
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Festival.Client.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenTemplateForm_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TItem __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext> __arg1)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenTemplateForm<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
