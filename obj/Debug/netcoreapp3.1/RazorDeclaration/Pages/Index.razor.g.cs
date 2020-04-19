#pragma checksum "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e61e00f2b164a41498599b4065d35ef8e920b556"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GridSample.Pages
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
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\Index.razor"
      
    public List<Order> Orders { get; set; }

    protected override void OnInitialized()
    {
        Orders = Enumerable.Range(1, 15).Select(x => new Order()
        {
            OrderID = 1000 + x,
            CustomerID = (new string[] { "ALFKI", "ANANTR", "ANTON", "BLONP", "BOLID" })
            [new Random().Next(5)],
            Freight = 2.1 * x,
            OrderDate = DateTime.Now.AddDays(-x)
        }).ToList();
    }

    public class Order
    {
        public int? OrderID { get; set; }

        public string CustomerID { get; set; }

        public DateTime? OrderDate { get; set; }

        public double? Freight { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591