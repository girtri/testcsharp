using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Dynamic;

namespace WinFormsTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLinq_Click(object sender, EventArgs e)
        {
            //---------------------------------------------
            // esempio Query
            var numbers = Enumerable.Range(50, 200);
            // use of linq to filter
            var selected = from n in numbers
                where n % 3 == 0 && n % 7 == 0
                select n;
            Console.WriteLine("Numbers divisible by 3 and 7 \n\r");
            // Now we use a lambda (Action) to print out results
            selected.ToList().ForEach(n => Console.WriteLine("Selected: {0} ", n));

            //---------------------------------------------
            // esempio order by
            var maxNumber = (from n in numbers
                where n % 3 == 0 && n % 7 == 0
                orderby n descending
                select n).First();
            Console.WriteLine("Nr più alto: {0} ", maxNumber);

           //---------------------------------------------
           // esempio group by
            string[] words = { "Packt", "Publishing", "Editorial", "Books", "CSharp", "Chapter" };
            var wordsGrouped = from w in words
                group w by w[0] into groupOfWords
                select new { FirstLetter = groupOfWords.Key, Words = groupOfWords };

            Console.WriteLine(" List of words grouped by starting letter\n\r");
            foreach (var indGroup in wordsGrouped) {
                Console.WriteLine(" Starting with letter '{0}':", indGroup.FirstLetter);
                foreach (var word in indGroup.Words) {
                    Console.WriteLine(" " + word);
                }
            }

            //---------------------------------------------
            // esempio join
            var numbersStartingBy1 = from n in numbers where n.ToString().StartsWith("1") select n;

            var doubleMultiplesBeg1 = from n in selected
                join n1 in numbersStartingBy1 on n equals n1
                select n;
            Console.WriteLine("Join results \n");
            doubleMultiplesBeg1.ToList().ForEach(n => Console.WriteLine("Selected: {0} ", n));

            // type projections (uso di anonymous type "al volo")
            var proj = from n in selected join n1 in numbersStartingBy1 on n equals n1
                select new { Num = n, DivBy2 = (n % 2 == 0) ? "Even" : "Odd" }; 
            Console.WriteLine("\n anonymous type \n");
            proj.ToList().ForEach(n => Console.WriteLine("Selected: {0}, {1} ", n.Num, n.DivBy2));
        }

        private void cmdExtesion_Click(object sender, EventArgs e)
        {
            string test = "ciao";
            Console.WriteLine(test.ExtendedString());

            int tot = 10;
            Console.WriteLine(tot.Per2());

        }

        private void cmdLazy_Click(object sender, EventArgs e)
        {
            List<Customer> Customers;
            List<Lazy<Customer>> CustomersLazy;

            Stopwatch watchLazy = Stopwatch.StartNew();
            CustomersLazy = new Customer().getCustomersLazy();
            watchLazy.Stop();

            Console.WriteLine(" Generation of Customers (Lazy Version)");
            Console.WriteLine((" ").PadRight(42, '-'));
            Console.WriteLine(" Total time (milliseconds): " + watchLazy.Elapsed.TotalMilliseconds);
            Console.WriteLine();

            Console.WriteLine(" Generation of Customers (non-lazy)");
            Console.WriteLine((" ").PadRight(42, '-'));

            Stopwatch watch = Stopwatch.StartNew();
            Customers = new Customer().getCustomers();
            watch.Stop();

            Console.WriteLine("Total time (milliseconds): " + watch.Elapsed.TotalMilliseconds);
            Console.ReadLine();
        }

        private void cmdDynamic_Click(object sender, EventArgs e)
        {
            dynamic dyn = "This is a dynamic declared string";
            Console.WriteLine(dyn.GetType());
            Console.WriteLine(dyn);
            Console.WriteLine(dyn.Length);
            Console.WriteLine(dyn.ToUpper());

            // Expando objects allow dynamic creation of properties
            dynamic oex = new ExpandoObject();
            oex.integerProp = 7;
            oex.stringProp = "And this is the string property";

            oex.datetimeProp = new System.Dynamic.ExpandoObject();
            oex.datetimeProp.dayOfWeek = DateTime.Today.DayOfWeek;
            oex.datetimeProp.time = DateTime.Now.TimeOfDay;

            Console.WriteLine("Int: {0}", oex.integerProp);
            Console.WriteLine("String: {0}", oex.stringProp);
            Console.WriteLine("Day of Week: {0}", oex.datetimeProp.dayOfWeek);
            Console.WriteLine("Time: {0}", oex.datetimeProp.time);

            // Expando objects & Generics
            var listOfBooks = new List<dynamic>();
            var book1 = CreateBookObject("Mastering C# and .NET Programming", 500);
            var book2 = CreateBookObject("Practical Machine Learning", 468);

            listOfBooks.Add(book1);
            listOfBooks.Add(book2);

            var bookWith500Pages = listOfBooks.Find(b => b.Pages == 500);

            Console.WriteLine("Packt Pub. Books with 500 pages: {0}", bookWith500Pages.Title);
            Console.ReadLine();
        }

        private dynamic CreateBookObject(dynamic title, dynamic pages)
        {
            dynamic book = new ExpandoObject();
            book.Title = title;
            book.Pages = pages;
            return book;
        }

        private void cmdTask_Click(object sender, EventArgs e)
        {
            // esempio 1 (no generics)
            string theString = "";

            Task t1 = new Task(() => {
                SlowMethod1(ref theString);
            });

            t1.Start();
            Console.WriteLine("Waiting for SlowMethod to finish...");
            t1.Wait();
            Console.WriteLine("Finished at: {0}",theString);

            // esempio 2 (generics)
            Task<string> t2 = Task.Factory.StartNew<string>(() => SlowMethod2());

            Console.WriteLine("Waiting for SlowMethod to finish...");
            t2.Wait();
            Console.WriteLine("Finished at: {0}", t2.Result);
            Console.ReadLine();
        }

        private void SlowMethod1(ref string value)
        {
            System.Threading.Thread.Sleep(3000);
            value = DateTime.Now.ToLongTimeString();
        }

        private string SlowMethod2()
        {
            System.Threading.Thread.Sleep(3000);
            return DateTime.Now.ToLongTimeString();
        }

        //------------------------------------------------------
        // async await
        private void cmdAsync_Click(object sender, EventArgs e)
        {
            // async / await
            Console.WriteLine("SlowMethod started at...{0}", DateTime.Now.ToLongTimeString());
            SlowMethodAsync();
            Console.WriteLine("Awaiting for SlowMethod...");
            Console.ReadLine();
        }

        private async Task SlowMethodAsync()
        {
            // Simulation of slow method "Sleeping" the thread for 3 secs.
            await Task.Run(new Action(() => System.Threading.Thread.Sleep(3000)));
            Console.WriteLine("Finished at: {0}", DateTime.Now.ToLongTimeString());
            return;
        }
    }
}
