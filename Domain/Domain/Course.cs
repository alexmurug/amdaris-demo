using System;
using System.Collections.Generic;

namespace Domain.Domain
{
    public class Course
    {
        private List<Book> _carti;
        private bool _current;
        private readonly string _nume;
        private DateTime _createtime;

        public Course()
        {
        }

        public Course(List<Book> carti, bool current, string nume, DateTime createtime)
        {
            _carti = carti;
            _current = current;
            _nume = nume;
            _createtime = createtime;
        }

        public string Nume
        {
            get { return _nume; }
        }
    }
}