using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WinFormsTest1
{
    class Customer
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }

        public Customer()
        {
        // We force a delay for testing purposes
            Thread.Sleep(100);
        }

        public List<Customer> getCustomers()
        {
            string[] names = { "Gerry", "Tony", "Susy", "Betty", "Mauri", "Silvio", "Katia" };
            string[] cities = { "New York", "Los Angeles", "Chicago", "New Orleans" };

            int totalCustomers = names.Length;
            List<Customer> list = new List<Customer>();
            Random r = new Random(DateTime.Now.Millisecond);

            for (int i = 1; i < totalCustomers; i++) {
                list.Add(new Customer() {
                    Code = i,
                    Balance = r.Next(0, 10000),
                    Name = "Nome" + i.ToString(),
                    City = cities[r.Next(1, 4)]
                });
            }
            return list;
        }

        public List<Lazy<Customer>> getCustomersLazy()
        {
            string[] names = { "Gerry", "Tony", "Susy", "Betty", "Mauri", "Silvio", "Katia" };
            string[] cities = { "New York", "Los Angeles", "Chicago", "New Orleans" };

            int totalCustomers = names.Length;
            List<Lazy<Customer>> list = new List<Lazy<Customer>>();
            Random r = new Random(DateTime.Now.Millisecond);

            for (int i = 1; i < totalCustomers; i++) {
                list.Add(new Lazy<Customer>(() => new Customer() {
                    Code = i,
                    Balance = r.Next(0, 10000),
                    Name = Name = "Nome" + i.ToString(),
                    City = cities[r.Next(1, 4)]
                }));
            }
            return list;
        }
    }
}
