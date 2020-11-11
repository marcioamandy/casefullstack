using System;

namespace Api.Domain.Models
{
    public class ClassStudentModel
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _idclass;
        public string IdClass
        {
            get { return _idclass; }
            set { _idclass = value; }
        }

        private string _idstudent;
        public string IdStudent
        {
            get { return _idstudent; }
            set { _idstudent = value; }
        }

        private DateTime _createAt;
        public DateTime CreateAt
        {
            get { return _createAt; }
            set
            {
                _createAt = value == null ? DateTime.UtcNow : value;
            }
        }

        private DateTime _updateAt;
        public DateTime UpdateAt
        {
            get { return _updateAt; }
            set { _updateAt = value; }
        }
    }
}
