using System;
using System.Collections.Generic;
using Domain.Domain;
using InterfaceActions;

namespace Factories.Factories
{
    public class CourseFactory
    {
        private readonly IWriteEventLog _notifyUsersAction;


        public Course CreateNewCours(List<Book> carti, bool current, string nume, DateTime date)
        {
            if (string.IsNullOrEmpty(nume))
                throw new ArgumentNullException("Nu puteti crea un curs fara nume");
            var curs = new Course(carti, current, nume, date);
            OnProductCreation(curs);
            return curs;
        }

        public void OnProductCreation(Course product)
        {
            _notifyUsersAction.Write(product);
        }

        public CourseFactory(IWriteEventLog notifycation)
        {
            _notifyUsersAction = notifycation;
        }
    }
}