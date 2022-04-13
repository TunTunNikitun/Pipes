using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskForTMK.Models
{
    public class PackageStructure
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public Packages Package { get; set; }
        public int PipeId { get; set; }
        public PipesModel Pipe { get; set; }
    }
}
