using System;

namespace Api.Domain.Dtos.Class
{
    public class ClassDtoUpdateResult
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        
        public string DaysWeek { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public string IdSchool { get; set; }

        public bool Status { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
