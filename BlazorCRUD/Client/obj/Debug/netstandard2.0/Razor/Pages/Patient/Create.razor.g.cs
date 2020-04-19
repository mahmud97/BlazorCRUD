#pragma checksum "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\Pages\Patient\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a55a39b62e590e23adcfac1c899f094b626e5a4b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.Client.Pages.Patient
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\_Imports.razor"
using BlazorCRUD.Client;

#line default
#line hidden
#line 7 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\_Imports.razor"
using BlazorCRUD.Client.Shared;

#line default
#line hidden
#line 8 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\_Imports.razor"
using BlazorCRUD.Shared.Models;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/patient/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create</h3>\r\n\r\n");
            __builder.OpenComponent<BlazorCRUD.Client.Pages.Patient.PatientForm>(1);
            __builder.AddAttribute(2, "ButtonText", "Create Patient");
            __builder.AddAttribute(3, "Patient", 
#line 6 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\Pages\Patient\Create.razor"
                                                   patient

#line default
#line hidden
            );
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 7 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\Pages\Patient\Create.razor"
                            CreatePatient

#line default
#line hidden
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 10 "E:\PROJECTS\BlazorCRUD\BlazorCRUD\Client\Pages\Patient\Create.razor"
       

    Patient patient = new Patient();

    async Task CreatePatient()
    {
        await http.PostJsonAsync("api/patient", patient);
        navigate.NavigateTo("patient");    

    }



#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591