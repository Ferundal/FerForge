using FerForge.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerForge.Models
{
    internal class ChangeSet
    {
        // Name of the change set
        public string ChangeSetName { get; set; }

        // Description of the change set
        public string ChangeSetDescription { get; set; }

        // Reasons for the changes (e.g., for comments)
        public string ChangeSetReasons { get; set; }

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
