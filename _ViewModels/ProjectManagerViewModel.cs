using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FerForge._Models;
using FerForge._Views;
using FerForge.Services.ProjectService;
using System.Collections.ObjectModel;

namespace FerForge._ViewModels
{
    public partial class ProjectManagerViewModel : ObservableObject, IExpandable
    {
        private const string ProjectsManagerStatusDeafultLabel = "New Project";

        private TopBarViewModel topBarViewModel;

        private ProjectInfoService projectInfoService;
        private List<ProjectInfo> knownProjects;
        private ProjectInfo currentProjectInfo;

        public ProjectManagerViewModel(
            TopBarViewModel topBarViewModel,
            ProjectInfoService projectInfoService)
        {
            this.topBarViewModel = topBarViewModel;
            this.projectInfoService = projectInfoService;

            knownProjects = projectInfoService.LoadKnownProjects();

            if (knownProjects.Count > 0)
            {
                currentProjectInfo = knownProjects[0];
                StatusLabel = currentProjectInfo.Name;
                KnownProjectsExcludingCurrent = new ObservableCollection<ProjectInfo>(knownProjects.Skip(1));
            }
            else
            {
                StatusLabel = ProjectsManagerStatusDeafultLabel;
                KnownProjectsExcludingCurrent = new ObservableCollection<ProjectInfo>();
            }
        }

        [ObservableProperty]
        public partial string? StatusLabel { get; private set; }

        // Collection of known projects
        public ObservableCollection<ProjectInfo> KnownProjectsExcludingCurrent { get; }

        [ObservableProperty]
        public partial bool IsKnownProjectsVisible { get; private set; } = false;

        [RelayCommand]
        public void KnownProjectsButtonPressed()
        {
            if (currentProjectInfo == null)
            {
                CreateNewProject();
                return;
            }

            if (!IsKnownProjectsVisible)
            {
                topBarViewModel.Expand(this);
            }
            else
            {
                topBarViewModel.Collapce();
            }
        }

        public void OnAddNewProjectPressed()
        {
            CreateNewProject();
        }

        public void Collapse()
        {
            IsKnownProjectsVisible = false;
        }

        public void Expand()
        {
            IsKnownProjectsVisible = true;
        }

        private void CreateNewProject()
        {
            var popup = new Popup
            {
                Content = new VerticalStackLayout
                {
                    Children =
            {
                new Label
                {
                    Text = "Привет! Это popup.",
                    FontSize = 18,
                    HorizontalOptions = LayoutOptions.Center
                }
            },
                    Padding = 20,
                    Spacing = 15
                }
            };

            var view = IPlatformApplication.Current.Services.GetService<MainPage>();
            PopupExtensions.ShowPopup(view, popup);
        }
    }
}
