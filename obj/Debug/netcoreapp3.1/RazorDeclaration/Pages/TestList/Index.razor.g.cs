#pragma checksum "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "315e157ce23a707c0163a6db2b01d45d1d9b856e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GridSample.Pages.TestList
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\_Imports.razor"
using GridSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\_Imports.razor"
using GridSample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\_Imports.razor"
using GridSample.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/testlist")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Index.razor"
      


    TestList t = new TestList();

    List<TestList> lists;
    protected override async Task OnInitializedAsync()
    {
        lists = await Task.Run(() => tservice.GetTestLists());


    }

    //async Task DeleteTest(int testid)
    //{
    //    var selectedtest = lists.First(l => l.TestId == testid);
    //    if (await js.InvokeAsync<bool>("confirm", $"Are you sure to delete patient information of  : {selectedtest.TestName}?"))
    //    {

    //        tservice.DeleteTest(t);
    //        //await http.DeleteAsync($"api/patient/{patientId}");
    //        //await GetPatientData();

    //    }
    //}



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Controllers.TestListService tservice { get; set; }
    }
}
#pragma warning restore 1591
