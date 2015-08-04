using System;
using System.Collections.Generic;
using Domain.Domain;
using InterfaceActions;

namespace Factories.Factories
{
    public class BookFactory
    {
        public BookFactory(INotifycation<Book> notifycation)
        {
            _notifyUsersAction = notifycation;
        }


        public Book CreateNewBook(string name, List<Pages> pagini, string editura, Author aut,DateTime anlans)
        {
            var carte = new Book(name, pagini, editura, aut,anlans);
            OnProductCreation(carte);
            return carte;
        }

        public void OnProductCreation(Book product)
        {
            _notifyUsersAction.Send(product);
        }

        private readonly INotifycation<Book> _notifyUsersAction;
    }
}