using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerForge.Utils
{
    public static class PathUtils
    {
        // Example: Return the folder path for known projects
        public static string KnownProjectsFolder => Path.Combine(FileSystem.AppDataDirectory, "Projects");
    }
}
