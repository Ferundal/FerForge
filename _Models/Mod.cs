using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerForge.Models
{
    internal class Mod
    {
        public List<ChangeSet> Changes;

        public Mod()
        { 
            Changes = new List<ChangeSet>();
        }
    }
}
