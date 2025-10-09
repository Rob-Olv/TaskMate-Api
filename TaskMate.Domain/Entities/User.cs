using System.Collections.Generic;

namespace TaskMate.Domain
{
    public class User : BaseDomain
    {
        public string Name { get; set; }
        public Email Email { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }

        public virtual List<Category> Categories { get; set; }
        public virtual List<Task> Tasks { get; set; }

        public User() { }
        public User(Email email)
        {
            Email = email;
        }
    }
}
