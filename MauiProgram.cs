﻿using FerForge._ViewModels;
using FerForge.Services.ProjectService;
using Microsoft.Extensions.Logging;

namespace FerForge
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<ProjectInfoService>();

            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<TopBarViewModel>();


            return builder.Build();
        }
    }
}
