using System;

namespace Api.Domain.Entities
{
    public class ClassEntity : BaseEntity
    {
        public String Name { get; set; }

        public String DaysWeek { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public String IdSchool { get; set; }

        public bool Status { get; set; }
    }
}
