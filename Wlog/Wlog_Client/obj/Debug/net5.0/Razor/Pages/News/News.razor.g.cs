#pragma checksum "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\Pages\News\News.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86a5bf8f3251c786439d9cda6360ac5bb8c431e1"
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
using Model.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Wlog_Client.Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ASUS\source\repos\Wlog\Wlog_Client\_Imports.razor"
using Wlog_Client.Pages.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/news")]
    public partial class News : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container-fluid mt-5 pt-3\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-8\"><div class=\"row\"><div class=\"col-12\"><div class=\"section-title\"><h4 class=\"m-0 text-uppercase font-weight-bold\">Category: Business</h4>\r\n                            <a class=\"text-secondary font-weight-medium text-decoration-none\" href>View All</a></div></div>\r\n                    <div class=\"col-lg-6\"><div class=\"position-relative mb-3\"><img class=\"img-fluid w-100\" src=\"img/news-700x435-1.jpg\" style=\"object-fit: cover;\">\r\n                            <div class=\"bg-white border border-top-0 p-4\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-2 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h4 d-block mb-3 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a>\r\n                                <p class=\"m-0\">\r\n                                    Dolor lorem eos dolor duo et eirmod sea. Dolor sit magna\r\n                                    rebum clita rebum dolor stet amet justo\r\n                                </p></div>\r\n                            <div class=\"d-flex justify-content-between bg-white border border-top-0 p-4\"><div class=\"d-flex align-items-center\"><img class=\"rounded-circle mr-2\" src=\"img/user.jpg\" width=\"25\" height=\"25\" alt>\r\n                                    <small>John Doe</small></div>\r\n                                <div class=\"d-flex align-items-center\"><small class=\"ml-3\"><i class=\"far fa-eye mr-2\"></i>12345</small>\r\n                                    <small class=\"ml-3\"><i class=\"far fa-comment mr-2\"></i>123</small></div></div></div></div>\r\n                    <div class=\"col-lg-6\"><div class=\"position-relative mb-3\"><img class=\"img-fluid w-100\" src=\"img/news-700x435-2.jpg\" style=\"object-fit: cover;\">\r\n                            <div class=\"bg-white border border-top-0 p-4\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-2 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h4 d-block mb-3 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a>\r\n                                <p class=\"m-0\">\r\n                                    Dolor lorem eos dolor duo et eirmod sea. Dolor sit magna\r\n                                    rebum clita rebum dolor stet amet justo\r\n                                </p></div>\r\n                            <div class=\"d-flex justify-content-between bg-white border border-top-0 p-4\"><div class=\"d-flex align-items-center\"><img class=\"rounded-circle mr-2\" src=\"img/user.jpg\" width=\"25\" height=\"25\" alt>\r\n                                    <small>John Doe</small></div>\r\n                                <div class=\"d-flex align-items-center\"><small class=\"ml-3\"><i class=\"far fa-eye mr-2\"></i>12345</small>\r\n                                    <small class=\"ml-3\"><i class=\"far fa-comment mr-2\"></i>123</small></div></div></div></div>\r\n                    <div class=\"col-lg-12 mb-3\"><a href><img class=\"img-fluid w-100\" src=\"img/ads-728x90.png\" alt></a></div>\r\n                    <div class=\"col-lg-6\"><div class=\"position-relative mb-3\"><img class=\"img-fluid w-100\" src=\"img/news-700x435-3.jpg\" style=\"object-fit: cover;\">\r\n                            <div class=\"bg-white border border-top-0 p-4\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-2 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h4 d-block mb-0 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a></div>\r\n                            <div class=\"d-flex justify-content-between bg-white border border-top-0 p-4\"><div class=\"d-flex align-items-center\"><img class=\"rounded-circle mr-2\" src=\"img/user.jpg\" width=\"25\" height=\"25\" alt>\r\n                                    <small>John Doe</small></div>\r\n                                <div class=\"d-flex align-items-center\"><small class=\"ml-3\"><i class=\"far fa-eye mr-2\"></i>12345</small>\r\n                                    <small class=\"ml-3\"><i class=\"far fa-comment mr-2\"></i>123</small></div></div></div></div>\r\n                    <div class=\"col-lg-6\"><div class=\"position-relative mb-3\"><img class=\"img-fluid w-100\" src=\"img/news-700x435-4.jpg\" style=\"object-fit: cover;\">\r\n                            <div class=\"bg-white border border-top-0 p-4\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-2 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h4 d-block mb-0 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a></div>\r\n                            <div class=\"d-flex justify-content-between bg-white border border-top-0 p-4\"><div class=\"d-flex align-items-center\"><img class=\"rounded-circle mr-2\" src=\"img/user.jpg\" width=\"25\" height=\"25\" alt>\r\n                                    <small>John Doe</small></div>\r\n                                <div class=\"d-flex align-items-center\"><small class=\"ml-3\"><i class=\"far fa-eye mr-2\"></i>12345</small>\r\n                                    <small class=\"ml-3\"><i class=\"far fa-comment mr-2\"></i>123</small></div></div></div></div>\r\n                    <div class=\"col-lg-6\"><div class=\"d-flex align-items-center bg-white mb-3\" style=\"height: 110px;\"><img class=\"img-fluid\" src=\"img/news-110x110-1.jpg\" alt>\r\n                            <div class=\"w-100 h-100 px-3 d-flex flex-column justify-content-center border border-left-0\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-1 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h6 m-0 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a></div></div>\r\n                        <div class=\"d-flex align-items-center bg-white mb-3\" style=\"height: 110px;\"><img class=\"img-fluid\" src=\"img/news-110x110-2.jpg\" alt>\r\n                            <div class=\"w-100 h-100 px-3 d-flex flex-column justify-content-center border border-left-0\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-1 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h6 m-0 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a></div></div></div>\r\n                    <div class=\"col-lg-6\"><div class=\"d-flex align-items-center bg-white mb-3\" style=\"height: 110px;\"><img class=\"img-fluid\" src=\"img/news-110x110-3.jpg\" alt>\r\n                            <div class=\"w-100 h-100 px-3 d-flex flex-column justify-content-center border border-left-0\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-1 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h6 m-0 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a></div></div>\r\n                        <div class=\"d-flex align-items-center bg-white mb-3\" style=\"height: 110px;\"><img class=\"img-fluid\" src=\"img/news-110x110-4.jpg\" alt>\r\n                            <div class=\"w-100 h-100 px-3 d-flex flex-column justify-content-center border border-left-0\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-1 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h6 m-0 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a></div></div></div>\r\n                    <div class=\"col-lg-12 mb-3\"><a href><img class=\"img-fluid w-100\" src=\"img/ads-728x90.png\" alt></a></div>\r\n                    <div class=\"col-lg-12\"><div class=\"row news-lg mx-0 mb-3\"><div class=\"col-md-6 h-100 px-0\"><img class=\"img-fluid h-100\" src=\"img/news-700x435-5.jpg\" style=\"object-fit: cover;\"></div>\r\n                            <div class=\"col-md-6 d-flex flex-column border bg-white h-100 px-0\"><div class=\"mt-auto p-4\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-2 mr-2\" href>Business</a>\r\n                                        <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                    <a class=\"h4 d-block mb-3 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a>\r\n                                    <p class=\"m-0\">\r\n                                        Dolor lorem eos dolor duo et eirmod sea. Dolor sit magna\r\n                                        rebum clita rebum dolor stet amet justo\r\n                                    </p></div>\r\n                                <div class=\"d-flex justify-content-between bg-white border-top mt-auto p-4\"><div class=\"d-flex align-items-center\"><img class=\"rounded-circle mr-2\" src=\"img/user.jpg\" width=\"25\" height=\"25\" alt>\r\n                                        <small>John Doe</small></div>\r\n                                    <div class=\"d-flex align-items-center\"><small class=\"ml-3\"><i class=\"far fa-eye mr-2\"></i>12345</small>\r\n                                        <small class=\"ml-3\"><i class=\"far fa-comment mr-2\"></i>123</small></div></div></div></div></div>\r\n                    <div class=\"col-lg-6\"><div class=\"d-flex align-items-center bg-white mb-3\" style=\"height: 110px;\"><img class=\"img-fluid\" src=\"img/news-110x110-1.jpg\" alt>\r\n                            <div class=\"w-100 h-100 px-3 d-flex flex-column justify-content-center border border-left-0\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-1 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h6 m-0 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a></div></div>\r\n                        <div class=\"d-flex align-items-center bg-white mb-3\" style=\"height: 110px;\"><img class=\"img-fluid\" src=\"img/news-110x110-2.jpg\" alt>\r\n                            <div class=\"w-100 h-100 px-3 d-flex flex-column justify-content-center border border-left-0\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-1 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h6 m-0 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a></div></div></div>\r\n                    <div class=\"col-lg-6\"><div class=\"d-flex align-items-center bg-white mb-3\" style=\"height: 110px;\"><img class=\"img-fluid\" src=\"img/news-110x110-3.jpg\" alt>\r\n                            <div class=\"w-100 h-100 px-3 d-flex flex-column justify-content-center border border-left-0\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-1 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h6 m-0 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a></div></div>\r\n                        <div class=\"d-flex align-items-center bg-white mb-3\" style=\"height: 110px;\"><img class=\"img-fluid\" src=\"img/news-110x110-4.jpg\" alt>\r\n                            <div class=\"w-100 h-100 px-3 d-flex flex-column justify-content-center border border-left-0\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-1 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h6 m-0 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a></div></div></div></div></div>\r\n\r\n            <div class=\"col-lg-4\"><div class=\"mb-3\"><div class=\"section-title mb-0\"><h4 class=\"m-0 text-uppercase font-weight-bold\">Follow Us</h4></div>\r\n                    <div class=\"bg-white border border-top-0 p-3\"><a href class=\"d-block w-100 text-white text-decoration-none mb-3\" style=\"background: #39569E;\"><i class=\"fab fa-facebook-f text-center py-4 mr-3\" style=\"width: 65px; background: rgba(0, 0, 0, .2);\"></i>\r\n                            <span class=\"font-weight-medium\">12,345 Fans</span></a>\r\n                        <a href class=\"d-block w-100 text-white text-decoration-none mb-3\" style=\"background: #52AAF4;\"><i class=\"fab fa-twitter text-center py-4 mr-3\" style=\"width: 65px; background: rgba(0, 0, 0, .2);\"></i>\r\n                            <span class=\"font-weight-medium\">12,345 Followers</span></a>\r\n                        <a href class=\"d-block w-100 text-white text-decoration-none mb-3\" style=\"background: #0185AE;\"><i class=\"fab fa-linkedin-in text-center py-4 mr-3\" style=\"width: 65px; background: rgba(0, 0, 0, .2);\"></i>\r\n                            <span class=\"font-weight-medium\">12,345 Connects</span></a>\r\n                        <a href class=\"d-block w-100 text-white text-decoration-none mb-3\" style=\"background: #C8359D;\"><i class=\"fab fa-instagram text-center py-4 mr-3\" style=\"width: 65px; background: rgba(0, 0, 0, .2);\"></i>\r\n                            <span class=\"font-weight-medium\">12,345 Followers</span></a>\r\n                        <a href class=\"d-block w-100 text-white text-decoration-none mb-3\" style=\"background: #DC472E;\"><i class=\"fab fa-youtube text-center py-4 mr-3\" style=\"width: 65px; background: rgba(0, 0, 0, .2);\"></i>\r\n                            <span class=\"font-weight-medium\">12,345 Subscribers</span></a>\r\n                        <a href class=\"d-block w-100 text-white text-decoration-none\" style=\"background: #055570;\"><i class=\"fab fa-vimeo-v text-center py-4 mr-3\" style=\"width: 65px; background: rgba(0, 0, 0, .2);\"></i>\r\n                            <span class=\"font-weight-medium\">12,345 Followers</span></a></div></div>\r\n                \r\n                \r\n                <div class=\"mb-3\"><div class=\"section-title mb-0\"><h4 class=\"m-0 text-uppercase font-weight-bold\">Advertisement</h4></div>\r\n                    <div class=\"bg-white text-center border border-top-0 p-3\"><a href><img class=\"img-fluid\" src=\"img/news-800x500-2.jpg\" alt></a></div></div>\r\n                \r\n                \r\n                <div class=\"mb-3\"><div class=\"section-title mb-0\"><h4 class=\"m-0 text-uppercase font-weight-bold\">Tranding News</h4></div>\r\n                    <div class=\"bg-white border border-top-0 p-3\"><div class=\"d-flex align-items-center bg-white mb-3\" style=\"height: 110px;\"><img class=\"img-fluid\" src=\"img/news-110x110-1.jpg\" alt>\r\n                            <div class=\"w-100 h-100 px-3 d-flex flex-column justify-content-center border border-left-0\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-1 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h6 m-0 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a></div></div>\r\n                        <div class=\"d-flex align-items-center bg-white mb-3\" style=\"height: 110px;\"><img class=\"img-fluid\" src=\"img/news-110x110-2.jpg\" alt>\r\n                            <div class=\"w-100 h-100 px-3 d-flex flex-column justify-content-center border border-left-0\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-1 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h6 m-0 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a></div></div>\r\n                        <div class=\"d-flex align-items-center bg-white mb-3\" style=\"height: 110px;\"><img class=\"img-fluid\" src=\"img/news-110x110-3.jpg\" alt>\r\n                            <div class=\"w-100 h-100 px-3 d-flex flex-column justify-content-center border border-left-0\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-1 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h6 m-0 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a></div></div>\r\n                        <div class=\"d-flex align-items-center bg-white mb-3\" style=\"height: 110px;\"><img class=\"img-fluid\" src=\"img/news-110x110-4.jpg\" alt>\r\n                            <div class=\"w-100 h-100 px-3 d-flex flex-column justify-content-center border border-left-0\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-1 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h6 m-0 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a></div></div>\r\n                        <div class=\"d-flex align-items-center bg-white mb-3\" style=\"height: 110px;\"><img class=\"img-fluid\" src=\"img/news-110x110-5.jpg\" alt>\r\n                            <div class=\"w-100 h-100 px-3 d-flex flex-column justify-content-center border border-left-0\"><div class=\"mb-2\"><a class=\"badge badge-primary text-uppercase font-weight-semi-bold p-1 mr-2\" href>Business</a>\r\n                                    <a class=\"text-body\" href><small>Jan 01, 2045</small></a></div>\r\n                                <a class=\"h6 m-0 text-secondary text-uppercase font-weight-bold\" href>Lorem ipsum dolor sit amet elit...</a></div></div></div></div>\r\n                \r\n                \r\n                <div class=\"mb-3\"><div class=\"section-title mb-0\"><h4 class=\"m-0 text-uppercase font-weight-bold\">Newsletter</h4></div>\r\n                    <div class=\"bg-white text-center border border-top-0 p-3\"><p>Aliqu justo et labore at eirmod justo sea erat diam dolor diam vero kasd</p>\r\n                        <div class=\"input-group mb-2\" style=\"width: 100%;\"><input type=\"text\" class=\"form-control form-control-lg\" placeholder=\"Your Email\">\r\n                            <div class=\"input-group-append\"><button class=\"btn btn-primary font-weight-bold px-3\">Sign Up</button></div></div>\r\n                        <small>Lorem ipsum dolor sit amet elit</small></div></div>\r\n                \r\n                \r\n                <div class=\"mb-3\"><div class=\"section-title mb-0\"><h4 class=\"m-0 text-uppercase font-weight-bold\">Tags</h4></div>\r\n                    <div class=\"bg-white border border-top-0 p-3\"><div class=\"d-flex flex-wrap m-n1\"><a href class=\"btn btn-sm btn-outline-secondary m-1\">Politics</a>\r\n                            <a href class=\"btn btn-sm btn-outline-secondary m-1\">Business</a>\r\n                            <a href class=\"btn btn-sm btn-outline-secondary m-1\">Corporate</a>\r\n                            <a href class=\"btn btn-sm btn-outline-secondary m-1\">Business</a>\r\n                            <a href class=\"btn btn-sm btn-outline-secondary m-1\">Health</a>\r\n                            <a href class=\"btn btn-sm btn-outline-secondary m-1\">Education</a>\r\n                            <a href class=\"btn btn-sm btn-outline-secondary m-1\">Science</a>\r\n                            <a href class=\"btn btn-sm btn-outline-secondary m-1\">Business</a>\r\n                            <a href class=\"btn btn-sm btn-outline-secondary m-1\">Foods</a>\r\n                            <a href class=\"btn btn-sm btn-outline-secondary m-1\">Travel</a></div></div></div></div></div></div></div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INewsService newsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591