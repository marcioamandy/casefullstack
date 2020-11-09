using System;

namespace Api.Domain.Entities
{
    public class StudentEntity : BaseEntity
    {
        public String Name { get; set; }

        public String Email { get; set; }

        public DateTime DateBirth { get; set; }
        
        public bool Status { get; set; }
    }
}
