using FerForge.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerForge.Models
{
    public class ChangeSet
    {
        // Name of the change set
        public string Name { get; set; } = String.Empty;

        // Description of the change set
        public string Description { get; set; } = String.Empty;

        // Reasons for the changes (e.g., for comments)
        public string Reasons { get; set; } = String.Empty;

        // List of sub-change sets (for nested changes)
        public List<ChangeSet> SubChangeSets { get; set; } = new List<ChangeSet>();

        // Status of the change set execution (e.g., updated or not)
        public ExecutionStatus ExecutionStatus { get; set; }

        // Approval status of the change set (approved, in discussion, etc.)
        public ChangeApprovalStatus ChangeApprovalStatus { get; set; }

        // Feasibility of implementing the change (feasible or not)
        public FeasibilityStatus FeasibilityStatus { get; set; }
    }
}
