namespace Domain.Domain
{
    public class Author : Person
    {
        public string Preferinte;

        public Author(long idpn, string nume, string prenume, string preferinte) : base(idpn, nume, prenume)
        {
            Preferinte = preferinte;
        }
    }
}