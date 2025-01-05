﻿namespace FerForge.Services.ProjectService
{
    public class ProjectInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime LastOpened { get; set; }
        public bool IsAvailable { get; set; }
    }
}