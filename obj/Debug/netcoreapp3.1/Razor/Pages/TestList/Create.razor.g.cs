#pragma checksum "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97e012c1ff37941f5b7263dbc105e2fdf415c4f8"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/addtest")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create Test</h3>\r\n<hr>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor"
                  test

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor"
                                        AddTest

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<label>Test Id</label>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __Blazor.GridSample.Pages.TestList.Create.TypeInference.CreateInputNumber_0(__builder2, 13, 14, 
#nullable restore
#line 15 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor"
                                       test.TestId

#line default
#line hidden
#nullable disable
                , 15, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => test.TestId = __value, test.TestId)), 16, () => test.TestId);
                __builder2.AddMarkupContent(17, "\r\n            ");
                __Blazor.GridSample.Pages.TestList.Create.TypeInference.CreateValidationMessage_1(__builder2, 18, 19, 
#nullable restore
#line 16 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor"
                                      () => test.TestId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.AddMarkupContent(25, "<label>Category Name</label>\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor"
                                     test.CategoryName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => test.CategoryName = __value, test.CategoryName))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => test.CategoryName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __Blazor.GridSample.Pages.TestList.Create.TypeInference.CreateValidationMessage_2(__builder2, 33, 34, 
#nullable restore
#line 24 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor"
                                      () => test.CategoryName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.AddMarkupContent(40, "<label>Test ShortName</label>\r\n        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor"
                                     test.TestShortName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => test.TestShortName = __value, test.TestShortName))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => test.TestShortName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n            ");
                __Blazor.GridSample.Pages.TestList.Create.TypeInference.CreateValidationMessage_3(__builder2, 48, 49, 
#nullable restore
#line 33 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor"
                                      () => test.TestShortName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.AddMarkupContent(55, "<label>Test Name</label>\r\n        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor"
                                     test.TestName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => test.TestName = __value, test.TestName))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => test.TestName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n            ");
                __Blazor.GridSample.Pages.TestList.Create.TypeInference.CreateValidationMessage_4(__builder2, 63, 64, 
#nullable restore
#line 41 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor"
                                      () => test.TestName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(65, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n\r\n    ");
                __builder2.OpenElement(68, "div");
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.AddMarkupContent(70, "<label>Test Price</label>\r\n        ");
                __builder2.OpenElement(71, "div");
                __builder2.AddMarkupContent(72, "\r\n            ");
                __Blazor.GridSample.Pages.TestList.Create.TypeInference.CreateInputNumber_5(__builder2, 73, 74, 
#nullable restore
#line 48 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor"
                                       test.TestPrice

#line default
#line hidden
#nullable disable
                , 75, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => test.TestPrice = __value, test.TestPrice)), 76, () => test.TestPrice);
                __builder2.AddMarkupContent(77, "\r\n            ");
                __Blazor.GridSample.Pages.TestList.Create.TypeInference.CreateValidationMessage_6(__builder2, 78, 79, 
#nullable restore
#line 49 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor"
                                      () => test.TestPrice

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(80, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n    ");
                __builder2.OpenElement(83, "div");
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.AddMarkupContent(85, "<label>Currently Performing</label>\r\n        ");
                __builder2.OpenElement(86, "div");
                __builder2.AddMarkupContent(87, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(88);
                __builder2.AddAttribute(89, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor"
                                     test.CurrentlyPerforming

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => test.CurrentlyPerforming = __value, test.CurrentlyPerforming))));
                __builder2.AddAttribute(91, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => test.CurrentlyPerforming));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n            ");
                __Blazor.GridSample.Pages.TestList.Create.TypeInference.CreateValidationMessage_7(__builder2, 93, 94, 
#nullable restore
#line 57 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor"
                                      () => test.CurrentlyPerforming

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(95, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n\r\n    <br>\r\n\r\n    ");
                __builder2.AddMarkupContent(98, "<button type=\"submit\" class=\"btn btn-success\">\r\n        Create Test\r\n    </button>\r\n    ");
                __builder2.OpenElement(99, "button");
                __builder2.AddAttribute(100, "type", "submit");
                __builder2.AddAttribute(101, "class", "btn btn-primary");
                __builder2.AddAttribute(102, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor"
                                                             Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(103, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 117 "C:\Users\mahmu\Desktop\blazor-datagrid\blazor-datagrid\Pages\TestList\Create.razor"
       

    TestList test = new TestList();

    protected void AddTest()
    {

        tservice.CreateTest(test);
        navigate.NavigateTo("testlist");
    }

    void Cancel()
    {
        navigate.NavigateTo("testlist");

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Controllers.TestListService tservice { get; set; }
    }
}
namespace __Blazor.GridSample.Pages.TestList.Create
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591