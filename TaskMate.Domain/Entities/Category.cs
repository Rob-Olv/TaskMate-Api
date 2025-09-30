using System.Collections.Generic;

namespace TaskMate.Domain
{
    public class Category : BaseDomain
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<Task> Tasks { get; set; }
    }
}
