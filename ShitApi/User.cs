using System;
using System.Collections.Generic;

namespace ShitApi
{
    public partial class User
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        public int? IdDepartment { get; set; }

        public virtual Department? IdDepartmentNavigation { get; set; }
    }
}
