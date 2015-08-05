namespace Domain.Domain
{
    public class Author : Person
    {
        public string Preferinte;

        public Author(long idpn, string nume, string prenume, int aniex, string preferinte)
            : base(idpn, nume, prenume, aniex)
        {
            Preferinte = preferinte;
        }
    }
}