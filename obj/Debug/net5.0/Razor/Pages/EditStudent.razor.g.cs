#pragma checksum "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\Pages\EditStudent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c076b87304c15ca04c703f5208f376bab3908db4"
// <auto-generated/>
#pragma warning disable 1591
namespace UAS.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\_Imports.razor"
using UAS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\_Imports.razor"
using UAS.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editstudent/{id}")]
    public partial class EditStudent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\Pages\EditStudent.razor"
                  Student

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\Pages\EditStudent.razor"
                                          HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.AddMarkupContent(6, "<h3>Edit Employee</h3>\r\n    <hr>\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group row");
                __builder2.AddMarkupContent(9, "<label for=\"studentID\" class=\"col-sm-2 col-form-label\">\r\n            Nim\r\n        </label>\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-sm-10");
                __builder2.OpenElement(12, "Input");
                __builder2.AddAttribute(13, "disabled", "true");
                __builder2.AddAttribute(14, "id", "studentID");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "placeholder", "Nim...");
                __builder2.AddAttribute(17, "value", 
#nullable restore
#line 12 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\Pages\EditStudent.razor"
                                                                                                  Student.studentID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.UAS.Pages.EditStudent.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 13 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\Pages\EditStudent.razor"
                                        ()=>Student.studentID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group row");
                __builder2.AddMarkupContent(24, "<label for=\"firstName\" class=\"col-sm-2 col-form-label\">\r\n            Nama Depan\r\n        </label>\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "id", "firstName");
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "placeholder", "First Name");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\Pages\EditStudent.razor"
                                                                                                 Student.firstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Student.firstName = __value, Student.firstName))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Student.firstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __Blazor.UAS.Pages.EditStudent.TypeInference.CreateValidationMessage_1(__builder2, 35, 36, 
#nullable restore
#line 22 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\Pages\EditStudent.razor"
                                        ()=>Student.firstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group row");
                __builder2.AddMarkupContent(40, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">\r\n            Nama Belakang\r\n        </label>\r\n        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "id", "lastName");
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "placeholder", "Nama Belakang....");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\Pages\EditStudent.razor"
                                                                                                       Student.lastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Student.lastName = __value, Student.lastName))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Student.lastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __Blazor.UAS.Pages.EditStudent.TypeInference.CreateValidationMessage_2(__builder2, 51, 52, 
#nullable restore
#line 31 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\Pages\EditStudent.razor"
                                        ()=>Student.lastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group row");
                __builder2.AddMarkupContent(56, "<label for=\"enrollmentDate\" class=\"col-sm-2 col-form-label\">\r\n            Tanggal Masuk\r\n        </label>\r\n        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col-sm-10");
                __builder2.OpenElement(59, "input");
                __builder2.AddAttribute(60, "type", "datetime-local");
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\Pages\EditStudent.razor"
                                                                      Student.enrollmentDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-ddTHH:mm", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Student.enrollmentDate = __value, Student.enrollmentDate, format: "yyyy-MM-ddTHH:mm", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __Blazor.UAS.Pages.EditStudent.TypeInference.CreateValidationMessage_3(__builder2, 65, 66, 
#nullable restore
#line 40 "C:\Users\Makeroot\Documents\TUGAS\Semester 5\Frontend\Tugas UAS\UAS\Pages\EditStudent.razor"
                                        ()=>Student.enrollmentDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n    \r\n    ");
                __builder2.AddMarkupContent(68, "<button class=\"btn btn-primary\" type=\"submit\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.UAS.Pages.EditStudent
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
    }
}
#pragma warning restore 1591
