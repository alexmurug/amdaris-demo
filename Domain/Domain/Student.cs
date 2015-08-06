using System;
using System.Collections.Generic;
using Domain.Domain.Observer;

namespace Domain.Domain
{
    public class Student : Person,ISubscriber
    {
        private int _aniStudii;
        private double _notaMedie;
        private List<Course> _studii;

        public Student(long idpn, string nume, string prenume, int aniex, int anstudii, double notamedie,
            List<Course> studii)
            : base(idpn, nume, prenume, aniex)
        {
            _aniStudii = anstudii;
            _notaMedie = notamedie;
            _studii = studii;
        }

        public void Update(Course course)
        {
            Console.WriteLine(
                course.Current
                    ? "Dear {0}, we have new current course '{1}'"
                    : "Dear {0}, the course '{1}' is out of date", Nume, course.Nume);
        }
    }
}