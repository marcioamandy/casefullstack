using System;

namespace Api.Domain.Dtos.School
{
    public class SchoolDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public bool Status { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
