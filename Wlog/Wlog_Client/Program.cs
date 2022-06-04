using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Wlog_Client.Service;
using Wlog_Client.Service.IService;

namespace Wlog_Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration.GetValue<string>("BaseAPIUrl")) });
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddMudServices();
            builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
            builder.Services.AddScoped<INewsService, NewsService>();
            builder.Services.AddScoped<IMessageService, MessageService>();
            builder.Services.AddScoped<INewsCategoryService, NewsCategoryService>();
            builder.Services.AddScoped<ISubscribeService, SubscribeService>();
            builder.Services.AddScoped<INewsCommentService, NewsCommentService>();
            builder.Services.AddScoped<INewsSubCategoryService, NewsSubCategoryService>();
            builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
            builder.Services.AddScoped<IAccountService, AccountService>();

            await builder.Build().RunAsync();
        }
    }
}
