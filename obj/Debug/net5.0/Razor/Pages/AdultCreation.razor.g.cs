#pragma checksum "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/AdultCreation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baaa362b547d8f69c6580e4cf21a50f34f6353bd"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginExample.Pages
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
#line 2 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/AdultCreation.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/AdultCreation.razor"
using global::Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adultCreation")]
    public partial class AdultCreation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AdultCreation</h3>\n\n");
            __builder.AddMarkupContent(1, "<label>First Name: &nbsp;</label>\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "placeholder", "First Name");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/AdultCreation.razor"
                                                         FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FirstName = __value, FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n<br>\n\n");
            __builder.AddMarkupContent(8, "<label>Last Name: &nbsp;</label>\n");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "placeholder", "Last Name");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/AdultCreation.razor"
                                                        LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => LastName = __value, LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n<br>\n\n");
            __builder.AddMarkupContent(15, "<label>Hair Color: &nbsp;</label>\n");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "placeholder", "Hair Color");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/AdultCreation.razor"
                                                         HairColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HairColor = __value, HairColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n<br>\n\n");
            __builder.AddMarkupContent(22, "<label>Eye Color: &nbsp;</label>\n");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "text");
            __builder.AddAttribute(25, "placeholder", "Eye Color");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/AdultCreation.razor"
                                                        EyeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EyeColor = __value, EyeColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n<br>\n\n");
            __builder.AddMarkupContent(29, "<label>Sex: &nbsp;</label>\n");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "text");
            __builder.AddAttribute(32, "placeholder", "Sex");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/AdultCreation.razor"
                                                  Sex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Sex = __value, Sex));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n<br>\n\n");
            __builder.AddMarkupContent(36, "<label>Age: &nbsp;</label>\n");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "text");
            __builder.AddAttribute(39, "placeholder", "Age");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/AdultCreation.razor"
                                                  Age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Age = __value, Age));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n<br>\n\n");
            __builder.AddMarkupContent(43, "<label>Height: &nbsp;</label>\n");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "text");
            __builder.AddAttribute(46, "placeholder", "Height");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/AdultCreation.razor"
                                                     Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Height = __value, Height));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n<br>\n\n");
            __builder.AddMarkupContent(50, "<label>Weight: &nbsp;</label>\n");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "type", "text");
            __builder.AddAttribute(53, "placeholder", "Weight");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/AdultCreation.razor"
                                                     Weight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Weight = __value, Weight));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n<br>\n\n");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "class", "btn btn-primary");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/AdultCreation.razor"
                                          submit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(60, "Submit");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/AdultCreation.razor"
       
    private string FirstName, LastName, HairColor, EyeColor, Sex;
    private int Age, Height, Id;
    private float Weight;
    FileContext adultFromJson = new FileContext();
    
    
    public void submit()
    {
        try
        {
            Id = adultFromJson.Adults.Count;

            adultFromJson.Adults.Add(new Adult(Id,FirstName,LastName,HairColor,EyeColor,Age,Weight,Height,Sex));
            
            adultFromJson.SaveChanges();

            FirstName = "";
            LastName = "";
            HairColor = "";
            EyeColor = "";
            Sex = "";
            Age = new int();
            Height = new int();
            Id = new int();
            Weight = new float();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591