using System;
using System.Globalization;
using System.IO;
using Domain.Domain;
using InterfaceActions;

namespace ActionImplimentations.ActionsImplements
{
    public class EventWriteToFile : IWriteEventLog
    {
        public void Write(Course obj)
        {
            var composite = "Cursul {0} s-a creat pe {1}" + Environment.NewLine;
            var ro = new CultureInfo("ro-RO");
            var lines = string.Format(composite, obj.Nume, DateTime.Now.ToString(ro));
            File.AppendAllText(@"C:\Users\alexandru.murug\Desktop\WriteLines.txt", lines);
        }
    }
}