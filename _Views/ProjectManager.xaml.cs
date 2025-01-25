using FerForge._ViewModels;

namespace FerForge._Views;
public partial class ProjectManager : ContentView
{
	public ProjectManager()
	{
        InitializeComponent();

        var viewModel = IPlatformApplication.Current.Services.GetService<ProjectManagerViewModel>();

        BindingContext = viewModel;
    }
}