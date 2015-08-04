using System.Collections.Generic;

namespace Domain.Domain
{
    public sealed class DecanSingleton : Person
    {
        private static readonly object PadLock = new object();
        private int _aniStudii;
        private List<Course> _preda;
        private string _studii;

        private DecanSingleton(long idpn, string nume, string prenume, int anistudii, string diploma,
            List<Course> cursuri): base(idpn, nume, prenume)
        {
            _aniStudii = anistudii;
            _studii = diploma;
            _preda = cursuri;
        }

        public static DecanSingleton Instance { get; private set; }

        public static DecanSingleton CreateaInstance(long idpn, string nume, string prenume, int anistudii,
            string diploma, List<Course> cursuri)
        {
            lock (PadLock)
            {
                if (Instance == null)
                {
                    Instance = new DecanSingleton(idpn, nume, prenume, anistudii, diploma, cursuri);
                    return Instance;
                }
                return Instance;
            }
        }
    }
}