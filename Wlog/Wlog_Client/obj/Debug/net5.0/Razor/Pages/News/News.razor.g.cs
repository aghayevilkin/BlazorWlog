#pragma checksum "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7aff4263196725f5cbe1a327e5ff62ed9d094165"
// <auto-generated/>
#pragma warning disable 1591
namespace Wlog_Client.Pages.News
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Wlog_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Wlog_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Wlog_Client.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Wlog_Client.Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Wlog_Client.Pages.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/news")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/news/category/{id:int}")]
    public partial class News : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid mt-5 pt-3");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-lg-8");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-12");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "section-title");
            __builder.OpenElement(14, "h4");
            __builder.AddAttribute(15, "class", "m-0 text-uppercase font-weight-bold");
            __builder.AddContent(16, "Category: ");
            __builder.AddContent(17, 
#nullable restore
#line 16 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                                                       NewsCategoryModel.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                            ");
            __builder.OpenComponent<MudBlazor.MudSpacer>(19);
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n                            ");
            __Blazor.Wlog_Client.Pages.News.News.TypeInference.CreateMudTextField_0(__builder, 21, 22, "Search", 23, 
#nullable restore
#line 18 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                                                                      Adornment.Start

#line default
#line hidden
#nullable disable
            , 24, 
#nullable restore
#line 18 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                                                                                                       Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
            , 25, 
#nullable restore
#line 18 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                                                                                                                                               Size.Medium

#line default
#line hidden
#nullable disable
            , 26, "mt-0", 27, 
#nullable restore
#line 18 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                       searchString1

#line default
#line hidden
#nullable disable
            , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString1 = __value, searchString1)));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n\r\n\r\n                    ");
            __Blazor.Wlog_Client.Pages.News.News.TypeInference.CreateMudTable_1(__builder, 30, 31, 
#nullable restore
#line 25 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                      NewsModel.Where(x=>x.Category.NewsCategory.Id == NewsCategoryModel.Id)

#line default
#line hidden
#nullable disable
            , 32, 
#nullable restore
#line 25 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                                                                                      dense

#line default
#line hidden
#nullable disable
            , 33, 
#nullable restore
#line 25 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                                                                                                     hover

#line default
#line hidden
#nullable disable
            , 34, 
#nullable restore
#line 25 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                                                                                                                       bordered

#line default
#line hidden
#nullable disable
            , 35, 
#nullable restore
#line 25 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                                                                                                                                           striped

#line default
#line hidden
#nullable disable
            , 36, 
#nullable restore
#line 25 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                                                                                                                                                             new Func<NewsDTO,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 37, 
#nullable restore
#line 25 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                                                                                                                                                                                                                      selectedItem1

#line default
#line hidden
#nullable disable
            , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 39, (context) => (__builder2) => {
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "col-lg-12");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "position-relative mb-3");
#nullable restore
#line 31 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                     foreach (var img in context.NewsImages.Take(1))
                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(44, "img");
                __builder2.AddAttribute(45, "class", "img-fluid w-100");
                __builder2.AddAttribute(46, "src", 
#nullable restore
#line 33 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                                           img.NewsImageUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(47, "style", "object-fit: cover;");
                __builder2.AddAttribute(48, "alt");
                __builder2.CloseElement();
#nullable restore
#line 34 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "bg-white border border-top-0 p-4");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "mb-2");
                __builder2.OpenElement(53, "a");
                __builder2.AddAttribute(54, "class", "badge badge-primary text-uppercase font-weight-semi-bold p-2 mr-2");
                __builder2.AddAttribute(55, "href", 
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                       $"news/details/{context.Id}"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(56, 
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                                                       context.Category.NewsCategory.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                                            ");
                __builder2.AddMarkupContent(58, "<a class=\"text-body\" href><small>Jan 01, 2045</small></a>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                                        ");
                __builder2.OpenElement(60, "a");
                __builder2.AddAttribute(61, "class", "h4 d-block mb-3 text-secondary text-uppercase font-weight-bold");
                __builder2.AddAttribute(62, "href", 
#nullable restore
#line 41 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                                                                                          $"news/details/{context.Id}"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(63, 
#nullable restore
#line 41 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                                                                                                                          context.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                                        ");
                __builder2.OpenElement(65, "p");
                __builder2.AddAttribute(66, "class", "m-0");
                __builder2.AddContent(67, 
#nullable restore
#line 43 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                              (MarkupString)(context.Details != null && context.Details.Length > 150 ? context.Details.Substring(0, 250) + "..." : context.Details)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                                    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "d-flex justify-content-between bg-white border border-top-0 p-4");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "d-flex align-items-center");
                __builder2.AddMarkupContent(73, "<img class=\"rounded-circle mr-2\" src=\"img/user.jpg\" width=\"25\" height=\"25\" alt>\r\n                                            ");
                __builder2.OpenElement(74, "small");
                __builder2.AddContent(75, 
#nullable restore
#line 49 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                    context.User.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(76, " ");
                __builder2.AddContent(77, 
#nullable restore
#line 49 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                                       context.User.Surname

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                                        ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "d-flex align-items-center");
                __builder2.OpenElement(81, "small");
                __builder2.AddAttribute(82, "class", "ml-3");
                __builder2.AddMarkupContent(83, "<i class=\"far fa-eye mr-2\"></i>");
                __builder2.AddContent(84, 
#nullable restore
#line 52 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                                                                context.ViewCount

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                                            ");
                __builder2.AddMarkupContent(86, "<small class=\"ml-3\"><i class=\"far fa-comment mr-2\"></i>123</small>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            , 87, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTablePager>(88);
                __builder2.AddAttribute(89, "HideRowsPerPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 62 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
                                                            hideRowsPerPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n            ");
            __builder.OpenComponent<Wlog_Client.Pages.News.NewsRightSide>(91);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor"
       
    [Parameter]
    public int Id { get; set; }

    [Parameter]
    public string Url { get; set; }

    private bool dense = false;
    private bool hover = true;
    private bool striped = false;
    private bool bordered = false;
    private bool hideRowsPerPage = true;
    private string searchString1 = "";
    private NewsDTO selectedItem1 = null;
    private HashSet<NewsDTO> selectedItems = new HashSet<NewsDTO>();

    public NewsCategoryDTO NewsCategoryModel { get; set; } = new NewsCategoryDTO();

    public IEnumerable<NewsDTO> NewsModel { get; set; } = new List<NewsDTO>();


    public bool IsProcessing { get; set; } = false;


    protected override async Task OnInitializedAsync()
    {


        navigationManager.LocationChanged += (o, e) =>
        {
            Url = navigationManager.Uri;
            navigationManager.NavigateTo(Url, true);
        };

        NewsCategoryModel = await newsCategoryService.GetCategory(Id);

        IsProcessing = true;
        NewsModel = await newsService.GetNews();
        IsProcessing = false;
    }



    private bool FilterFunc1(NewsDTO element) => FilterFunc(element, searchString1);

    private bool FilterFunc(NewsDTO element, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.Title.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.Category.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.Category.NewsCategory.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INewsService newsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INewsCategoryService newsCategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
    }
}
namespace __Blazor.Wlog_Client.Pages.News.News
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Adornment __arg1, int __seq2, global::System.String __arg2, int __seq3, global::MudBlazor.Size __arg3, int __seq4, global::System.String __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Adornment", __arg1);
        __builder.AddAttribute(__seq2, "AdornmentIcon", __arg2);
        __builder.AddAttribute(__seq3, "IconSize", __arg3);
        __builder.AddAttribute(__seq4, "Class", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateMudTable_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Func<T, global::System.Boolean> __arg5, int __seq6, T __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Hover", __arg2);
        __builder.AddAttribute(__seq3, "Bordered", __arg3);
        __builder.AddAttribute(__seq4, "Striped", __arg4);
        __builder.AddAttribute(__seq5, "Filter", __arg5);
        __builder.AddAttribute(__seq6, "SelectedItem", __arg6);
        __builder.AddAttribute(__seq7, "SelectedItemChanged", __arg7);
        __builder.AddAttribute(__seq8, "RowTemplate", __arg8);
        __builder.AddAttribute(__seq9, "PagerContent", __arg9);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
