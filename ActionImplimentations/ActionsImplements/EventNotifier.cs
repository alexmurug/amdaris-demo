using System;
using System.Diagnostics;
using Domain.Domain;
using InterfaceActions;

namespace ActionImplimentations.ActionsImplements
{
    public class EventNotifier : IWriteEventLog

    {
        public void Write(Course obj)
        {
            const string sSource = "Presentation";
            const string sLog = "Application";
            const string composite = "Cursul {0} s-a creat la data {1}";
            var sEvent = string.Format(composite, obj.Nume, DateTime.Now.DayOfWeek);

            if (!EventLog.SourceExists(sSource))
                EventLog.CreateEventSource(sSource, sLog);

            EventLog.WriteEntry(sSource, sEvent);
            EventLog.WriteEntry(sSource, sEvent,
                EventLogEntryType.Information, 234);
        }
    }
}