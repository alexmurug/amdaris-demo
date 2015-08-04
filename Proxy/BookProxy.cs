using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Domain;

namespace Proxy
{
    class BookProxy:IBook
    {
        public BookProxy(Person person)
        {
            _person = person;
            _realBook = new Book();
        }

        private readonly IBook _realBook;
        private readonly Person _person;

    }
}
