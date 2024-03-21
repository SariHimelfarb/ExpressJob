using solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Core.Dtos
{
    public class InterviewDto
    {
        public int Id { get; set; }
        public Job CurrentJob { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}
