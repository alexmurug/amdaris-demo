namespace Domain.Domain
{
    public abstract class Person
    {
        protected long Idpn;
        protected string Nume;
        protected string Prenume;
        public int Aniex { get; private set; }

        protected Person(long idpn, string nume, string prenume,int aniex)
        {
            Idpn = idpn;
            Nume = nume;
            Prenume = prenume;
            Aniex = aniex;
        }
    }
}