// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 4 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
using System.Reflection.Metadata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "/Users/Kasper/Documents/3. Semester/DNP/Assignment 1 - Second try/LoginExample/Pages/Adults.razor"
       
    
    //De 2 nederstående funktioner, køres når siden åbnes
    Task SomeStartupTask()
    {
    // Do some task based work
        return Task.CompletedTask;
    }

    protected override async Task OnInitializedAsync()
    {
        await FetchAdultsAsync();
        await SomeStartupTask();
    }
    
    
    public string searchWord = "";
    public IList<Adult> _adults;
    private int resultAmount = 0;

    public async void Search()
    {
        if (searchWord == "")
        {
            
        } else {
        resultAmount = 0;
            _adults =  FetchAdultsAsync().Result;

        IList < Adult > resultList = new List<Adult>();

        Console.WriteLine("Pre loop");
        for (int i = 0; i < FetchAdultsAsync().Result.Count; i++)
        {
            Console.WriteLine("In loop");
            if (_adults[i].firstName.Contains(searchWord))
            {
                Console.WriteLine("In if");
                resultList.Add(_adults[i]);
                resultAmount++;
            }
        }

            
        _adults = resultList;
        Console.Write("Search done");
    }
    }

    

    public async void loadEverything()
    {
        try
        {
            await FetchAdultsAsync();
    

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<List<Adult>> FetchAdultsAsync()
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:5005/Adult");

        if (!responseMessage.IsSuccessStatusCode)
        {
            throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
        }

        string result = await responseMessage.Content.ReadAsStringAsync();

        List<Adult> adults2 = JsonSerializer.Deserialize<List < Adult >>  (result, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        
        _adults = adults2;
        Console.WriteLine("Done fetching");
        return adults2;
    } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
