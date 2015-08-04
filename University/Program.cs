using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Domain.Domain;
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
            var products = GetNewBook(5);
            var prod = products.ToList();
            var Course = FactoryCourse.CreateNewCours(prod, true, "Test Course", DateTime.Now.Date);
            Thread.Sleep(4000);
            var Course1 = FactoryCourse.CreateNewCours(prod, true, "APA", DateTime.Now.Date);
            Console.ReadKey();
        }

        public static IList<Book> GetNewBook(int number)
        {
            var productList = new List<Book>();
            var vieru = new Author(1234567898789, "Grigore", "Vieru", "Poezii, Opere");
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
            var vieru = new Author(1234567898789, "Grigore", "Vieru", "Poezii, Opere");
            var shoupensahuer = new Author(12312312312, "Arthur", "Shoupenhauer", "Filosofia");


            var p = new List<Book>();

            var pagVam = new List<Pages>();
            var pag1 = new Pages(1, "Intrducere - această carte conţine fapte reale din viaţa mea.");
            pagVam.Add(pag1);

            var c = new Book(pagVam, "Test", vieru);
            p.Add(c);

            try
            {
                var viataAmorulMoartea = BookFactory.CreateNewBook(pagVam, "Nistru", shoupensahuer);
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


            */
    }
}