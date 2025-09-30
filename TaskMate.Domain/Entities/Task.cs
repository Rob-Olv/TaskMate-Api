using System;

namespace TaskMate.Domain
{
    public class Task : BaseDomain
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CompletionDate { get; set; }
        public PriorityTaskEnum Priority { get; set; }
        public StatusTaskEnum Status { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int ImageId { get; set; }

        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
    }
}
