#pragma checksum "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f061242f4c2794b997a1d5c49ca801e47665c8dc"
// <auto-generated/>
#pragma warning disable 1591
namespace Wlog_Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
 if (IsProcessing)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, @"<div class=""loading""><div class=""fl spinner7 loader-gif""><p style=""color: #fff;width: 510px;font-size: 20px;line-height: 1.2em;margin-left: -210px;margin-bottom: 40px;"">Loading</p><div class=""circ1""></div><div class=""circ2""></div><div class=""circ3""></div><div class=""circ4""></div></div></div>");
#nullable restore
#line 13 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-lg-7 px-0");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "blog-slider");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "blog-slider__wrp swiper-wrapper");
#nullable restore
#line 23 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                         foreach (var item in News.Take(3))
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "blog-slider__item swiper-slide");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "blog-slider__img");
#nullable restore
#line 28 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                     foreach (var img in item.NewsImages)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 30 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                   img.NewsImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "alt");
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "blog-slider__content");
            __builder.OpenElement(21, "div");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "class", "badge badge-primary text-uppercase font-weight-semi-bold p-2 mr-2");
            __builder.AddAttribute(24, "href", 
#nullable restore
#line 37 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                   $"news/category/{item.Category.NewsCategory.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, 
#nullable restore
#line 37 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                                                       item.Category.NewsCategory.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                                        ");
            __builder.OpenElement(27, "span");
            __builder.AddAttribute(28, "class", "blog-slider__code");
            __builder.AddContent(29, 
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                         item.AddedDate.ToString("dd MMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n                                    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "blog-slider__title");
            __builder.AddContent(33, 
#nullable restore
#line 41 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                     item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "blog-slider__text");
            __builder.AddContent(37, 
#nullable restore
#line 42 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                     (MarkupString)(item.Details != null && item.Details.Length > 150 ? item.Details.Substring(0, 250) + "..." : item.Details)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                    ");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "href", 
#nullable restore
#line 43 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                               $"news/details/{item.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "class", "blog-slider__button");
            __builder.AddContent(42, "READ MORE");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    <div class=\"blog-slider__pagination\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-lg-5 px-0");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "row mx-0");
#nullable restore
#line 57 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                     foreach (var item in News.Skip(3).Take(4))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-md-6 px-0");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "position-relative overflow-hidden");
            __builder.AddAttribute(53, "style", "height: 250px;");
#nullable restore
#line 61 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                 foreach (var img in item.NewsImages)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "img");
            __builder.AddAttribute(55, "class", "img-fluid w-100 h-100");
            __builder.AddAttribute(56, "src", 
#nullable restore
#line 63 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                             img.NewsImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(57, "style", "object-fit: cover;");
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "overlay");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "mb-2");
            __builder.OpenElement(62, "a");
            __builder.AddAttribute(63, "class", "badge badge-primary text-uppercase font-weight-semi-bold p-2 mr-2");
            __builder.AddAttribute(64, "href", 
#nullable restore
#line 68 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                   $"news/category/{item.Category.NewsCategory.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(65, 
#nullable restore
#line 68 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                                                       item.Category.NewsCategory.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                        ");
            __builder.OpenElement(67, "a");
            __builder.AddAttribute(68, "class", "text-white");
            __builder.AddAttribute(69, "href");
            __builder.OpenElement(70, "small");
            __builder.AddContent(71, 
#nullable restore
#line 69 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                              item.AddedDate.ToString("dd MMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                                    ");
            __builder.OpenElement(73, "a");
            __builder.AddAttribute(74, "class", "h6 m-0 text-white text-uppercase font-weight-semi-bold");
            __builder.AddAttribute(75, "href", 
#nullable restore
#line 71 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                                                              $"news/details/{item.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(76, 
#nullable restore
#line 71 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                                                                                            (MarkupString)(item.Details != null && item.Details.Replace("h2", "p").Length > 50 ? item.Details.Replace("h2", "p").Substring(0, 50) + "..." : item.Details.Replace("h2", "p"))

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "<div class=\"container-fluid bg-dark py-3 mb-3\"><div class=\"container\"><div class=\"row align-items-center bg-dark\"><div class=\"col-12\"><div class=\"d-flex justify-content-between\"></div></div></div></div></div>");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "container-fluid");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "container");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "row");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "col-lg-8");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "row");
            __builder.AddMarkupContent(88, "<div class=\"col-12\"><div class=\"section-title\"><h4 class=\"m-0 text-uppercase font-weight-bold\">Son X??b??rl??r</h4></div></div>");
#nullable restore
#line 177 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                         if (News != null)
                        {
                            foreach (var item in News.Take(TakeLoad))
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "col-lg-6");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "position-relative mb-3");
#nullable restore
#line 183 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                         foreach (var img in item.NewsImages.Take(1))
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(93, "img");
            __builder.AddAttribute(94, "class", "img-fluid w-100");
            __builder.AddAttribute(95, "src", 
#nullable restore
#line 185 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                               img.NewsImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(96, "style", "object-fit: cover; height: 14.375rem;");
            __builder.AddAttribute(97, "alt");
            __builder.CloseElement();
#nullable restore
#line 186 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "bg-white border border-top-0 p-4");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "mb-2");
            __builder.OpenElement(102, "a");
            __builder.AddAttribute(103, "class", "badge badge-primary text-uppercase font-weight-semi-bold p-2 mr-2");
            __builder.AddAttribute(104, "href", 
#nullable restore
#line 190 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                           $"news/details/{item.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(105, 
#nullable restore
#line 190 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                                        item.Category.NewsCategory.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 191 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                  
                                                    var gerCult = CultureInfo.CreateSpecificCulture("aze-az");
                                                

#line default
#line hidden
#nullable disable
            __builder.OpenElement(106, "a");
            __builder.AddAttribute(107, "class", "text-body");
            __builder.AddAttribute(108, "href");
            __builder.OpenElement(109, "small");
            __builder.AddContent(110, 
#nullable restore
#line 194 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                                     item.AddedDate.ToString("dd MMM yyyy", gerCult)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                                            ");
            __builder.OpenElement(112, "a");
            __builder.AddAttribute(113, "class", "h4 d-block mb-3 text-secondary text-uppercase font-weight-bold");
            __builder.AddAttribute(114, "href", 
#nullable restore
#line 196 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                                                                              $"news/details/{item.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(115, 
#nullable restore
#line 196 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                                                                                                           item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                                            ");
            __builder.OpenElement(117, "p");
            __builder.AddAttribute(118, "class", "m-0");
            __builder.AddContent(119, 
#nullable restore
#line 198 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                  (MarkupString)(item.Details != null && item.Details.Length > 150 ? item.Details.Substring(0, 250) + "..." : item.Details)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                                        ");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "d-flex justify-content-between bg-white border border-top-0 p-4");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "d-flex align-items-center");
#nullable restore
#line 203 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                 if (item.User.Images != null)
                                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(125, "img");
            __builder.AddAttribute(126, "class", "rounded-circle mr-2");
            __builder.AddAttribute(127, "src", 
#nullable restore
#line 205 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                                           item.User.Images

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(128, "width", "25");
            __builder.AddAttribute(129, "height", "25");
            __builder.AddAttribute(130, "alt");
            __builder.CloseElement();
#nullable restore
#line 206 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(131, "<img class=\"rounded-circle mr-2\" src=\"img/avatar.png\" width=\"25\" height=\"25\" alt>");
#nullable restore
#line 210 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(132, "small");
            __builder.AddContent(133, 
#nullable restore
#line 212 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                        item.User.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(134, " ");
            __builder.AddContent(135, 
#nullable restore
#line 212 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                        item.User.Surname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                                            ");
            __builder.OpenElement(137, "div");
            __builder.AddAttribute(138, "class", "d-flex align-items-center");
            __builder.OpenElement(139, "small");
            __builder.AddAttribute(140, "class", "ml-3");
            __builder.AddMarkupContent(141, "<i class=\"far fa-eye mr-2\"></i>");
            __builder.AddContent(142, 
#nullable restore
#line 215 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                                                    item.ViewCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                                                ");
            __builder.OpenElement(144, "small");
            __builder.AddAttribute(145, "class", "ml-3");
            __builder.AddMarkupContent(146, "<i class=\"far fa-comment mr-2\"></i>");
            __builder.AddContent(147, 
#nullable restore
#line 216 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                                                        CommentList.Where(x => x.NewsId == item.Id).Count()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n                                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(149);
            __builder.AddAttribute(150, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(151, "small");
                __builder2.AddAttribute(152, "class", "ml-3");
                __builder2.AddAttribute(153, "style", "cursor: pointer; color: #FFCC00;");
                __builder2.AddAttribute(154, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 219 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                                                                               ()=>SavedNewsClicked(Convert.ToInt32(item.Id))

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(155, "i");
                __builder2.AddAttribute(156, "class", (
#nullable restore
#line 219 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                                                                                                                                           item.SavedNews.Any(s=>s.UserId==USerID)==true?"fas added":"far"

#line default
#line hidden
#nullable disable
                ) + " fa-bookmark" + " fa-2x" + " blog-bookmarked");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 226 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                            }

                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(157, "div");
            __builder.AddAttribute(158, "class", "col-lg-12 mb-3");
#nullable restore
#line 231 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                             if (News.Count() > 6)
                            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(159, "button");
            __builder.AddAttribute(160, "class", "button" + " " + (
#nullable restore
#line 234 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                       Loadingmore

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(161, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 234 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                                                               TakeLoadClick

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 235 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                     if (IsLoading)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(162, "<span class=\"spinner\"></span>");
#nullable restore
#line 238 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(163, 
#nullable restore
#line 239 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
                                     LoadText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 241 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"


                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n\r\n                ");
            __builder.OpenComponent<Wlog_Client.Pages.News.NewsRightSide>(165);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 254 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 258 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\Index.razor"
      

    public int TakeLoad { get; set; } = 6;
    public string Loadingmore { get; set; } = "";
    public string LoadText { get; set; } = "Daha ??ox y??kl??";
    public string USerID { get; set; }

    NewsPaginationDTO NewsPagingModel = new NewsPaginationDTO();

    public IEnumerable<NewsDTO> News { get; set; } = new List<NewsDTO>();
    public IEnumerable<NewsCommentDTO> CommentList { get; set; } = new List<NewsCommentDTO>();
    public SavedNewsDTO SavedNews { get; set; } = new SavedNewsDTO();
    public bool IsProcessing { get; set; } = false;
    public bool IsLoading { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        if (await localStorage.GetItemAsync<UserDTO>
                (SD.Local_UserDetails) !=null)
        {
            var userInfo = await localStorage.GetItemAsync<UserDTO>
                (SD.Local_UserDetails);
            USerID = userInfo.Id;
        }


        IsProcessing = true;
        News = await newsService.GetNews();
        CommentList = await newsCommentService.GetNewsComment();
        IsProcessing = false;
    }

    private async Task TakeLoadClick()
    {
        LoadText = "";
        IsLoading = true;
        await Task.Delay(1000);
        TakeLoad = TakeLoad + 6;
        IsLoading = false;
        LoadText = "Daha ??ox y??kl??";
    }

    private async Task SavedNewsClicked(int newsId)
    {
        if (await localStorage.GetItemAsync<UserDTO>
                (SD.Local_UserDetails) != null)
        {
            var userInfo = await localStorage.GetItemAsync<UserDTO>
                (SD.Local_UserDetails);
            SavedNews.UserId = userInfo.Id;
            SavedNews.NewsId = newsId;


            await newsService.AddToSavedNews(SavedNews);

            IsProcessing = true;
            News = await newsService.GetNews();
            CommentList = await newsCommentService.GetNewsComment();
            IsProcessing = false;

        }
    }


    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        await jsRuntime.InvokeVoidAsync("startCarousel", null);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INewsCommentService newsCommentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INewsService newsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
