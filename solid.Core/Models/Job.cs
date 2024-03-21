using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Core.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string RequiredExperience { get; set; }
        public string Category { get; set; }
        public List<Interview> intervies { get; set; }  //new 
    }
}
