#pragma checksum "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\TopRatedMovies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a18f2f7b5aeece7676e31870e6c05d0915921ee0"
// <auto-generated/>
#pragma warning disable 1591
namespace UpdatedBlazorMovies.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\_Imports.razor"
using UpdatedBlazorMovies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\_Imports.razor"
using UpdatedBlazorMovies.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\TopRatedMovies.razor"
using UpdatedBlazorMovies.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/topratedmovies")]
    public partial class TopRatedMovies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Top Rated Movies</h3>\r\n\r\n<br>");
#nullable restore
#line 10 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\TopRatedMovies.razor"
 if (ListData == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\TopRatedMovies.razor"
}


#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\TopRatedMovies.razor"
       

else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, @"<style>
        td,
        th {
            border: 1px solid rgb(190, 190, 190);
            padding: 10px;
            text-align: center;
        }

        td {
            text-align: center;
            font-family: -apple-system, BlinkMacSystemFont, ""Segoe UI"", Roboto, ""Helvetica Neue"", Arial, ""Noto Sans"", sans-serif, ""Apple Color Emoji"", ""Segoe UI Emoji"", ""Segoe UI Symbol"", ""Noto Color Emoji"";
            font-size: 1rem;
            font-weight: 400;
            line-height: 1.5;
        }

        th[scope=""col""] {
            background-color: #3f87a6;
            color: #fff;
        }

        table {
            border-collapse: collapse;
            border: 2px solid rgb(200, 200, 200);
            letter-spacing: 1px;
            font-family: -apple-system, BlinkMacSystemFont, ""Segoe UI"", Roboto, ""Helvetica Neue"", Arial, ""Noto Sans"", sans-serif, ""Apple Color Emoji"", ""Segoe UI Emoji"", ""Segoe UI Symbol"", ""Noto Color Emoji"";
            font-size: 1rem;
            font-weight: 400;
            line-height: 1.5;
        }
    </style>");
            __builder.OpenElement(3, "table");
            __builder.AddMarkupContent(4, "<tr><th scope=\"col\">Top Rated Films</th></tr>\r\n        ");
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
#nullable restore
#line 69 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\TopRatedMovies.razor"
                 foreach (var data in ListData)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "ul");
            __builder.AddContent(9, 
#nullable restore
#line 72 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\TopRatedMovies.razor"
                     data.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\TopRatedMovies.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 78 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\TopRatedMovies.razor"
        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\TopRatedMovies.razor"
 
    public List<string> ListData;

    protected override async Task OnInitializedAsync()
    {
        ListData = await Scrapit.TopRatedMoviesScraper();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ScrapperService Scrapit { get; set; }
    }
}
#pragma warning restore 1591
