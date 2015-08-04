namespace Domain.Domain
{
    public abstract class Person
    {
        protected long Idpn;
        protected string Nume;
        protected string Prenume;

        protected Person(long idpn, string nume, string prenume)
        {
            Idpn = idpn;
            Nume = nume;
            Prenume = prenume;
        }
    }
}