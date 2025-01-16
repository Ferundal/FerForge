using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FerForge.Models;
using System.Collections.ObjectModel;

namespace FerForge._ViewModels
{
    public partial class TopBarViewModel : ObservableObject
    {
        private const string ProjectsManagementButtonDeafultLabel = "New Project";

        public TopBarViewModel()
        {
            Projects = new ObservableCollection<Project>
            {
                new Project { Name = "Project 1" },
                new Project { Name = "Project 2" },
                new Project { Name = "Project 3" }
            };

            if (Projects.Count > 0)
            {
                ProjectsManagementButtonLabel = Projects[0].Name;
            }
            else
            {
                ProjectsManagementButtonLabel = ProjectsManagementButtonDeafultLabel;
            }
        }

        [ObservableProperty]
        public partial string? ProjectsManagementButtonLabel { get; private set; }

        // Collection of known projects
        public ObservableCollection<Project> Projects { get; }

        [ObservableProperty]
        public partial bool IsKnownProjectsListVisible { get; private set; } = false;

        [RelayCommand]
        public void ShowKnownProjects()
        {
            IsKnownProjectsListVisible = true;
        }
    }
}
