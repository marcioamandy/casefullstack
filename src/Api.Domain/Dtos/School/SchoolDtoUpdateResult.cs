using System;

namespace Api.Domain.Dtos.School
{
    public class SchoolDtoUpdateResult
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public bool Status { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
