#pragma checksum "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Account\SavedNews.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39349ac38652a19763ee6a8e8ce5670d17adf788"
// <auto-generated/>
#pragma warning disable 1591
namespace Wlog_Client.Pages.Account
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
#nullable restore
#line 21 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Wlog_Client.ModelVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Wlog_Client.Pages.News;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/savednews")]
    public partial class SavedNews : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"css/account.css\" rel=\"stylesheet\">\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container padding-bottom-3x mb-2");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __Blazor.Wlog_Client.Pages.Account.SavedNews.TypeInference.CreateCascadingValue_0(__builder, 5, 6, 
#nullable restore
#line 12 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Account\SavedNews.razor"
                               ActiveSavedNews

#line default
#line hidden
#nullable disable
            , 7, "ActiveSavedNews", 8, (__builder2) => {
                __builder2.OpenComponent<Wlog_Client.Pages.Account.Profile>(9);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 16 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Account\SavedNews.razor"
         if (UserDetails == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, @"<div class=""loading""><div class=""fl spinner7 loader-gif""><p style=""color: #fff;width: 510px;font-size: 20px;line-height: 1.2em;margin-left: -210px;margin-bottom: 40px;"">Loading</p><div class=""circ1""></div><div class=""circ2""></div><div class=""circ3""></div><div class=""circ4""></div></div></div>");
#nullable restore
#line 21 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Account\SavedNews.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-lg-8");
            __builder.AddMarkupContent(13, "<div class=\"padding-top-2x mt-2 hidden-lg-up\"></div>\r\n                \r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-lg-12 pb-5");
#nullable restore
#line 29 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Account\SavedNews.razor"
                     foreach (var item in NewsList.Where(x=>x.SavedNews.Any(u=>u.UserId == USerId)))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "cart-item d-md-flex justify-content-between");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "class", "remove-item");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Account\SavedNews.razor"
                                                                ()=>SavedNewsClicked(Convert.ToInt32(item.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "<i class=\"fa fa-times\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "px-3 my-3");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "class", "cart-item-product");
            __builder.AddAttribute(27, "href", 
#nullable restore
#line 34 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Account\SavedNews.razor"
                                                                     $"news/details/{item.Id}"

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 35 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Account\SavedNews.razor"
                                     foreach (var img in item.NewsImages.Take(1))
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "cart-item-product-thumb");
            __builder.OpenElement(30, "img");
            __builder.AddAttribute(31, "src", 
#nullable restore
#line 37 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Account\SavedNews.razor"
                                                                                        img.NewsImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "alt", "Product");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Account\SavedNews.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "cart-item-product-info");
            __builder.OpenElement(35, "h4");
            __builder.AddAttribute(36, "class", "cart-item-product-title");
            __builder.AddContent(37, 
#nullable restore
#line 40 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Account\SavedNews.razor"
                                                                             item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                        ");
            __builder.OpenElement(39, "span");
            __builder.AddContent(40, "Kateqoriya: ");
            __builder.OpenElement(41, "span");
            __builder.AddAttribute(42, "class", "text-success font-weight-medium");
            __builder.AddContent(43, 
#nullable restore
#line 41 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Account\SavedNews.razor"
                                                                                                         item.Category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Account\SavedNews.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Account\SavedNews.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Account\SavedNews.razor"
       
    public string USerId { get; set; }
    public bool IsProcessing { get; set; } = false;
    public string ActiveSavedNews { get; set; } = "active";

    public UserDTO UserDetails { get; set; } = new UserDTO();
    public IEnumerable<NewsDTO> NewsList { get; set; } = new List<NewsDTO>();
    public SavedNewsDTO SavedNewsDTOs { get; set; } = new SavedNewsDTO();

    protected override async Task OnInitializedAsync()
    {
        var userInfo = await localStorage.GetItemAsync<UserDTO>
                (SD.Local_UserDetails);
        USerId = userInfo.Id;

        IsProcessing = true;
        UserDetails = await accountService.USerDetails(userInfo.Id);
        NewsList = await newsService.GetNews();
        IsProcessing = false;
    }


    private async Task SavedNewsClicked(int newsId)
    {
        if (await localStorage.GetItemAsync<UserDTO>
                (SD.Local_UserDetails) != null)
        {
            var userInfo = await localStorage.GetItemAsync<UserDTO>
                (SD.Local_UserDetails);
            SavedNewsDTOs.UserId = userInfo.Id;
            SavedNewsDTOs.NewsId = newsId;


            await newsService.AddToSavedNews(SavedNewsDTOs);

            await jsRuntime.ToastrSuccess("Silindi");

            IsProcessing = true;
            UserDetails = await accountService.USerDetails(userInfo.Id);
            NewsList = await newsService.GetNews();
            IsProcessing = false;

        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INewsService newsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService accountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
    }
}
namespace __Blazor.Wlog_Client.Pages.Account.SavedNews
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
