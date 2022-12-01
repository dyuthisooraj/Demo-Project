using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection().AddScoped<Ilogger, Filelogger>().BuildServiceProvider();

            Calculator c=new Calculator(serviceProvider.GetService<Ilogger>());
            c.Dividebyzero();
        }
    }
}
