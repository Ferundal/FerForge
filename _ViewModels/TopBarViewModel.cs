using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FerForge.Models;
using System.Collections.ObjectModel;

namespace FerForge._ViewModels
{
    public partial class TopBarViewModel : ObservableObject
    {
        private const string ProjectsManagerStatusDeafultLabel = "New Project";

        public TopBarViewModel()
        {
            KnownProjects = new ObservableCollection<Project>
            {
                new Project { Name = "Project 1" },
                new Project { Name = "Project 2" },
                new Project { Name = "Project 3" }
            };

            if (KnownProjects.Count > 0)
            {
                ProjectsManagerStatusLabel = KnownProjects[0].Name;
            }
            else
            {
                ProjectsManagerStatusLabel = ProjectsManagerStatusDeafultLabel;
            }
        }

        [ObservableProperty]
        public partial string? ProjectsManagerStatusLabel { get; private set; }

        // Collection of known projects
        public ObservableCollection<Project> KnownProjects { get; }

        [ObservableProperty]
        public partial bool IsKnownProjectsListVisible { get; private set; } = false;

        [RelayCommand]
        public void ShowKnownProjects()
        {
            IsKnownProjectsListVisible = true;
        }
    }
}
