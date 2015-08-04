using System;
using Domain.Domain;
using InterfaceActions;

namespace ActionImplimentations.ActionsImplements
{
    public class SmsNotifier : INotifycation<Book>
    {
        public bool Send(Book obj)
        {
            Console.WriteLine("Send SMS: Book {0,-20} has been created at {1,5} by {2,10}", obj.Name,DateTime.Now.ToString("t"), obj.Editura);
            return true;
        }
    }
}