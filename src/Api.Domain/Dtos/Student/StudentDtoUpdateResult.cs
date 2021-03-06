using System;

namespace Api.Domain.Dtos.Student
{
    public class StudentDtoUpdateResult
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        
        public string Email { get; set; }

        public DateTime DateBirth { get; set; }

        public bool Status { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
