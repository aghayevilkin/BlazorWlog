#pragma checksum "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1389846004b8af4ab30e0b6fd0a169882bbf8bf7"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/news/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/news/edit/{Id:int}")]
    public partial class NewsUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-2 mb-5");
            __builder.OpenElement(2, "h3");
            __builder.AddAttribute(3, "class", "card-title text-info mb-3 ml-3");
            __builder.AddContent(4, 
#nullable restore
#line 14 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                                Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " News");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-12");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                 NewsModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                                           HandleNewsUpsert

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label>Name</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                                NewsModel.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewsModel.Title = __value, NewsModel.Title))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NewsModel.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                        ");
                __Blazor.Wlog_Server.Pages.News.NewsUpsert.TypeInference.CreateValidationMessage_0(__builder2, 30, 31, 
#nullable restore
#line 24 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                                ()=>NewsModel.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\r\n                    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "<label>Category</label>\r\n                        ");
                __Blazor.Wlog_Server.Pages.News.NewsUpsert.TypeInference.CreateInputSelect_1(__builder2, 36, 37, "subcategoryId", 38, "form-control", 39, 
#nullable restore
#line 29 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                                                      NewsModel.CategoryId

#line default
#line hidden
#nullable disable
                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewsModel.CategoryId = __value, NewsModel.CategoryId)), 41, () => NewsModel.CategoryId, 42, (__builder3) => {
#nullable restore
#line 30 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                             foreach (var item in NewsSubCategoryDTOs)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                 foreach (var item2 in NewsCategoryDTOs.Where(x=>x.Id==item.NewsCategoryId))
                                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(43, "option");
                    __builder3.AddAttribute(44, "value", 
#nullable restore
#line 34 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                                    item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(45, 
#nullable restore
#line 34 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                                              item2.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(46, " - ");
                    __builder3.AddContent(47, 
#nullable restore
#line 34 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                                                            item.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 35 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __Blazor.Wlog_Server.Pages.News.NewsUpsert.TypeInference.CreateValidationMessage_2(__builder2, 49, 50, 
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                                ()=>NewsModel.CategoryId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n                ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group");
                __builder2.AddAttribute(54, "style", "height:250px;");
                __builder2.AddMarkupContent(55, "<label>Content</label>\r\n\r\n                    ");
                __builder2.OpenComponent<Blazored.TextEditor.BlazoredTextEditor>(56);
                __builder2.AddAttribute(57, "Placeholder", "Please enter news content");
                __builder2.AddAttribute(58, "ToolbarContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(59, "select");
                    __builder3.AddAttribute(60, "class", "ql-header");
                    __builder3.OpenElement(61, "option");
                    __builder3.AddAttribute(62, "selected");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(63, "\r\n                                ");
                    __builder3.OpenElement(64, "option");
                    __builder3.AddAttribute(65, "value", "1");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(66, "\r\n                                ");
                    __builder3.OpenElement(67, "option");
                    __builder3.AddAttribute(68, "value", "2");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(69, "\r\n                                ");
                    __builder3.OpenElement(70, "option");
                    __builder3.AddAttribute(71, "value", "3");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\r\n                                ");
                    __builder3.OpenElement(73, "option");
                    __builder3.AddAttribute(74, "value", "4");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\r\n                                ");
                    __builder3.OpenElement(76, "option");
                    __builder3.AddAttribute(77, "value", "5");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(78, "\r\n                            ");
                    __builder3.AddMarkupContent(79, @"<span class=""ql-formats""><button class=""ql-bold""></button>
                                <button class=""ql-italic""></button>
                                <button class=""ql-underline""></button>
                                <button class=""ql-strike""></button></span>
                            ");
                    __builder3.AddMarkupContent(80, "<span class=\"ql-formats\"><select class=\"ql-color\"></select>\r\n                                <select class=\"ql-background\"></select></span>\r\n                            ");
                    __builder3.AddMarkupContent(81, "<span class=\"ql-formats\"><button class=\"ql-list\" value=\"ordered\"></button>\r\n                                <button class=\"ql-list\" value=\"bullet\"></button></span>\r\n                            ");
                    __builder3.AddMarkupContent(82, "<span class=\"ql-formats\"><button class=\"ql-link\"></button></span>");
                }
                ));
                __builder2.AddAttribute(83, "EditorContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                }
                ));
                __builder2.AddComponentReferenceCapture(84, (__value) => {
#nullable restore
#line 44 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                               QuillHtml = (Blazored.TextEditor.BlazoredTextEditor)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                    ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group");
                __builder2.AddAttribute(88, "style", "padding-top: 100px; padding-bottom: 20px;");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(89);
                __builder2.AddAttribute(90, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 79 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                             HandleImageUpload

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(91, "multiple", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n                        ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "row");
#nullable restore
#line 81 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                             if (IsImageUploadProcessStarted)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(95, "<div class=\"col-md-12\"><span><i class=\"fa fa-spin fa-spinner\"></i> Please wait.. Images are uploading...</span></div>");
#nullable restore
#line 86 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                             if (NewsModel.ImageUrls != null && NewsModel.ImageUrls.Count > 0)
                            {
                                int serial = 1;
                                foreach (var roomImage in NewsModel.ImageUrls)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "col-md-2 mt-3");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "room-image");
                __builder2.AddAttribute(100, "style", "background:" + " url(\'" + (
#nullable restore
#line 93 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                                                                         roomImage

#line default
#line hidden
#nullable disable
                ) + "\')" + " 50%" + " 50%" + " ");
                __builder2.OpenElement(101, "span");
                __builder2.AddAttribute(102, "class", "room-image-title");
                __builder2.AddContent(103, 
#nullable restore
#line 94 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                                                            serial

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n                                        ");
                __builder2.OpenElement(105, "button");
                __builder2.AddAttribute(106, "type", "button");
                __builder2.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                                                        ()=>DeletePhoto(roomImage)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(108, "class", "btn btn-outline-danger btn-block mt-4");
                __builder2.AddContent(109, " Delete");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 98 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"

                                    serial++;
                                }
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n                    ");
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "form-group");
                __builder2.OpenElement(113, "button");
                __builder2.AddAttribute(114, "class", "btn btn-primary");
                __builder2.AddContent(115, 
#nullable restore
#line 105 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
                                                         Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(116, " News");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(118);
                __builder2.AddAttribute(119, "href", "news");
                __builder2.AddAttribute(120, "class", "btn btn-secondary");
                __builder2.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(122, "Back to Index");
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
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "C:\Users\ASUS\source\repos\Wlog\Wlog_Server\Pages\News\NewsUpsert.razor"
       

    [Parameter]
    public int? Id { get; set; }
    private NewsDTO NewsModel { get; set; } = new NewsDTO();
    private string Title { get; set; } = "Create";
    private NewsImageDTO NewsImage { get; set; } = new NewsImageDTO();
    private List<string> DeletedImageNames { get; set; } = new List<string>();
    public BlazoredTextEditor QuillHtml { get; set; } = new BlazoredTextEditor();
    private IEnumerable<NewsSubCategoryDTO> NewsSubCategoryDTOs { get; set; } = new List<NewsSubCategoryDTO>();
    private IEnumerable<NewsCategoryDTO> NewsCategoryDTOs { get; set; } = new List<NewsCategoryDTO>();
    private IEnumerable<NewsDTO> NewsModels { get; set; } = new List<NewsDTO>();

    private bool IsImageUploadProcessStarted { get; set; } = false;










    [CascadingParameter]
    public Task<AuthenticationState> AuthenticationState { get; set; }


    protected override async Task OnInitializedAsync()
    {

        NewsSubCategoryDTOs = await NewsSubCategoryRepository.GetAllNewsSubCategory();
        NewsCategoryDTOs = await NewsCategoryRepository.GetAllNewsCategory();
        NewsModels = await NewsRepository.GetAllNews();


        var authenticationState = await AuthenticationState;
        if (!authenticationState.User.IsInRole(SD.Role_Admin))
        {
            var uri = new Uri(NavigationManager.Uri);
            NavigationManager.NavigateTo($"/identity/account/login?returnUrl={uri.LocalPath}");
        }

        if (Id != null)
        {
            //Updating
            Title = "Update";
            NewsModel = await NewsRepository.GetNews(Id.Value);

            if (NewsModel?.NewsImages != null)
            {
                NewsModel.ImageUrls = NewsModel.NewsImages.Select(u => u.NewsImageUrl).ToList();
            }


        }
        else
        {
            //Create
            NewsModel = new NewsDTO
            {
                CategoryId = _db.NewsSubCategories.FirstOrDefault().Id
            };

        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender)
            return;
        bool loading = true;
        while (loading)
        {
            try
            {
                if (!string.IsNullOrEmpty(NewsModel.Details))
                {
                    await this.QuillHtml.LoadHTMLContent(NewsModel.Details);
                }
                loading = false;
            }
            catch (Exception)
            {
                await Task.Delay(10);
                loading = true;
            }

        }

    }


    private async Task HandleNewsUpsert()
    {

        try
        {
            //var newsDetailsByName = await NewsRepository.IsNewsUnique(NewsModel.Title, NewsModel.Id);
            //if (newsDetailsByName != null)
            //{
            //    await JsRuntime.ToastrError("News name already exists.");
            //    return;
            //}

            if (NewsModel.Id != 0 && Title == "Update")
            {
                NewsModel.Details = await QuillHtml.GetHTML();
                //Update
                var updateNewsResult = await NewsRepository.UpdateNews(NewsModel.Id, NewsModel);
                if ((NewsModel.ImageUrls != null && NewsModel.ImageUrls.Any())
                    || (DeletedImageNames != null && DeletedImageNames.Any())
                    )
                {
                    if (DeletedImageNames != null && DeletedImageNames.Any())
                    {
                        foreach (var deletedImageName in DeletedImageNames)
                        {
                            var imageName = deletedImageName.Replace($"{NavigationManager.BaseUri}WlogImages/", "");

                            var result = FileUpload.DeleteFile(imageName);
                            await NewsImagesRepository.DeleteNewsImageByUrl(deletedImageName);
                        }
                    }



                    await AddNewsImage(updateNewsResult);
                }
                await JsRuntime.ToastrSuccess("News updated successfully.");
            }
            else
            {

                //Create
                NewsModel.Details = await QuillHtml.GetHTML();


                var createdResult = await NewsRepository.CreateNews(NewsModel);
                await AddNewsImage(createdResult);
                await JsRuntime.ToastrSuccess("News created successfully.");
            }
        }
        catch (Exception ex)
        {
            //log exceptions
            throw;
        }



        NavigationManager.NavigateTo("news");
    }

    public void SetHtml()
    {
        if (!string.IsNullOrEmpty(NewsModel.Details))
        {
            this.QuillHtml.LoadHTMLContent(NewsModel.Details);
        }

        StateHasChanged();
    }

    private async Task HandleImageUpload(InputFileChangeEventArgs e)
    {
        IsImageUploadProcessStarted = true;

        try
        {
            var images = new List<string>();
            if (e.GetMultipleFiles().Count > 0)
            {
                foreach (var file in e.GetMultipleFiles())
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(file.Name);
                    if (fileInfo.Extension.ToLower() == ".jpg" ||
                        fileInfo.Extension.ToLower() == ".png" ||
                        fileInfo.Extension.ToLower() == ".jpeg")
                    {
                        var uploadedImagePath = await FileUpload.UploadFile(file);
                        images.Add(uploadedImagePath);
                    }
                    else
                    {
                        await JsRuntime.ToastrError("Please select .jpg/ .jpeg/ .png file only");
                        return;
                    }
                }

                if (images.Any())
                {
                    if (NewsModel.ImageUrls != null && NewsModel.ImageUrls.Any())
                    {
                        NewsModel.ImageUrls.AddRange(images);
                    }
                    else
                    {
                        NewsModel.ImageUrls = new List<string>();
                        NewsModel.ImageUrls.AddRange(images);
                    }
                }
                else
                {
                    await JsRuntime.ToastrError("Image uploading failed");
                    return;
                }

            }


            IsImageUploadProcessStarted = false;
        }
        catch (Exception ex)
        {

            await JsRuntime.ToastrError(ex.Message);
        }

    }


    private async Task AddNewsImage(NewsDTO newsDetails)
    {
        foreach (var imageUrl in NewsModel.ImageUrls)
        {
            if (NewsModel.NewsImages == null || NewsModel.NewsImages.Where(x => x.NewsImageUrl == imageUrl).Count() == 0)
            {
                NewsImage = new NewsImageDTO()
                {
                    NewsId = newsDetails.Id,
                    NewsImageUrl = imageUrl,
                };
                await NewsImagesRepository.CreateNewsImage(NewsImage);
            }

        }
    }


    internal async Task DeletePhoto(string imageUrl)
    {
        try
        {
            var imageIndex = NewsModel.ImageUrls.FindIndex(x => x == imageUrl);
            var imageName = imageUrl.Replace($"{NavigationManager.BaseUri}WlogImages/", "");
            if (NewsModel.Id == 0 && Title == "Create")
            {
                var result = FileUpload.DeleteFile(imageName);
            }
            else
            {
                //Update
                DeletedImageNames ??= new List<string>();
                DeletedImageNames.Add(imageUrl);
            }

            NewsModel.ImageUrls.RemoveAt(imageIndex);
        }
        catch (Exception ex)
        {

            await JsRuntime.ToastrError(ex.Message);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppDbContext _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INewsImagesRepository NewsImagesRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INewsSubCategoryRepository NewsSubCategoryRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INewsCategoryRepository NewsCategoryRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INewsRepository NewsRepository { get; set; }
    }
}
namespace __Blazor.Wlog_Server.Pages.News.NewsUpsert
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
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
