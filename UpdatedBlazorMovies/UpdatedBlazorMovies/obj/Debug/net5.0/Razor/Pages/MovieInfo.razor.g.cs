#pragma checksum "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\MovieInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e61587d5c7fa920204f46680eabe9e2eec2a8b1b"
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
#line 1 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\MovieInfo.razor"
using BlazorMovies.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\MovieInfo.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movieinfo")]
    public partial class MovieInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Movie Info</h3>\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\MovieInfo.razor"
                 movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\MovieInfo.razor"
                                        GetMovieInfo

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-4");
                __builder2.AddMarkupContent(11, "<label for>Title</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\MovieInfo.razor"
                                    movie.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => movie.Title = __value, movie.Title))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => movie.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __Blazor.UpdatedBlazorMovies.Pages.MovieInfo.TypeInference.CreateValidationMessage_0(__builder2, 18, 19, 
#nullable restore
#line 18 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\MovieInfo.razor"
                                      () => movie.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n\r\n    <br>\r\n\r\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "row");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-md-4");
                __builder2.AddMarkupContent(25, "<label for>Year</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "id", "");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\MovieInfo.razor"
                                    movie.Year

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => movie.Year = __value, movie.Year))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => movie.Year));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __Blazor.UpdatedBlazorMovies.Pages.MovieInfo.TypeInference.CreateValidationMessage_1(__builder2, 32, 33, 
#nullable restore
#line 28 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\MovieInfo.razor"
                                      () => movie.Year

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n    <br>\r\n    <br>\r\n\r\n    ");
                __builder2.OpenElement(35, "button");
                __builder2.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\MovieInfo.razor"
                      GetMovieInfo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "class", "btn btn-light");
                __builder2.AddContent(38, "Get Movie");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n    <br>\r\n    <br>\r\n    <br>\r\n\r\n\r\n    <br>\r\n\r\n    ");
                __builder2.AddMarkupContent(40, "<label for>Plot</label>\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "container");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "comment");
                __builder2.OpenElement(47, "textarea");
                __builder2.AddAttribute(48, "class", "textinput");
                __builder2.AddAttribute(49, "rows", "8");
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\MovieInfo.razor"
                                                             movie.moviePlot

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => movie.moviePlot = __value, movie.moviePlot));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n    <br>\r\n\r\n    ");
                __builder2.AddMarkupContent(53, "<label for>Actors</label>\r\n    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "container");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "comment");
                __builder2.OpenElement(60, "textarea");
                __builder2.AddAttribute(61, "class", "textinput");
                __builder2.AddAttribute(62, "rows", "1");
                __builder2.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\MovieInfo.razor"
                                                             movie.movieActors

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => movie.movieActors = __value, movie.movieActors));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\r\n    <br>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\erica\OneDrive\Documents\C#GitHubRepo\IDMbWebScraper\UpdatedBlazorMovies\UpdatedBlazorMovies\Pages\MovieInfo.razor"
       

    Movie movie = new Movie();
    HttpClient ApiClient = new HttpClient();

    protected async Task GetMovies()
    {
        string Title = movie.Title;
        string Year = movie.Year;
        string key = "";

        string url = $"http://www.omdbapi.com/?apikey={key}&t={movie.Title}&y={movie.Year}&plot=full";

        string response = await ApiClient.GetStringAsync(url);

        Movie movieObject = JsonConvert.DeserializeObject<Movie>(response);

        movie.moviePlot = movieObject.Plot;
        movie.movieActors = movieObject.Actors;
    }

    protected async Task GetMovieInfo()
    {
        await GetMovies();
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.UpdatedBlazorMovies.Pages.MovieInfo
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
    }
}
#pragma warning restore 1591
