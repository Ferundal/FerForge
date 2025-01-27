﻿using FerForge._ViewModels;
using FerForge.Services.ProjectService;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using FerForge._Views;

namespace FerForge
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<ProjectInfoService>();

            builder.Services.AddSingleton<MainPage>();

            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<TopBarViewModel>();
            builder.Services.AddSingleton<ProjectManagerViewModel>();

            return builder.Build();
        }
    }
}
