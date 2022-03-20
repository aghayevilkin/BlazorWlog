#pragma checksum "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "983263e6d6c468233d1af5159b799cb61d433898"
// <auto-generated/>
#pragma warning disable 1591
namespace Wlog_Server.Pages.News
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Wlog_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Wlog_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using DataAccess.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Business.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Wlog_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Wlog_Server.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Wlog_Server.Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsList.razor"
           [Authorize(Roles = SD.Role_Admin)]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/news")]
    public partial class NewsList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-4");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-8");
            __builder.AddMarkupContent(4, "<h4 class=\"card-title text-info\">News</h4>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "href", "newscategory");
            __builder.AddAttribute(7, "class", "btn btn-info");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(9, "Category");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(11);
            __builder.AddAttribute(12, "href", "newssubcategory");
            __builder.AddAttribute(13, "class", "btn btn-info");
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(15, "Sub Category");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-3 offset-1");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(19);
            __builder.AddAttribute(20, "href", "news/create");
            __builder.AddAttribute(21, "class", "btn btn-info form-control");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(23, "Add New");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row mt-4");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-12");
            __builder.OpenElement(29, "table");
            __builder.AddAttribute(30, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(31, "<thead><tr><th>Title</th>\r\n                    <th>Content</th>\r\n                    <th>Category</th>\r\n                    <th>SubCategory</th>\r\n                    <th></th></tr></thead>\r\n            ");
            __builder.OpenElement(32, "tbody");
#nullable restore
#line 31 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsList.razor"
                 if (NewsModels.Any())
                {
                    foreach (var news in NewsModels)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "tr");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 36 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsList.razor"
                                 news.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 37 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsList.razor"
                                  (MarkupString)news.Details

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                            ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsList.razor"
                                 news.Category.NewsCategory.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 39 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsList.razor"
                                 news.Category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                            ");
            __builder.OpenElement(46, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(47);
            __builder.AddAttribute(48, "href", 
#nullable restore
#line 41 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsList.razor"
                                                 $"news/edit/{news.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(49, "class", "btn btn-primary");
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(51, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n                                ");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "class", "btn btn-danger");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsList.razor"
                                                                         ()=>HandleDelete(news.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(56, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsList.razor"
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(57, "<tr><td colspan=\"5\">No records found</td></tr>");
#nullable restore
#line 52 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n\r\n");
            __builder.OpenComponent<Wlog_Server.Shared.DeleteConfirmation>(59);
            __builder.AddAttribute(60, "IsParentComponentProcessing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 59 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsList.razor"
                                                 IsProcessing

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 59 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsList.razor"
                                                                                    ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsList.razor"
       
    private IEnumerable<NewsDTO> NewsModels { get; set; } = new List<NewsDTO>();
    private int? DeleteNewsId { get; set; } = null;
    private bool IsProcessing { get; set; } = false;


    protected override async Task OnInitializedAsync()
    {
        NewsModels = await NewsRepository.GetAllNews();
    }



    private async Task HandleDelete(int newsId)
    {
        DeleteNewsId = newsId;
        await JsRuntime.InvokeVoidAsync("ShowDeleteConfirmationModal");
    }


    public async Task ConfirmDelete_Click(bool isConfirmed)
    {
        IsProcessing = true;

        if (isConfirmed && DeleteNewsId != null)
        {
            NewsDTO news = await NewsRepository.GetNews(DeleteNewsId.Value);
            foreach (var image in news.NewsImages)
            {
                var imageName = image.NewsImageUrl.Replace($"{NavigationManager.BaseUri}WlogImages/", "");
                FileUpload.DeleteFile(imageName);
            }

            await NewsRepository.DeleteNews(DeleteNewsId.Value);
            await JsRuntime.ToastrSuccess("News Deleted successfully");
            NewsModels = await NewsRepository.GetAllNews();
        }
        await JsRuntime.InvokeVoidAsync("HideDeleteConfirmationModal");

        IsProcessing = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INewsRepository NewsRepository { get; set; }
    }
}
#pragma warning restore 1591