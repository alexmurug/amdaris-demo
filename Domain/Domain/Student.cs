using System.Collections.Generic;

namespace Domain.Domain
{
    public class Student : Person
    {
        private int _aniStudii;
        private double _notaMedie;
        private List<Course> _studii;

        public Student(long idpn, string nume, string prenume, int anstudii, double notamedie, List<Course> studii)
            :base(idpn, nume, prenume)
        {
            _aniStudii = anstudii;
            _notaMedie = notamedie;
            _studii = studii;
        }
    }
}