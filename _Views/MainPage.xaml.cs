using FerForge._ViewModels;

namespace FerForge._Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        var viewModel = IPlatformApplication.Current.Services.GetService< MainPageViewModel>();

        BindingContext = viewModel;
    }
}