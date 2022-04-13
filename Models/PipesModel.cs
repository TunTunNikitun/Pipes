using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskForTMK.Models
{
     public class PipesModel
    {
        public int Id { get; set; }
        public int PipeNumber { get; set; }
        public bool Quality { get; set; }
        public double Weight { get; set; }
        public string Size { get; set; }
        public int SteelId { get; set; }
        public Steel Steel { get; set; }
    }
}
