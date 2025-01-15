using FerForge._ViewModels;

namespace FerForge._Views;

public partial class ProjectMenu : ContentView
{
	public ProjectMenu()
	{
		InitializeComponent();

        var viewModel = IPlatformApplication.Current.Services.GetService<ProjectMenuViewModel>();

        BindingContext = viewModel;
	}
}