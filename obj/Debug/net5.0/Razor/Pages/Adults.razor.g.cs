#pragma checksum "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c76109449b83da379312e4f92a793e0d255cebad"
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
#line 2 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
using System.Reflection.Metadata;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\n\n");
            __builder.AddMarkupContent(1, "<label>Search by First Name: &nbsp;</label>\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "placeholder", "First Name");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
                                                         searchWord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchWord = __value, searchWord));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-primary");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
                                          Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n<br>\n");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-primary");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
                                          loadEverything

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Load Everyone");
            __builder.CloseElement();
#nullable restore
#line 15 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
 if (_adults == null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<p><em>Loading...</em></p>");
#nullable restore
#line 20 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
} else {
    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table");
            __builder.AddMarkupContent(20, @"<thead><tr><th>First Name</th>
            <th>Last Name</th>
            <th>ID</th>
            <th>Hair Color</th>
            <th>Eye Color</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th>
            <th>Job Title</th>
            <th>Salary</th></tr></thead>
        ");
            __builder.OpenElement(21, "tbody");
#nullable restore
#line 41 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
         foreach (var adultList in searchResult) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "tr");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 43 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
                     adultList.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 44 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
                     adultList.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 45 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
                     adultList.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 46 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
                     adultList.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 47 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
                     adultList.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 48 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
                     adultList.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 49 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
                     adultList.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 50 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
                     adultList.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 51 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
                     adultList.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n                ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 52 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
                     adultList.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n                ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 53 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
                     adultList.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
       
    
    //De 2 nederstående funktioner, køres når siden åbnes
    Task SomeStartupTask()
    {
    // Do some task based work
        return Task.CompletedTask;
    }

    protected override async Task OnInitializedAsync()
    {
        loadEverything();
        await SomeStartupTask();
    }
    
    
    public string searchWord = "";
    FileContext adultFromJson = new FileContext();
    public IList<Adult> _adults;

    public IList<Adult> searchResult;
    private int resultAmount = 0;

    public void Search()
    {
        if (searchWord == "")
        {
            
        } else {
        resultAmount = 0;
        _adults = adultFromJson.Adults;

        IList < Adult > resultList = new List<Adult>();

        Console.WriteLine("Pre loop");
        for (int i = 0; i < adultFromJson.Adults.Count; i++)
        {
            Console.WriteLine("In loop");
            if (_adults[i].FirstName.Contains(searchWord))
            {
                Console.WriteLine("In if");
                resultList.Add(_adults[i]);
                resultAmount++;
            }
        }

        


        searchResult = resultList;
        Console.Write("Search done");
    }
    }

    

    public void loadEverything()
    {
        try
        {
            _adults = adultFromJson.Adults;
            searchResult = _adults;
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
