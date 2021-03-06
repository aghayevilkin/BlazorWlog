#pragma checksum "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsSubCategoryList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f420e847d94d681fe5f31c0d72aa3866c9c6736"
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
#line 25 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsSubCategoryList.razor"
           [Authorize(Roles = SD.Role_Admin)]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/newssubcategory")]
    public partial class NewsSubCategoryList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-4");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-8");
            __builder.AddMarkupContent(4, "<h4 class=\"card-title text-info\">Sub Category</h4>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "href", "news");
            __builder.AddAttribute(7, "class", "btn btn-info");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(9, "News");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-3 offset-1");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "href", "newssubcategory/create");
            __builder.AddAttribute(15, "class", "btn btn-info form-control");
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(17, "Add New");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "row mt-4");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-12");
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(25, "<thead><tr><th>News Category</th>\r\n                    <th>NewsSub Category</th>\r\n                    <th></th></tr></thead>\r\n            ");
            __builder.OpenElement(26, "tbody");
#nullable restore
#line 30 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsSubCategoryList.razor"
                 if (NewsSubCategories.Any())
                {
                    foreach (var item in NewsSubCategories)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsSubCategoryList.razor"
                         foreach (var item2 in NewsCategoryDTOs.Where(x => x.Id == item.NewsCategoryId))
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "tr");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 37 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsSubCategoryList.razor"
                                     item2.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsSubCategoryList.razor"
                                     item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                                ");
            __builder.OpenElement(34, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
            __builder.AddAttribute(36, "href", 
#nullable restore
#line 40 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsSubCategoryList.razor"
                                                     $"newssubcategory/edit/{item.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "class", "btn btn-primary");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(39, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n                                    ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "class", "btn btn-danger");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsSubCategoryList.razor"
                                                                             ()=>HandleDelete(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsSubCategoryList.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsSubCategoryList.razor"
                         
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "<tr><td colspan=\"5\">No records found</td></tr>");
#nullable restore
#line 52 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsSubCategoryList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n\r\n");
            __builder.OpenComponent<Wlog_Server.Shared.DeleteConfirmation>(47);
            __builder.AddAttribute(48, "IsParentComponentProcessing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 59 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsSubCategoryList.razor"
                                                 IsProcessing

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 59 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsSubCategoryList.razor"
                                                                                    ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsSubCategoryList.razor"
       
    private IEnumerable<NewsSubCategoryDTO> NewsSubCategories { get; set; } = new List<NewsSubCategoryDTO>();
    private IEnumerable<NewsCategoryDTO> NewsCategoryDTOs { get; set; } = new List<NewsCategoryDTO>();
    private int? DeleteCategoryId { get; set; } = null;
    private bool IsProcessing { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        NewsSubCategories = await NewsSubCategoryRepository.GetAllNewsSubCategory();
        NewsCategoryDTOs = await NewsCategoryRepository.GetAllNewsCategory();
    }


    private async Task HandleDelete(int categoryId)
    {
        DeleteCategoryId = categoryId;
        await JsRuntime.InvokeVoidAsync("ShowDeleteConfirmationModal");
    }


    public async Task ConfirmDelete_Click(bool isConfirmed)
    {
        IsProcessing = true;

        if (isConfirmed && DeleteCategoryId != null)
        {
            NewsSubCategoryDTO newsSubCategory = await NewsSubCategoryRepository.GetNewsSubCategory(DeleteCategoryId.Value);

            await NewsSubCategoryRepository.DeleteNewsSubCategory(DeleteCategoryId.Value);
            await JsRuntime.ToastrSuccess("Category Deleted successfully");
            NewsSubCategories = await NewsSubCategoryRepository.GetAllNewsSubCategory();
        }
        await JsRuntime.InvokeVoidAsync("HideDeleteConfirmationModal");

        IsProcessing = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INewsCategoryRepository NewsCategoryRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INewsSubCategoryRepository NewsSubCategoryRepository { get; set; }
    }
}
#pragma warning restore 1591
