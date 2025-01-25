using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FerForge._Models;
using FerForge.Services.ProjectService;
using System.Collections.ObjectModel;

namespace FerForge._ViewModels
{
    public partial class ProjectManagerViewModel : ObservableObject
    {
        private const string ProjectsManagerStatusDeafultLabel = "New Project";
        private ProjectInfoService projectInfoService;
        private List<ProjectInfo> knownProjects;
        private ProjectInfo currentProjectInfo;

        public ProjectManagerViewModel(ProjectInfoService projectInfoService)
        {
            this.projectInfoService = projectInfoService;

            //knownProjects = projectInfoService.LoadKnownProjects();

            knownProjects = new List<ProjectInfo>
            {
                new ProjectInfo { Name="Clown", LastOpened=new DateTime(1991, 2, 6), Path="clown.ferp", IsAvailable=true },
                new ProjectInfo { Name="Big brother", LastOpened=new DateTime(1984, 2, 6), Path="big_brother.ferp", IsAvailable=true },
                new ProjectInfo { Name="War", LastOpened=new DateTime(1941, 2, 6), Path="war.ferp", IsAvailable=true }
            };

            if (knownProjects.Count > 0)
            {
                currentProjectInfo = knownProjects[0];
                ProjectsManagerStatusLabel = currentProjectInfo.Name;
                KnownProjectsExcludingCurrent = new ObservableCollection<ProjectInfo>(knownProjects.Skip(1));
            }
            else
            {
                ProjectsManagerStatusLabel = ProjectsManagerStatusDeafultLabel;
                KnownProjectsExcludingCurrent = new ObservableCollection<ProjectInfo>();
            }
        }

        [ObservableProperty]
        public partial string? ProjectsManagerStatusLabel { get; private set; }

        // Collection of known projects
        public ObservableCollection<ProjectInfo> KnownProjectsExcludingCurrent { get; }

        [ObservableProperty]
        public partial bool IsKnownProjectsVisible { get; private set; } = false;

        [RelayCommand]
        public void KnownProjectsButtonPressed()
        {
            IsKnownProjectsVisible = !IsKnownProjectsVisible;
        }

        [RelayCommand]
        public void HideKnownProjects()
        {
            IsKnownProjectsVisible = false;
        }
    }
}
