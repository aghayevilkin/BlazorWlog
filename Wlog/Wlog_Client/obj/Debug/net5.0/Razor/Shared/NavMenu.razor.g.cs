#pragma checksum "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2e73f3de780c6f2144b0d06aaca136fc83deeb4"
// <auto-generated/>
#pragma warning disable 1591
namespace Wlog_Client.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""container-fluid d-none d-lg-block"" b-f6yfj0zv3z><div class=""row align-items-center bg-white py-3 px-lg-5"" b-f6yfj0zv3z><div class=""col-lg-4"" b-f6yfj0zv3z><a href class=""navbar-brand p-0 d-none d-lg-block"" b-f6yfj0zv3z><h1 class=""m-0 display-4 text-uppercase text-primary"" b-f6yfj0zv3z>Biz<span class=""text-secondary font-weight-normal"" b-f6yfj0zv3z>News</span></h1></a></div>
        <div class=""col-lg-8 text-center text-lg-right"" b-f6yfj0zv3z></div></div></div>


");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid p-0");
            __builder.AddAttribute(3, "b-f6yfj0zv3z");
            __builder.OpenElement(4, "nav");
            __builder.AddAttribute(5, "class", "navbar navbar-expand-lg bg-dark navbar-dark py-2 py-lg-0 px-lg-5");
            __builder.AddAttribute(6, "b-f6yfj0zv3z");
            __builder.AddMarkupContent(7, "<a href=\"index.html\" class=\"navbar-brand d-block d-lg-none\" b-f6yfj0zv3z><h1 class=\"m-0 display-4 text-uppercase text-primary\" b-f6yfj0zv3z>Biz<span class=\"text-white font-weight-normal\" b-f6yfj0zv3z>News</span></h1></a>\r\n        ");
            __builder.AddMarkupContent(8, "<button type=\"button\" class=\"navbar-toggler\" data-toggle=\"collapse\" data-target=\"#navbarCollapse\" b-f6yfj0zv3z><span class=\"navbar-toggler-icon\" b-f6yfj0zv3z></span></button>\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "collapse navbar-collapse justify-content-between px-0 px-lg-3");
            __builder.AddAttribute(11, "id", "navbarCollapse");
            __builder.AddAttribute(12, "b-f6yfj0zv3z");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "navbar-nav mr-auto py-0");
            __builder.AddAttribute(15, "b-f6yfj0zv3z");
            __builder.AddMarkupContent(16, "<a href class=\"nav-item nav-link active\" b-f6yfj0zv3z>ANA S??H??F??</a>\r\n                ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "nav-item dropdown");
            __builder.AddAttribute(19, "b-f6yfj0zv3z");
            __builder.AddMarkupContent(20, "<a href=\"#\" class=\"nav-link dropdown-toggle\" data-toggle=\"dropdown\" b-f6yfj0zv3z>\r\n                        KATEQOR??YALAR\r\n                    </a>\r\n                    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "dropdown-menu rounded-0 m-0");
            __builder.AddAttribute(23, "b-f6yfj0zv3z");
#nullable restore
#line 35 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Shared\NavMenu.razor"
                         foreach (var item in NewsCategoryList)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", 
#nullable restore
#line 37 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Shared\NavMenu.razor"
                                       $"news/category/{item.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "class", "dropdown-item");
            __builder.AddAttribute(27, "b-f6yfj0zv3z");
            __builder.AddContent(28, 
#nullable restore
#line 37 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Shared\NavMenu.razor"
                                                                                           item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Shared\NavMenu.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.AddMarkupContent(30, "<a href=\"contact\" class=\"nav-item nav-link\" b-f6yfj0zv3z>??laq??</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "input-group ml-auto d-none d-lg-flex");
            __builder.AddAttribute(34, "style", "width: 100%; max-width: 300px;");
            __builder.AddAttribute(35, "b-f6yfj0zv3z");
            __builder.AddMarkupContent(36, "<ul class=\"navbar-nav mr-auto\" b-f6yfj0zv3z></ul>\r\n                ");
            __builder.OpenElement(37, "ul");
            __builder.AddAttribute(38, "class", "my-0 navbar-nav");
            __builder.AddAttribute(39, "b-f6yfj0zv3z");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(40);
            __builder.AddAttribute(41, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "action");
                __builder2.AddAttribute(44, "b-f6yfj0zv3z");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "profile");
                __builder2.AddAttribute(47, "onclick", "menuToggle();");
                __builder2.AddAttribute(48, "b-f6yfj0zv3z");
#nullable restore
#line 50 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Shared\NavMenu.razor"
                                     if (UserDetails.Images != null)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(49, "img");
                __builder2.AddAttribute(50, "src", 
#nullable restore
#line 52 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Shared\NavMenu.razor"
                                                   UserDetails.Images

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(51, "alt", "User");
                __builder2.AddAttribute(52, "b-f6yfj0zv3z");
                __builder2.CloseElement();
#nullable restore
#line 53 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Shared\NavMenu.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(53, "<img style=\"background:white;\" src=\"img/avatar.png\" b-f6yfj0zv3z>");
#nullable restore
#line 57 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Shared\NavMenu.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                                ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "menu");
                __builder2.AddAttribute(57, "b-f6yfj0zv3z");
                __builder2.OpenElement(58, "h3");
                __builder2.AddAttribute(59, "class", "text-white");
                __builder2.AddAttribute(60, "b-f6yfj0zv3z");
                __builder2.AddContent(61, 
#nullable restore
#line 61 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Shared\NavMenu.razor"
                                                            UserDetails.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(62, " ");
                __builder2.AddContent(63, 
#nullable restore
#line 61 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Shared\NavMenu.razor"
                                                                              UserDetails.Surname

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(64, "<br b-f6yfj0zv3z>");
                __builder2.OpenElement(65, "span");
                __builder2.AddAttribute(66, "b-f6yfj0zv3z");
                __builder2.AddContent(67, 
#nullable restore
#line 61 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Shared\NavMenu.razor"
                                                                                                              UserDetails.Profision

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                                    ");
                __builder2.AddMarkupContent(69, @"<ul b-f6yfj0zv3z><li b-f6yfj0zv3z><i class=""fa-solid fa-user fa-lg menuicon"" b-f6yfj0zv3z></i><a href=""account"" b-f6yfj0zv3z>My profile</a></li>
                                        <li b-f6yfj0zv3z><i class=""fa-solid fa-pen-to-square fa-lg menuicon"" b-f6yfj0zv3z></i><a href=""#"" b-f6yfj0zv3z>Edit profile</a></li>
                                        <li b-f6yfj0zv3z><i class=""fa-solid fa-envelope fa-lg menuicon"" b-f6yfj0zv3z></i><a href=""#"" b-f6yfj0zv3z>Inbox</a></li>
                                        <li b-f6yfj0zv3z><i class=""fa-solid fa-gear fa-lg menuicon"" b-f6yfj0zv3z></i><a href=""#"" b-f6yfj0zv3z>Setting</a></li>
                                        <li b-f6yfj0zv3z><i class=""fa-solid fa-circle-question fa-lg menuicon"" b-f6yfj0zv3z></i><a href=""#"" b-f6yfj0zv3z>Help</a></li>
                                        <li b-f6yfj0zv3z><i class=""fa-solid fa-power-off fa-lg menuicon"" b-f6yfj0zv3z></i><a href=""logout"" b-f6yfj0zv3z>Logout</a></li></ul>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(70, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(71, "li");
                __builder2.AddAttribute(72, "class", "nav-item p-0");
                __builder2.AddAttribute(73, "b-f6yfj0zv3z");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(74);
                __builder2.AddAttribute(75, "class", "nav-link");
                __builder2.AddAttribute(76, "href", "registration");
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(78, "<span class=\"p-2\" b-f6yfj0zv3z>\r\n                                        Qeydiyyat\r\n                                    </span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                            ");
                __builder2.OpenElement(80, "li");
                __builder2.AddAttribute(81, "class", "nav-item p-0");
                __builder2.AddAttribute(82, "b-f6yfj0zv3z");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(83);
                __builder2.AddAttribute(84, "class", "nav-link");
                __builder2.AddAttribute(85, "href", "login");
                __builder2.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(87, "<span class=\"p-2\" b-f6yfj0zv3z>\r\n                                        Daxil ol\r\n                                    </span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Shared\NavMenu.razor"
       

    public IEnumerable<NewsCategoryDTO> NewsCategoryList { get; set; } = new List<NewsCategoryDTO>();
    public UserDTO UserDetails { get; set; } = new UserDTO();
    public UserRoleDTO UserRole { get; set; } = new UserRoleDTO();


    protected override async Task OnInitializedAsync()
    {
        NewsCategoryList = await newsCategoryService.GetAllCategory();

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Shared\NavMenu.razor"
         if (await localStorage.GetItemAsync<UserDTO>
               (SD.Local_UserDetails) != null)
        {
            var userInfo = await localStorage.GetItemAsync<UserDTO>
                (SD.Local_UserDetails);

            UserDetails = await accountService.USerDetails(userInfo.Id);
            UserRole = await accountService.USerRole(userInfo.Id);
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Shared\NavMenu.razor"
         
        
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService accountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INewsCategoryService newsCategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591
