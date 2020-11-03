using System;

namespace Api.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public String Name { get; set; }

        public String Email { get; set; }
    }
}
