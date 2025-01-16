namespace FerForge.Models
{
    public class Project
    {
        public string Name { get; set; }
        public List<ChangeSet> ChangeSet;

        public Project()
        { 
            ChangeSet = new List<ChangeSet>();
        }
    }
}
