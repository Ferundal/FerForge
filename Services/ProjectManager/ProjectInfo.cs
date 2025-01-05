using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerForge.Services.ProjectManager
{
    public class ProjectInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime LastOpened { get; set; }
        public bool IsAvailable { get; set; }
    }
}
