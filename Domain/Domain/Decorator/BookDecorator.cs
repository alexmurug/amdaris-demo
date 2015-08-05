using System;

namespace Domain.Domain.Decorator
{
    public interface IBookDecoration
    {
        void AddDecoration();
    }

    public abstract class Decoration : IBookDecoration
    {
        protected IBookDecoration Input;

        protected Decoration(IBookDecoration i)
        {
            Input = i;
        }

        public abstract void AddDecoration();
    }

    public class Coperta : Decoration
    {
        public Coperta(IBookDecoration i) : base(i)
        {
        }

        public override void AddDecoration()
        {
            Input.AddDecoration();
            Console.WriteLine("S-a adăugat copertă");
        }
    }

    public class Scris : Decoration
    {
        public Scris(IBookDecoration i)
            : base(i)
        {
        }

        public override void AddDecoration()
        {
            Input.AddDecoration();
            Console.WriteLine("S-a adăugat scris personalizat");
        }
    }
}