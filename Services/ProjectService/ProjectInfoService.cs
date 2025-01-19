using FerForge._Models.ProjectManager;
using FerForge.Utils;
using System.Text.Json;

namespace FerForge.Services.ProjectService
{
    public class ProjectInfoService
    {
        // File name for storing known projects
        private const string FileName = "KnownProjects.json";

        // Load known projects from file
        public List<ProjectInfo> LoadKnownProjects()
        {
            var knownProjectsFilePath = Path.Combine(PathUtils.KnownProjectsFolder, FileName); // Combine folder path with file name
            if (!File.Exists(knownProjectsFilePath)) return new List<ProjectInfo>();

            var json = File.ReadAllText(knownProjectsFilePath);
            return JsonSerializer.Deserialize<List<ProjectInfo>>(json) ?? new List<ProjectInfo>();
        }

        // Save the list of known projects to file
        public void SaveKnownProjects(List<ProjectInfo> projects)
        {
            var knownProjectsFilePath = Path.Combine(PathUtils.KnownProjectsFolder, FileName); // Combine folder path with file name
            var json = JsonSerializer.Serialize(projects, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(knownProjectsFilePath, json);
        }
    }
}
