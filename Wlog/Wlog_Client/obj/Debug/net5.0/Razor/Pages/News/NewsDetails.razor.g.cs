#pragma checksum "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b2df15339abf7945a6b07091057ed4442050ef3"
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
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/news/details/{Id:int}")]
    public partial class NewsDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
 if (News?.NewsImages == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, @"<div class=""loading""><div class=""fl spinner7 loader-gif""><p style=""color: #fff;width: 510px;font-size: 20px;line-height: 1.2em;margin-left: -210px;margin-bottom: 40px;"">Loading</p><div class=""circ1""></div><div class=""circ2""></div><div class=""circ3""></div><div class=""circ4""></div></div></div>");
#nullable restore
#line 15 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-lg-8");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "position-relative mb-3");
            __builder.OpenComponent<MudBlazor.MudCarousel<object>>(11);
            __builder.AddAttribute(12, "Class", "mud-width-full");
            __builder.AddAttribute(13, "Style", "height:400px;");
            __builder.AddAttribute(14, "ShowArrows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                                                                               arrows

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ShowBullets", 
#nullable restore
#line 26 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                                                                                                     bullets

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "AutoCycle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                                                                                                                          autocycle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 28 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                             foreach (var item in News.NewsImages)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudCarouselItem>(18);
                __builder2.AddAttribute(19, "Transition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Transition>(
#nullable restore
#line 30 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                                             transition

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 30 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                                                                 Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "d-flex");
                    __builder3.AddAttribute(24, "style", "height:100%;");
                    __builder3.OpenElement(25, "img");
                    __builder3.AddAttribute(26, "class", "mx-auto my-auto");
                    __builder3.AddAttribute(27, "style", "width:100%;");
                    __builder3.AddAttribute(28, "src", 
#nullable restore
#line 32 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                                                                               item.NewsImageUrl

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(29, "alt", "slide");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 35 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                            }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n\r\n\r\n                        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "bg-white border border-top-0 p-4");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "mb-3");
            __builder.OpenElement(35, "a");
            __builder.AddAttribute(36, "class", "badge badge-primary text-uppercase font-weight-semi-bold p-2 mr-2");
            __builder.AddAttribute(37, "href", 
#nullable restore
#line 43 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                           $"news/category/{News.Category.NewsCategory.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(38, 
#nullable restore
#line 43 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                                                                               News.Category.NewsCategory.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                                ");
            __builder.OpenElement(40, "a");
            __builder.AddAttribute(41, "class", "text-body");
            __builder.AddAttribute(42, "href");
            __builder.AddContent(43, 
#nullable restore
#line 44 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                                              News.AddedDate.ToString("dd MMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.OpenElement(45, "h1");
            __builder.AddAttribute(46, "class", "mb-3 text-secondary text-uppercase font-weight-bold");
            __builder.AddContent(47, 
#nullable restore
#line 46 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                                                                             News.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                            ");
            __builder.AddContent(49, 
#nullable restore
#line 47 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                              (MarkupString)News.Details

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "d-flex justify-content-between bg-white border border-top-0 p-4");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "d-flex align-items-center");
            __builder.AddMarkupContent(55, "<img class=\"rounded-circle mr-2\" src=\"img/user.jpg\" width=\"25\" height=\"25\" alt>\r\n                                ");
            __builder.OpenElement(56, "span");
            __builder.AddContent(57, 
#nullable restore
#line 52 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                       News.User.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(58, " ");
            __builder.AddContent(59, 
#nullable restore
#line 52 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                                       News.User.Surname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                            ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "d-flex align-items-center");
            __builder.OpenElement(63, "span");
            __builder.AddAttribute(64, "class", "ml-3");
            __builder.AddMarkupContent(65, "<i class=\"far fa-eye mr-2\"></i>");
            __builder.AddContent(66, 
#nullable restore
#line 55 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                                                                   News.ViewCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                                ");
            __builder.AddMarkupContent(68, "<span class=\"ml-3\"><i class=\"far fa-comment mr-2\"></i>123</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    \r\n                    \r\n                    ");
            __builder.AddMarkupContent(70, "<div class=\"mb-3\"><div class=\"section-title mb-0\"><h4 class=\"m-0 text-uppercase font-weight-bold\">3 Comments</h4></div>\r\n                        <div class=\"bg-white border border-top-0 p-4\"><div class=\"media mb-4\"><img src=\"img/user.jpg\" alt=\"Image\" class=\"img-fluid mr-3 mt-1\" style=\"width: 45px;\">\r\n                                <div class=\"media-body\"><h6><a class=\"text-secondary font-weight-bold\" href>John Doe11</a> <small><i>01 Jan 2045</i></small></h6>\r\n                                    <p>\r\n                                        Diam amet duo labore stet elitr invidunt ea clita ipsum voluptua, tempor labore\r\n                                        accusam ipsum et no at. Kasd diam tempor rebum magna dolores sed sed eirmod ipsum.\r\n                                    </p>\r\n                                    <button class=\"btn btn-sm btn-outline-secondary\">Reply</button></div></div>\r\n                            <div class=\"media\"><img src=\"img/user.jpg\" alt=\"Image\" class=\"img-fluid mr-3 mt-1\" style=\"width: 45px;\">\r\n                                <div class=\"media-body\"><h6><a class=\"text-secondary font-weight-bold\" href>John Doe</a> <small><i>01 Jan 2045</i></small></h6>\r\n                                    <p>\r\n                                        Diam amet duo labore stet elitr invidunt ea clita ipsum voluptua, tempor labore\r\n                                        accusam ipsum et no at. Kasd diam tempor rebum magna dolores sed sed eirmod ipsum.\r\n                                    </p>\r\n                                    <button class=\"btn btn-sm btn-outline-secondary\">Reply</button>\r\n                                    <div class=\"media mt-4\"><img src=\"img/user.jpg\" alt=\"Image\" class=\"img-fluid mr-3 mt-1\" style=\"width: 45px;\">\r\n                                        <div class=\"media-body\"><h6><a class=\"text-secondary font-weight-bold\" href>John Doe</a> <small><i>01 Jan 2045</i></small></h6>\r\n                                            <p>\r\n                                                Diam amet duo labore stet elitr invidunt ea clita ipsum voluptua, tempor\r\n                                                labore accusam ipsum et no at. Kasd diam tempor rebum magna dolores sed sed\r\n                                                eirmod ipsum.\r\n                                            </p>\r\n                                            <button class=\"btn btn-sm btn-outline-secondary\">Reply</button></div></div></div></div></div></div>\r\n                    \r\n                    \r\n                    ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "mb-3");
            __builder.AddMarkupContent(73, "<div class=\"section-title mb-0\"><h4 class=\"m-0 text-uppercase font-weight-bold\">Şərh yaz</h4></div>\r\n                        ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "bg-white border border-top-0 p-4");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(76);
            __builder.AddAttribute(77, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 111 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                             Comment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 111 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                                                     HandleComment

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(80);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n\r\n                                ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group");
                __builder2.AddMarkupContent(84, "<label for=\"message\">Message *</label>\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(85);
                __builder2.AddAttribute(86, "cols", "30");
                __builder2.AddAttribute(87, "rows", "5");
                __builder2.AddAttribute(88, "class", "form-control");
                __builder2.AddAttribute(89, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 116 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                                                Comment.Message

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Comment.Message = __value, Comment.Message))));
                __builder2.AddAttribute(91, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Comment.Message));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n                                    ");
                __Blazor.Wlog_Client.Pages.News.NewsDetails.TypeInference.CreateValidationMessage_0(__builder2, 93, 94, 
#nullable restore
#line 117 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
                                                            (()=>Comment.Message)

#line default
#line hidden
#nullable disable
                , 95, "margin-top: 0.5rem;");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                                ");
                __builder2.AddMarkupContent(97, "<div class=\"form-group mb-0\"><input type=\"submit\" value=\"Şərh yaz\" class=\"btn btn-primary font-weight-semi-bold py-2 px-3\"></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n\r\n                ");
            __builder.OpenComponent<Wlog_Client.Pages.News.NewsRightSide>(99);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 135 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 139 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\NewsDetails.razor"
       
    [Parameter]
    public int? Id { get; set; }


    private bool arrows = true;
    private bool bullets = true;
    private bool autocycle = true;
    private Transition transition = Transition.Slide;


    public NewsDTO News { get; set; } = new NewsDTO();
    public IEnumerable<NewsDTO> NewsList { get; set; } = new List<NewsDTO>();
    public NewsCommentDTO Comment { get; set; } = new NewsCommentDTO();

    protected override async Task OnInitializedAsync()
    {
        News = await newsService.GetNewsDetails(Id);
        NewsList = await newsService.GetNews();

    }



    private async Task HandleComment()
    {
        Comment.UserId = "27428551-6269-4e4e-8157-c381dc7a23e9";
        Comment.NewsId = News.Id;
        await newsCommentService.CreateNewsComment(Comment);

        await jsRuntime.ToastrSuccess("Create Comment");
        

    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INewsCommentService newsCommentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISubscribeService subscribeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INewsService newsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
namespace __Blazor.Wlog_Client.Pages.News.NewsDetails
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
