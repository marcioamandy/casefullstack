using System;

namespace Api.Domain.Models
{
    public class ClassModel
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _daysweek;
        public string DaysWeek
        {
            get { return _daysweek; }
            set { _daysweek = value; }
        }

        private DateTime _datestart;
        public DateTime DateStart
        {
            get { return _datestart; }
            set { _datestart = value; }
        }

        private DateTime _dateend;
        public DateTime DateEnd
        {
            get { return _dateend; }
            set { _dateend = value; }
        }

        private string _idschool;
        public string IdSchool
        {
            get { return _idschool; }
            set { _idschool = value; }
        }

        private bool _status;
        public bool Status
        {
            get { return _status; }
            set { _status = value; }
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
