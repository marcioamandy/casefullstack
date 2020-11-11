using System;

namespace Api.Domain.Dtos.ClassStudent
{
    public class ClassStudentDtoCreateResult
    {
        public Guid Id { get; set; }

        public string IdClass { get; set; }

        public string IdStudent { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
