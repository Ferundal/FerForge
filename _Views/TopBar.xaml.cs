using FerForge._ViewModels;

namespace FerForge._Views;

public partial class TopBar : ContentView
{
	public TopBar()
	{
		InitializeComponent();

        var viewModel = IPlatformApplication.Current.Services.GetService<TopBarViewModel>();

        BindingContext = viewModel;
    }
}