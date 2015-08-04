using System;
using System.Collections.Generic;
using Proxy;

namespace Domain.Domain.Proxy
{
    public class BookProxy : IBook
    {
        public BookProxy(Person person, string name, List<Pages> pagini, string editura, Author autor,
            DateTime anultiparirii)
        {
            _person = person;
            _realBook = new Book(name, pagini, editura, autor, anultiparirii);
        }

        private readonly IBook _realBook;
        private readonly Person _person;

        public void Read()
        {
            if (_person.Aniex >= 10)
            {
                _realBook.Read();
            }
            else
            {
                Console.WriteLine("Nu ai suficienta experienta");
            }
        }
    }
}