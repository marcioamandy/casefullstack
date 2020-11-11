using System;

namespace Api.Domain.Dtos.ClassStudent
{
    public class ClassStudentDtoUpdateResult
    {
        public Guid Id { get; set; }

        public string IdClass { get; set; }

        public string IdStudent { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
