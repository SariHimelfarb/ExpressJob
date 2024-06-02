using solid.Core.Models;

namespace solid.Models
{
    public class InterviewPostModel
    {
        public int Id { get; set; }
        public Job CurrentJob { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}
