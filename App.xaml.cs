using FerForge._ViewModels;
using FerForge._Views;

namespace FerForge
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var view = IPlatformApplication.Current.Services.GetService<MainPage>();
            return new Window(view);
        }
    }
}