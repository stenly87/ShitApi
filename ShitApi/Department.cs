using System;
using System.Collections.Generic;

namespace ShitApi
{
    public partial class Department
    {
        public Department()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
