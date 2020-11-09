using System;

namespace Api.Domain.Entities
{
    public class SchoolEntity : BaseEntity
    {
        public String Name { get; set; }

        public String Address { get; set; }
        
        public bool Status { get; set; }
    }
}
