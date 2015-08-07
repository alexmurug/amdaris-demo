using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Domain.Domain;
using Domain.Domain.Decorator;
using Domain.Domain.Proxy;
using Factories.Factories;
using Infrastructure.IoC;

namespace University
{
    internal class Program
    {
        static Program()
        {
            ServiceLocator.RegisterAll();
            FactoryBook = ServiceLocator.Get<BookFactory>();
            FactoryCourse = ServiceLocator.Get<CourseFactory>();
        }

        private static readonly BookFactory FactoryBook;
        private static readonly CourseFactory FactoryCourse;

        private static void Main(string[] args)
        {
            //FactoryTest();
            // var pagVam = new List<Pages>();
            //  var pag1 = new Pages(1, "Intrducere - această carte conţine fapte reale din viaţa mea.");
            //  pagVam.Add(pag1);

            //  ProxyExample(pagVam);
            //  DecoratorExameple(pagVam);

            ObserverPatternExample();

            Console.ReadKey();
        }

        private static void ObserverPatternExample()
        {
            var c1 = new Course(new List<Book>(), true, "Apa", DateTime.Now);
            var st1 = new Student(2341234235234, "Murug", "Alexandru", 10, 4, 9.49, new List<Course>());
            var st2 = new Student(234431234235234, "Lica", "Ion", 10, 4, 9.49, new List<Course>());
            var dec = DecanSingleton.CreateaInstance(24352435243, "Balmus", "Ion", 35, 10, "Doctorat",
                new List<Course>());
            c1.Subscribe(st1);
            c1.Subscribe(st2);
            c1.Subscribe(dec);
            c1.Current = false;
        }


        private static void FactoryTest()
        {
            //Create 5 book with factoryMethod
            var products = GetNewBook(5);
            var prod = products.ToList();

            //Factory-Test
            var course = FactoryCourse.CreateNewCours(prod, true, "Test Course", DateTime.Now.Date);
            Thread.Sleep(4000);
            var course1 = FactoryCourse.CreateNewCours(prod, true, "APA", DateTime.Now.Date);
        }

        private static void ProxyExample(List<Pages> pagVam)
        {
            var vieru = new Author(1234567898789, "Grigore", "Vieru", 1, "Poezii, Opere");
            var carte = new BookProxy(vieru, "Name", pagVam, "Nistru", vieru, new DateTime(2015, 10, 14));
            carte.Read();
        }

        private static void DecoratorExameple(List<Pages> pageses)
        {
            IBookDecoration carte = new Book("Poezii pentru copii", pageses, "Nistru",
                new Author(1234123412, "Grigore", "Vieru", 10, "Patria,Neamul"), DateTime.Now);
            IBookDecoration carte1 = new Coperta(carte);
            IBookDecoration carte3 = new Scris(carte1);
            carte3.AddDecoration();
        }

        public static IList<Book> GetNewBook(int number)
        {
            var productList = new List<Book>();
            var vieru = new Author(1234567898789, "Grigore", "Vieru", 1, "Poezii, Opere");
            var pagVam = new List<Pages>();
            var pag1 = new Pages(1, "Intrducere - această carte conţine fapte reale din viaţa mea.");
            pagVam.Add(pag1);
            for (long i = 0; i < number; i++)
            {
                var product = FactoryBook.CreateNewBook("Name" + i, pagVam, "Nistru", vieru, DateTime.Today);
                productList.Add(product);
            }
            return productList;
        }

        /*
        private void LINQExamples()
        {
            var vieru = new Author(1234567898789, "Grigore", "Vieru",1, "Poezii, Opere");
            var shoupensahuer = new Author(12312312312, "Arthur", "Shoupenhauer",10, "Filosofia");


            var p = new List<Book>();

            var pagVam = new List<Pages>();
            var pag1 = new Pages(1, "Intrducere - această carte conţine fapte reale din viaţa mea.");
            pagVam.Add(pag1);

            var c = new Book("Testin",pagVam, "Test", vieru,DateTime.Now);
            p.Add(c);

            try
            {
                var ani = DateTime.Now;
                var viataAmorulMoartea = BookFactory.CreateNewBook("Nume",pagVam, "Nistru", shoupensahuer,ani);
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }


            //Day 12 task
            var courses = new[]
            {
                new Course(p, false, "LFPC", DateTime.Now),
                new Course(p, true, "MIDPS", DateTime.Now),
                new Course(p, true, "CO", DateTime.Now),
                new Course(p, true, "PW", DateTime.Now),
                new Course(p, true, "AC", DateTime.Now),
                new Course(p, false, "APA", DateTime.Now)
            };

            var curs = courses.ToList();
            DecanSingleton decan = DecanSingleton.CreateaInstance(45234512543523, "Balmus", "Ion", 20, "Doctorat", curs);
            //Orders cursuri by Current
            var orderCursuri = courses.OrderBy(x => !x.Current);
            //Return cursuri where current = false;
            var retCursCurfalse = courses.Where(x => x.Current == false);

            //Afisarea primelor 2 cursurui
            var ret2Cursuri = courses.Take(2);


            //Proiectarea (SELECT)

            var selNumCurs = courses.Select(x => x.Nume);
            //var selectMany = Courses.SelectMany(m => m.Nume);

            //Group
            var grouping = from cursu in courses
                group cursu by cursu.Current
                into cursbyCurrent
                select new {cursbyCurrent.Key, Nume = cursbyCurrent};
        }
        */
    }
}