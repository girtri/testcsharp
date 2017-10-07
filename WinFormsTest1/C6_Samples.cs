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

// static using declarations
using static System.Math;

namespace WinFormsTest1
{
    public partial class C6_Samples : Form
    {
        public C6_Samples()
        {
            InitializeComponent();
        }

        private void cmdStringInter_Click(object sender, EventArgs e)
        {
            string data = "mia stringa";
            // metodo classico
            Console.WriteLine("string classic: {0}", data);
            // string interpolation
            Console.WriteLine($"string interpolation: {data}");
            Console.WriteLine($"string interpolation: {1 + 2}");
            Console.WriteLine($@"string interpolation: \n gerry {1 + 3}");
        }

        private void cmdExFilter_Click(object sender, EventArgs e)
        {
            decimal a, b, res;
            a = 10;
            b = 0;

            try {
                res = a / b;
                Console.WriteLine($"Result: {res}");
                Console.ReadLine();

            } catch when (a > 0 && DateTime.Today.DayOfWeek == DayOfWeek.Thursday) {
                Console.WriteLine("Divisione non valida di giovedì");

            } catch (Exception ex) {
                Console.WriteLine($"Divisione non valida: {ex.Message}");
            }
        }

        private void cmdNameOf_Click(object sender, EventArgs e)
        {
            Console.WriteLine(nameof(e.GetHashCode)); //print GetHashCode
            Console.WriteLine(nameof(DateTime.Now.Month)); //print Month
        }

        private void cmdAutoProperty_Click(object sender, EventArgs e)
        {
            PepperoniPizza p = new PepperoniPizza();
            Console.WriteLine(p.ExtraPrice);
        }


        public class PepperoniPizza
        {
            public decimal ExtraPrice { get; set; } = 0.25m;
            public void DisplayName(string name) => Console.WriteLine(name);
        }

        private void cmdUsingStatic_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"The square root of 9 is {Sqrt(9)}");
        }

        private void cmdExprBodied_Click(object sender, EventArgs e)
        {
            PepperoniPizza p = new PepperoniPizza();
            p.DisplayName("gerry");
        }

        private void cmdIndexInit_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> HttpWebErrors = new Dictionary<int, string>
            {
                [301] = "The page requested has been permanently moved",
                [307] = "The requested resource is available only through a proxy",
                [403] = "Access forbidden by the server",
                [404] = "Page not found. Try to change the URL",
                [408] = "Request timeout. Try again."
            };
            Console.WriteLine(HttpWebErrors[404]);
        }

        private void cmdNullConditional_Click(object sender, EventArgs e)
        {
            string name = null;

            if (name?.Length > 0)
                Console.WriteLine(name.Length);
            else
                Console.WriteLine("no value");
        }
    }
}
