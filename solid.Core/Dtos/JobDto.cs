using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Core.Dtos
{
    public class JobDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string RequiredExperience { get; set; }
        public string Category { get; set; }
    }
}
