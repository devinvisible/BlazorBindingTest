#pragma checksum "E:\Programming\CSharp\BlazorBindingTest\Pages\Test.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aef57ee82674fae3122c50fd4d6eabe3ed429686"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorBindingTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Programming\CSharp\BlazorBindingTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Programming\CSharp\BlazorBindingTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Programming\CSharp\BlazorBindingTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Programming\CSharp\BlazorBindingTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Programming\CSharp\BlazorBindingTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Programming\CSharp\BlazorBindingTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Programming\CSharp\BlazorBindingTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Programming\CSharp\BlazorBindingTest\_Imports.razor"
using BlazorBindingTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Programming\CSharp\BlazorBindingTest\_Imports.razor"
using BlazorBindingTest.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Test")]
    public partial class Test : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "E:\Programming\CSharp\BlazorBindingTest\Pages\Test.razor"
       
    int? SelectedNumber { get; set; } = 4;

    List<int> NumbersToSelectFrom { get; set; } = Enumerable.Range(1, 10).ToList();

    List<int> AllNumbers { get; set; }
    List<int> FilteredNumbers
    {
        get
        {
            var filtered = AllNumbers;

            if (SelectedNumber != null )
            {
                filtered = AllNumbers.Where(n => n % SelectedNumber == 0).ToList();
            }            

            return filtered;
        }
    }

    void OnNumberSelectedCallback(int number)
    {
        SelectedNumber = number;
        //StateHasChanged();
    }


    protected override void OnInitialized()
    {
        AllNumbers = Enumerable.Range(1, 40).ToList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
