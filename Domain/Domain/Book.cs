using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Domain
{
    public class Book
    {

        private readonly string _name;
        private List<Pages> _pagini;
        private readonly string _editura;
        private Author _autor;
        public string Name { get { return _name; } }
        public string Editura { get { return _editura;} }
        public DateTime AnulTiparirii { get; private set; }

        public Book(string name,List<Pages> pagini, string editura, Author autor,DateTime anultiparirii)
        {
            if (autor == null)
                throw new ArgumentException("Pentru a crea o carte este nevoie de autor");
            if (editura == null)
                editura = "NA";
            if (pagini == null || !pagini.Any())
                throw new ArgumentException("Nu poti crea o cartea fara pagini");
            _name = name;
            _pagini = pagini;
            _editura = editura;
            _autor = autor;
            AnulTiparirii = anultiparirii;
        }
    }
}