using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Users
{
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Location { get; set; }
        public String Address { get; set; }
        public bool isActive { get; set; }
    }
}
